using System;

namespace Event.Domain
{
    public class Conductor
    {
        public int IdConductor { get; set; }

        public Empleado Empleado { get; set; }
        public int IdEmpleado { get; set; }


        public CatBrevete Brevete {get;set;}
        public int IdBrevete { get; set; }

        public Vehiculo Vehiculo { get; set; }
        public int IdVehiculo { get; set; }

    
    }
}