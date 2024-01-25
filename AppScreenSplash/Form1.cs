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


namespace AppScreenSplash
{
    public partial class FrmSplash : Form
    {
        Thread NT;
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSplash_Shown(object sender, EventArgs e)
        {
            label1.Text = "Carregando...";
            this.Refresh();

            for (int i = 1; i < 101; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(40);

            }

            progressBar1.Value = 99;
            Thread.Sleep(500);
            this.Close();

            NT = new Thread(NovoFrm2);
            NT.SetApartmentState(ApartmentState.STA);
            NT.Start();
        }

        private void NovoFrm2()
        {
            Application.Run(new Form2());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
