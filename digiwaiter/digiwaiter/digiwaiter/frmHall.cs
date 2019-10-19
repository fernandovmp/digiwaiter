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
    public partial class frmHall : Form
    {
        Thread th;
        public frmHall()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
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
    }
}
