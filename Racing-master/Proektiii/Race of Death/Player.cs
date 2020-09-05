using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Race_of_Death
{

    public class Player
    {
        int playerLife;
        Car car;
        int coins;
        int maxwidth;
        int maxheight;
        int level;

        public Player(Car car, int width, int height) {
            playerLife = 3;
            coins = 0;
            this.car = car;
            maxwidth = width - car.getwidthcar() - 5;
            maxheight = height - car.getheight();
            level = 1;
        }

//functions that move the player's car right,left,up and down

        public void moveRight()
        {
            if (car.getX() < maxwidth - 35)
            {
                car.setX(car.getX() + car.getspeed());
            }
            
        }
        public void moveLeft()
        {
            if (car.getX() >= 40)
            {
                car.setX(car.getX() - car.getspeed());
            }
        }
        public void moveUp()
        {
            if (car.getY() >= 10)
            {
                car.setY(car.getY() - car.getspeed());
            }
        }
        public void moveDown()
        {
            if (car.getY() < maxheight - 10)
            {
                car.setY(car.getY() + car.getspeed());
            }
        }
        public Car getCar()
        {
            return car;
        }
        public void loseLife()
        {
            playerLife--;
        }
        public void Draw(Graphics g)
        {
            car.Draw(g);
        }
        public void increaseScore()
        {
            coins++;
        }
        public void setCoins(int k)
        {
            
            coins = k;
        }
        public int getCoins()
        {
            return coins;
        } 
        public void setLevel(int k)
        {
            level = k;
        }
        public int getLevel()
        {
            return level;
        }
        public void setLife(int k)
        {
            playerLife = k;
        }
        public int getLifes()
        {
            return playerLife;
        }
    }
}
