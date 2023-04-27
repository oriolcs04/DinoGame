
namespace InterficiesGraficas
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
            this.components = new System.ComponentModel.Container();
            this.miEtiqueta = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.Dino = new System.Windows.Forms.PictureBox();
            this.castusDoble = new System.Windows.Forms.PictureBox();
            this.castus = new System.Windows.Forms.PictureBox();
            this.GameManager = new System.Windows.Forms.Timer(this.components);
            this.Puntuacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castusDoble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castus)).BeginInit();
            this.SuspendLayout();
            // 
            // miEtiqueta
            // 
            this.miEtiqueta.AutoSize = true;
            this.miEtiqueta.Location = new System.Drawing.Point(867, 113);
            this.miEtiqueta.Name = "miEtiqueta";
            this.miEtiqueta.Size = new System.Drawing.Size(0, 15);
            this.miEtiqueta.TabIndex = 0;
            this.miEtiqueta.Click += new System.EventHandler(this.label1_Click);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ground.Location = new System.Drawing.Point(-2, 510);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1166, 106);
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            this.ground.Tag = "groundTag";
            // 
            // Dino
            // 
            this.Dino.BackColor = System.Drawing.Color.Transparent;
            this.Dino.Image = global::InterficiesGraficas.Properties.Resources.running;
            this.Dino.Location = new System.Drawing.Point(94, 467);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(40, 43);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dino.TabIndex = 2;
            this.Dino.TabStop = false;
            this.Dino.Tag = "player";
            this.Dino.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // castusDoble
            // 
            this.castusDoble.Image = global::InterficiesGraficas.Properties.Resources.obstacle_2;
            this.castusDoble.Location = new System.Drawing.Point(912, 477);
            this.castusDoble.Name = "castusDoble";
            this.castusDoble.Size = new System.Drawing.Size(32, 33);
            this.castusDoble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.castusDoble.TabIndex = 3;
            this.castusDoble.TabStop = false;
            this.castusDoble.Tag = "obstacle";
            // 
            // castus
            // 
            this.castus.Image = global::InterficiesGraficas.Properties.Resources.obstacle_1;
            this.castus.Location = new System.Drawing.Point(682, 464);
            this.castus.Name = "castus";
            this.castus.Size = new System.Drawing.Size(23, 46);
            this.castus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.castus.TabIndex = 4;
            this.castus.TabStop = false;
            this.castus.Tag = "obstacle";
            // 
            // GameManager
            // 
            this.GameManager.Interval = 20;
            this.GameManager.Tag = "running";
            this.GameManager.Tick += new System.EventHandler(this.GameManager_tick);
            // 
            // Puntuacion
            // 
            this.Puntuacion.AutoSize = true;
            this.Puntuacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Puntuacion.Location = new System.Drawing.Point(867, 75);
            this.Puntuacion.Name = "Puntuacion";
            this.Puntuacion.Size = new System.Drawing.Size(97, 19);
            this.Puntuacion.TabIndex = 5;
            this.Puntuacion.Tag = "scoreTag";
            this.Puntuacion.Text = "Puntuacion: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1163, 614);
            this.Controls.Add(this.Puntuacion);
            this.Controls.Add(this.castus);
            this.Controls.Add(this.castusDoble);
            this.Controls.Add(this.Dino);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.miEtiqueta);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "HOLA BBSOTA";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPulsada);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castusDoble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label miEtiqueta;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.PictureBox castusDoble;
        private System.Windows.Forms.PictureBox castus;
        private System.Windows.Forms.Timer GameManager;
        private System.Windows.Forms.Label Puntuacion;
    }
}

