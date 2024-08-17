using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Models
{
    public class Comisaria
    {
        Guardia[] guardias = new Guardia[2];
        ArrayList agentes = new ArrayList();
        ArrayList incidentes = new ArrayList();

        public int CantidadIncidentes
        {
            get 
            {
                return incidentes.Count;    
            }
        }

        public Comisaria()
        {
            for (int n = 0; n < guardias.Length; n++)
                guardias[n] = new Guardia();
        }

        public bool AsignarPolicia(Policia agente)
        {
            if (agentes.Count < 2)
            {
                agentes.Add(agente);
                return true;
            }
            return false;
        }

        public Policia VerAgente(int nro)
        {
            Policia buscado = null;
            for (int n = 0; n < agentes.Count; n++)
            {
                Policia agente = agentes[n] as Policia;
                if (agente != null && agente.NumeroPlaca == nro)
                {
                    buscado = agente;
                }
            }
            return buscado;
        }

        public void AsignarGuardia(int nroGuardia, int hDesde, int mDesde, int mDuracion, Policia agente)
        {
            if (nroGuardia < 2)
            {
                Guardia sel = guardias[nroGuardia];
                sel.HoraDesde = hDesde;
                sel.MinutoDesde = mDesde;
                sel.TiempoMinutos = mDuracion;
            }
        }

        public void RegistrarIncidente(Policia agente, Persona persona, string motivo, int hIncidente, int mIncidente, int tipoIncidente)
        {
            Incidente nueva = null;
            if (tipoIncidente == 0)
            {
                nueva = new Denuncia(agente, persona);
            }
            else if (tipoIncidente == 1)
            {
                nueva = new Arresto(agente, persona);
            }

            if (nueva != null)
            {
                incidentes.Add(nueva);

                nueva.Hora = hIncidente;
                nueva.Minuto = mIncidente;
                nueva.Motivo = motivo;
                nueva.TipoIncidente = tipoIncidente;
            }
        }

        public Incidente VerIncidente(int idx)
        {
            if (idx>=0 && idx < CantidadIncidentes)
            {
                return incidentes[idx] as Incidente;
            }
            return null;
        }
    }
}
