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
  
    public partial class Form4 : Form
    {
        Thread nt;
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-QEOUED8\SQLEXPRESS;Initial Catalog=db_Papelaria;Integrated Security=True");
        SqlCommand comm = new SqlCommand();
        SqlDataReader dr;

        public void desabilitaCamposCli()
        {
            mskCPFCli.Enabled = false;
            mskCNPJCli.Enabled = false;
            textBoxNOMECli.Enabled = false;
            radioButtonFis.Enabled = false;
            radioButtonJur.Enabled = false;
            textBoxAPELIDOCli.Enabled = false;
            mskCEPCli.Enabled = false;
            textBoxCIDADECli.Enabled = false;
            textBoxENDERECOCli.Enabled = false;
            textBoxNUMCli.Enabled = false;
            textBoxBAIRROCli.Enabled = false;
            comboBoxUFCLI.Enabled = false;
            mskCelCli.Enabled = false;
            checkBoxAtivo.Enabled = false;
            checkBoxInativo.Enabled = false;
            textBoxCodigoCli.Enabled = false;
        }

        public void habilitaCamposCli()
        {
            mskCPFCli.Enabled = true;
            mskCNPJCli.Enabled = true;
            textBoxNOMECli.Enabled = true;
            radioButtonFis.Enabled = true;
            radioButtonJur.Enabled = true;
            textBoxAPELIDOCli.Enabled = true;
            mskCEPCli.Enabled = true;
            textBoxCIDADECli.Enabled = true;
            textBoxENDERECOCli.Enabled = true;
            textBoxNUMCli.Enabled = true;
            textBoxBAIRROCli.Enabled = true;
            comboBoxUFCLI.Enabled = true;
            mskCelCli.Enabled = true;
            checkBoxAtivo.Enabled = true;
            checkBoxInativo.Enabled = true;
            textBoxCodigoCli.Enabled = true;
            checkBoxAtivo.Checked = true;
            checkBoxInativo.Checked = false;
        }

        public void limpaCamposCli()
        {
            mskCPFCli.Text = "";
            mskCNPJCli.Text = "";
            textBoxNOMECli.Text = "";
            textBoxAPELIDOCli.Text = "";
            mskCEPCli.Text = "";
            textBoxCIDADECli.Text = "";
            textBoxENDERECOCli.Text = "";
            textBoxNUMCli.Text = "";
            textBoxBAIRROCli.Text = "";
            comboBoxUFCLI.Text = "";
            mskCelCli.Text = "";
            comboBoxUFCLI.SelectedIndex = -1;
            mskCelCli.Text = "";
            checkBoxAtivo.Checked = true;
            checkBoxInativo.Checked = false;
            textBoxCodigoCli.Text = "";
        }
        private void Desativar(Form4 f, string nomeComponente)
        {
            foreach (Control c in f.Controls)
            {
                if (c is MaskedTextBox)
                {
                    if (c.Name == "mskCNPJCli")
                    {
                        c.Enabled = false;
                    }
                    else
                    {
                        c.Enabled = true;
                    }
                }
                else if (c is TextBox)
                {
                    if (c.Name == "textBoxAPELIDOCli")
                    {
                        c.Enabled = false;
                    }
                    else
                    {
                        c.Enabled = true;
                    }
                }
                
            }
        }

        private void Desativar_CPF(Form4 f, string nomeComponente)
        {
            foreach(Control c in f.Controls)
            {
                if(c is MaskedTextBox)
                {
                    if(c.Name == "mskCPFCli")
                    {
                        c.Enabled = false;
                    }
                    else
                    {
                        c.Enabled = true;
                    }
                }
                else if(c is TextBox)
                {
                    if(c.Name == "textBoxAPELIDOCli")
                    {
                        c.Enabled = true;
                    }
                    else
                    {
                        c.Enabled = true;
                    }
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            desabilitaCamposCli();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void buttonNovoCli_Click(object sender, EventArgs e)
        {
            habilitaCamposCli();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpaCamposCli();
            buttonNovoCli.Enabled = true;
        }

        private void buttonGravarCli_Click(object sender, EventArgs e)
        {

            checkBoxAtivo.Checked = true;

            if(textBoxNOMECli.Text == "")
            {
                MessageBox.Show("Deve ser informado um NOME!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNOMECli.Focus();
            }

            

            else if(mskCEPCli.Text.Length < 8)
            {
                MessageBox.Show("Deve ser informado um CEP válido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCEPCli.Focus();
            }

            else if(textBoxCIDADECli.Text == "")
            {
                MessageBox.Show("Deve ser informado uma CIDADE", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCIDADECli.Focus();
            }

            else if(mskCelCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Contato", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCelCli.Focus();
            }
             
            else if(textBoxENDERECOCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Endereço", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxENDERECOCli.Focus();
            }

            else if(textBoxNUMCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Número de Residência", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNUMCli.Focus();
            }

            else if(textBoxBAIRROCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Bairro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBAIRROCli.Focus();
            }

            
            

            else
            {            
                string nomeCli = textBoxNOMECli.Text;
                string cpfCli = mskCPFCli.Text;
                string cnpjCli = mskCNPJCli.Text;
                string apelidoCli = textBoxAPELIDOCli.Text;
                string cepCli = mskCEPCli.Text;
                string cidadeCli = textBoxCIDADECli.Text;
                string contatoCli = mskCelCli.Text;
                string enderecoCli = textBoxENDERECOCli.Text;
                string numresidCli = textBoxNUMCli.Text;
                string bairroCli = textBoxBAIRROCli.Text;
                string ufCli = comboBoxUFCLI.SelectedIndex.ToString();
                string pessoaCli = "";
                int statusCli = 1;

                    if (radioButtonFis.Checked)
                    {
                        pessoaCli = "Física";
                       

                    try
                    {
                        string strSql = ("insert into cad_Clientes(NomeRazaoCli, CpfCli, CepCli, CidadeCli, ContatoCli, EnderecoCli, NumeroEndCli, BairroCli, UfCli, PessoaCli, StatusCli) values (@nomeCli, @cpfCli, @cepCli, @cidadeCli, @contatoCli, @enderecoCli, @numresidCli, @bairroCli, @ufCli, @pessoaCli, @statusCli);");

                            comm.CommandText = strSql;
                            comm.Connection = conexao;

                        comm.Parameters.Add("@nomeCli", SqlDbType.VarChar).Value = nomeCli;
                        comm.Parameters.Add("@cpfCli", SqlDbType.VarChar).Value = cpfCli;
                        comm.Parameters.Add("@cepCli", SqlDbType.VarChar).Value = cepCli;
                        comm.Parameters.Add("@cidadeCli", SqlDbType.VarChar).Value = cidadeCli;
                        comm.Parameters.Add("@contatoCli", SqlDbType.VarChar).Value = contatoCli;
                        comm.Parameters.Add("@enderecoCli", SqlDbType.VarChar).Value = enderecoCli;
                        comm.Parameters.Add("@numresidCli", SqlDbType.VarChar).Value = numresidCli;
                        comm.Parameters.Add("@bairroCli", SqlDbType.VarChar).Value = bairroCli;
                        comm.Parameters.Add("@ufCli", SqlDbType.Char).Value = ufCli;
                        comm.Parameters.Add("@pessoaCli", SqlDbType.VarChar).Value = pessoaCli;
                        comm.Parameters.Add("@statusCli", SqlDbType.Bit).Value = statusCli;

                        conexao.Open();
                        comm.ExecuteNonQuery();
                        comm.Parameters.Clear();
                        MessageBox.Show("Dados cadastrados com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaCamposCli();
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
                    

                    else if (radioButtonJur.Checked)
                    {
                        pessoaCli = "Jurídica";
                       

                    try
                    {
                        string strSql = "insert into cad_Clientes(NomeRazaoCli, CnpjCli, ApelidoCNPJCli, CepCli, CidadeCli, ContatoCli, EnderecoCli, NumeroEndCli, BairroCli, UfCli, PessoaCli, StatusCli) values (@nomeCli, @cnpjCli, @apelidoCli, @cepCli, @cidadeCli, @contatoCli, @enderecoCli, @numresidCli, @bairroCli, @ufCli, @pessoaCli, @statusCli);";

                        comm.CommandText = strSql;
                        comm.Connection = conexao;

                        comm.Parameters.Add("@nomeCli", SqlDbType.VarChar).Value = nomeCli;
                        comm.Parameters.Add("@cnpjCli", SqlDbType.VarChar).Value = cnpjCli;
                        comm.Parameters.Add("@apelidoCli", SqlDbType.VarChar).Value = apelidoCli;
                        comm.Parameters.Add("@cepCli", SqlDbType.VarChar).Value = cepCli;
                        comm.Parameters.Add("@cidadeCli", SqlDbType.VarChar).Value = cidadeCli;
                        comm.Parameters.Add("@contatoCli", SqlDbType.VarChar).Value = contatoCli;
                        comm.Parameters.Add("@enderecoCli", SqlDbType.VarChar).Value = enderecoCli;
                        comm.Parameters.Add("@numresidCli", SqlDbType.VarChar).Value = numresidCli;
                        comm.Parameters.Add("@bairroCli", SqlDbType.VarChar).Value = bairroCli;
                        comm.Parameters.Add("@ufCli", SqlDbType.Char).Value = ufCli;
                        comm.Parameters.Add("@pessoaCli", SqlDbType.VarChar).Value = pessoaCli;
                        comm.Parameters.Add("@statusCli", SqlDbType.Bit).Value = statusCli;

                        conexao.Open();
                        comm.ExecuteNonQuery();
                        comm.Parameters.Clear();
                        MessageBox.Show("Dados cadastrados com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaCamposCli();
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

        private void mskCPFCli_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void mskCNPJCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void mskCEPCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void mskCelCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void radioButtonFis_Click(object sender, EventArgs e)
        {
            if (radioButtonFis.Checked)
            {
                Desativar(this, "mskCNPJCli");
                Desativar(this, "textBoxAPELIDOCli");
                Desativar(this, "textBoxCnpjPesq");
            }    
        }

        private void radioButtonJur_Click(object sender, EventArgs e)
        {
            Desativar_CPF(this, "mskCPFCli");
            Desativar_CPF(this, "textBoxPesquisa");
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPesquisa.Text != "")
            {
                try
                {
                    conexao.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from cad_Clientes where CpfCli like ('%" + textBoxPesquisa.Text + "%')";
                    command.Connection = conexao;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = command;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conexao.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void textBoxCnpjPesq_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCnpjPesq.Text != "")
            {
                conexao.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from cad_Clientes where CnpjCli like ('%" + textBoxCnpjPesq.Text + "%')";
                command.Connection = conexao;
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = command;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conexao.Close();

            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (textBoxNOMECli.Text == "")
            {
                MessageBox.Show("Deve ser informado um NOME!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNOMECli.Focus();
            }

            else if (mskCEPCli.Text.Length < 8)
            {
                MessageBox.Show("Deve ser informado um CEP válido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCEPCli.Focus();
            }

            else if (textBoxCIDADECli.Text == "")
            {
                MessageBox.Show("Deve ser informado uma CIDADE", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCIDADECli.Focus();
            }

            else if (mskCelCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Contato", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCelCli.Focus();
            }

            else if (textBoxENDERECOCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Endereço", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxENDERECOCli.Focus();
            }

            else if (textBoxNUMCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Número de Residência", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNUMCli.Focus();
            }

            else if (textBoxBAIRROCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Bairro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBAIRROCli.Focus();
            }

            else if (checkBoxInativo.Checked)
            {
                MessageBox.Show("Para inativar o usuário, use o botão Excluir", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   

            else 
            {
                if (radioButtonFis.Checked)
                {
                    textBoxCnpjPesq.Enabled = false;
                    try
                    {
                        string nomeCli = textBoxNOMECli.Text;
                        string cpfCli = mskCPFCli.Text;
                        string cnpjCli = mskCNPJCli.Text;
                        string apelidoCli = textBoxAPELIDOCli.Text;
                        string cepCli = mskCEPCli.Text;
                        string cidadeCli = textBoxCIDADECli.Text;
                        string contatoCli = mskCelCli.Text;
                        string enderecoCli = textBoxENDERECOCli.Text;
                        string numresidCli = textBoxNUMCli.Text;
                        string bairroCli = textBoxBAIRROCli.Text;
                        string ufCli = comboBoxUFCLI.SelectedIndex.ToString();
                        string pessoaCli = "Física";
                        int statusCli = 1;
                        int idCli = Convert.ToInt32(textBoxCodigoCli.Text);

                        string strSql = ("Update cad_Clientes set NomeRazaoCli = @nomeCli, CpfCli = @cpfCli, CepCli = @cepCli, CidadeCli = @cidadeCli, ContatoCli = @contatoCli, EnderecoCli = @enderecoCli, NumeroEndCli = @numresidCli, BairroCli = @bairroCli, UfCli = @ufCli, PessoaCli = @pessoaCli, StatusCli = @statusCli where idCli = @idCli");

                        comm.CommandText = strSql;
                        comm.Connection = conexao;

                        comm.Parameters.Add("@nomeCli", SqlDbType.VarChar).Value = nomeCli;
                        comm.Parameters.Add("@cpfCli", SqlDbType.VarChar).Value = cpfCli;
                        comm.Parameters.Add("@cepCli", SqlDbType.VarChar).Value = cepCli;
                        comm.Parameters.Add("@cidadeCli", SqlDbType.VarChar).Value = cidadeCli;
                        comm.Parameters.Add("@contatoCli", SqlDbType.VarChar).Value = contatoCli;
                        comm.Parameters.Add("@enderecoCli", SqlDbType.VarChar).Value = enderecoCli;
                        comm.Parameters.Add("@numresidCli", SqlDbType.VarChar).Value = numresidCli;
                        comm.Parameters.Add("@bairroCli", SqlDbType.VarChar).Value = bairroCli;
                        comm.Parameters.Add("@ufCli", SqlDbType.VarChar).Value = ufCli;
                        comm.Parameters.Add("@pessoaCli", SqlDbType.VarChar).Value = pessoaCli;
                        comm.Parameters.Add("@statusCli", SqlDbType.VarChar).Value = statusCli;
                        comm.Parameters.Add("@idCli", SqlDbType.VarChar).Value = idCli;

                        conexao.Open();
                        comm.ExecuteNonQuery();
                        comm.Parameters.Clear();

                        MessageBox.Show("Dados alterados com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaCamposCli();
                        buttonNovoCli.Enabled = true;
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
                else if (radioButtonJur.Checked)
                {
                    textBoxPesquisa.Enabled = false;
                    try
                    {
                        string nomeCli = textBoxNOMECli.Text;
                        string cpfCli = mskCPFCli.Text;
                        string cnpjCli = mskCNPJCli.Text;
                        string apelidoCli = textBoxAPELIDOCli.Text;
                        string cepCli = mskCEPCli.Text;
                        string cidadeCli = textBoxCIDADECli.Text;
                        string contatoCli = mskCelCli.Text;
                        string enderecoCli = textBoxENDERECOCli.Text;
                        string numresidCli = textBoxNUMCli.Text;
                        string bairroCli = textBoxBAIRROCli.Text;
                        string ufCli = comboBoxUFCLI.SelectedIndex.ToString();
                        string pessoaCli = "Jurídica";
                        int statusCli = 1;
                        int idCli = Convert.ToInt32(textBoxCodigoCli.Text);

                        string strSql = ("Update cad_Clientes set NomeRazaoCli = @nomeCli, CnpjCli = @cnpjCli, ApelidoCNPJCli = @apelidoCli, CepCli = @cepCli, CidadeCli = @cidadeCli, ContatoCli = @contatoCli, EnderecoCli = @enderecoCli, NumeroEndCli = @numresidCli, BairroCli = @bairroCli, UfCli = @ufCli, PessoaCli = @pessoaCli, StatusCli = @statusCli where idCli = @idCli");

                        comm.CommandText = strSql;
                        comm.Connection = conexao;

                        comm.Parameters.Add("@nomeCli", SqlDbType.VarChar).Value = nomeCli;
                        comm.Parameters.Add("@cnpjCli", SqlDbType.VarChar).Value = cnpjCli;
                        comm.Parameters.Add("@apelidoCli", SqlDbType.VarChar).Value = apelidoCli;
                        comm.Parameters.Add("@cepCli", SqlDbType.VarChar).Value = cepCli;
                        comm.Parameters.Add("@cidadeCli", SqlDbType.VarChar).Value = cidadeCli;
                        comm.Parameters.Add("@contatoCli", SqlDbType.VarChar).Value = contatoCli;
                        comm.Parameters.Add("@enderecoCli", SqlDbType.VarChar).Value = enderecoCli;
                        comm.Parameters.Add("@numresidCli", SqlDbType.VarChar).Value = numresidCli;
                        comm.Parameters.Add("@bairroCli", SqlDbType.VarChar).Value = bairroCli;
                        comm.Parameters.Add("@ufCli", SqlDbType.VarChar).Value = ufCli;
                        comm.Parameters.Add("@pessoaCli", SqlDbType.VarChar).Value = pessoaCli;
                        comm.Parameters.Add("@statusCli", SqlDbType.VarChar).Value = statusCli;
                        comm.Parameters.Add("@idCli", SqlDbType.VarChar).Value = idCli;




                        conexao.Open();
                        comm.ExecuteNonQuery();
                        comm.Parameters.Clear();

                        MessageBox.Show("Dados alterados com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaCamposCli();
                        buttonNovoCli.Enabled = true;
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

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxNOMECli.Text == "")
            {
                MessageBox.Show("Deve ser informado um NOME!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNOMECli.Focus();
            }

            else if (mskCEPCli.Text.Length < 8)
            {
                MessageBox.Show("Deve ser informado um CEP válido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCEPCli.Focus();
            }

            else if (textBoxCIDADECli.Text == "")
            {
                MessageBox.Show("Deve ser informado uma CIDADE", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCIDADECli.Focus();
            }

            else if (mskCelCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Contato", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCelCli.Focus();
            }

            else if (textBoxENDERECOCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Endereço", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxENDERECOCli.Focus();
            }

            else if (textBoxNUMCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Número de Residência", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNUMCli.Focus();
            }

            else if (textBoxBAIRROCli.Text == "")
            {
                MessageBox.Show("Deve ser informado um Bairro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBAIRROCli.Focus();
            }

            else
            {
                DialogResult excluir = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Excluir!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(excluir == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int idCli = Convert.ToInt32(textBoxCodigoCli.Text);
                        conexao.Open();
                        string strSql = "Update cad_Clientes set StatusCli = 0 where idCli = @idCli";
                        comm.CommandText = strSql;
                        comm.Connection = conexao;
                        comm.Parameters.Add("@idCli", SqlDbType.Int).Value = idCli;

                        comm.ExecuteNonQuery();
                        comm.Parameters.Clear();
                        MessageBox.Show("Dados excluídos com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaCamposCli();
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
