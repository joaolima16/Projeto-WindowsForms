namespace Desafios_Empresa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txbValues = new TextBox();
            button1 = new Button();
            lbValues = new Label();
            btnGenerate = new Button();
            button2 = new Button();
            txbResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 59);
            label1.Name = "label1";
            label1.Size = new Size(299, 47);
            label1.TabIndex = 0;
            label1.Text = "Ordenar Numeros";
            // 
            // txbValues
            // 
            txbValues.Location = new Point(120, 145);
            txbValues.Multiline = true;
            txbValues.Name = "txbValues";
            txbValues.Size = new Size(285, 28);
            txbValues.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(411, 145);
            button1.Name = "button1";
            button1.Size = new Size(106, 28);
            button1.TabIndex = 2;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbValues
            // 
            lbValues.Location = new Point(0, 0);
            lbValues.Name = "lbValues";
            lbValues.Size = new Size(100, 23);
            lbValues.TabIndex = 6;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerate.Location = new Point(180, 334);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(176, 40);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "GerarArquivo";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += BtnGenerate_click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(-1, 412);
            button2.Name = "button2";
            button2.Size = new Size(125, 38);
            button2.TabIndex = 5;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txbResult
            // 
            txbResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txbResult.Location = new Point(120, 198);
            txbResult.Multiline = true;
            txbResult.Name = "txbResult";
            txbResult.Size = new Size(315, 130);
            txbResult.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(txbResult);
            Controls.Add(button2);
            Controls.Add(btnGenerate);
            Controls.Add(lbValues);
            Controls.Add(button1);
            Controls.Add(txbValues);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Desafio  - 1/2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbValues;
        private Button button1;
        private Label lbValues;
        private Button btnGenerate;
        private Button button2;
        private TextBox txbResult;
    }
}