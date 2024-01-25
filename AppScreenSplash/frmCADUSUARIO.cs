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
    public partial class frmCADUSUARIO : Form
    {
        Thread nt;
        public frmCADUSUARIO()
        {
            InitializeComponent();
            desabilitaCampos();
        }

        SqlConnection Conexao = new SqlConnection(@"Data Source=DESKTOP-QEOUED8\SQLEXPRESS;Initial Catalog=db_Papelaria;Integrated Security=True");
        SqlCommand comm = new SqlCommand();
        SqlDataAdapter dr;

        public void desabilitaCampos()
        {
            textBoxNome.Enabled = false;
            dateNasc.Enabled = false;
            mskCPF.Enabled = false;
            mskCel.Enabled = false;
            radioButtonMasc.Enabled = false;
            radioButtonFem.Enabled = false;
            bttnSalvarUsuario.Enabled = false;
            bttnLimpar.Enabled = false;
            checkBoxAtivo.Enabled = false;
            checkBoxInativo.Enabled = false;
            textBoxCodigo.Enabled = false;
        }

        public void habilitaCampos()
        {
            textBoxNome.Enabled = true;
            dateNasc.Enabled = true;
            mskCPF.Enabled = true;
            mskCel.Enabled = true;
            radioButtonMasc.Enabled = true;
            radioButtonFem.Enabled = true;
            bttnSalvarUsuario.Enabled = true;
            bttnLimpar.Enabled = true;
            checkBoxAtivo.Enabled = true;
            checkBoxInativo.Enabled = true;
            checkBoxAtivo.Checked = true;
            textBoxCodigo.Enabled = true;
        }

        public void limpaCampos()
        {
            textBoxNome.Text = "";
            dateNasc.Enabled = true;
            mskCPF.Text = "";
            mskCel.Text = "";
            radioButtonMasc.Enabled = false;
            radioButtonFem.Enabled = false;
            bttnSalvarUsuario.Enabled = false;
            bttnLimpar.Enabled = false;
            dateNasc.Text = "";
            checkBoxAtivo.Enabled = false;
            checkBoxInativo.Enabled = false;
            textBoxCodigo.Enabled = true;
            textBoxCodigo.Text = "";

        }

        public void habilitaCodigo()
        {
            textBoxCodigo.Enabled = true;
            textBoxNome.Enabled = true;
            dateNasc.Enabled = true;
            mskCPF.Enabled = true;
            mskCel.Enabled = true;
            radioButtonMasc.Enabled = true;
            radioButtonFem.Enabled = true;
            bttnSalvarUsuario.Enabled = true;
            bttnLimpar.Enabled = true;
            checkBoxAtivo.Enabled = true;
            checkBoxInativo.Enabled = true;
            checkBoxAtivo.Checked = true;
        }

        public void frmCADUSUARIO_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void bttnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(backHome);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void backHome()
        {
            Application.Run(new Form2());
        }

        private void bttnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
            bttnNovo.Enabled = false;
        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            desabilitaCampos();
            bttnNovo.Enabled = true;
        }

        private void bttnSalvarUsuario_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Deve ser informado um Nome!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Focus();
            }

            else if (dateNasc.Text == "")
            {
                MessageBox.Show("Deve ser informado uma Data de Nascimento!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateNasc.Focus();
            }

            else if (mskCPF.Text == "")
            {
                MessageBox.Show("Deve ser informado um CPF!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCPF.Focus();
            }

            else if (mskCel.Text == "")
            {
                MessageBox.Show("Deve ser informado um número de Telefone!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCel.Focus();
            }

            

            else
            {
                string nomeuser = textBoxNome.Text;
                string datanascuser = dateNasc.Text;
                string cpfuser = mskCPF.Text;
                string celuser = mskCel.Text;
                int statusUser = 1;

                 if (radioButtonMasc.Checked)
                {
                    sexo = "M";
                }

                else if (radioButtonFem.Checked)
                {
                    sexo = "F";
                }
                else if (checkBoxAtivo.Checked)
                {
                    statusUser = 1;
                }
                 else if (checkBoxInativo.Checked)
                {
                    statusUser = 0;
                }

                 
                try
                {

                    string strSql = "insert into cad_Usuario(NomeUser, NascUser, CpfUser, CelUser, SexoUser, StatusUser) values (@nomeuser, @datanascuser, @cpfuser, @celuser, @sexouser, @statusUser)";

                    comm.CommandText = strSql;
                    comm.Connection = Conexao;

                    comm.Parameters.Add("@nomeuser", SqlDbType.VarChar).Value = nomeuser;
                    comm.Parameters.Add("@datanascuser", SqlDbType.Date).Value = datanascuser;
                    comm.Parameters.Add("@cpfuser", SqlDbType.VarChar).Value = cpfuser;
                    comm.Parameters.Add("@celuser", SqlDbType.VarChar).Value = celuser;
                    comm.Parameters.Add("@sexouser", SqlDbType.Char).Value = sexo;
                    comm.Parameters.Add("@statusUser", SqlDbType.Bit).Value = statusUser;

                    Conexao.Open();
                    comm.ExecuteNonQuery();
                    comm.Parameters.Clear();
                    MessageBox.Show("Dados cadastrados com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {


                    MessageBox.Show(erro.Message);
                    Conexao.Close();

                }

                finally
                {
                    Conexao.Close();
                }



            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
            
        {
            habilitaCodigo();
            string sexo = "";
            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Deve ser informado um Nome!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Focus();
            }

            else if (dateNasc.Text == "")
            {
                MessageBox.Show("Deve ser informado uma Data de Nascimento!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateNasc.Focus();
            }

            else if (mskCPF.Text == "")
            {
                MessageBox.Show("Deve ser informado um CPF!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCPF.Focus();
            }

            else if (mskCel.Text == "")
            {
                MessageBox.Show("Deve ser informado um número de Telefone!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCel.Focus();
            }
            else
            {
                try
                {
                    string nomeUser = textBoxNome.Text;
                    string dataNascUser = dateNasc.Text;
                    string cpfUser = mskCPF.Text;
                    string celUser = mskCel.Text;
                    int StatusUser = 1;
                    int idUser = Convert.ToInt32(textBoxCodigo.Text);


                    if (radioButtonMasc.Checked)
                        {
                            sexo = "M";
                        }

                    else if (radioButtonFem.Checked)
                        {
                            sexo = "F";
                        }
                    

                    
                    string strSql = "Update cad_Usuario set NomeUser = @nomeUser, NascUser = @dataNascUser, CpfUser = @cpfUser, CelUser = @celuser, SexoUser = @sexo, StatusUser = @StatusUser where IdUser = @idUser";

                    comm.CommandText = strSql;
                    comm.Connection = Conexao;

                    comm.Parameters.Add("@nomeuser", SqlDbType.VarChar).Value = nomeUser;
                    comm.Parameters.Add("@datanascuser", SqlDbType.Date).Value = dataNascUser;
                    comm.Parameters.Add("@cpfuser", SqlDbType.VarChar).Value = cpfUser;
                    comm.Parameters.Add("@celuser", SqlDbType.VarChar).Value = celUser;
                    comm.Parameters.Add("@sexo", SqlDbType.Char).Value = sexo;
                    comm.Parameters.Add("@statusUser", SqlDbType.Bit).Value = StatusUser;
                    comm.Parameters.Add("@idUser", SqlDbType.SmallInt).Value = idUser;

                    Conexao.Open();
                    comm.ExecuteNonQuery();
                    comm.Parameters.Clear();
                    

                    MessageBox.Show("Dados atualizados com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampos();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    Conexao.Close();
                }
                finally
                {
                    Conexao.Close();
                }
            }
        }

        private void textBoxPesquisar_TextChanged(object sender, EventArgs e)
        {

            if (textBoxPesquisar.Text != "")
            {
                try
                {
                    Conexao.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from cad_Usuario where CpfUser like ('%" + textBoxPesquisar.Text + "%')";
                    command.Connection = Conexao;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = command;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    Conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    Conexao.Close();
                }
                finally
                {
                    Conexao.Close();
                }
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if(textBoxCodigo.Text == "")
            {
                MessageBox.Show("Deve ser informado o código do usuário!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCodigo.Focus();
            }

            else if (textBoxNome.Text == "")
            {
                MessageBox.Show("Deve ser informado um Nome!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Focus();
            }

            else if (dateNasc.Text == "")
            {
                MessageBox.Show("Deve ser informado uma Data de Nascimento!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateNasc.Focus();
            }

            else if (mskCPF.Text == "")
            {
                MessageBox.Show("Deve ser informado um CPF!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCPF.Focus();
            }

            else if (mskCel.Text == "")
            {
                MessageBox.Show("Deve ser informado um número de Telefone!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCel.Focus();
            }

            
            else
            {
                DialogResult excluir = MessageBox.Show("Certeza que deseja excluir o registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (excluir == DialogResult.No)
                {
                    return;
                }

                else if (checkBoxInativo.Checked = true);
                {
                    try
                    {
                        int idUser = Convert.ToInt32(textBoxCodigo.Text);
                        Conexao.Open();
                        string strSql = "update cad_Usuario set StatusUser = 0 where IdUser = @idUser";
                        comm.CommandText = strSql;
                        comm.Connection = Conexao;
                        comm.Parameters.Add("@idUser", SqlDbType.Int).Value = idUser;

                        comm.ExecuteNonQuery();
                        comm.Parameters.Clear();
                        MessageBox.Show("Dados excluídos com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaCampos();
                        bttnNovo.Enabled = true;
                        bttnLimpar.Enabled = true;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        Conexao.Close();
                    }
                    finally
                    {
                        Conexao.Close();
                    }
                }
            }
        }
    }
}
