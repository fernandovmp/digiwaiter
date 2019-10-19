using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace digiwaiter
{
    public partial class frmJob : Form
    {
        Thread th;
        public frmJob()
        {
            InitializeComponent();
        }

        private void LblDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenHallForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenHallForm(object obj)
        {
            Application.Run(new frmHall());
        }

        private void LblContato_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenContatoForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenContatoForm(object obj)
        {
            Application.Run(new frmContato());
        }

        private void PnlVerificar_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenJobRequestForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenJobRequestForm(object obj)
        {
            Application.Run(new frmJobReq());
        }

        private void PnlSolicitar_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenJobCheckForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenJobCheckForm(object obj)
        {
            Application.Run(new frmJobCheck());
        }

        private void LblCandidatos_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenCandidatosForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenCandidatosForm(object obj)
        {
            Application.Run(new frmCandidatos());
        }

        private void LblMembros_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenMembrosForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenMembrosForm(object obj)
        {
            Application.Run(new frmMembros());
        }

        private void LblAgenda_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenAgendaForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenAgendaForm(object obj)
        {
            Application.Run(new frmAgenda());
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenMainForm(object obj)
        {
            Application.Run(new frmLogin());
        }
    }
}
