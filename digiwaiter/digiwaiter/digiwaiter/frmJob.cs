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
    }
}
