using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;

namespace Aeronaves.Domain.ValueObjects
{

    public record RegistroDecimalValue
    {
        public decimal Value { get; }
        public RegistroDecimalValue(decimal value)
        {
            if (value < 0)
            {
                throw new BussinessRuleValidationException("El valor del registro no puede ser Negativo");
            }
            Value = value;
        }

        public static implicit operator decimal(RegistroDecimalValue value)
        {
            return value.Value;
        }

        public static implicit operator RegistroDecimalValue(decimal value)
        {
            return new RegistroDecimalValue(value);
        }
    }
}
