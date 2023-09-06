namespace Desafios_Empresa
{
    partial class Challenge_3
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
            dataGridJson = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridJson).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(226, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 40);
            label1.TabIndex = 0;
            label1.Text = "Gerador Arquivo .JSON";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(280, 76);
            button1.Name = "button1";
            button1.Size = new Size(223, 50);
            button1.TabIndex = 1;
            button1.Text = "Gerar arquivo .JSON";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridJson
            // 
            dataGridJson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJson.Location = new Point(204, 132);
            dataGridJson.Name = "dataGridJson";
            dataGridJson.RowTemplate.Height = 25;
            dataGridJson.Size = new Size(392, 285);
            dataGridJson.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(0, 418);
            button2.Name = "button2";
            button2.Size = new Size(122, 32);
            button2.TabIndex = 3;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // Challenge_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(button2);
            Controls.Add(dataGridJson);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Challenge_3";
            Text = "Challenge_3";
            ((System.ComponentModel.ISupportInitialize)dataGridJson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridJson;
        private Button button2;
    }
}