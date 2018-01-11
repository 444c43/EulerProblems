describe("SumofMultiples", function() {
  var sumOfM;

  it("should sum multiples up to 10", function() {
    sumOfM = new SumOfMultiples();
    var result = sumOfM.sum(10);

    expect(result).toEqual(23);
  });

  it("should sum multiples up to 1000", function() {
    sumOfM = new SumOfMultiples();
    var result = sumOfM.sum(1000);

    expect(result).toEqual(233168);
  });
});
