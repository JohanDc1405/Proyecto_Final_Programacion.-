namespace Proyecto_Final_Programacion._
{
    partial class Peliculas_Alquiladas
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
            listPeliculas = new ListBox();
            btn1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.netflix;
            pictureBox1.Location = new Point(2, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(795, 433);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(166, 27);
            label1.Name = "label1";
            label1.Size = new Size(230, 18);
            label1.TabIndex = 1;
            label1.Text = "Mis peliculas alquiladas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(623, 19);
            label2.TabIndex = 2;
            label2.Text = "         Pelicula                       /                  Genero               /               Anotaciones                 ";
            // 
            // listPeliculas
            // 
            listPeliculas.BackColor = Color.Black;
            listPeliculas.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listPeliculas.ForeColor = Color.Transparent;
            listPeliculas.FormattingEnabled = true;
            listPeliculas.ItemHeight = 18;
            listPeliculas.Location = new Point(12, 93);
            listPeliculas.Name = "listPeliculas";
            listPeliculas.Size = new Size(627, 346);
            listPeliculas.TabIndex = 3;
            listPeliculas.SelectedIndexChanged += listPeliculas_SelectedIndexChanged;
            // 
            // btn1
            // 
            btn1.BackColor = Color.IndianRed;
            btn1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(657, 93);
            btn1.Name = "btn1";
            btn1.Size = new Size(119, 46);
            btn1.TabIndex = 4;
            btn1.Text = "Generar Novedad";
            btn1.UseVisualStyleBackColor = false;
            // 
            // Peliculas_Alquiladas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn1);
            Controls.Add(listPeliculas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Peliculas_Alquiladas";
            Text = "Peliculas_Alquiladas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ListBox listPeliculas;
        private Button btn1;
    }
}