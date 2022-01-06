using System;
using Xunit;

namespace DIO.Sports.Tests
{
    public class UnitTest1
    {
        //[Fact(DisplayName ="GIVEN WHEN THEN")]
        [Fact(DisplayName = "DADO um esporte válido QUANDO inserimos ENTAO persistir esporte")]
        public void Insere_Sucesso()
        {
            var repositorio = new SportsRepositorio();

            repositorio.Insere(new Sports(1, Genero.Baseball, "TITULO", "", 2022));

            var sportsPersistido = repositorio.RetornaPorId(1);

            Assert.NotNull(sportsPersistido);
            Assert.Equal("TITULO", sportsPersistido.retornaTitulo());
        }
    }
}