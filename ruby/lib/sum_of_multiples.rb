class SumOfMultiples
  def sum_multiples(range)
    numbers = define_range(range - 1)
    select_multiples(numbers).inject(0, :+)
  end

  private

  def define_range(range)
    (1..range).to_a
  end

  def select_multiples(numbers)
    numbers.select { |n| n if n % 3 == 0 || n % 5 == 0 }.map { |i| i}
  end
end

module Enumerable
  def sum
    inject(0, :+)
  end
end
