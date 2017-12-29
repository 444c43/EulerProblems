module EulerTests where

import Test.Hspec
import EulerProblems

main :: IO ()
main = hspec $ do

  describe "sum of multiples" $ do
    it "sum multiples under 10 (example)" $ do
      sumOfMultiples 10 `shouldBe` 23

    it "sum multiples under 1000 (example)" $ do
      sumOfMultiples 1000 `shouldBe` 233168 

  describe "sum even fibonacci" $ do
    it "sums values under 100 (example)" $ do
      sumEvenFib 100 `shouldBe` 44

    it "sums values under 4 million" $ do
      sumEvenFib 4000000 `shouldBe` 4613732
