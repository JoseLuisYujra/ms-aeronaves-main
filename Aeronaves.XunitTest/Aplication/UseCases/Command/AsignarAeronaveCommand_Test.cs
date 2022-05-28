using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave;
using Aeronaves.Aplication.Dto.Aeronave;

namespace Aeronaves.XunitTest.Aplication.UseCases.Command
{
    public class AsignarAeronaveCommand_Tests
    {
        [Fact]
        public void IsRequest_Valid()
        {

        
            var aeronaveControl = new ControlAeronaveDto();            
            var CapacidadCargaTest = new decimal(500.0);
            var CapTanqueCombustible = new decimal(400.0);           
            var EstadoFuncionalAeronaveTest = "Funcional";
            var command = new AsignarAeronaveCommand(aeronaveControl);

            Assert.Equal(CapacidadCargaTest, command.AeronaveControl.CapacidadCarga);
            Assert.Equal(CapTanqueCombustible, command.AeronaveControl.CapTanqueCombustible);
            Assert.Equal(EstadoFuncionalAeronaveTest, command.AeronaveControl.EstadoFuncionalAeronave);
                                
        }

        [Fact]
        public void TestConstructor_IsPrivate()
        {
            var command = (AsignarAeronaveCommand)Activator.CreateInstance(typeof(AsignarAeronaveCommand), true);
            Assert.Null(command.AeronaveControl);
        }



    }
}
