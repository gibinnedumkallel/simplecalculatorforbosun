using Moq;
using SimpleCalculator.Controllers;
using SimpleCalculator.Service.Interfaces;
using Xunit;

namespace SimpleCalculator.Tests;

public class CalculatorApiTest
{

    private readonly Mock<ICalculatorService> _calculatorService;

    public CalculatorApiTest()
    {
        _calculatorService = new Mock<ICalculatorService>();
    }

    [Fact]
    public void Add()
    {
        //arrange
        double a = 5;
        double b = 3;
        double expected = 8;
        _calculatorService.Setup(x => x.Add(a, b))
            .Returns(expected);
        var controller = new CalculateController(_calculatorService.Object);

        //act
        var actual = controller.Add(a, b);

        //Assert
        Assert.Equal(expected, actual, 0);
    }

    [Fact]
    public void Substract()
    {
        //arrange
        double x1 = 10;
        double x2 = 8;
        double expected = 2;
        _calculatorService.Setup(x => x.Subtract(x1, x2))
            .Returns(expected);
        var controller = new CalculateController(_calculatorService.Object);

        //act
        var actual = controller.Subtract(x1, x2);

        //Assert
        Assert.Equal(expected, actual, 0);
    }

    [Theory(DisplayName = "Maths- Divided with parameters")]
    [InlineData(40, 8, 5)]
    public void Divide(double value1, double value2, double value3)
    {
        //arrange
        double x1 = value1;
        double x2 = value2;
        double expected = value3;

        _calculatorService.Setup(x => x.Divide(x1, x2))
            .Returns(expected);
        var controller = new CalculateController(_calculatorService.Object);

        //act
        var actual = controller.Divide(x1, x2);

        //Assert
        Assert.Equal(expected, actual, 0);
        
    }

    [Fact]
    public void Multiply()
    {
        //arrange
        double x1 = 5;
        double x2 = 8;
        double expected = 40;
        _calculatorService.Setup(x => x.Multiply(x1, x2))
            .Returns(expected);
        var controller = new CalculateController(_calculatorService.Object);

        //act
        var actual = controller.Multiply(x1, x2);

        //Assert
        Assert.Equal(expected, actual, 0);
        
    }    
}
