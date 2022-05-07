using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;

namespace Aeronaves.Domain.Model.Aeronaves.ValueObjects
{
    public record AeronaveEstadoAsignacion : ValueObject
    {
        public string Value { get; }

        public AeronaveEstadoAsignacion(string value)
        {
            if (value is null)
            {
                throw new BussinessRuleValidationException("El Estado no puede ser vacio o nulo");
            }
            else if (value != "Asignado" && value != "Cancelado")
            {
                throw new BussinessRuleValidationException("El Estado no es valido -> (Asignado,Cancelado)");
            }
            Value = value;
        }

        public static implicit operator string(AeronaveEstadoAsignacion value)
        {
            return value.Value;
        }

        public static implicit operator AeronaveEstadoAsignacion(string value)
        {
            return new AeronaveEstadoAsignacion(value);
        }
    }
}
