namespace Proyecto_Final_Programacion._
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txt2 = new TextBox();
            txt1 = new TextBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.netflix;
            pictureBox1.Location = new Point(-12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(812, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 56);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // txt2
            // 
            txt2.Location = new Point(326, 150);
            txt2.Name = "txt2";
            txt2.Size = new Size(172, 23);
            txt2.TabIndex = 3;
            // 
            // txt1
            // 
            txt1.Location = new Point(326, 80);
            txt1.Name = "txt1";
            txt1.Size = new Size(172, 23);
            txt1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Black;
            linkLabel1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.IndianRed;
            linkLabel1.LinkColor = Color.FromArgb(192, 0, 0);
            linkLabel1.Location = new Point(323, 387);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(168, 26);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrar Cliente";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 56);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(315, 51);
            label4.Name = "label4";
            label4.Size = new Size(199, 20);
            label4.TabIndex = 7;
            label4.Text = "Numero Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(347, 118);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 8;
            label5.Text = "Contraseña";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(323, 293);
            button1.Name = "button1";
            button1.Size = new Size(175, 51);
            button1.TabIndex = 9;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(txt1);
            Controls.Add(txt2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txt2;
        private TextBox txt1;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
