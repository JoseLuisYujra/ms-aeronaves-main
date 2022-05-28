using Aeronaves.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Aeronaves.Aplication.UseCases.Command.Aeronaves;
using Aeronaves.Domain.Event;
using Aeronaves.Domain.Model.Aeronaves;

namespace Aeronaves.XunitTest.Aplication.UseCases.Handler
{
    public class ActualizarEstadoAeronaveHandler_Test
    {
        private readonly Mock<IAeronaveRepository> _IAeronaveRepository;

        public ActualizarEstadoAeronaveHandler_Test()
        {
            _IAeronaveRepository = new Mock<IAeronaveRepository>();
        }

        [Fact]
        public void Handle_Correctly()
        {
            
            var IdAeronaveTest = Guid.NewGuid();
            var CodAeronaveTest = 3;
            var idaeronaveTest = Guid.NewGuid();
            var idVueloTest = Guid.NewGuid();
            var nroAsientosAeronaveTest = 50;
            var estadoAsignacionTest = "Disponible";
            var estadoDisponibilidadTest = "Disponible";
            var totalNroAsientosTest = 50;

            var AeronaveasignadaTest = new AsignacionAeronave(idaeronaveTest, idVueloTest, nroAsientosAeronaveTest,
                                                              estadoAsignacionTest);
            var tcs = new CancellationTokenSource(1000);
            
            /*
            _IAeronaveRepository.Setup(mock => mock.FindByIdAsync(IdAeronaveTest))
                .Returns(Task.FromResult(AeronaveasignadaTest));

          */

            var handler = new ActualizarEstadoAeronaveHandler(_IAeronaveRepository.Object);
            var objRequest = new AeronaveEstado(idaeronaveTest, CodAeronaveTest, estadoDisponibilidadTest,
                                                              totalNroAsientosTest);      

            var result = handler.Handle(objRequest, tcs.Token);
                      
           Assert.Equal(50, (int)AeronaveasignadaTest.NroAsientosAeronave);
        }
    }
}
