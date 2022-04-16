using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using ShareKernel.Rules;

namespace Aeronaves.Domain.ValueObjects
{

    public record CapacidadCargaValue : ValueObject
    {
        public int Value { get; }
        
        public CapacidadCargaValue(int value)
        {
            if (value <= 0)
            {
                throw new BussinessRuleValidationException("La cantidad de pasajeros no puede ser negativa o cero");
            }
            //Aeronave Comercial  Aeronave Comercial   Clase Ejecutiva = 30 Clase Economica = 100
            //Control a nivel general del ejemplo 30 + 100 =  130
            else if (value > 130)
                { 
                    throw new BussinessRuleValidationException("La cantidad de pasajeros no puede sobrepasar el limite");
                }

            Value = value;
        }

        public static implicit operator int(CapacidadCargaValue value)
        {
            return value.Value;
        }
                
        public static implicit operator CapacidadCargaValue(int value)
        {
            return new CapacidadCargaValue(value);
        }
    }
}
