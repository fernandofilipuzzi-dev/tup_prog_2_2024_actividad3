using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Incidente
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

        public string VerDescripcion()
        {
            string descripcion = "";
            byte[] vector;
            vector.len
            if (TipoIncidente == 0)
            {
                descripcion =
$@"Denuncia Policial, Emitida a las {Hora}:{Minuto} 
Motivo: {Motivo}
Agente policial inteviniente: {OficialACargo.VerDatos()}
Sujeto Denunciante:{OficialACargo.VerDatos()}
";
            }
            else if (TipoIncidente == 1)
            {
                descripcion =
$@"Orden de Arresto, Emitada a las {Hora}:{Minuto} 
Motivo: {Motivo}
Sujeto a arrestar:{OficialACargo.VerDatos()}
Orden: Por la presente se ordena al arresto inmediato de {OficialACargo.VerDatos()}. El Agente {OficialACargo.VerDatos()} está autorizado a proceder con el arresto conforme a las leyes y regulaciones aplicadas
";
            }
            return descripcion;

  
        }
    }
}
