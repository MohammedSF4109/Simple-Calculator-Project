global using Xunit;
namespace SimpleCalculator.Test;
using SimpleCalculator;


public class CalculatorTest
{
    [Fact]
    public void Add_SimpleValuesShouldCalculate()
    {
        //Arrange
        double exepected = 5;

        //Actual
        double actual = Calculator.Addition(3, 2);

        //Assert
        Assert.Equal(exepected, actual);
    }

    [Fact]

    public void Subtract_SimpleValuesShouldCalculate()
    {
        //Arrange
        double exepected = 5;

        //Actual 
        double actual = Calculator.Subtraction(10, 5);

        //Assert
        Assert.Equal(exepected, actual);
    }

    [Fact]

    public void Multiple_SimpleValuesCalculate()
    {
        //Arrange
        double exepected = 10;

        //Actual 
        double actual = Calculator.Multiplication(5, 2);

        //Assert
        Assert.Equal(exepected, actual);
    }

    [Fact]

    public void Division_SimpleValuesCalculate()
    {
        //Arrange 
        double exepected = 5;

        //Actual 
        double actual = Calculator.Division(10, 2);

        //Assert
        Assert.Equal(exepected, actual);
    }
}