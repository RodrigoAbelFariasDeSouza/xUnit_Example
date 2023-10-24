using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();

    }

    [Fact]
    public void Somar5com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado =_calc.Somar(num1,num2);
        
        //Assert
        Assert.Equal(15,resultado);

    }

        [Fact]
    public void Somar10com10ERetornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;

        //Act
        int resultado =_calc.Somar(num1,num2);
        
        //Assert
        Assert.Equal(20,resultado);

    }


    [Fact]
    public void Passar2RetornarVerdadeiro()
    {
        //Arrange
        int num = 2;

        //Act
        bool resultado =_calc.EhPar(num);
        
        //Assert
        Assert.True(resultado);

    }
    [Theory]
    [InlineData(new int[] { 2, 4, 6})]
    public void PassarNumerosParesRetornarVerdadeiro(int[] numero)
    {

        //Act/Assert
        Assert.All(numero, num => Assert.True(_calc.EhPar(num)));

    }
}