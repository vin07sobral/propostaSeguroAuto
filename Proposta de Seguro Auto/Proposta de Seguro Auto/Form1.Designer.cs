namespace Proposta_de_Seguro_Auto
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMas = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRod = new System.Windows.Forms.CheckBox();
            this.cbUM = new System.Windows.Forms.CheckBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValTotal = new System.Windows.Forms.TextBox();
            this.txtValDescP = new System.Windows.Forms.TextBox();
            this.txtDescId = new System.Windows.Forms.TextBox();
            this.txtSexDesc = new System.Windows.Forms.TextBox();
            this.txtValBase = new System.Windows.Forms.TextBox();
            this.cmbFaixa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor do Carro";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(196, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(92, 42);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(60, 20);
            this.txtValor.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFem);
            this.groupBox1.Controls.Add(this.rbMas);
            this.groupBox1.Location = new System.Drawing.Point(15, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(109, 19);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(67, 17);
            this.rbFem.TabIndex = 1;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // rbMas
            // 
            this.rbMas.AutoSize = true;
            this.rbMas.Location = new System.Drawing.Point(7, 20);
            this.rbMas.Name = "rbMas";
            this.rbMas.Size = new System.Drawing.Size(73, 17);
            this.rbMas.TabIndex = 0;
            this.rbMas.TabStop = true;
            this.rbMas.Text = "Masculino";
            this.rbMas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRod);
            this.groupBox2.Controls.Add(this.cbUM);
            this.groupBox2.Location = new System.Drawing.Point(15, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 73);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perfil";
            // 
            // cbRod
            // 
            this.cbRod.AutoSize = true;
            this.cbRod.Location = new System.Drawing.Point(7, 50);
            this.cbRod.Name = "cbRod";
            this.cbRod.Size = new System.Drawing.Size(145, 17);
            this.cbRod.TabIndex = 1;
            this.cbRod.Text = "Roda somente na cidade";
            this.cbRod.UseVisualStyleBackColor = true;
            // 
            // cbUM
            // 
            this.cbUM.AutoSize = true;
            this.cbUM.Location = new System.Drawing.Point(7, 20);
            this.cbUM.Name = "cbUM";
            this.cbUM.Size = new System.Drawing.Size(99, 17);
            this.cbUM.TabIndex = 0;
            this.cbUM.Text = "Unico motorista";
            this.cbUM.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(221, 237);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(320, 237);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(419, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtValTotal);
            this.groupBox3.Controls.Add(this.txtValDescP);
            this.groupBox3.Controls.Add(this.txtDescId);
            this.groupBox3.Controls.Add(this.txtSexDesc);
            this.groupBox3.Controls.Add(this.txtValBase);
            this.groupBox3.Location = new System.Drawing.Point(255, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 170);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado da Proposta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "VALOR A PAGAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Desconto Perfil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desconto Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desconto Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor Base";
            // 
            // txtValTotal
            // 
            this.txtValTotal.Location = new System.Drawing.Point(122, 144);
            this.txtValTotal.Name = "txtValTotal";
            this.txtValTotal.ReadOnly = true;
            this.txtValTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValTotal.TabIndex = 4;
            // 
            // txtValDescP
            // 
            this.txtValDescP.Location = new System.Drawing.Point(122, 110);
            this.txtValDescP.Name = "txtValDescP";
            this.txtValDescP.ReadOnly = true;
            this.txtValDescP.Size = new System.Drawing.Size(100, 20);
            this.txtValDescP.TabIndex = 3;
            // 
            // txtDescId
            // 
            this.txtDescId.Location = new System.Drawing.Point(122, 82);
            this.txtDescId.Name = "txtDescId";
            this.txtDescId.ReadOnly = true;
            this.txtDescId.Size = new System.Drawing.Size(100, 20);
            this.txtDescId.TabIndex = 2;
            // 
            // txtSexDesc
            // 
            this.txtSexDesc.Location = new System.Drawing.Point(122, 52);
            this.txtSexDesc.Name = "txtSexDesc";
            this.txtSexDesc.ReadOnly = true;
            this.txtSexDesc.Size = new System.Drawing.Size(100, 20);
            this.txtSexDesc.TabIndex = 1;
            // 
            // txtValBase
            // 
            this.txtValBase.Location = new System.Drawing.Point(122, 19);
            this.txtValBase.Name = "txtValBase";
            this.txtValBase.ReadOnly = true;
            this.txtValBase.Size = new System.Drawing.Size(100, 20);
            this.txtValBase.TabIndex = 0;
            this.txtValBase.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // cmbFaixa
            // 
            this.cmbFaixa.FormattingEnabled = true;
            this.cmbFaixa.Items.AddRange(new object[] {
            "de 19 a 25 anos",
            "de 26 a 35 anos",
            "acima de 35 anos"});
            this.cmbFaixa.Location = new System.Drawing.Point(15, 156);
            this.cmbFaixa.Name = "cmbFaixa";
            this.cmbFaixa.Size = new System.Drawing.Size(121, 21);
            this.cmbFaixa.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Faixa Etária";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(506, 276);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbFaixa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbRod;
        private System.Windows.Forms.CheckBox cbUM;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValTotal;
        private System.Windows.Forms.TextBox txtValDescP;
        private System.Windows.Forms.TextBox txtDescId;
        private System.Windows.Forms.TextBox txtSexDesc;
        private System.Windows.Forms.TextBox txtValBase;
        private System.Windows.Forms.ComboBox cmbFaixa;
        private System.Windows.Forms.Label label8;
    }
}

