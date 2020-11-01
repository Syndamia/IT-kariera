{- 01 Introduction -}

-- Ex. 1

name :: IO ()
name = do
    firstName <- getLine
    lastName <- getLine
    putStrLn (firstName ++ " " ++ lastName)

-- Ex. 2

multiplyNums :: IO ()
multiplyNums = do
    a <- getLine
    b <- getLine
    putStrLn (show ((read a::Int) * (read b::Int)))

-- Ex. 3

circleArea :: IO ()
circleArea = do
    radius <- getLine
    print (pi * (read radius::Double) ** 2) 

-- Ex. 4

isInsideRectangle :: Int -> Int -> Int -> Int -> Int -> Int -> Bool
isInsideRectangle x y x1 y1 x' y' = if x < x' && x' < x1 && y < y' && y' < y1 then True
                                    else False

insideRectangle :: IO ()
insideRectangle = do
   x <- getLine
   y <- getLine
   x1 <- getLine
   y1 <- getLine
   x' <- getLine
   y' <- getLine
   if isInsideRectangle (read x::Int) (read y::Int) (read x1::Int) (read y1::Int) (read x'::Int) (read y'::Int)
   then putStrLn "INSIDE"
   else putStrLn "OUTSIDE"

-- Ex. 5

guessTheNumber :: IO ()
guessTheNumber = do
    line <- getLine
    let guess = read line::Int

    if guess == 5 then putStrLn "You win!"
    else do
        if guess > 5 then putStrLn "Too high!"
        else putStrLn "Too low!"
        main

{- 02 Functions and values -}

-- Ex. 1

doubleVal :: Int -> Int
doubleVal x = x * 2

-- Ex. 2

isEven :: Int -> Bool
isEven x = if (mod x 2) == 0 then True -- x `mod` 2 == 0 also works
           else False

-- Ex. 3

biggestOf3 :: Int -> Int -> Int -> Int
biggestOf3 x y z = if x > y && x > z then x
                   else if y > x && y > z then y
                   else z

-- Ex. 4

add1 :: Int -> Int
add1 x = x + 1

execute :: (a -> a) -> a -> a
execute func x = func x

-- Ex. 5

fac :: Int -> Int
fac 0 = 1 -- you don't really need pattern matching ; this can be done in the if
fac n = if n == 1 then 1
        else n * fac (n - 1)

-- Ex. 5

fib :: Int -> Int
fib n = if n <= 2 then 1
        else fib (n - 1) + fib (n - 2)


main = do
    name
    multiplyNums
    circleArea
    insideRectangle
    multiplyNums

    print (doubleVal 13)
    print (isEven 5)
    print (biggestOf3 15 24 11)
    print (execute add1 5)
    print (fac 5)
    print (fib 21)
