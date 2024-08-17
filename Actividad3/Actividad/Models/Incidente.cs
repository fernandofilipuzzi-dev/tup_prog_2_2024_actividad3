using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Models
{
    abstract public class Incidente
    {
        public int Hora { get; set; }
        public int Minuto { get; set; }

        public string Motivo { get; set; }

        public Policia OficialACargo { get; private set; }
        public Persona Sujeto { get; private set; }

        public int TipoIncidente { get; set; }

        public Incidente(Policia oficial, Persona sujeto) 
        {
            OficialACargo = oficial;
            Sujeto = sujeto;
        }

        abstract public string VerDescripcion();
    }
}
