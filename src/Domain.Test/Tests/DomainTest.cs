using Domain.Entity;
using Domain.Entity.Enum;
using Xunit;

namespace Domain.Test.Tests;

public class DomainTest
{
    //Criar um curso com os seguintes dados :
    //    Nome, Carga horária, Publico alvo e Valor do curso

    [Fact]
    public void Curso_CriarCurso_RetornaCurso()
    {
        var cursoEsperado = new
        {
            Nome = "Curso de TDD",
            CargaHoraria = (double)40,
            PublicoAlvo = EPublicoAlvo.ESTUDANTE,
            Valor = (decimal)100
        };
        Curso curso = new(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);

        Assert.Equal(cursoEsperado.Nome, curso.Nome);
        Assert.Equal(cursoEsperado.CargaHoraria, curso.CargaHoraria);
        Assert.Equal(cursoEsperado.PublicoAlvo, curso.PublicoAlvo);
        Assert.Equal(cursoEsperado.Valor, curso.Valor);
    }
}
