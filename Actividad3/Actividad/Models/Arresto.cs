using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Models
{
    public class Arresto : Incidente
    {
        public Arresto(Policia oficial, Persona sujeto) : base(oficial, sujeto)
        {
        }

        override public string VerDescripcion()
        {
            string descripcion =
  $@"Orden de Arresto, Emitada a las {Hora}:{Minuto} 
Motivo: {Motivo}
Sujeto a arrestar:{Sujeto.VerDatos()}
Orden: Por la presente se ordena al arresto inmediato de {Sujeto.VerDatos()}. El Agente {OficialACargo.VerDatos()} está autorizado a proceder con el arresto conforme a las leyes y regulaciones aplicadas
";

            return descripcion;
        }
    }
}
