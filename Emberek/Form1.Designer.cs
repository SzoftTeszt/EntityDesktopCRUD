namespace Emberek
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
            lstEmberek = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            btnMentes = new Button();
            btnModositas = new Button();
            btnTorles = new Button();
            SuspendLayout();
            // 
            // lstEmberek
            // 
            lstEmberek.FormattingEnabled = true;
            lstEmberek.Location = new Point(24, 19);
            lstEmberek.Name = "lstEmberek";
            lstEmberek.Size = new Size(277, 404);
            lstEmberek.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Név:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(349, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 94);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Életkor:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(349, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 27);
            textBox2.TabIndex = 2;
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(349, 179);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(94, 45);
            btnMentes.TabIndex = 3;
            btnMentes.Text = "Mentés";
            btnMentes.UseVisualStyleBackColor = true;
            // 
            // btnModositas
            // 
            btnModositas.Location = new Point(463, 179);
            btnModositas.Name = "btnModositas";
            btnModositas.Size = new Size(94, 45);
            btnModositas.TabIndex = 3;
            btnModositas.Text = "Módosítás";
            btnModositas.UseVisualStyleBackColor = true;
            // 
            // btnTorles
            // 
            btnTorles.Location = new Point(349, 246);
            btnTorles.Name = "btnTorles";
            btnTorles.Size = new Size(94, 45);
            btnTorles.TabIndex = 3;
            btnTorles.Text = "Törlés";
            btnTorles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 450);
            Controls.Add(btnModositas);
            Controls.Add(btnTorles);
            Controls.Add(btnMentes);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lstEmberek);
            Name = "Form1";
            Text = "Emberek Nyílvántartása";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmberek;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button btnMentes;
        private Button btnModositas;
        private Button btnTorles;
    }
}
