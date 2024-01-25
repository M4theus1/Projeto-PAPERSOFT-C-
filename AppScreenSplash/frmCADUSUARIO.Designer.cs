namespace AppScreenSplash
{
    partial class frmCADUSUARIO
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblCPFUSUARIO = new System.Windows.Forms.Label();
            this.lblCELUSUARIO = new System.Windows.Forms.Label();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.bttnSalvarUsuario = new System.Windows.Forms.Button();
            this.radioButtonMasc = new System.Windows.Forms.RadioButton();
            this.lblSexoUsuario = new System.Windows.Forms.Label();
            this.radioButtonFem = new System.Windows.Forms.RadioButton();
            this.bttnHome = new System.Windows.Forms.Button();
            this.bttnNovo = new System.Windows.Forms.Button();
            this.bttnLimpar = new System.Windows.Forms.Button();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.dateNasc = new System.Windows.Forms.DateTimePicker();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.lblPesq = new System.Windows.Forms.Label();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.checkBoxInativo = new System.Windows.Forms.CheckBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(177, 176);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(342, 22);
            this.textBoxNome.TabIndex = 0;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeUsuario.Location = new System.Drawing.Point(28, 176);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(58, 18);
            this.lblNomeUsuario.TabIndex = 1;
            this.lblNomeUsuario.Text = "Nome:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDataNasc.Location = new System.Drawing.Point(28, 204);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(143, 18);
            this.lblDataNasc.TabIndex = 2;
            this.lblDataNasc.Text = "Data Nascimento:";
            // 
            // lblCPFUSUARIO
            // 
            this.lblCPFUSUARIO.AutoSize = true;
            this.lblCPFUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFUSUARIO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCPFUSUARIO.Location = new System.Drawing.Point(28, 236);
            this.lblCPFUSUARIO.Name = "lblCPFUSUARIO";
            this.lblCPFUSUARIO.Size = new System.Drawing.Size(46, 18);
            this.lblCPFUSUARIO.TabIndex = 4;
            this.lblCPFUSUARIO.Text = "CPF:";
            // 
            // lblCELUSUARIO
            // 
            this.lblCELUSUARIO.AutoSize = true;
            this.lblCELUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCELUSUARIO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCELUSUARIO.Location = new System.Drawing.Point(28, 263);
            this.lblCELUSUARIO.Name = "lblCELUSUARIO";
            this.lblCELUSUARIO.Size = new System.Drawing.Size(66, 18);
            this.lblCELUSUARIO.TabIndex = 6;
            this.lblCELUSUARIO.Text = "Celular:";
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTítulo.Location = new System.Drawing.Point(13, 13);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(485, 55);
            this.lblTítulo.TabIndex = 11;
            this.lblTítulo.Text = "Cadastro de Usuário";
            // 
            // bttnSalvarUsuario
            // 
            this.bttnSalvarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSalvarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnSalvarUsuario.Location = new System.Drawing.Point(104, 468);
            this.bttnSalvarUsuario.Name = "bttnSalvarUsuario";
            this.bttnSalvarUsuario.Size = new System.Drawing.Size(83, 23);
            this.bttnSalvarUsuario.TabIndex = 18;
            this.bttnSalvarUsuario.Text = "Gravar";
            this.bttnSalvarUsuario.UseVisualStyleBackColor = true;
            this.bttnSalvarUsuario.Click += new System.EventHandler(this.bttnSalvarUsuario_Click);
            // 
            // radioButtonMasc
            // 
            this.radioButtonMasc.AutoSize = true;
            this.radioButtonMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMasc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonMasc.Location = new System.Drawing.Point(177, 295);
            this.radioButtonMasc.Name = "radioButtonMasc";
            this.radioButtonMasc.Size = new System.Drawing.Size(82, 17);
            this.radioButtonMasc.TabIndex = 19;
            this.radioButtonMasc.TabStop = true;
            this.radioButtonMasc.Text = "Masculino";
            this.radioButtonMasc.UseVisualStyleBackColor = true;
            // 
            // lblSexoUsuario
            // 
            this.lblSexoUsuario.AutoSize = true;
            this.lblSexoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSexoUsuario.Location = new System.Drawing.Point(28, 293);
            this.lblSexoUsuario.Name = "lblSexoUsuario";
            this.lblSexoUsuario.Size = new System.Drawing.Size(51, 18);
            this.lblSexoUsuario.TabIndex = 20;
            this.lblSexoUsuario.Text = "Sexo:";
            // 
            // radioButtonFem
            // 
            this.radioButtonFem.AutoSize = true;
            this.radioButtonFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonFem.Location = new System.Drawing.Point(265, 295);
            this.radioButtonFem.Name = "radioButtonFem";
            this.radioButtonFem.Size = new System.Drawing.Size(75, 17);
            this.radioButtonFem.TabIndex = 21;
            this.radioButtonFem.TabStop = true;
            this.radioButtonFem.Text = "Feminino";
            this.radioButtonFem.UseVisualStyleBackColor = true;
            // 
            // bttnHome
            // 
            this.bttnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnHome.Location = new System.Drawing.Point(104, 497);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(263, 23);
            this.bttnHome.TabIndex = 22;
            this.bttnHome.Text = "Sair";
            this.bttnHome.UseVisualStyleBackColor = true;
            this.bttnHome.Click += new System.EventHandler(this.bttnHome_Click);
            // 
            // bttnNovo
            // 
            this.bttnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnNovo.Location = new System.Drawing.Point(23, 468);
            this.bttnNovo.Name = "bttnNovo";
            this.bttnNovo.Size = new System.Drawing.Size(75, 23);
            this.bttnNovo.TabIndex = 23;
            this.bttnNovo.Text = "Novo";
            this.bttnNovo.UseVisualStyleBackColor = true;
            this.bttnNovo.Click += new System.EventHandler(this.bttnNovo_Click);
            // 
            // bttnLimpar
            // 
            this.bttnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnLimpar.Location = new System.Drawing.Point(373, 468);
            this.bttnLimpar.Name = "bttnLimpar";
            this.bttnLimpar.Size = new System.Drawing.Size(84, 23);
            this.bttnLimpar.TabIndex = 24;
            this.bttnLimpar.Text = "Limpar";
            this.bttnLimpar.UseVisualStyleBackColor = true;
            this.bttnLimpar.Click += new System.EventHandler(this.bttnLimpar_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(177, 233);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(104, 21);
            this.mskCPF.TabIndex = 27;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskCel
            // 
            this.mskCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCel.Location = new System.Drawing.Point(177, 263);
            this.mskCel.Mask = "(00)00000-0000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(104, 21);
            this.mskCel.TabIndex = 28;
            this.mskCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dateNasc
            // 
            this.dateNasc.CustomFormat = "dd/MM/yyyy";
            this.dateNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNasc.Location = new System.Drawing.Point(178, 204);
            this.dateNasc.Name = "dateNasc";
            this.dateNasc.ShowUpDown = true;
            this.dateNasc.Size = new System.Drawing.Size(103, 20);
            this.dateNasc.TabIndex = 29;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAlterar.Location = new System.Drawing.Point(193, 468);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(84, 23);
            this.buttonAlterar.TabIndex = 30;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Usuário:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(564, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 348);
            this.dataGridView1.TabIndex = 34;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigo.Location = new System.Drawing.Point(28, 148);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 18);
            this.lblCodigo.TabIndex = 35;
            this.lblCodigo.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(177, 148);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodigo.TabIndex = 36;
            // 
            // lblPesq
            // 
            this.lblPesq.AutoSize = true;
            this.lblPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPesq.Location = new System.Drawing.Point(561, 113);
            this.lblPesq.Name = "lblPesq";
            this.lblPesq.Size = new System.Drawing.Size(156, 18);
            this.lblPesq.TabIndex = 37;
            this.lblPesq.Text = "Pesquisar por CPF:";
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisar.Location = new System.Drawing.Point(723, 112);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(189, 22);
            this.textBoxPesquisar.TabIndex = 38;
            this.textBoxPesquisar.TextChanged += new System.EventHandler(this.textBoxPesquisar_TextChanged);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.checkBoxAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAtivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxAtivo.Location = new System.Drawing.Point(177, 112);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(55, 17);
            this.checkBoxAtivo.TabIndex = 39;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = false;
            // 
            // checkBoxInativo
            // 
            this.checkBoxInativo.AutoSize = true;
            this.checkBoxInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInativo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxInativo.Location = new System.Drawing.Point(238, 112);
            this.checkBoxInativo.Name = "checkBoxInativo";
            this.checkBoxInativo.Size = new System.Drawing.Size(65, 17);
            this.checkBoxInativo.TabIndex = 40;
            this.checkBoxInativo.Text = "Inativo";
            this.checkBoxInativo.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExcluir.Location = new System.Drawing.Point(283, 468);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(84, 23);
            this.buttonExcluir.TabIndex = 41;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // frmCADUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(938, 527);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.checkBoxInativo);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.lblPesq);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.dateNasc);
            this.Controls.Add(this.mskCel);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.bttnLimpar);
            this.Controls.Add(this.bttnNovo);
            this.Controls.Add(this.bttnHome);
            this.Controls.Add(this.radioButtonFem);
            this.Controls.Add(this.lblSexoUsuario);
            this.Controls.Add(this.radioButtonMasc);
            this.Controls.Add(this.bttnSalvarUsuario);
            this.Controls.Add(this.lblTítulo);
            this.Controls.Add(this.lblCELUSUARIO);
            this.Controls.Add(this.lblCPFUSUARIO);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.textBoxNome);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCADUSUARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCADUSUARIO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblCPFUSUARIO;
        private System.Windows.Forms.Label lblCELUSUARIO;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Button bttnSalvarUsuario;
        private System.Windows.Forms.RadioButton radioButtonMasc;
        private System.Windows.Forms.Label lblSexoUsuario;
        private System.Windows.Forms.RadioButton radioButtonFem;
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Button bttnNovo;
        private System.Windows.Forms.Button bttnLimpar;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskCel;
        private System.Windows.Forms.DateTimePicker dateNasc;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label lblPesq;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.CheckBox checkBoxInativo;
        private System.Windows.Forms.Button buttonExcluir;
    }
}