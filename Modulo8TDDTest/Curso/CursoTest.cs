using ExpectedObjects;
using Modulo8TDD.Curso.Enums;
using Modulo8TDDTest.Utils;
using System;
using Xunit;

namespace Modulo8TDDTest.Curso
{
    public class CursoTest
    {
        //Criar um curso com nome, carga horária, publico alvo e valor do curso

        [Fact]
        public void Curso_CriarCurso_RetornaCurso()
        {
            var cursoEsperado = new
            {
                Nome = "Curso de Informatica",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)50,
            };

            var curso = new Modulo8TDD.Curso.Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);

            cursoEsperado.ToExpectedObject().ShouldMatch(curso);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Curso_NomeVazioOuNulo_RetornaArgumentException(string nomeInvalido)
        {
            string mensagemError = "Parametros inválidos!";
            var cursoEsperado = new
            {
                Nome = "Curso de Informatica",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)50,
            };

            Assert.Throws<ArgumentException>(() => new Modulo8TDD.Curso.Curso(nomeInvalido, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor)).ValidarMensagem(mensagemError);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void Curso_CargaHorariaMenorQue1_RetornaArgumentException(double CargaHorariaInvalida)
        {
            string mensagemError = "Parametros inválidos!";
            var cursoEsperado = new
            {
                Nome = "Curso de Informatica",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)50,
            };

            Assert.Throws<ArgumentException>(() => new Modulo8TDD.Curso.Curso(cursoEsperado.Nome, CargaHorariaInvalida, cursoEsperado.PublicoAlvo, cursoEsperado.Valor)).ValidarMensagem(mensagemError);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void Curso_ValorMenorQue1_RetornaArgumentException(double valorInvalido)
        {
            string mensagemError = "Parametros inválidos!";
            var cursoEsperado = new
            {
                Nome = "Curso de Informatica",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)50,
            };

            Assert.Throws<ArgumentException>(() => new Modulo8TDD.Curso.Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, valorInvalido)).ValidarMensagem(mensagemError);
        }
    }
}