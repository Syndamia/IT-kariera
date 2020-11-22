smallestDigit :: Integer -> Integer
smallestDigit x = if x `div` 10 == 0 then x
                  else min (x `mod` 10) (smallestDigit (x `div` 10))

main = do
    line <- getLine
    let num = read line :: Integer
    print (smallestDigit num)
