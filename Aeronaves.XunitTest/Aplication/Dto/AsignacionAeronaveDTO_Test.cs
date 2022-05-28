using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Aeronaves.Aplication.Dto.Aeronave;

namespace Aeronaves.XunitTest.Aplication.Dto
{
    public class AsignacionAeronaveDTO_Test
    {
       
        [Fact]
        public void AsignacionAeronaveDTO_CheckPropertiesValid()
        {
    
            var IdAsignacionAeronaveTest = Guid.NewGuid();
            var IdAeronaveTest = Guid.NewGuid();
            var IdVueloTest = Guid.NewGuid();
            var NroAsientosAeronaveTest = 50;
            var EstadoAsignacionTest = "Disponible";

            var asignacionAeronave = new AsignacionAeronaveDTO();

            Assert.Equal(Guid.Empty, asignacionAeronave.IdAeronave);
            Assert.Equal(Guid.Empty, asignacionAeronave.IdAsignacionAeronave);
            Assert.Equal(Guid.Empty, asignacionAeronave.IdVuelo);
            Assert.Equal(0, asignacionAeronave.NroAsientosAeronave);           

            asignacionAeronave.IdAeronave = IdAsignacionAeronaveTest;
            asignacionAeronave.IdAsignacionAeronave = IdAeronaveTest;
            asignacionAeronave.IdVuelo = IdVueloTest;
            asignacionAeronave.NroAsientosAeronave = NroAsientosAeronaveTest;
            asignacionAeronave.EstadoAsignacion = EstadoAsignacionTest;


            Assert.Equal(IdAsignacionAeronaveTest, asignacionAeronave.IdAeronave);
            Assert.Equal(IdAeronaveTest, asignacionAeronave.IdAsignacionAeronave);
            Assert.Equal(IdVueloTest, asignacionAeronave.IdVuelo);
            Assert.Equal(NroAsientosAeronaveTest, asignacionAeronave.NroAsientosAeronave);
            Assert.Equal(EstadoAsignacionTest, asignacionAeronave.EstadoAsignacion);

        }
    }
}
