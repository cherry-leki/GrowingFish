using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GrowingFish
{
    public partial class Form1 : Form
    {

        int counter;
        double gameScore;

        //Image buffImage;

        Bitmap background;
        Graphics buffg;
        MainCharacter mainCharacter;
        ManagerEnemys managerEnemys;

        public Form1()
        {
            mainCharacter = new MainCharacter();
            managerEnemys = new ManagerEnemys();
            InitializeComponent();

            background = new Bitmap("./pictures/FishBackground.png");
            buffg = this.CreateGraphics();

            counter = 0;
            gameScore = 0;

            Thread sub = new Thread(new ThreadStart(run));
            sub.Start();
        }

        public void run()
        {
            MessageBox.Show("dd");

            while (true)
            {
                Thread.Sleep(5);
                counter++;

                Console.WriteLine("Time : " + counter);
                Invalidate();
            }
        }

        public void drawBackground()
        {
            buffg.DrawImage(background, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
            buffg.DrawString(counter.ToString(), new Font("Arial", 16), new System.Drawing.SolidBrush(System.Drawing.Color.Black), 10, 10);
        }

        public void drawFish()
        {
            
        }

        public void EnemyRight()
        {

        }

        public void EnemyLeft()
        {

        }

        public void isCrash()
        {

        }

        public bool Crash()
        {
            return true;
        }

        // ClientRectangle.Width = 
        // ClientRectangle.Heigt = 
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawBackground();

        }
    }
}
