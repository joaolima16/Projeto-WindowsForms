namespace Desafios_Empresa
{
    partial class CEP
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
            label1 = new Label();
            label2 = new Label();
            txbCep = new TextBox();
            txbUf = new TextBox();
            label3 = new Label();
            txbCidade = new TextBox();
            label4 = new Label();
            txbBairro = new TextBox();
            label5 = new Label();
            txbRua = new TextBox();
            label6 = new Label();
            btnVerify = new Button();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 40);
            label1.TabIndex = 0;
            label1.Text = "Consulta CEP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 78);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 2;
            label2.Text = "Digite o CEP";
            // 
            // txbCep
            // 
            txbCep.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbCep.Location = new Point(23, 113);
            txbCep.Multiline = true;
            txbCep.Name = "txbCep";
            txbCep.Size = new Size(299, 35);
            txbCep.TabIndex = 3;
            txbCep.TextChanged += txbCep_TextChanged;
            // 
            // txbUf
            // 
            txbUf.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbUf.Location = new Point(293, 291);
            txbUf.Multiline = true;
            txbUf.Name = "txbUf";
            txbUf.Size = new Size(109, 30);
            txbUf.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(293, 258);
            label3.Name = "label3";
            label3.Size = new Size(29, 21);
            label3.TabIndex = 4;
            label3.Text = "UF";
            // 
            // txbCidade
            // 
            txbCidade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbCidade.Location = new Point(23, 208);
            txbCidade.Multiline = true;
            txbCidade.Name = "txbCidade";
            txbCidade.Size = new Size(225, 30);
            txbCidade.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 172);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 6;
            label4.Text = "Cidade";
            // 
            // txbBairro
            // 
            txbBairro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbBairro.Location = new Point(23, 291);
            txbBairro.Multiline = true;
            txbBairro.Name = "txbBairro";
            txbBairro.Size = new Size(225, 30);
            txbBairro.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 258);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 8;
            label5.Text = "Bairro";
            // 
            // txbRua
            // 
            txbRua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbRua.Location = new Point(23, 384);
            txbRua.Multiline = true;
            txbRua.Name = "txbRua";
            txbRua.Size = new Size(357, 30);
            txbRua.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 345);
            label6.Name = "label6";
            label6.Size = new Size(37, 21);
            label6.TabIndex = 10;
            label6.Text = "Rua";
            // 
            // btnVerify
            // 
            btnVerify.Enabled = false;
            btnVerify.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerify.Location = new Point(328, 113);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(114, 35);
            btnVerify.TabIndex = 12;
            btnVerify.Text = "Consultar";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += button1_Click_1;
            // 
            // btnClear
            // 
            btnClear.Enabled = false;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(459, 113);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 13;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += txbClear_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(473, 411);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 39);
            btnBack.TabIndex = 14;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CEP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 450);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnVerify);
            Controls.Add(txbRua);
            Controls.Add(label6);
            Controls.Add(txbBairro);
            Controls.Add(label5);
            Controls.Add(txbCidade);
            Controls.Add(label4);
            Controls.Add(txbUf);
            Controls.Add(label3);
            Controls.Add(txbCep);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CEP";
            Text = "Desafio - 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVerify;
        private Label label2;
        private TextBox txbCep;
        private TextBox txbUf;
        private Label label3;
        private TextBox txbCidade;
        private Label label4;
        private TextBox txbBairro;
        private Label label5;
        private TextBox txbRua;
        private Label label6;
        private Button btnClear;
        private Button btnBack;
    }
}