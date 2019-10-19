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
    }
}
