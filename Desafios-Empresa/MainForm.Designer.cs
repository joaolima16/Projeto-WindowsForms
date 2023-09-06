namespace Desafios_Empresa
{
    partial class MainForm
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
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 20);
            label1.Name = "label1";
            label1.Size = new Size(283, 45);
            label1.TabIndex = 0;
            label1.Text = "Menu de desafios";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(33, 147);
            button1.Name = "button1";
            button1.Size = new Size(145, 75);
            button1.TabIndex = 1;
            button1.Text = "Desafio - 1/2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(228, 147);
            button2.Name = "button2";
            button2.Size = new Size(145, 75);
            button2.TabIndex = 2;
            button2.Text = "Desafio - 3/4/5";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(426, 147);
            button4.Name = "button4";
            button4.Size = new Size(145, 75);
            button4.TabIndex = 4;
            button4.Text = "Desafio - 6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(33, 268);
            button3.Name = "button3";
            button3.Size = new Size(145, 75);
            button3.TabIndex = 5;
            button3.Text = "Desafio - 7";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click_1;
            // 
            // button5
            // 
            button5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(228, 268);
            button5.Name = "button5";
            button5.Size = new Size(145, 75);
            button5.TabIndex = 6;
            button5.Text = "Desafio - 8";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 378);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button5;
    }
}