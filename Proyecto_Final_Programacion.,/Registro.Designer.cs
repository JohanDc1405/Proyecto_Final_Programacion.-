namespace Proyecto_Final_Programacion._
{
    partial class Registro
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt1 = new TextBox();
            txt3 = new TextBox();
            txt2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.netflix;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(789, 437);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(110, 284);
            label1.Name = "label1";
            label1.Size = new Size(270, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre y apellido usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(219, 319);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 2;
            label2.Text = "Nro Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(258, 360);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // txt1
            // 
            txt1.Location = new Point(403, 281);
            txt1.Name = "txt1";
            txt1.Size = new Size(218, 23);
            txt1.TabIndex = 4;
            // 
            // txt3
            // 
            txt3.Location = new Point(403, 357);
            txt3.Name = "txt3";
            txt3.Size = new Size(218, 23);
            txt3.TabIndex = 5;
            // 
            // txt2
            // 
            txt2.Location = new Point(403, 316);
            txt2.Name = "txt2";
            txt2.Size = new Size(218, 23);
            txt2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Orange;
            button1.Location = new Point(24, 36);
            button1.Name = "button1";
            button1.Size = new Size(44, 43);
            button1.TabIndex = 7;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(323, 401);
            button2.Name = "button2";
            button2.Size = new Size(152, 37);
            button2.TabIndex = 8;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.YellowGreen;
            label4.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(74, 48);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 9;
            label4.Text = "Volver";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt2);
            Controls.Add(txt3);
            Controls.Add(txt1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Registro";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt1;
        private TextBox txt3;
        private TextBox txt2;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}