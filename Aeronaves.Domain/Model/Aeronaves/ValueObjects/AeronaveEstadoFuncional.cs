using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;

namespace Aeronaves.Domain.ValueObjects
{

    public record AeronaveEstadoFuncional : ValueObject
    {
        public string Value { get; }
        public AeronaveEstadoFuncional(string value)
        {
            if (value is null)
            {
                throw new BussinessRuleValidationException("El Estado no puede ser vacio o nulo");
            }
            else if (value != "Operativo" && value != "Mantenimiento")
                {
                throw new BussinessRuleValidationException("El Estado no es valido -> (Operativo,Mantenimiento)");
            }      
           Value = value;
        }

        public static implicit operator string(AeronaveEstadoFuncional value)
        {
            return value.Value;
        }

        public static implicit operator AeronaveEstadoFuncional(string value)
        {
            return new AeronaveEstadoFuncional(value);
        }
    }
}
