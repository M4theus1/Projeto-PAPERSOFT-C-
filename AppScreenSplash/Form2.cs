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
using System.Data.SqlClient;

namespace AppScreenSplash
{
    public partial class Form2 : Form
    {
        Thread nt;
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QEOUED8\SQLEXPRESS;Initial Catalog=db_Papelaria;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FRMLogin(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBoxUsuario.Text == "ADMING" & textBoxSenhaUsuario.Text == "ADMING")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }

        }

        public void novoForm()
        {
            Application.Run(new Form3());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void bttnCADUSUARIO_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(FormCadUsuario);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void FormCadUsuario()
        {
            Application.Run(new frmCADUSUARIO());
        }
    }
}
