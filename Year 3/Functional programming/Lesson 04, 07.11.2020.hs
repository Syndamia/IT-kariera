{- 05. Functions -}

-- Ex. 1

-- mathematicalEq :: [Int] -> String
-- mathematicalEq [] = ""
-- mathematicalEq nums = if length nums <= 1 then show (head nums)
--                       else "(" ++ mathematicalEq (init nums) ++ "+" ++ show (last nums) ++ ")"

stringGen :: String -> Int -> String
stringGen str a = "(" ++ str ++ "+" ++ show a ++ ")"

mathEq :: [Int] -> String
mathEq [] = ""
mathEq nums = foldl stringGen (show (head nums)) (tail nums)

-- Ex. 2

stringGen' :: Int -> String -> String
stringGen' a str ="(" ++ show a ++ "+" ++ str ++ ")"

mathEq' :: [Int] -> String
mathEq' [] = ""
mathEq' nums = foldr stringGen' (show (last nums)) (init nums)

-- Ex. 3

comp :: Eq a => [a] -> a -> [a]
comp arr a = if last arr == a then arr
             else arr ++ [a]

compress :: Eq a => [a] -> [a]
compress arr = foldl comp [head arr] (tail arr)

-- Ex. 4

duplicateElem :: [a] -> [a]
duplicateElem [] = []
duplicateElem arr = foldl (\array a -> array ++ [a] ++ [a]) [] arr

-- Ex. 5

duplicateElemTimes :: [a] -> Int -> [a]
duplicateElemTimes arr n = foldl (\array a -> array ++ replicate n a) [] arr

-- Ex. 6

-- subElements :: [a] -> Int -> Int -> [a]
-- subElements arr start end = drop start (take (end + 1) arr)

takeElement :: [a] -> Int -> Int -> Int -> [a]
takeElement arr index start end = if start <= index && index <= end then [arr!!index]
                                  else []

subElements :: [a] -> Int -> Int -> [a]
subElements arr start end = foldl (\array index -> array ++ takeElement arr index start end) [] [0..(length arr - 1)]

{- 06. Closures -}

-- Ex. 1

multiply :: Int -> Int -> Int
multiply a = \b -> a * b

-- Ex. 2

biggestOfThree :: Int -> Int -> Int -> Int
biggestOfThree a = \b -> \c -> if a > b && a > c then a
                               else if b > a && b > c then b
                               else c

-- Ex. 3

functionArg :: (a -> a) -> a -> a
functionArg func = \a -> func a

-- Ex. 4

mathEq1 :: [Int] -> String
mathEq1 [] = ""
mathEq1 nums = foldl (\str a -> "(" ++ str ++ "+" ++ show a ++ ")") (show (head nums)) (tail nums)


main :: IO()
main = do
    print (mathEq [1, 2, 3, 4, 5])
    print (mathEq' [1, 2, 3, 4, 5])
    print (compress [1, 1, 1, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8])
    print (duplicateElem [1, 2, 3, 4, 4])
    print (duplicateElemTimes [1, 2, 3] 3)
    print (subElements [1, 2, 3, 4, 5] 2 3)

    print (multiply 5 10)
    print (biggestOfThree 5 10 (-20))
    print (functionArg (\x -> x + 1) 5)
    print (mathEq1 [1, 2, 3, 4, 5])
