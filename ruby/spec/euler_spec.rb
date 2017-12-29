require 'spec_helper'

describe 'Euler Problems' do
  describe SumOfMultiples do
    context 'sum of multiples' do
      subject { described_class.new }
      let(:test) { 23 }
      let(:answer) { 233168 }

      it { expect(subject.sum_multiples(10)).to eq(test) }

      it { expect(subject.sum_multiples(1000)).to eq(answer) }
    end
  end

  describe SumEvenFib do
    context 'sum even fibonacci numbers' do
      subject { described_class.new }
      let(:test) { 44 }
      let(:answer) { 4613732 }

      it { expect(subject.sum_even_fib(89)).to eq(test) }

      it { expect(subject.sum_even_fib(4000000)).to eq(answer) }
    end
  end

  describe PrimeFactor do
    context 'find largest prime factor' do
      subject { described_class.new }
      let(:test) { 29 }
      let(:answer) { 6857 }

      it { expect(subject.largest_prime(13195)).to eq(test) }

      it { expect(subject.largest_prime(600851475143)).to eq(answer) }
    end
  end
end
