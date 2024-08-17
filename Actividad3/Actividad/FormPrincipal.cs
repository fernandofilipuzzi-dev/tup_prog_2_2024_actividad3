using Actividad3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3
{
    public partial class FormPrincipal : Form
    {
        Comisaria destacamento=new Comisaria();

        public FormPrincipal()
        {
            InitializeComponent();
        }
            
        private void btnAltaComisaria_Click(object sender, EventArgs e)
        {
            Policia juan = new Policia(43344232, "Juan Barrientos", 23);//1
            Policia ana = new Policia(40344232, "Ana", 30);//2

            destacamento = new Comisaria();//3 y 4

            destacamento.AsignarPolicia(juan);//5
            destacamento.AsignarPolicia(ana);//6

            #region mostrando los numero de placa de los policias asignados
            cmbNumeroPlaca.Items.Clear();
            cmbNumeroPlaca.Items.Add(juan.NumeroPlaca);
            cmbNumeroPlaca.Items.Add(ana.NumeroPlaca);
            btnListrarIncidentes.Enabled = true;
            gbAdministracion.Enabled = true;
            #endregion
        }
        
        private void btnAsignarGuardias_Click(object sender, EventArgs e)
        {
            string nroPlacaString=cmbNumeroPlaca.SelectedItem.ToString();

            int nroPlaca=Convert.ToInt32(nroPlacaString);
            int nroGuardia = Convert.ToInt32(nupNumeroGuardia.Value);
            int hDesde= Convert.ToInt32(nupHDesde.Value);
            int mDesde=Convert.ToInt32(nupMDesde.Value);
            int duracion=Convert.ToInt32(nupMDuracion.Value);

            Policia agente = destacamento.VerAgente(nroPlaca);

            destacamento.AsignarGuardia(nroGuardia, hDesde, mDesde, duracion, agente);

            #region clear
            cmbNumeroPlaca.SelectedIndex = -1;
            nupNumeroGuardia.Value = -1;
            nupHIncidente.Value = 0;
            nupMIncidente.Value = 0;
            tbMotivo.Clear();
            #endregion
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrarDenuncia_Click(object sender, EventArgs e)
        {
            if (cmbNumeroPlaca.SelectedItem != null && cbxIncidente.SelectedItem!=null)
            {
                string nroPlacaString = cmbNumeroPlaca.SelectedItem.ToString();
                int nroPlaca = Convert.ToInt32(nroPlacaString);
                int hIncidente = Convert.ToInt32(nupHIncidente.Value);
                int mIncidente = Convert.ToInt32(nupMIncidente.Value);
                string motivo = tbMotivo.Text;

                Policia agente = destacamento.VerAgente(nroPlaca);

                int dni = Convert.ToInt32(tbDNI.Text);
                string nombre = tbNombre.Text;
                Persona persona = new Persona(dni, nombre);

                int tipoIncidente = cbxIncidente.SelectedIndex;

                destacamento.RegistrarIncidente(agente, persona, motivo, hIncidente, mIncidente, tipoIncidente);

                #region clear
                cmbNumeroPlaca.SelectedIndex = -1;
                cbxIncidente.SelectedIndex = -1;
                nupHIncidente.Value = 0;
                nupMIncidente.Value = 0;
                tbMotivo.Clear();
                tbDNI.Clear();
                tbNombre.Clear();
                #endregion
            }
            else
            {
                MessageBox.Show("Verifique la selección de un agente y/o el tipo de incidente","Error");
            }

        }

        private void btnListrarIncidentes_Click(object sender, EventArgs e)
        {
            FormVerInicidentes fIncidentes=new FormVerInicidentes();

            for (int idx = 0; idx < destacamento.CantidadIncidentes; idx++)
            {
                fIncidentes.tbIncidentes.Text += $"\r\n--{idx + 1}---------------------\r\n";

                Incidente inc = destacamento.VerIncidente(idx);

                fIncidentes.tbIncidentes.Text += inc.VerDescripcion();
            }
            fIncidentes.tbIncidentes.Text += $"\r\n-----------------------";

            fIncidentes.ShowDialog();
        }
    }
}
