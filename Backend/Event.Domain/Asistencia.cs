using System;

namespace Event.Domain
{
    public class Asistencia
    {
        public int Id {get;set;}
        public int nroAsistencia {get;set;}
        public double posX {get;set;}
        public double posY {get;set;}
        public DateTime fecha {get;set;}
        public int conductorId {get;set;}
        public Conductor Conductor {get;set;}
        public int vehiculoId {get;set;}
        public Vehiculo Vehiculo {get;set;}
        public bool asistencia {get;set;}
    }
}