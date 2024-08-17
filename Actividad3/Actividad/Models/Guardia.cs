using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Guardia
    {
        public int HoraDesde { get; set; }
        public int MinutoDesde { get; set; }

        public int HoraHasta 
        { 
            get 
            {
                int mins=HoraDesde*60+MinutoDesde+TiempoMinutos;
                return mins % 60;
            } 
        }
        public int MintoHasta
        {
            get
            {
                int mins = HoraDesde * 60 + MinutoDesde + TiempoMinutos;
                return mins / 60;
            }
        }

        public int TiempoMinutos { get; set; }

        public Policia OficialAsignado{get;private set;}

        public Guardia() { }

        public void AsignarPolicia(Policia agente, int h, int m, int cantM) 
        {
            OficialAsignado = agente;
            HoraDesde = h; 
            MinutoDesde=m;
            TiempoMinutos = cantM;
        }
    }
}
