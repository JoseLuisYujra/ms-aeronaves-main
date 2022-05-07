using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;

namespace Aeronaves.Domain.Model.Aeronaves.ValueObjects
{
 

    public record AeronaveEstadoDisponibilidad : ValueObject
    {
        public string Value { get; }
                
        public AeronaveEstadoDisponibilidad(string value)
        {
            if (value is null)
            {
                throw new BussinessRuleValidationException("El Estado no puede ser vacio o nulo");
            }
            else if (value != "Disponible"  && value != "Asignado")
            {
                throw new BussinessRuleValidationException("El Estado no es valido -> (Disponible,Asignado)");
            }
            Value = value;
        }

        public static implicit operator string(AeronaveEstadoDisponibilidad value)
        {
            return value.Value;
        }

        public static implicit operator AeronaveEstadoDisponibilidad(string value)
        {
            return new AeronaveEstadoDisponibilidad(value);
        }
    }
}
