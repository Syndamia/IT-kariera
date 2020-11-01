-- Ex. 1
getElementByIndex :: [a] -> Int -> a
getElementByIndex array i = if i == 0 then head array
                            else getElementByIndex (tail array) (i - 1)

-- Ex. 2

listLength :: [a] -> Int
listLength arr = if null arr then 0
                 else 1 + listLength (tail arr)

-- Ex. 3

duplicate :: [a] -> Int -> [a]
duplicate array n = if null array then []
                    else take n (repeat (head array)) ++ duplicate (tail array) n

-- Ex. 4

removeNTh :: [a] -> Int -> [a]
removeNTh array n = if null array then []
                    else (take (n - 1) array) ++ removeNTh (drop n array) n

-- Ex. 5

fib :: Int -> [Int] -> [Int]
fib n arr = if n <= 0 then arr
            else fib (n - 1) (arr ++ [last arr + last (init arr)])

fibonacci :: Int -> [Int]
fibonacci n
    | n <= 2 = take n (repeat 1)
    | otherwise = fib (n - 2) [1, 1]

-- Ex. 6

fac :: Int -> [Int] -> [Int]
fac n arr = if n <= 0 then arr
            else fac (n - 1) ([product [1..(n-1)]] ++ arr) -- a bit wrong, shouldn't return [1, 1, 2, ...], but [1, 2, ...] ; leaving it because the exercise examples have the same error

factoriel :: Int -> [Int]
factoriel n = fac n []

{- Advanced Exercises -}

-- Ex. 1

swapTwo :: [a] -> Int -> [a]
swapTwo arr i = take i arr ++ [arr!!(i + 1)] ++ [arr!!i] ++ drop (i + 2) arr

desc :: (Ord a) => [a] -> Int -> Int -> [a] -- (Ord a) => means "for all types a the belong to the class Ord, this is a function type" ; required when comparing (< or >) values of type a
desc arr end curr = if end == 0 then arr
                    else if curr == end then desc arr (end - 1) 0
                    else if arr!!curr < arr!!(curr + 1) then desc (swapTwo arr curr) end (curr + 1)
                    else desc arr end (curr + 1)

orderByDesc :: (Ord a) => [a] -> [a]
orderByDesc arr = desc arr (length arr - 1) 0


main :: IO ()
main = do
    print (getElementByIndex [11, 22, 33] 2)
    print (listLength [1, 2, 3])
    print (duplicate "abc" 2)
    print (removeNTh [1, 2, 3, 4, 5, 6, 7, 8, 9] 3)
    print (fibonacci 10)
    print (factoriel 5)

    print (orderByDesc ["one", "two", "three"])
