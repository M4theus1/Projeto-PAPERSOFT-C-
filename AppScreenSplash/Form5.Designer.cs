namespace AppScreenSplash
{
    partial class FormProdutos
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCODBARRAS = new System.Windows.Forms.Label();
            this.lblNOMEPROD = new System.Windows.Forms.Label();
            this.textBoxNOMEPROD = new System.Windows.Forms.TextBox();
            this.lblFORN = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.lblDESC = new System.Windows.Forms.Label();
            this.textBoxForn = new System.Windows.Forms.TextBox();
            this.lblDATACAD = new System.Windows.Forms.Label();
            this.lblQTD = new System.Windows.Forms.Label();
            this.textBoxQTD = new System.Windows.Forms.TextBox();
            this.lblVALORPROD = new System.Windows.Forms.Label();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.dateCad = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxCodBar = new System.Windows.Forms.MaskedTextBox();
            this.textBoxValorProd = new System.Windows.Forms.TextBox();
            this.labelRS = new System.Windows.Forms.Label();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxPesqProd = new System.Windows.Forms.GroupBox();
            this.textBoxPesquisaProd = new System.Windows.Forms.TextBox();
            this.labelProdStatus = new System.Windows.Forms.Label();
            this.radioButtonProdAtivo = new System.Windows.Forms.RadioButton();
            this.radioButtonProdInativo = new System.Windows.Forms.RadioButton();
            this.labelIdProd = new System.Windows.Forms.Label();
            this.textBoxIdProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxPesqProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppScreenSplash.Properties.Resources.formato1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(877, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::AppScreenSplash.Properties.Resources.caixa_alt;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::AppScreenSplash.Properties.Resources.saida;
            this.pictureBox6.Location = new System.Drawing.Point(851, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(862, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sair";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCODBARRAS
            // 
            this.lblCODBARRAS.AutoSize = true;
            this.lblCODBARRAS.BackColor = System.Drawing.Color.LightGray;
            this.lblCODBARRAS.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCODBARRAS.Location = new System.Drawing.Point(106, 210);
            this.lblCODBARRAS.Name = "lblCODBARRAS";
            this.lblCODBARRAS.Size = new System.Drawing.Size(132, 19);
            this.lblCODBARRAS.TabIndex = 19;
            this.lblCODBARRAS.Text = "Cód. Barras/EAN";
            // 
            // lblNOMEPROD
            // 
            this.lblNOMEPROD.AutoSize = true;
            this.lblNOMEPROD.BackColor = System.Drawing.Color.LightGray;
            this.lblNOMEPROD.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOMEPROD.Location = new System.Drawing.Point(106, 138);
            this.lblNOMEPROD.Name = "lblNOMEPROD";
            this.lblNOMEPROD.Size = new System.Drawing.Size(136, 19);
            this.lblNOMEPROD.TabIndex = 21;
            this.lblNOMEPROD.Text = "Nome do Produto";
            // 
            // textBoxNOMEPROD
            // 
            this.textBoxNOMEPROD.Location = new System.Drawing.Point(110, 160);
            this.textBoxNOMEPROD.Name = "textBoxNOMEPROD";
            this.textBoxNOMEPROD.Size = new System.Drawing.Size(448, 20);
            this.textBoxNOMEPROD.TabIndex = 22;
            // 
            // lblFORN
            // 
            this.lblFORN.AutoSize = true;
            this.lblFORN.BackColor = System.Drawing.Color.LightGray;
            this.lblFORN.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFORN.Location = new System.Drawing.Point(325, 210);
            this.lblFORN.Name = "lblFORN";
            this.lblFORN.Size = new System.Drawing.Size(94, 19);
            this.lblFORN.TabIndex = 23;
            this.lblFORN.Text = "Fornecedor";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(603, 160);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(268, 20);
            this.textBoxDesc.TabIndex = 24;
            // 
            // lblDESC
            // 
            this.lblDESC.AutoSize = true;
            this.lblDESC.BackColor = System.Drawing.Color.LightGray;
            this.lblDESC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDESC.Location = new System.Drawing.Point(599, 138);
            this.lblDESC.Name = "lblDESC";
            this.lblDESC.Size = new System.Drawing.Size(82, 19);
            this.lblDESC.TabIndex = 25;
            this.lblDESC.Text = "Descrição";
            // 
            // textBoxForn
            // 
            this.textBoxForn.Location = new System.Drawing.Point(329, 232);
            this.textBoxForn.Name = "textBoxForn";
            this.textBoxForn.Size = new System.Drawing.Size(229, 20);
            this.textBoxForn.TabIndex = 26;
            // 
            // lblDATACAD
            // 
            this.lblDATACAD.AutoSize = true;
            this.lblDATACAD.BackColor = System.Drawing.Color.LightGray;
            this.lblDATACAD.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDATACAD.Location = new System.Drawing.Point(599, 210);
            this.lblDATACAD.Name = "lblDATACAD";
            this.lblDATACAD.Size = new System.Drawing.Size(135, 19);
            this.lblDATACAD.TabIndex = 27;
            this.lblDATACAD.Text = "Data de Cadastro";
            // 
            // lblQTD
            // 
            this.lblQTD.AutoSize = true;
            this.lblQTD.BackColor = System.Drawing.Color.LightGray;
            this.lblQTD.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQTD.Location = new System.Drawing.Point(106, 279);
            this.lblQTD.Name = "lblQTD";
            this.lblQTD.Size = new System.Drawing.Size(92, 19);
            this.lblQTD.TabIndex = 29;
            this.lblQTD.Text = "Quantidade";
            // 
            // textBoxQTD
            // 
            this.textBoxQTD.Location = new System.Drawing.Point(110, 301);
            this.textBoxQTD.Name = "textBoxQTD";
            this.textBoxQTD.Size = new System.Drawing.Size(172, 20);
            this.textBoxQTD.TabIndex = 30;
            // 
            // lblVALORPROD
            // 
            this.lblVALORPROD.AutoSize = true;
            this.lblVALORPROD.BackColor = System.Drawing.Color.LightGray;
            this.lblVALORPROD.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVALORPROD.Location = new System.Drawing.Point(325, 279);
            this.lblVALORPROD.Name = "lblVALORPROD";
            this.lblVALORPROD.Size = new System.Drawing.Size(110, 19);
            this.lblVALORPROD.TabIndex = 31;
            this.lblVALORPROD.Text = "Valor Produto";
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.Silver;
            this.buttonNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.Location = new System.Drawing.Point(553, 428);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 23);
            this.buttonNovo.TabIndex = 33;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.BackColor = System.Drawing.Color.Silver;
            this.buttonGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGravar.Location = new System.Drawing.Point(634, 428);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 34;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Silver;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(634, 457);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(156, 23);
            this.buttonLimpar.TabIndex = 35;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // dateCad
            // 
            this.dateCad.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCad.CustomFormat = "dd/MM/yyyy";
            this.dateCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCad.Location = new System.Drawing.Point(603, 231);
            this.dateCad.Name = "dateCad";
            this.dateCad.Size = new System.Drawing.Size(78, 20);
            this.dateCad.TabIndex = 37;
            // 
            // maskedTextBoxCodBar
            // 
            this.maskedTextBoxCodBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCodBar.Location = new System.Drawing.Point(110, 232);
            this.maskedTextBoxCodBar.Mask = "0000000000000";
            this.maskedTextBoxCodBar.Name = "maskedTextBoxCodBar";
            this.maskedTextBoxCodBar.Size = new System.Drawing.Size(132, 26);
            this.maskedTextBoxCodBar.TabIndex = 39;
            // 
            // textBoxValorProd
            // 
            this.textBoxValorProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorProd.Location = new System.Drawing.Point(373, 301);
            this.textBoxValorProd.Name = "textBoxValorProd";
            this.textBoxValorProd.Size = new System.Drawing.Size(106, 31);
            this.textBoxValorProd.TabIndex = 40;
            // 
            // labelRS
            // 
            this.labelRS.AutoSize = true;
            this.labelRS.BackColor = System.Drawing.Color.LightGray;
            this.labelRS.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.labelRS.Location = new System.Drawing.Point(324, 303);
            this.labelRS.Name = "labelRS";
            this.labelRS.Size = new System.Drawing.Size(43, 27);
            this.labelRS.TabIndex = 41;
            this.labelRS.Text = "R$:";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.Silver;
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(715, 428);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 42;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Silver;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(796, 428);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 43;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 81);
            this.dataGridView1.TabIndex = 44;
            // 
            // groupBoxPesqProd
            // 
            this.groupBoxPesqProd.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxPesqProd.Controls.Add(this.textBoxPesquisaProd);
            this.groupBoxPesqProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPesqProd.Location = new System.Drawing.Point(110, 338);
            this.groupBoxPesqProd.Name = "groupBoxPesqProd";
            this.groupBoxPesqProd.Size = new System.Drawing.Size(419, 55);
            this.groupBoxPesqProd.TabIndex = 45;
            this.groupBoxPesqProd.TabStop = false;
            this.groupBoxPesqProd.Text = "Pesquisa de Produto";
            // 
            // textBoxPesquisaProd
            // 
            this.textBoxPesquisaProd.Location = new System.Drawing.Point(6, 21);
            this.textBoxPesquisaProd.Name = "textBoxPesquisaProd";
            this.textBoxPesquisaProd.Size = new System.Drawing.Size(407, 22);
            this.textBoxPesquisaProd.TabIndex = 46;
            this.textBoxPesquisaProd.TextChanged += new System.EventHandler(this.textBoxPesquisaProd_TextChanged);
            // 
            // labelProdStatus
            // 
            this.labelProdStatus.AutoSize = true;
            this.labelProdStatus.BackColor = System.Drawing.Color.LightGray;
            this.labelProdStatus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdStatus.Location = new System.Drawing.Point(112, 91);
            this.labelProdStatus.Name = "labelProdStatus";
            this.labelProdStatus.Size = new System.Drawing.Size(71, 19);
            this.labelProdStatus.TabIndex = 46;
            this.labelProdStatus.Text = "Produto:";
            // 
            // radioButtonProdAtivo
            // 
            this.radioButtonProdAtivo.AutoSize = true;
            this.radioButtonProdAtivo.BackColor = System.Drawing.Color.LightGray;
            this.radioButtonProdAtivo.Location = new System.Drawing.Point(116, 114);
            this.radioButtonProdAtivo.Name = "radioButtonProdAtivo";
            this.radioButtonProdAtivo.Size = new System.Drawing.Size(49, 17);
            this.radioButtonProdAtivo.TabIndex = 47;
            this.radioButtonProdAtivo.TabStop = true;
            this.radioButtonProdAtivo.Text = "Ativo";
            this.radioButtonProdAtivo.UseVisualStyleBackColor = false;
            // 
            // radioButtonProdInativo
            // 
            this.radioButtonProdInativo.AutoSize = true;
            this.radioButtonProdInativo.BackColor = System.Drawing.Color.LightGray;
            this.radioButtonProdInativo.Location = new System.Drawing.Point(171, 113);
            this.radioButtonProdInativo.Name = "radioButtonProdInativo";
            this.radioButtonProdInativo.Size = new System.Drawing.Size(57, 17);
            this.radioButtonProdInativo.TabIndex = 48;
            this.radioButtonProdInativo.TabStop = true;
            this.radioButtonProdInativo.Text = "Inativo";
            this.radioButtonProdInativo.UseVisualStyleBackColor = false;
            // 
            // labelIdProd
            // 
            this.labelIdProd.AutoSize = true;
            this.labelIdProd.BackColor = System.Drawing.Color.LightGray;
            this.labelIdProd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdProd.Location = new System.Drawing.Point(231, 91);
            this.labelIdProd.Name = "labelIdProd";
            this.labelIdProd.Size = new System.Drawing.Size(112, 19);
            this.labelIdProd.TabIndex = 49;
            this.labelIdProd.Text = "ID do Produto:";
            // 
            // textBoxIdProd
            // 
            this.textBoxIdProd.Location = new System.Drawing.Point(235, 110);
            this.textBoxIdProd.Name = "textBoxIdProd";
            this.textBoxIdProd.Size = new System.Drawing.Size(172, 20);
            this.textBoxIdProd.TabIndex = 50;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(937, 532);
            this.Controls.Add(this.textBoxIdProd);
            this.Controls.Add(this.labelIdProd);
            this.Controls.Add(this.radioButtonProdInativo);
            this.Controls.Add(this.radioButtonProdAtivo);
            this.Controls.Add(this.labelProdStatus);
            this.Controls.Add(this.groupBoxPesqProd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.labelRS);
            this.Controls.Add(this.textBoxValorProd);
            this.Controls.Add(this.maskedTextBoxCodBar);
            this.Controls.Add(this.dateCad);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.lblVALORPROD);
            this.Controls.Add(this.textBoxQTD);
            this.Controls.Add(this.lblQTD);
            this.Controls.Add(this.lblDATACAD);
            this.Controls.Add(this.textBoxForn);
            this.Controls.Add(this.lblDESC);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.lblFORN);
            this.Controls.Add(this.textBoxNOMEPROD);
            this.Controls.Add(this.lblNOMEPROD);
            this.Controls.Add(this.lblCODBARRAS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxPesqProd.ResumeLayout(false);
            this.groupBoxPesqProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCODBARRAS;
        private System.Windows.Forms.Label lblNOMEPROD;
        private System.Windows.Forms.TextBox textBoxNOMEPROD;
        private System.Windows.Forms.Label lblFORN;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label lblDESC;
        private System.Windows.Forms.TextBox textBoxForn;
        private System.Windows.Forms.Label lblDATACAD;
        private System.Windows.Forms.Label lblQTD;
        private System.Windows.Forms.TextBox textBoxQTD;
        private System.Windows.Forms.Label lblVALORPROD;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.DateTimePicker dateCad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodBar;
        private System.Windows.Forms.TextBox textBoxValorProd;
        private System.Windows.Forms.Label labelRS;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxPesqProd;
        private System.Windows.Forms.TextBox textBoxPesquisaProd;
        private System.Windows.Forms.Label labelProdStatus;
        private System.Windows.Forms.RadioButton radioButtonProdAtivo;
        private System.Windows.Forms.RadioButton radioButtonProdInativo;
        private System.Windows.Forms.Label labelIdProd;
        private System.Windows.Forms.TextBox textBoxIdProd;
    }
}