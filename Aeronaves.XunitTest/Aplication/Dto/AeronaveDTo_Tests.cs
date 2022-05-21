using Aeronaves.Aplication.Dto.Aeronave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Aeronaves.XunitTest.Aplication.Dto
{
    public class AeronaveDTo_Tests
    {
        [Fact]
        public void AeronaveDTO_CheckPropertiesValid()
        {
            //arrange
            var IdTest = Guid.NewGuid();
            var IdAeronaveTest = Guid.NewGuid();
            var CodAeronaveTest = 1;
            var IdAeropuertoTest = Guid.NewGuid();
            var TotalNroAsientosTest = 50;
            var EstadoDisponibilidadTet = "Disponible";

            var ObjAeronave = new AeronaveDTO();

            Assert.Equal(Guid.Empty, ObjAeronave.Id);
            Assert.Equal(0, ObjAeronave.TotalNroAsientos);
            Assert.Null(ObjAeronave.EstadoDisponibilidad);


            ObjAeronave.Id = IdTest;
            ObjAeronave.IdAeronave = IdAeronaveTest;
            ObjAeronave.CodAeronave = CodAeronaveTest;
            ObjAeronave.TotalNroAsientos = TotalNroAsientosTest;
            ObjAeronave.IdAeropuerto = IdAeropuertoTest;
            ObjAeronave.EstadoDisponibilidad = EstadoDisponibilidadTet;

            Assert.Equal(IdTest, ObjAeronave.Id);
            Assert.Equal(TotalNroAsientosTest, ObjAeronave.TotalNroAsientos);
            Assert.Equal(EstadoDisponibilidadTet, ObjAeronave.EstadoDisponibilidad);




        }
    }
}
