using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterficiesGraficas
{
    public partial class Form1 : Form
    {
        bool Saltando = false;
        int PosEjeY = 0;
        int Puntos = 0;
        int FuerzaSalto = 20;
        int VelocidadCactus = 10;
        int Tiempo = 7;
        Random rnd = new Random();
        

        public Form1()
        {
            InitializeComponent();
            GameManager.Start();
        }

        private void TeclaPulsada(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                miEtiqueta.Visible = !miEtiqueta.Visible;
            }

            if (e.KeyCode == Keys.Space)
            {
                Saltando = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void GameManager_tick(object sender, EventArgs e)
        {
            //Dino.Top -= PosEjeY;
            miEtiqueta.Text = Dino.Top.ToString();
            ground.Width = this.ClientSize.Width;

            CheckDinoStatus();
            
            Puntos++;
            Puntuacion.Text = "Puntuacion: " + Puntos;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    x.Left -= this.VelocidadCactus;
                    if (x.Left + x.Width < ground.Left)
                    {
                        x.Left = ground.Right + rnd.Next(200, 800);
                    }

                    if (Dino.Bounds.IntersectsWith(x.Bounds))
                    {
                        EndGame();
                    }
                }
            }
        }

        private void CheckDinoStatus()
        {
            if (Saltando && Tiempo > 0)
            {
                Dino.Top -= 30;
                Tiempo--;
            }
            else if (!Saltando && Tiempo == 0 && Dino.Top < ground.Top - Dino.Height)
            {
                Dino.Top += 30;
                if (Dino.Top == ground.Top - Dino.Height)
                {
                    Tiempo = 5;
                }
            }
            if (Tiempo == 0)
            {
                Saltando = false;
            }
        }

        private void EndGame()
        {
            Dino.Image = Properties.Resources.dead;
            GameManager.Stop();
        }

        //private void CactusMovement()
        //{
        //    castus.
        //    //if ()
        //    //{
        //    //    castus.Left -= VelocidadCactus;
        //    //    castusDoble.Left -= VelocidadCactus;
        //    //}
        //}
    }
}
