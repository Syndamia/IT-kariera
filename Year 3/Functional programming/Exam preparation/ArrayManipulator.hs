exchange :: Int -> [Int] -> [Int]
exchange i arr = drop (i + 1) arr ++ take (i + 1) arr

getIndexOfExtr :: (Int -> Bool) -> (Int -> Int -> Bool) -> [Int] -> Int
getIndexOfExtr isProper comp arr = foldl takeExtrInd 0 [1..(length arr - 1)]
    where takeExtrInd acc x = if isProper (arr!!x) && ( comp (arr!!x) (arr!!acc) || not (isProper (arr!!acc)) ) 
                              then x else acc 

firstElems :: Int -> (Int -> Bool)  -> [Int] -> [Int]
firstElems count filt arr = take count (filter filt arr)

lastElems :: Int -> (Int -> Bool) -> [Int] -> [Int]
lastElems count filt arr = reverse (firstElems count filt (reverse arr)) 

readUntilWord :: [Int] -> IO [Int]
readUntilWord arr = do
    line <- getLine
    let comms = words line

    if null comms then readUntilWord arr 
    else 
        if head comms == "exchange" then do
            let index = read (comms!!1) :: Int

            if index < 0 || index >= length arr then do
                 putStrLn "Invalid index"
                 readUntilWord arr
            else readUntilWord (exchange index arr)

        else if head comms == "min" || head comms == "max" then do
            let isProper = if comms!!1 == "even" then even else odd
            let comparator = if head comms == "min" then (<=) else (>=)

            if getIndexOfExtr isProper comparator arr == 0 && not (isProper (arr!!0)) then 
                putStrLn "No matches" -- if index is 0 because accumulator wasn't changed
            else print (getIndexOfExtr isProper comparator arr)

            readUntilWord arr

        else if head comms == "first" || head comms == "last" then do
            let count = read (comms!!1) :: Int
            let filt = if comms!!2 == "even" then even else odd
            
            if count < 0 || count > length arr then putStrLn "Invalid count"
            else if head comms == "first" then 
                print (firstElems count filt arr)
            else print (lastElems count filt arr)

            readUntilWord arr

        else if head comms == "end" then return arr
        else readUntilWord arr

main :: IO()
main = do    
    line <- getLine
    let nums = map (\x -> read x :: Int) (words line)
    result <- readUntilWord nums
    print result
