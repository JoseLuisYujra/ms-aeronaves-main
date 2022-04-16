using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;

namespace Aeronaves.Domain.Model.Aeronaves.ValueObjects
{

    public record NroAsientosValue : ValueObject
    {
        public int Value { get; }
        public NroAsientosValue(int value)
        {
            if (value <= 0)
            {
                throw new BussinessRuleValidationException("Nro de Asientos no puede ser negativa o cero");
            }
            Value = value;
        }

        public static implicit operator int(NroAsientosValue value)
        {
            return value.Value;
        }

        public static implicit operator NroAsientosValue(int value)
        {
            return new NroAsientosValue(value);
        }
    }
}
