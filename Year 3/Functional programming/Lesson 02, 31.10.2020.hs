-- Ex. From Presentation

findSum :: Integer -> Integer
findSum n = if n == 0 then 0
            else n + findSum (n - 1)

-- Ex. 1 Kind of doesn't count, saw a bit the solution

triangle :: Int -> IO ()
triangle n = if n == 0 then return ()
             else do
                print (take n (repeat '*'))
                triangle (n - 1)
                print (take n (repeat '#'))

-- Ex. 2

checkPrime :: Int -> Int -> Bool
checkPrime n j = if j > div n 2 then True
                 else if mod n j == 0 then False
                 else checkPrime n (j + 1)

isPrime :: Int -> Bool
isPrime n = checkPrime n 2

sumOfPrimeNumbers :: Int -> Int ->  Int
sumOfPrimeNumbers n j =  if n == 0 then 0
                         else if not(isPrime j) then sumOfPrimeNumbers n (j + 1)
                         else j + (sumOfPrimeNumbers (n - 1) (j + 1))

sumOfNPrimeNumbers :: Int -> Int
sumOfNPrimeNumbers n = sumOfPrimeNumbers n 2

-- Ex. 3

reverseArray :: [a] -> [a]
reverseArray arr = if length arr == 0 then []
                   else (reverseArray (tail arr)) ++ [head arr] -- this is the same as: [last arr] ++ (reverseArray (init arr))

-- Ex. 4

delIndexStart :: String -> String -> Int -> Int
delIndexStart str del i = if i >= length str then (-1)
                          else if str!!i == del!!0 then 
                            if take (length del) (drop i str) == del then i
                            else delIndexStart str del (i + 1)
                          else delIndexStart str del (i + 1)

getDelIndexStart :: String -> String -> Int
getDelIndexStart str del = if length del == 0 then 1
                           else delIndexStart str del 0

splitString :: String -> String -> [String]
splitString str del = if getDelIndexStart str del == (-1) then [str]
                      else if length str == 0 then []
                      else [take (getDelIndexStart str del) str] ++ splitString (drop (getDelIndexStart str del + length del) str) del

-- Ex. 5

readUntilWord :: String -> [String] -> IO [String]
readUntilWord end arr = do
    line <- getLine
    if line == end then return arr
    else readUntilWord end (arr ++ [line])

readUntil :: String -> IO [String]
readUntil end = readUntilWord end []


main = do
    triangle 4
    print (sumOfNPrimeNumbers 50)
    print (reverseArray [1,2,3,4,5])
    print (splitString "" "")
    lines <- readUntil "end"
    print lines
