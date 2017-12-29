class SumEvenFib
  def sum_even_fib(limit)
    return generate_fib_seq(limit).select { |n| n % 2 == 0 }.sum
  end

  private

  def generate_fib_seq(limit)
    seq = [0,1]
    seq << nums(seq) while seq.last < limit
    seq
  end

  def nums(ary)
    ary.last(2).inject(0, :+)
  end
end

