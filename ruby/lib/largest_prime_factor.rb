require 'prime'

class PrimeFactor
  def largest_prime(number)
    list = number.prime_division
    list.last.max
  end
end

