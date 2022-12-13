public class StringCalculatorTest
{
    private StringCalculator calculator = new StringCalculator();

    [Fact]
    public void Add_EmptyString_ReturnsZero()
    {
        int result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void Add_OneNumber_ReturnsNumber()
    {
        int result = calculator.Add("42");

        Assert.Equal(42, result);
    }

    [Fact]
    public void Add_TwoNumbersDelimitedWithComma_ReturnsSum()
    {
        int result = calculator.Add("1,2");

        Assert.Equal(3, result);
    }

    [Fact]
    public void Add_MultipleNumbersDelimitedWithComma_ReturnsSum()
    {
        int result = calculator.Add("1,2,3");

        Assert.Equal(6, result);
    }

    [Fact]
    public void Add_TwoNumbersDelimitedWithNewLine_ReturnsSum()
    {
        int result = calculator.Add("1\n2");

        Assert.Equal(3, result);
    }


    [Fact]
    public void Add_TwoNumbersDelimitedWithCustomDelimiter_ReturnsSum()
    {
        string input = "//;\n1;2";
        int result = calculator.Add(input);

        Assert.Equal(3, result);
    }

    
    
}