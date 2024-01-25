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
    public partial class FormVendas : Form
    {
        Thread nt;
        public FormVendas()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-QEOUED8\SQLEXPRESS;Initial Catalog=db_Papelaria;Integrated Security=True");
        SqlCommand comm = new SqlCommand();
        SqlDataReader dr;
        

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(backform3);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void backform3()
        {
            Application.Run(new Form3());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(backform3);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = int.Parse(textBoxPreco.Text) * int.Parse(textBoxQtd.Text);
            
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {

        }


            
        
    }
}
