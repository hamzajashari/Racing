using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Race_of_Death
{
    public class Car
    {
        public Image carImage;
        int X;//horizontal positions
        int Y;//vertical positions

        int carwidth=60;
        int carheight=100;

        Form1.CarType typeofcar;
        int speed;

        public Car (Form1.CarType type,int speed,int X, int Y) {

            this.speed = speed;
            this.X = X;
            this.Y = Y;
            switch (type)
            {
                case Form1.CarType.CAR:
                    {
                        this.carImage = Race_of_Death.Properties.Resources.car_2;
                        break;
                    }
                case Form1.CarType.RED_CAR:
                    {
                        this.carImage = Race_of_Death.Properties.Resources.car_3;
                        break;
                    }
                case Form1.CarType.MOTORCYCLE:
                    {
                        this.carImage = Race_of_Death.Properties.Resources.moto_1;
                        break;
                    }
                case Form1.CarType.TRUCK:
                    {
                        this.carImage = Race_of_Death.Properties.Resources.TRUCK; 
                        break;
                    }
                case Form1.CarType.PLAYER:
                    {
                        this.carImage = Race_of_Death.Properties.Resources.car_1;
                        break;
                    }
            }

        }
        public int getwidthcar() { return carwidth; }
        public int getheight() { return carheight; }
        public int getX() { return X; }
        public void setX(int x) { this.X = x; }
        public int getY() { return Y; }
        public void setY(int y) { this.Y = y; }
        public int getspeed() { return speed; }
        public void setspeed(int speed) { this.speed = speed; }
        public Image getImage()
        {
            return carImage;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(carImage,X,Y,carwidth,carheight);
        }
        public Form1.CarType getType()
        {
            return this.typeofcar;
        }
        public void setImage(Image image)
        {
            this.carImage = image;
            this.carwidth = 80;
            this.carheight = 170; 
        }
    }
}
