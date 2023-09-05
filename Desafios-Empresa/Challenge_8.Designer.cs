namespace Desafios_Empresa
{
    partial class Challenge_8
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
            button1 = new Button();
            label1 = new Label();
            txbImage = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(215, 73);
            button1.Name = "button1";
            button1.Size = new Size(224, 70);
            button1.TabIndex = 0;
            button1.Text = "Baixar Imagem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 28);
            label1.TabIndex = 1;
            label1.Text = "Converter Imagem para Base64";
            // 
            // txbImage
            // 
            txbImage.Location = new Point(30, 149);
            txbImage.Multiline = true;
            txbImage.Name = "txbImage";
            txbImage.Size = new Size(592, 245);
            txbImage.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(-1, 413);
            button2.Name = "button2";
            button2.Size = new Size(89, 37);
            button2.TabIndex = 4;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Challenge_8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 450);
            Controls.Add(button2);
            Controls.Add(txbImage);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Challenge_8";
            Text = "Desafio - 8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txbImage;
        private Button button2;
    }
}