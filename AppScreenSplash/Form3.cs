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
    public partial class Form3 : Form
    {
        Thread nt;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoFormCAD);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoFormCAD);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoFormCAD()
        {
            Application.Run(new Form4());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm2()
        {
            Application.Run(new Form2());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(formProd);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formProd()
        {
            Application.Run(new FormProdutos());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(formProd);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(FormVENDAS);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(FormVENDAS);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void FormVENDAS()
        {
            Application.Run(new FormVendas());
        }
    }
}
