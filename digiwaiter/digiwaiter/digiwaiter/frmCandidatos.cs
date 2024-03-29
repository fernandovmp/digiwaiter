﻿using System;
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
    public partial class frmCandidatos : Form
    {
        Thread th;
        public frmCandidatos()
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new frmDetalheCandidato().Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new frmDetalheCandidato().Show();
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            new frmAdicionarCandidato().Show();
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
