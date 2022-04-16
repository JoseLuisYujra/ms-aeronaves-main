using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using ShareKernel.ValueObjects;

namespace Aeronaves.Domain.Model.Personal
{
    public class Personal : AggregateRoot<Guid>
    {
        public PersonNameValue NombreCompleto { get; set; }

        public Personal(string nombreCompleto)
        {
            Id = Guid.NewGuid();           
            NombreCompleto = nombreCompleto;
        }
    }
}
