using Xunit;
using FluentAssertions;

namespace greet.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve retornar \"Olá\"")]
    [InlineData("Olá")]     // a entrada e inserida aqui
    public void TestGreet(string expected)  // indiquei esse parâmetro para a função de teste:
    {
        var result = Class1.Greet();        // aqui estou usando a funcao que quero testar
        result.Should().Be(expected);       // para testar uso aqui o FluentAssertions e digo que o result deve ser igual ao esperado
    }
}