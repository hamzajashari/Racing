using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_of_Death
{
    public class Coin
    {
        private Image coinImage;
        private int X;
        private int Y;
        public int height;
        public int width;
        public Coin(int X, int Y)
        {
            this.coinImage = Race_of_Death.Properties.Resources.coin_png;
            this.X = X;
            this.Y = Y;
            this.height = 60;
            this.width = 40;
        }
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
        public void setX(int x)
        {
            this.X = x;
        }
        public void setY(int y)
        {
            this.Y = y;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(coinImage, X, Y, width, height) ;
        }
        public Image getImage()
        {
            return coinImage;
        }
        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }

    }
}
