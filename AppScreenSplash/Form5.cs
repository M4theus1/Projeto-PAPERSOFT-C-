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


    public partial class FormProdutos : Form
    {
        Thread nt;
        public FormProdutos()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-QEOUED8\SQLEXPRESS;Initial Catalog=db_Papelaria;Integrated Security=True");
        SqlCommand comm = new SqlCommand();
        SqlDataReader dr;

        private void desabilitaCampos()
        {
            textBoxNOMEPROD.Enabled = false;
            textBoxDesc.Enabled = false;
            maskedTextBoxCodBar.Enabled = false;
            textBoxForn.Enabled = false;
            dateCad.Enabled = false;
            textBoxQTD.Enabled = false;
            textBoxValorProd.Enabled = false;
            radioButtonProdAtivo.Enabled = false;
            radioButtonProdInativo.Enabled = false;
            textBoxIdProd.Enabled = false;
            textBoxPesquisaProd.Enabled = false;
        }
        private void habilitaCampos()
        {
            textBoxNOMEPROD.Enabled = true;
            textBoxDesc.Enabled = true;
            maskedTextBoxCodBar.Enabled = true;
            textBoxForn.Enabled = true;
            dateCad.Enabled = true;
            textBoxQTD.Enabled = true;
            textBoxValorProd.Enabled = true;
            radioButtonProdAtivo.Enabled = true;
            radioButtonProdInativo.Enabled = true;
            radioButtonProdAtivo.Checked = true;
            textBoxIdProd.Enabled = true;
            textBoxPesquisaProd.Enabled = true;
        }

        private void limpaCampos()
        {
            textBoxNOMEPROD.Text = "";
            textBoxDesc.Text = "";
            maskedTextBoxCodBar.Text = "";
            textBoxForn.Text = "";
            textBoxQTD.Text = "";
            textBoxValorProd.Text = "";
            textBoxIdProd.Text = "";
            textBoxPesquisaProd.Text = "";
        }



        public void atualizaDataGridView(String comandoSQL)
        {
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(backForm3);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void backForm3()
        {
            Application.Run(new Form3());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(backForm3);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            limpaCampos();
            desabilitaCampos();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            if (textBoxNOMEPROD.Text == "")
            {
                MessageBox.Show("É necessário apresentar um nome para o produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxDesc.Text == "")
            {
                MessageBox.Show("É necessário apresentar uma Descrição para o produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (maskedTextBoxCodBar.Text == "")
            {
                MessageBox.Show("É necessário inserir um código de barras para o produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxForn.Text == "")
            {
                MessageBox.Show("É necessário informar o forncecedor do produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dateCad.Text == "")
            {
                MessageBox.Show("É necessário informar a data que o produto foi cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxQTD.Text == "")
            {
                MessageBox.Show("É necessário informar a quantidade do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxValorProd.Text == "")
            {
                MessageBox.Show("É necessário informar o preço de venda do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButtonProdInativo.Checked)
            {
                MessageBox.Show("Para excluir um produto, use o botão EXCLUIR", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nomeProd = textBoxNOMEPROD.Text;
                string descProd = textBoxDesc.Text;
                string barcodProd = maskedTextBoxCodBar.Text;
                string fornProd = textBoxForn.Text;
                string datecadProd = dateCad.Text;
                string qtdProd = textBoxQTD.Text;
                string valorProd = textBoxValorProd.Text;
                int StatusProd = 1;

                try
                {
                    string strSql = "insert into cad_Produtos (NomeProd, DescProd, CodBarProd, FornProd, DataCad, QtdEstoque, ValorProd)values(@nomeProd, @descProd, @barcodProd, @fornProd, @datecadProd, @qtdProd, @valorProd, StatusProd = @StatusProd);";

                    comm.CommandText = strSql;
                    comm.Connection = conexao;

                    comm.Parameters.Add("@nomeProd", SqlDbType.VarChar).Value = nomeProd;
                    comm.Parameters.Add("@descProd", SqlDbType.VarChar).Value = descProd;
                    comm.Parameters.Add("barcodProd", SqlDbType.VarChar).Value = barcodProd;
                    comm.Parameters.Add("@fornProd", SqlDbType.VarChar).Value = fornProd;
                    comm.Parameters.Add("@datecadProd", SqlDbType.Date).Value = datecadProd;
                    comm.Parameters.Add("@qtdProd", SqlDbType.VarChar).Value = qtdProd;
                    comm.Parameters.Add("@valorProd", SqlDbType.VarChar).Value = valorProd;
                    comm.Parameters.Add("@StatusProd", SqlDbType.Bit).Value = StatusProd;

                    conexao.Open();
                    comm.ExecuteNonQuery();
                    comm.Parameters.Clear();
                    MessageBox.Show("Dados cadastrados com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception erro)
                {
                    conexao.Close();
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void textBoxPesquisaProd_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPesquisaProd.Text != "")
            {
                try
                {
                    conexao.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from cad_Produtos where CodBarProd like ('%" + textBoxPesquisaProd.Text + "%')";
                    command.Connection = conexao;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = command;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (textBoxNOMEPROD.Text == "")
            {
                MessageBox.Show("É necessário apresentar um nome para o produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxDesc.Text == "")
            {
                MessageBox.Show("É necessário apresentar uma Descrição para o produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (maskedTextBoxCodBar.Text == "")
            {
                MessageBox.Show("É necessário inserir um código de barras para o produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxForn.Text == "")
            {
                MessageBox.Show("É necessário informar o forncecedor do produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dateCad.Text == "")
            {
                MessageBox.Show("É necessário informar a data que o produto foi cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxQTD.Text == "")
            {
                MessageBox.Show("É necessário informar a quantidade do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxValorProd.Text == "")
            {
                MessageBox.Show("É necessário informar o preço de venda do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButtonProdInativo.Checked)
            {
                MessageBox.Show("Para excluir um produto, use o botão EXCLUIR", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nomeProd = textBoxNOMEPROD.Text;
                string descProd = textBoxDesc.Text;
                string barcodProd = maskedTextBoxCodBar.Text;
                string fornProd = textBoxForn.Text;
                string datecadProd = dateCad.Text;
                string qtdProd = textBoxQTD.Text;
                string valorProd = textBoxValorProd.Text;
                int StatusProd = 1;
                int IdProd = Convert.ToInt32(textBoxIdProd.Text);
                try
                {
                    string strSql = "Update cad_Produtos set NomeProd = @nomeProd, DescProd = @descProd, CodBarProd = @barcodProd, FornProd = @fornProd, DataCad = @datecadProd, QtdEstoque = @qtdProd, ValorProd = @valorProd, StatusProd = @StatusProd where IdProd  = @IdProd;";

                    comm.CommandText = strSql;
                    comm.Connection = conexao;

                    comm.Parameters.Add("@nomeProd", SqlDbType.VarChar).Value = nomeProd;
                    comm.Parameters.Add("@descProd", SqlDbType.VarChar).Value = descProd;
                    comm.Parameters.Add("barcodProd", SqlDbType.VarChar).Value = barcodProd;
                    comm.Parameters.Add("@fornProd", SqlDbType.VarChar).Value = fornProd;
                    comm.Parameters.Add("@datecadProd", SqlDbType.Date).Value = datecadProd;
                    comm.Parameters.Add("@qtdProd", SqlDbType.VarChar).Value = qtdProd;
                    comm.Parameters.Add("@valorProd", SqlDbType.VarChar).Value = valorProd;
                    comm.Parameters.Add("@StatusProd", SqlDbType.Bit).Value = StatusProd;
                    comm.Parameters.Add("@IdProd", SqlDbType.SmallInt).Value = IdProd;

                    conexao.Open();
                    comm.ExecuteNonQuery();
                    comm.Parameters.Clear();
                    MessageBox.Show("Dados alterados com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception erro)
                {
                    conexao.Close();
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conexao.Close();
                }

            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxNOMEPROD.Text == "")
            {
                MessageBox.Show("É necessário apresentar um nome para o produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxDesc.Text == "")
            {
                MessageBox.Show("É necessário apresentar uma Descrição para o produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (maskedTextBoxCodBar.Text == "")
            {
                MessageBox.Show("É necessário inserir um código de barras para o produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxForn.Text == "")
            {
                MessageBox.Show("É necessário informar o forncecedor do produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dateCad.Text == "")
            {
                MessageBox.Show("É necessário informar a data que o produto foi cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxQTD.Text == "")
            {
                MessageBox.Show("É necessário informar a quantidade do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxValorProd.Text == "")
            {
                MessageBox.Show("É necessário informar o preço de venda do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButtonProdAtivo.Checked)
            {
                MessageBox.Show("Para incluir um produto, use o botão GRAVAR", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult excluir = MessageBox.Show("Certeza que deseja excluir o registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (excluir == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int IdProd = Convert.ToInt32(textBoxIdProd.Text);
                        conexao.Open();
                        string strSql = "update cad_Produtos set StatusProd = 0 where IdProd = @IdProd";
                        comm.CommandText = strSql;
                        comm.Connection = conexao;
                        comm.Parameters.Add("@IdProd", SqlDbType.SmallInt).Value = IdProd;

                        comm.ExecuteNonQuery();
                        comm.Parameters.Clear();
                        MessageBox.Show("Dados excluídos com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaCampos();
                        buttonNovo.Enabled = true;
                        buttonLimpar.Enabled = true;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        conexao.Close();
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
        }
    }
}
