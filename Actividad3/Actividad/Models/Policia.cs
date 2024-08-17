using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Models
{
    public class Policia : Persona
    {
        public int NumeroPlaca { get; private set; }
                
        public Policia(int dni, string nombre, int numeroPlaca):base(dni,nombre)
        {
            this.NumeroPlaca = numeroPlaca;
        }

        override public string VerDatos() 
        {
            return $"{this.Nombre}(DNI:{this.DNI} - placa:{NumeroPlaca})";
        }
    }
}
