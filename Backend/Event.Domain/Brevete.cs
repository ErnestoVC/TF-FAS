using System;

namespace Event.Domain
{
    public class Brevete
    {
        public int Id { get; set; }
        public int  numero { get; set; }
        public DateTime fechaCaducidad { get; set; }

        public Conductor conductor { get; set; }
        public int IdConductor { get; set; }

        public Brevete brevete { get; set; }
        public int IdBrevete { get; set; }
    }
}