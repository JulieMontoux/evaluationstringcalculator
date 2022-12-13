public class StringCalculatorTest
{
    private StringCalculator calculator = new StringCalculator();
    // cas de 0
    [Fact]
    public void Add_EmptyString_ReturnsZero()
    {
        //ETANT DONNE que result = 0 
        int result = calculator.Add("");
        //ALORS on affiche result
        Assert.Equal(0, result);
    }
    // cas d'un seul nombre
    [Fact]
    public void Add_OneNumber_ReturnsNumber()
    {
        //ETANT DONNE que result = 42
        int result = calculator.Add("42");
        //ALORS on affiche result
        Assert.Equal(42, result);
    }
    // cas de deux nombres séparés par une virgule
    [Fact]
    public void Add_TwoNumbersDelimitedWithComma_ReturnsSum()
    {
        //ETANT DONNE que result = "1,2"
        int result = calculator.Add("1,2");
        //ALORS on affiche result 1+2=3
        Assert.Equal(3, result);
    }
    // plus de 2 nombres
    [Fact]
    public void Add_MultipleNumbersDelimitedWithComma_ReturnsSum()
    {
        //ETANT DONNE que result = "1,2,3"
        int result = calculator.Add("1,2,3");
        //ALORS on affiche result 1+2+3=6
        Assert.Equal(6, result);
    }
    // séparation par le \n
    [Fact]
    public void Add_TwoNumbersDelimitedWithNewLine_ReturnsSum()
    {
        //ETANT DONNE que result = "1\n2" 
        int result = calculator.Add("1\n2");
        //ALORS on affiche result 1+2 =3
        Assert.Equal(3, result);
    }

    // cas de la longueur du délimitateur
    [Fact]
    public void Add_TwoNumbersDelimitedWithCustomDelimiter_ReturnsSum()
    {
        //ETANT DONNE que le delimitateur est différent
        string input = "//[delimitateur]1,2";
        //QUAND on ajoute input a Add()
        int result = calculator.Add(input);
        //ALORS on affiche result 1+2=3
        Assert.Equal(3, result);
    }


    //nombres négatifs
    [Fact]
    public void Add_NegativeNumber_ErrorMessageContainsNumber()
    {
        try
        {
            //ETANT DONNE une chaine avec un nombre négatif
            calculator.Add("-1");
        }
        catch (ArgumentException e)
        {
            //ALORS on affiche le message
            Assert.Equal("Negatives not allowed: -1", e.Message);
        }
    }
    // nombres négatifs et leurs positions
    [Fact]
    public void Add_MultipleNegativeNumbers_ErrorMessageContainsAllNegativeNumbers()
    {
        try
        {
            //ETANT DONNE une chaine avec des nombres négatifs
            calculator.Add("-1,2,-3");
        }
        catch (ArgumentException e)
        {
            //ALORS on affiche le message
            Assert.Equal("Negatives not allowed: -1 -3", e.Message);
        }
    }
}