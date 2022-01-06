using DIO.Sports.Interfaces;
using DIO.Sports.Web.Controllers;
using Moq;
using Xunit;

namespace DIO.Sports.Web.Tests
{
    public class SportsControllerTests
    {
        [Fact(DisplayName ="DADO um esporte valido QUANDO inserimos ENTAO chamar o repositorio para inserir")]
        public void Insere_Sucesso()
        {
            var sports = new SportsModel() {Titulo = "SUPERBOWL 2022"};

            var repositorio = new Mock<IRepositorio<Sports>>();

            repositorio.Setup(_ => _.ProximoId()).Returns(1);

            var controller = new SportsController(repositorio.Object);

            controller.Insere(sports);

            repositorio.Verify(_ => _.Insere(It.Is<Sports>(_ => _.Id == 1 && _.retornaTitulo() == "SUPERBOWL 2022")), Times.Once);
        }
    }
}