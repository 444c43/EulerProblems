module EulerProblems where

-- PROJECT EULER: PROBLEM 1

-- takes an integer, returns an integer
sumOfMultiples :: Integral a => a -> a 
sumOfMultiples n = 
  let limit = n - 1
  in sum [ x | x <- [1..limit], x `mod` 3 == 0 || x `mod` 5 == 0 ]


-- PROJECT EULER: PROBLEM 2(iterative, slow)

-- takes an integer, returns an integer
sumEvenFib :: Integral a => a -> a
sumEvenFib limit = sum [ n | n <- takeWhile (< limit) generateFib, even n ]

-- takes an integer, returns an array
generateFib :: Num a => [a]
generateFib = 0:1:zipWith (+) generateFib (tail generateFib)
