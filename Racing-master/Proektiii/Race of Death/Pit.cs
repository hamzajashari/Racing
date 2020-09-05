using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Race_of_Death
{
    public class Pit 
    {
        public Image pit;
        public int X;
        public int Y;
        public int width;
        public int height;
        public int speedpit;
        public Pit(int X,int Y)
        {
            width = 70;
            height = 70;
               
            speedpit = 8;
            this.X = X;
            this.Y = Y;
            pit = Properties.Resources.pits;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(pit, X, Y,width,height);
        }
        public int getwidth()
        {
            return width;
        }
        public int getheight()
        {
            return height;
        }
        public void setX(int x)
        {
            X = x;
        }
        public void setY(int y)
        {
            Y = y;
        }
        public int getX()
        {

            return X;
        }
        public int getY()
        {
            return Y;
        }
        public void moveDown()
        {
            if (Y > 700) Y = -100;
            else Y += speedpit;
        }
       
    }
}
