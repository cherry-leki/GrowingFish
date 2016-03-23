using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GrowingFish
{
    public partial class Form1 : Form
    {
        MainCharacter mainCharacter;
        Graphics g;
        int counter;

        public Form1()
        {
            InitializeComponent();
            mainCharacter = new MainCharacter();
            g = this.CreateGraphics();
            
            this.Refresh();

            Thread th = new Thread(new ThreadStart(run));
            th.Start();
        }

        public void run()
        {
            while (true)
            {
                mainCharacter.keyProcess(counter);
                Refresh();
                try
                {
                    Thread.Sleep(5);
                }
                catch (ThreadInterruptedException e)
                {
                }
                counter++;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 5);
            Rectangle rec = new Rectangle((int)mainCharacter.x, (int)mainCharacter.y, 20, 20);
            g.DrawArc(pen, rec, 0 ,360);
            //g.DrawRectangle(pen, rec);
        }

        private void keyPressed(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        mainCharacter.keyUp = true;
                        if (mainCharacter.fishSpeed < 40)
                        {
                            mainCharacter.fishSpeed++;
                        }   
                    }break;
                case Keys.Down:
                    {
                        mainCharacter.keyDown = true;
                        if (mainCharacter.fishSpeed < 40)
                        {
                            mainCharacter.fishSpeed++;
                        }
                    }break;
                case Keys.Left:
                    {
                        mainCharacter.keyLeft = true;
                        if (mainCharacter.fishSpeed < 40)
                        {
                            mainCharacter.fishSpeed++;
                        }
                    }break;
                case Keys.Right:
                    {
                        mainCharacter.keyRight = true;
                        if (mainCharacter.fishSpeed < 40)
                        {
                            mainCharacter.fishSpeed++;
                        }
                    }break;
            }
        }
        public void keyReleased(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        mainCharacter.keyUp = false;
                        mainCharacter.finalKey = "up";
                    }break;
                case Keys.Down:
                    {
                        mainCharacter.keyDown = false;
                        mainCharacter.finalKey = "down";
                    } break;
                case Keys.Left:
                    {
                        mainCharacter.keyLeft = false;
                        mainCharacter.finalKey2 = "left";
                    } break;
                case Keys.Right:
                    {
                        mainCharacter.keyRight = false;
                        mainCharacter.finalKey2 = "right";
                    } break;
            }
        }
    }
}
