averageOfDigits :: Integer -> Integer
averageOfDigits x = sumOfDigits x `div` lengthOfNumber x
    where sumOfDigits x = if x == 0 then 0
                          else (mod x 10) + sumOfDigits (x `div` 10)
          lengthOfNumber x = if x == 0 then 0
                             else 1 + lengthOfNumber (x `div` 10)

main = do
    line <- getLine
    let num = read line :: Integer
    print (averageOfDigits num)
