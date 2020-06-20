using System;

namespace Event.Domain
{
    public class Conductor
    {
        public int Id {get;set;}
        public string nombres {get;set;}
        public string apellidos {get;set;}
        public string telefono {get;set;}
        public string correo {get;set;}
        public string DNI {get;set;}
        public int CatBreveteId {get;set;}
        public CatBrevete CatBrevete {get;set;}
        public DateTime emisionBrevete {get;set;}
        public DateTime caducBrevete {get;set;}
    }
}