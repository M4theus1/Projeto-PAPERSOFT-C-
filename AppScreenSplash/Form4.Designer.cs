namespace AppScreenSplash
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCpfCli = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNOMECli = new System.Windows.Forms.TextBox();
            this.labelAPELIDO = new System.Windows.Forms.Label();
            this.labelCEP = new System.Windows.Forms.Label();
            this.labelCIDADE = new System.Windows.Forms.Label();
            this.textBoxAPELIDOCli = new System.Windows.Forms.TextBox();
            this.textBoxCIDADECli = new System.Windows.Forms.TextBox();
            this.labelEND = new System.Windows.Forms.Label();
            this.labelNÚMERO = new System.Windows.Forms.Label();
            this.labelBAIRRO = new System.Windows.Forms.Label();
            this.textBoxENDERECOCli = new System.Windows.Forms.TextBox();
            this.textBoxNUMCli = new System.Windows.Forms.TextBox();
            this.textBoxBAIRROCli = new System.Windows.Forms.TextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.comboBoxUFCLI = new System.Windows.Forms.ComboBox();
            this.buttonNovoCli = new System.Windows.Forms.Button();
            this.buttonGravarCli = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mskCPFCli = new System.Windows.Forms.MaskedTextBox();
            this.mskCNPJCli = new System.Windows.Forms.MaskedTextBox();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.mskCEPCli = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneCli = new System.Windows.Forms.Label();
            this.mskCelCli = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonFis = new System.Windows.Forms.RadioButton();
            this.radioButtonJur = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.labelPesq = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.labelCnpjpesq = new System.Windows.Forms.Label();
            this.textBoxCnpjPesq = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.checkBoxInativo = new System.Windows.Forms.CheckBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxCodigoCli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppScreenSplash.Properties.Resources.adicionar_usuario;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::AppScreenSplash.Properties.Resources.saida;
            this.pictureBox6.Location = new System.Drawing.Point(854, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(864, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sair";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCpfCli
            // 
            this.lblCpfCli.AutoSize = true;
            this.lblCpfCli.BackColor = System.Drawing.Color.LightGray;
            this.lblCpfCli.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCli.Location = new System.Drawing.Point(607, 135);
            this.lblCpfCli.Name = "lblCpfCli";
            this.lblCpfCli.Size = new System.Drawing.Size(38, 19);
            this.lblCpfCli.TabIndex = 14;
            this.lblCpfCli.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome, Razão Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pessoa:";
            // 
            // textBoxNOMECli
            // 
            this.textBoxNOMECli.Location = new System.Drawing.Point(335, 157);
            this.textBoxNOMECli.Name = "textBoxNOMECli";
            this.textBoxNOMECli.Size = new System.Drawing.Size(232, 20);
            this.textBoxNOMECli.TabIndex = 18;
            // 
            // labelAPELIDO
            // 
            this.labelAPELIDO.AutoSize = true;
            this.labelAPELIDO.BackColor = System.Drawing.Color.LightGray;
            this.labelAPELIDO.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAPELIDO.Location = new System.Drawing.Point(61, 211);
            this.labelAPELIDO.Name = "labelAPELIDO";
            this.labelAPELIDO.Size = new System.Drawing.Size(132, 19);
            this.labelAPELIDO.TabIndex = 21;
            this.labelAPELIDO.Text = "Apelido/Fantasia";
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.BackColor = System.Drawing.Color.LightGray;
            this.labelCEP.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEP.Location = new System.Drawing.Point(331, 211);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(39, 19);
            this.labelCEP.TabIndex = 22;
            this.labelCEP.Text = "CEP";
            // 
            // labelCIDADE
            // 
            this.labelCIDADE.AutoSize = true;
            this.labelCIDADE.BackColor = System.Drawing.Color.LightGray;
            this.labelCIDADE.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCIDADE.Location = new System.Drawing.Point(422, 211);
            this.labelCIDADE.Name = "labelCIDADE";
            this.labelCIDADE.Size = new System.Drawing.Size(63, 19);
            this.labelCIDADE.TabIndex = 23;
            this.labelCIDADE.Text = "Cidade:";
            // 
            // textBoxAPELIDOCli
            // 
            this.textBoxAPELIDOCli.Location = new System.Drawing.Point(65, 233);
            this.textBoxAPELIDOCli.Name = "textBoxAPELIDOCli";
            this.textBoxAPELIDOCli.Size = new System.Drawing.Size(172, 20);
            this.textBoxAPELIDOCli.TabIndex = 24;
            // 
            // textBoxCIDADECli
            // 
            this.textBoxCIDADECli.Location = new System.Drawing.Point(426, 233);
            this.textBoxCIDADECli.Name = "textBoxCIDADECli";
            this.textBoxCIDADECli.Size = new System.Drawing.Size(172, 20);
            this.textBoxCIDADECli.TabIndex = 26;
            // 
            // labelEND
            // 
            this.labelEND.AutoSize = true;
            this.labelEND.BackColor = System.Drawing.Color.LightGray;
            this.labelEND.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEND.Location = new System.Drawing.Point(61, 278);
            this.labelEND.Name = "labelEND";
            this.labelEND.Size = new System.Drawing.Size(113, 19);
            this.labelEND.TabIndex = 27;
            this.labelEND.Text = "Endereço/Rua";
            // 
            // labelNÚMERO
            // 
            this.labelNÚMERO.AutoSize = true;
            this.labelNÚMERO.BackColor = System.Drawing.Color.LightGray;
            this.labelNÚMERO.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNÚMERO.Location = new System.Drawing.Point(331, 278);
            this.labelNÚMERO.Name = "labelNÚMERO";
            this.labelNÚMERO.Size = new System.Drawing.Size(68, 19);
            this.labelNÚMERO.TabIndex = 28;
            this.labelNÚMERO.Text = "Número";
            // 
            // labelBAIRRO
            // 
            this.labelBAIRRO.AutoSize = true;
            this.labelBAIRRO.BackColor = System.Drawing.Color.LightGray;
            this.labelBAIRRO.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBAIRRO.Location = new System.Drawing.Point(426, 278);
            this.labelBAIRRO.Name = "labelBAIRRO";
            this.labelBAIRRO.Size = new System.Drawing.Size(59, 19);
            this.labelBAIRRO.TabIndex = 29;
            this.labelBAIRRO.Text = "Bairro:";
            // 
            // textBoxENDERECOCli
            // 
            this.textBoxENDERECOCli.Location = new System.Drawing.Point(65, 300);
            this.textBoxENDERECOCli.Name = "textBoxENDERECOCli";
            this.textBoxENDERECOCli.Size = new System.Drawing.Size(172, 20);
            this.textBoxENDERECOCli.TabIndex = 30;
            // 
            // textBoxNUMCli
            // 
            this.textBoxNUMCli.Location = new System.Drawing.Point(335, 300);
            this.textBoxNUMCli.Name = "textBoxNUMCli";
            this.textBoxNUMCli.Size = new System.Drawing.Size(64, 20);
            this.textBoxNUMCli.TabIndex = 31;
            // 
            // textBoxBAIRROCli
            // 
            this.textBoxBAIRROCli.Location = new System.Drawing.Point(426, 300);
            this.textBoxBAIRROCli.Name = "textBoxBAIRROCli";
            this.textBoxBAIRROCli.Size = new System.Drawing.Size(172, 20);
            this.textBoxBAIRROCli.TabIndex = 32;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.BackColor = System.Drawing.Color.LightGray;
            this.labelUF.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUF.Location = new System.Drawing.Point(617, 277);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(28, 19);
            this.labelUF.TabIndex = 33;
            this.labelUF.Text = "UF";
            // 
            // comboBoxUFCLI
            // 
            this.comboBoxUFCLI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUFCLI.FormattingEnabled = true;
            this.comboBoxUFCLI.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxUFCLI.Location = new System.Drawing.Point(621, 299);
            this.comboBoxUFCLI.Name = "comboBoxUFCLI";
            this.comboBoxUFCLI.Size = new System.Drawing.Size(55, 21);
            this.comboBoxUFCLI.TabIndex = 37;
            // 
            // buttonNovoCli
            // 
            this.buttonNovoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoCli.Location = new System.Drawing.Point(464, 446);
            this.buttonNovoCli.Name = "buttonNovoCli";
            this.buttonNovoCli.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoCli.TabIndex = 41;
            this.buttonNovoCli.Text = "Novo";
            this.buttonNovoCli.UseVisualStyleBackColor = true;
            this.buttonNovoCli.Click += new System.EventHandler(this.buttonNovoCli_Click);
            // 
            // buttonGravarCli
            // 
            this.buttonGravarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGravarCli.Location = new System.Drawing.Point(545, 446);
            this.buttonGravarCli.Name = "buttonGravarCli";
            this.buttonGravarCli.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarCli.TabIndex = 42;
            this.buttonGravarCli.Text = "Gravar";
            this.buttonGravarCli.UseVisualStyleBackColor = true;
            this.buttonGravarCli.Click += new System.EventHandler(this.buttonGravarCli_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(788, 446);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 43;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppScreenSplash.Properties.Resources.formato;
            this.pictureBox1.Location = new System.Drawing.Point(24, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // mskCPFCli
            // 
            this.mskCPFCli.Location = new System.Drawing.Point(614, 157);
            this.mskCPFCli.Mask = "000.000.000-00";
            this.mskCPFCli.Name = "mskCPFCli";
            this.mskCPFCli.Size = new System.Drawing.Size(88, 20);
            this.mskCPFCli.TabIndex = 44;
            this.mskCPFCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCPFCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCPFCli_KeyPress);
            // 
            // mskCNPJCli
            // 
            this.mskCNPJCli.Location = new System.Drawing.Point(740, 157);
            this.mskCNPJCli.Mask = "00.000.000/0000-00";
            this.mskCNPJCli.Name = "mskCNPJCli";
            this.mskCNPJCli.Size = new System.Drawing.Size(109, 20);
            this.mskCNPJCli.TabIndex = 45;
            this.mskCNPJCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCNPJCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCNPJCli_KeyPress);
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.BackColor = System.Drawing.Color.LightGray;
            this.labelCNPJ.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNPJ.Location = new System.Drawing.Point(736, 135);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(47, 19);
            this.labelCNPJ.TabIndex = 46;
            this.labelCNPJ.Text = "CNPJ";
            // 
            // mskCEPCli
            // 
            this.mskCEPCli.Location = new System.Drawing.Point(335, 233);
            this.mskCEPCli.Mask = "00000-000";
            this.mskCEPCli.Name = "mskCEPCli";
            this.mskCEPCli.Size = new System.Drawing.Size(64, 20);
            this.mskCEPCli.TabIndex = 47;
            this.mskCEPCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCEPCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCEPCli_KeyPress);
            // 
            // lblTelefoneCli
            // 
            this.lblTelefoneCli.AutoSize = true;
            this.lblTelefoneCli.BackColor = System.Drawing.Color.LightGray;
            this.lblTelefoneCli.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCli.Location = new System.Drawing.Point(610, 211);
            this.lblTelefoneCli.Name = "lblTelefoneCli";
            this.lblTelefoneCli.Size = new System.Drawing.Size(69, 19);
            this.lblTelefoneCli.TabIndex = 48;
            this.lblTelefoneCli.Text = "Contato:";
            // 
            // mskCelCli
            // 
            this.mskCelCli.Location = new System.Drawing.Point(614, 233);
            this.mskCelCli.Mask = "(00)00000-0000";
            this.mskCelCli.Name = "mskCelCli";
            this.mskCelCli.Size = new System.Drawing.Size(88, 20);
            this.mskCelCli.TabIndex = 49;
            this.mskCelCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCelCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCelCli_KeyPress);
            // 
            // radioButtonFis
            // 
            this.radioButtonFis.AutoSize = true;
            this.radioButtonFis.BackColor = System.Drawing.Color.LightGray;
            this.radioButtonFis.Location = new System.Drawing.Point(65, 161);
            this.radioButtonFis.Name = "radioButtonFis";
            this.radioButtonFis.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFis.TabIndex = 50;
            this.radioButtonFis.TabStop = true;
            this.radioButtonFis.Text = "Física";
            this.radioButtonFis.UseVisualStyleBackColor = false;
            this.radioButtonFis.Click += new System.EventHandler(this.radioButtonFis_Click);
            // 
            // radioButtonJur
            // 
            this.radioButtonJur.AutoSize = true;
            this.radioButtonJur.BackColor = System.Drawing.Color.LightGray;
            this.radioButtonJur.Location = new System.Drawing.Point(125, 161);
            this.radioButtonJur.Name = "radioButtonJur";
            this.radioButtonJur.Size = new System.Drawing.Size(63, 17);
            this.radioButtonJur.TabIndex = 51;
            this.radioButtonJur.TabStop = true;
            this.radioButtonJur.Text = "Jurídica";
            this.radioButtonJur.UseVisualStyleBackColor = false;
            this.radioButtonJur.Click += new System.EventHandler(this.radioButtonJur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 83);
            this.dataGridView1.TabIndex = 52;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(626, 446);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 53;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(707, 446);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 54;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // labelPesq
            // 
            this.labelPesq.AutoSize = true;
            this.labelPesq.BackColor = System.Drawing.Color.LightGray;
            this.labelPesq.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesq.Location = new System.Drawing.Point(61, 338);
            this.labelPesq.Name = "labelPesq";
            this.labelPesq.Size = new System.Drawing.Size(146, 19);
            this.labelPesq.TabIndex = 55;
            this.labelPesq.Text = "Pesquisar por CPF:";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(65, 360);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(142, 20);
            this.textBoxPesquisa.TabIndex = 56;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // labelCnpjpesq
            // 
            this.labelCnpjpesq.AutoSize = true;
            this.labelCnpjpesq.BackColor = System.Drawing.Color.LightGray;
            this.labelCnpjpesq.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCnpjpesq.Location = new System.Drawing.Point(224, 338);
            this.labelCnpjpesq.Name = "labelCnpjpesq";
            this.labelCnpjpesq.Size = new System.Drawing.Size(156, 19);
            this.labelCnpjpesq.TabIndex = 57;
            this.labelCnpjpesq.Text = "Pesquisar por CNPJ:";
            // 
            // textBoxCnpjPesq
            // 
            this.textBoxCnpjPesq.Location = new System.Drawing.Point(228, 360);
            this.textBoxCnpjPesq.Name = "textBoxCnpjPesq";
            this.textBoxCnpjPesq.Size = new System.Drawing.Size(152, 20);
            this.textBoxCnpjPesq.TabIndex = 58;
            this.textBoxCnpjPesq.TextChanged += new System.EventHandler(this.textBoxCnpjPesq_TextChanged);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.LightGray;
            this.labelUsuario.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(209, 135);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(69, 19);
            this.labelUsuario.TabIndex = 59;
            this.labelUsuario.Text = "Usuário:";
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.BackColor = System.Drawing.Color.LightGray;
            this.checkBoxAtivo.Location = new System.Drawing.Point(213, 161);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAtivo.TabIndex = 60;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = false;
            // 
            // checkBoxInativo
            // 
            this.checkBoxInativo.AutoSize = true;
            this.checkBoxInativo.BackColor = System.Drawing.Color.LightGray;
            this.checkBoxInativo.Location = new System.Drawing.Point(269, 161);
            this.checkBoxInativo.Name = "checkBoxInativo";
            this.checkBoxInativo.Size = new System.Drawing.Size(58, 17);
            this.checkBoxInativo.TabIndex = 61;
            this.checkBoxInativo.Text = "Inativo";
            this.checkBoxInativo.UseVisualStyleBackColor = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.LightGray;
            this.labelId.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(66, 91);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(63, 19);
            this.labelId.TabIndex = 62;
            this.labelId.Text = "Código:";
            // 
            // textBoxCodigoCli
            // 
            this.textBoxCodigoCli.Location = new System.Drawing.Point(65, 113);
            this.textBoxCodigoCli.Name = "textBoxCodigoCli";
            this.textBoxCodigoCli.Size = new System.Drawing.Size(64, 20);
            this.textBoxCodigoCli.TabIndex = 63;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(936, 531);
            this.Controls.Add(this.textBoxCodigoCli);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.checkBoxInativo);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxCnpjPesq);
            this.Controls.Add(this.labelCnpjpesq);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.labelPesq);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonJur);
            this.Controls.Add(this.radioButtonFis);
            this.Controls.Add(this.mskCelCli);
            this.Controls.Add(this.lblTelefoneCli);
            this.Controls.Add(this.mskCEPCli);
            this.Controls.Add(this.labelCNPJ);
            this.Controls.Add(this.mskCNPJCli);
            this.Controls.Add(this.mskCPFCli);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonGravarCli);
            this.Controls.Add(this.buttonNovoCli);
            this.Controls.Add(this.comboBoxUFCLI);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.textBoxBAIRROCli);
            this.Controls.Add(this.textBoxNUMCli);
            this.Controls.Add(this.textBoxENDERECOCli);
            this.Controls.Add(this.labelBAIRRO);
            this.Controls.Add(this.labelNÚMERO);
            this.Controls.Add(this.labelEND);
            this.Controls.Add(this.textBoxCIDADECli);
            this.Controls.Add(this.textBoxAPELIDOCli);
            this.Controls.Add(this.labelCIDADE);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.labelAPELIDO);
            this.Controls.Add(this.textBoxNOMECli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCpfCli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCpfCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNOMECli;
        private System.Windows.Forms.Label labelAPELIDO;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.Label labelCIDADE;
        private System.Windows.Forms.TextBox textBoxAPELIDOCli;
        private System.Windows.Forms.TextBox textBoxCIDADECli;
        private System.Windows.Forms.Label labelEND;
        private System.Windows.Forms.Label labelNÚMERO;
        private System.Windows.Forms.Label labelBAIRRO;
        private System.Windows.Forms.TextBox textBoxENDERECOCli;
        private System.Windows.Forms.TextBox textBoxNUMCli;
        private System.Windows.Forms.TextBox textBoxBAIRROCli;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.ComboBox comboBoxUFCLI;
        private System.Windows.Forms.Button buttonNovoCli;
        private System.Windows.Forms.Button buttonGravarCli;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mskCPFCli;
        private System.Windows.Forms.MaskedTextBox mskCNPJCli;
        private System.Windows.Forms.Label labelCNPJ;
        private System.Windows.Forms.MaskedTextBox mskCEPCli;
        public System.Windows.Forms.Label lblTelefoneCli;
        private System.Windows.Forms.MaskedTextBox mskCelCli;
        private System.Windows.Forms.RadioButton radioButtonFis;
        private System.Windows.Forms.RadioButton radioButtonJur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label labelPesq;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label labelCnpjpesq;
        private System.Windows.Forms.TextBox textBoxCnpjPesq;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.CheckBox checkBoxInativo;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxCodigoCli;
    }
}