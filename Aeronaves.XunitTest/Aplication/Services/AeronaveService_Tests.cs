using Aeronaves.Aplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Aeronaves.XunitTest.Aplication.Services
{
    public class AeronaveService_Tests
    {
        //[Fact]
        //public async void GenerarAsignacionAeronave_CheckValidData()
        //{

        //    var AeonaveServices = new AeronaveService();
        //    int asignacionAeronave = await AeonaveServices.GenerarAsignacionAeronaveAsync();
        //    Assert.Equal(1, asignacionAeronave);          

        //}

        [Theory]
        [InlineData(1,true)]
        [InlineData(2, false)]
        [InlineData(3, false)]
        [InlineData(4, false)]
        [InlineData(5, false)]
        [InlineData(6, false)]
        [InlineData(7, false)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(0, false)]
        public async void GenerarAsignacionAeronave_CheckValidData(int expectedAsignacionAeronave, bool isEqual)
        {
            var AeonaveServices = new AeronaveService();
            int asignacionAeronave = await AeonaveServices.GenerarAsignacionAeronaveAsync();
            if (isEqual)
            {
                Assert.Equal(expectedAsignacionAeronave, asignacionAeronave);
            }
            else 
            {
                Assert.NotEqual(expectedAsignacionAeronave, asignacionAeronave);
            }     

        }
    }
}
