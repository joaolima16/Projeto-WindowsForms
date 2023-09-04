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
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(252, 23);
            label1.Name = "label1";
            label1.Size = new Size(299, 47);
            label1.TabIndex = 0;
            label1.Text = "Ordenar Numeros";
            // 
            // txbValues
            // 
            txbValues.Location = new Point(252, 113);
            txbValues.Multiline = true;
            txbValues.Name = "txbValues";
            txbValues.Size = new Size(285, 28);
            txbValues.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(555, 113);
            button1.Name = "button1";
            button1.Size = new Size(106, 28);
            button1.TabIndex = 2;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbValues
            // 
            lbValues.AutoSize = true;
            lbValues.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbValues.Location = new Point(252, 176);
            lbValues.Name = "lbValues";
            lbValues.Size = new Size(0, 30);
            lbValues.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(325, 224);
            button2.Name = "button2";
            button2.Size = new Size(123, 40);
            button2.TabIndex = 4;
            button2.Text = "GerarArquivo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(lbValues);
            Controls.Add(button1);
            Controls.Add(txbValues);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbValues;
        private Button button1;
        private Label lbValues;
        private Button button2;
    }
}