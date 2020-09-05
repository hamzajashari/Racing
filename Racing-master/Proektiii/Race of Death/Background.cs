using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Race_of_Death
{
    public class Background
    {
        public Image background { get; set; }
        public int X { get; set; }//horiz poss
        public int Y { get; set; }// vertic poss
        public int backgroundspeed { get; set; } // speed

        public Background (int Y)
        {
           this.Y = Y;
            background =Properties.Resources.finalasphallt1;
            X = 0;
            backgroundspeed =7;
        }

        public void backgroundmove(bool flag)
        {

            //height 700 width 600
            if (Y >= 700)
            {
                Y = -677;
            }
            else if (flag == true)
            {
                Y = Y;
            }
            else
               Y += backgroundspeed;
            

        }
     
        public void Draw(Graphics g)
        {
            int width = 585;
            int height = 695;
            //drawing the image with the starting positions, height and width 
            g.DrawImage(background,X,Y,width,height);
   
        }
    }
}
