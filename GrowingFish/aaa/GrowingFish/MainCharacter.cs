using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace GrowingFish
{
    public class MainCharacter
    {
        public string finalKey, finalKey2;
        public double x, y;
        public bool keyUp, keyDown, keyLeft, keyRight;
        public double fishSpeed;
        public int fishStatus;
        //public Bitmap[] fishImg;
        public double fishWidth, fishHeight;

        public MainCharacter()
        {
            x = 500;
            y = 384;
            fishSpeed = 3;
            //fishImg = new Bitmap[5];

            //for (int i = 1; i < fishImg.Length; i++)
            //{
                //fishImg[i] = new Bitmap("");
            //}
            //fishWidth = fishImg[1].Width;
            //fishHeight = fishImg[1].Height;
        }
        public void keyProcess(int counter)
        {
            if (keyUp == true)
            {
                if (y > 40)
                {
                    y -= (fishSpeed) / 15;
                    if (fishStatus == 1 || fishStatus == 3)
                    {
                        if ((counter / 8 % 2) == 0)
                        {
                            fishStatus = 1;
                        }
                        else
                        {
                            fishStatus = 3;
                        }
                    }
                }
                else
                {
                    if ((counter / 8 % 2) == 0)
                    {
                        fishStatus = 0;
                    }
                    else
                    {
                        fishStatus = 2;
                    }
                }
            }

            if (keyDown == true)
            {
                if (y < 740)
                {
                    y += (fishSpeed) / 15;
                    if (fishStatus == 1 || fishStatus == 3)
                    {
                        if ((counter / 8 % 2) == 0)
                        {
                            fishStatus = 1;
                        }
                        else
                        {
                            fishStatus = 3;
                        }
                    }
                }
                else
                {
                    if ((counter / 8 % 2) == 0)
                    {
                        fishStatus = 0;
                    }
                    else
                    {
                        fishStatus = 2;
                    }
                }
            }

            if (keyLeft == true)
            {
                if (x > 10)
                    x -= (fishSpeed) / 15;
                if ((counter / 8 % 2) == 0)
                {
                    fishStatus = 0;
                }
                else
                {
                    fishStatus = 2;
                }
            }

            if (keyRight == true)
            {
                if (x < 980)
                    x += (fishSpeed) / 15;
                if ((counter / 8 % 2) == 0)
                {
                    fishStatus = 1;
                }
                else
                {
                    fishStatus = 3;
                }
            }
            if (keyUp == false && keyDown == false && keyLeft == false && keyRight == false)
            {
                if (fishSpeed > 3)
                {
                    fishSpeed--;

                    if (finalKey == "up" && y > 40) y -= (fishSpeed) / 10;
                    if (finalKey == "down" && y < 740) y += (fishSpeed) / 10;
                    if (finalKey == "left" && x > 10) x -= (fishSpeed) / 10;
                    if (finalKey == "right" && x < 980) x += (fishSpeed) / 10;

                    if (fishSpeed <= 10)
                    {
                        finalKey = "";
                        finalKey2 = "";
                    }
                }
            }
        }
    }
}
