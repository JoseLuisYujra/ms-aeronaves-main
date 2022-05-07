using System;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Model.Personal;

namespace AeroNaves.ConsolaUI
{
    static class AeronaveConsolaUI
    {
        static void Main(string[] args)
        {
            
            //Instanciando al PERSONAL 
            Personal objPersonal = new Personal("Jose Luis Yujra");

            //Codvuelo,CodAeronave,EstadoFuncionalAeronave (OPERATIVO/MANTENIMIENTO)
            Aeronave objAeronave1 = new Aeronave(1);


            //ASIGNACION DE AERONAVE
            //idaeronave, marca, modelo,capacidadCarga, capTanqueCombustible,  aereopuertoEstacionamiento, estadoFuncionalAeronave
            objAeronave1.RegistroAeronave(objAeronave1.Id, "Boeing","Boeing-2021", 200m,1000m,"Aeropuerto El Alto","OPERATIVO",30);
            objAeronave1.AsignarAeronave();


            //ACTUALIZAR AERONAVE
            //Codvuelo,CodAeronave,EstadoFuncionalAeronave (OPERATIVO/MANTENIMIENTO)
            Aeronave objAeronave2 = new Aeronave(2);
            objAeronave2.RegistroAeronave(objAeronave2.Id, "Boeing", "Boeing-2022", 100m, 800m, "Aeropuerto Santa Cruz", "MANTENIMIENTO",50);
            objAeronave2.AsignarAeronave();

        }
    }
}
