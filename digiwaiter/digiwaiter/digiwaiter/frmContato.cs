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
    public partial class frmContato : Form
    {
        Thread th;
        public frmContato()
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

        private void LblVagas_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenVagasForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenVagasForm(object obj)
        {
            Application.Run(new frmJob());
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

        private void LblPontos_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenPontosForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenPontosForm(object obj)
        {
            Application.Run(new frmPontos());
        }
    }
}
