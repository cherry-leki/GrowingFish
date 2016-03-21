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
        BufferedGraphicsContext currentContext;
        BufferedGraphics myBuffer;

        MainCharacter mainCharacter;
        ManagerEnemys managerEnemys;

        public Form1()
        {
            mainCharacter = new MainCharacter();
            managerEnemys = new ManagerEnemys();
            InitializeComponent();

            background = new Bitmap("./pictures/FishBackground.png");

            counter = 0;
            gameScore = 0;

            Thread sub = new Thread(new ThreadStart(run));
            sub.Start();
        }

        public void run()
        {
            this.Refresh();
            while (true)
            {
                counter++;

                Thread.Sleep(1);
                this.Refresh();
            }
        }

        public void drawBackground()
        {
            myBuffer.Graphics.DrawImage(background, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
            myBuffer.Graphics.DrawString(counter.ToString(), new Font("Arial", 16), new System.Drawing.SolidBrush(System.Drawing.Color.Black), 10, 10);
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

        public bool Crash(double mainX, double mainY, double enemyX, double enemyY, double enemyWidth, double enemyHeight)
        {
            bool check;


            return true;
        }

        protected override void OnPaintBackground(PaintEventArgs e) { }
        protected override void OnPaint(PaintEventArgs e)
        {
            currentContext = BufferedGraphicsManager.Current;
            myBuffer = currentContext.Allocate(this.CreateGraphics(), new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
            // 이 사이에 값을 넣어 더블 버퍼링으로 사용.
            drawBackground();

            // 이 사이에 값을 넣어 더블 버퍼링으로 사용.
            myBuffer.Render(e.Graphics);
            myBuffer.Dispose();
        }
    }
}
