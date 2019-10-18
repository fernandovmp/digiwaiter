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
    public partial class frmLogin : Form
    {
        Thread th;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text == String.Empty || txtUsuario.Text == String.Empty)
            {
                lblError.Text = "* Há campos vazios. Por favor, preencha-os e tente novamente.";
            }
            else
            {
                this.Close();
                th = new Thread(OpenHallForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void OpenHallForm(object obj)
        {
            Application.Run(new frmHall());
        }

        private void ChboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxShowPass.Checked)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '●';
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
