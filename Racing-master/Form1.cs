using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Race_of_Death
{
    public partial class Form1 : Form
    {

        public int speed;
        public int playerlife;
        public bool flag = false;
        public Random rand = new Random();
        public Player player;
        public Car enemy1;
        //public Car enemy2;
        public Car enemy3;
        public Background background;
        public Background background1;
        List<Car> enemyCars;
        List<Coin> coins;
        bool truckFlag=false;
        bool backflag = false;
        bool carflag = false;
        Pit pit;
        Sound sound = new Sound();
       
        
        public enum CarType
        {
            CAR, //stands for Yellow Car
            MOTORCYCLE,
            TRUCK,
            PLAYER,
            RED_CAR // stands for red car
        }

        public Form1()
        {
            InitializeComponent();
            Execute();
            Start.Start();
            carsTimer.Start();
            coinTimer.Start();
            pitTimer.Start();
            sound.PlayingSound();
        }
        public void Execute()
        {
            //Two same backgrounds, to repeat themselves 
            background = new Background(0);
            background1 = new Background(-689);
            
            int x, y;
            x = rand.Next(40, 160);
            y = rand.Next(40, 160);

            int width = 585;
            int height = 695;
            // Creating new player
            player = new Player(new Car((CarType)3, 10, width / 2 - 30, height - 200), this.ClientSize.Width, this.ClientSize.Height);
            generateCars();
            generateCoins();
            generatePit();
            updateLabel();
        }
        public void updateLabel()
        {
            scorelabel.Text = String.Format("Score: {0}\n Lives: {1} \n Level: {2}", player.getCoins(), player.getLifes(), player.getLevel());
        }

//Generate coins after they're taken or run out of Form Window
        public void generateCoins()
        {
            coins = new List<Coin>();
            int x, y;
            x = rand.Next(panelleft.Location.X, panelleft.Location.X + panelleft.Size.Width -120);
            y = rand.Next(-20,0);
            Coin coin1 = new Coin(x, y);
            x = rand.Next(panelright.Location.X, panelright.Location.X + panelright.Size.Width - 120);
           
            Coin coin2 = new Coin(x,y);

            x = rand.Next(panelmid.Location.X, panelmid.Location.X + panelmid.Size.Width - 120);
            Coin coin3 = new Coin(x,y);
            coins.Add(coin1);
            coins.Add(coin2);
            coins.Add(coin3);
        }
        public void generatePit()
        {
            int x = rand.Next(panelmid.Location.X, panelmid.Location.X + panelmid.Size.Width - 120);
            pit = new Pit(x, -100);
        }
//Generate every type of car
        public void generateCars()
        {
            int x, y;
            x = rand.Next(panelleft.Location.X, panelleft.Location.X + panelleft.Size.Width - 60);
            y = rand.Next(160, 260);
            enemy1 = new Car((CarType)1, 9, x, y);
            //left location X =41   left width =151
           /* x = rand.Next(panelmid.Location.X, panelmid.Location.X + panelmid.Size.Width - 60);
            y = rand.Next(160, 360);
            enemy2 = new Car((CarType)0, 6, x, y);*/
            x = rand.Next(panelright.Location.X, panelright.Location.X + panelright.Size.Width - 60);
            y = rand.Next(160, 360);
            enemy3 = new Car((CarType)4, 5, x, y);
            enemyCars = new List<Car>();
            enemyCars.Add(enemy1);
         //   enemyCars.Add(enemy2);
            enemyCars.Add(enemy3);
        }
 
 //after the inital cars pass the Window Form , update their position
 //so they are placed Randomly in the Form

        public void updateCarPosition(Car enemy)
        {
            enemy.setY(-100);
            int x;
            switch (enemy.getType())
            {
              /*  case CarType.CAR:
                    {
                        x = rand.Next(panelmid.Location.X, panelmid.Location.X + panelmid.Size.Width - 60);
                        enemy.setX(x);
                        break;
                    }*/
                case CarType.MOTORCYCLE:
                    {
                        x = rand.Next(panelleft.Location.X, panelleft.Location.X + panelleft.Size.Width - 60);
                        enemy.setX(x);
                        break;
                    }
                case CarType.TRUCK:
                    {
                        x = rand.Next(panelright.Location.X, panelright.Location.X + panelright.Size.Width - 60);
                        enemy.setX(x);
                        enemy.setY(-220);
                        break;
                    }
                    //plus one case for RED_CAR
            }
        }


//function that serves for the car movement and for adding truck to make the game interesting&difficult
        public void moveCars()
        {
            foreach (Car enemy in enemyCars)
            {
                if (enemy.getY() <this.ClientSize.Height)
                {
                    if(truckFlag == true)
                    {
                        AddTruckToGame();
                    }
                    enemy.setY(enemy.getY()+enemy.getspeed());
                }
                else
                {
                    updateCarPosition(enemy);
                }
            }
        }

//this function position the coins randomly on the Form after they are passed or taken
        public void moveCoins()
        {
            foreach(Coin coin in coins)
            {
                if(coin.getY() <this.ClientSize.Height)
                {
                    coin.setY(coin.getY()+background.backgroundspeed+rand.Next(3,15));
                }
                else
                {
                    coin.setY(-rand.Next(30,60));
                    coin.setX(rand.Next(40,this.ClientSize.Width-40));
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //clear the window
            e.Graphics.Clear(Color.White);
            
            //draw the two (Same) backgrounds
            background.Draw(e.Graphics);
            background1.Draw(e.Graphics);
            
            //draw method for the main player
            player.Draw(e.Graphics);
            
            //draw all the enemy car's
            enemy1.Draw(e.Graphics);
            //enemy2.Draw(e.Graphics);
            enemy3.Draw(e.Graphics);
            pit.Draw(e.Graphics);
            //draw each coin
            foreach(Coin coin in coins)
            {
                coin.Draw(e.Graphics);
            }

        }
       
//function that invokes a Form when the game is paused (by clicking the key P)
    
//when these keys are pressed by the player, the game will respond accordingly
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (!carflag) {
                
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    player.moveUp();
                }
                else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    player.moveRight();
                    
                }
                else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    player.moveLeft();
                }
                else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    player.moveDown();
                  //  sound.BreakSound();
                } 
            }
        }

//function that secures that the player is collecting coins
//and checks if the game has finished
        public void collision()
        {
            player.loseLife();
            updateLabel();
            if (player.getLifes() == 0)
            {
               // sound.CrashSound();
                
               sound.GameOverSound();
                //GAME OVER Form "Thank you for Playing"
                metiLabel.Visible = true;
                Start.Stop();
                carsTimer.Stop();
                coinTimer.Stop();
                pitTimer.Stop();
                backflag = true;
                carflag = true;
                highScorelb.Text = String.Format("High Score:{0}\n Thank You for playing", player.getCoins());
                highScorelb.TextAlign = ContentAlignment.MiddleCenter;
                highScorelb.Visible = true;

                
            }
        }

//This function will add a truck to the game after the player has reached a certain level
        public void AddTruckToGame()
        {
            int x, y;
            x = rand.Next(panelleft.Location.X, panelleft.Location.X + panelleft.Size.Width - 60);
            y = -220;
            enemy1.setImage(Race_of_Death.Properties.Resources.TRUCK);
        }

//After the player has collected certain coins he gains a life only if he has less than 3 lifes(starting condition)
//Also increases the speed of the enemy for each level that he completes
        public void updateLevel()
        {
            if(player.getLifes() < 3)
            {
                player.setLife(player.getLifes() + 1);
                //dodatok 
                if (player.getCoins() < 20)
                {
                    player.setCoins(0);
                }
                else
                {
                    player.setCoins(player.getCoins() - 20);
                }
            }
            player.setLevel(player.getLevel()+1);
            updateLevellb.Text = String.Format("Congratzz! \n New level is unlocked");
            updateLevellb.Visible = true;
            truckFlag = true;
            enemy1.setspeed(rand.Next(enemy1.getspeed(), enemy1.getspeed() + 15));
         /*   enemy2.setspeed(rand.Next(enemy2.getspeed(), enemy2.getspeed() + 14));*/
            enemy3.setspeed(rand.Next(enemy3.getspeed(), enemy3.getspeed() + 13));

        }
//Function to collect the coins 
        public void collectCoin(Coin myCoin)
        {
            player.increaseScore();
            //in every 25 coins collected increase the level
            if (player.getCoins()%10==0) 
            {
                updateLevel();
            }
            if(player.getCoins()%10==1)
            {
                updateLevellb.Visible = false;
            }
            myCoin.setY(-50);
            //myCoin.setX(rand.Next(0, this.ClientSize.Width));
            updateLabel();
        }
        private void Start_Tick(object sender, EventArgs e)
        {
            Invalidate();
             
            Rectangle playerRec = new Rectangle(player.getCar().getX(), player.getCar().getY(),
                player.getCar().getwidthcar(), player.getCar().getheight());
            foreach (Car enemy in enemyCars)
            {
               Rectangle enemyRec = new Rectangle(enemy.getX(),enemy.getY(), enemy.getwidthcar(), 
                                                  enemy.getheight());
                //Check if a collison has accured
                if (playerRec.IntersectsWith(enemyRec))
                {
                    updateCarPosition(enemy);
                    collision();
                }
            }
            Rectangle pitRec = new Rectangle(pit.getX(), pit.getY(),pit.getwidth(),pit.getheight());
            if (playerRec.IntersectsWith(pitRec))
            {
                pit.setY(-130);
                int x = rand.Next(panelmid.Location.X, panelmid.Location.X + panelmid.Size.Width - 60);
                pit.setX(x);
                collision();
            }
            background.backgroundmove(backflag);
            background1.backgroundmove(backflag);
             Start.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void carsTimer_Tick(object sender, EventArgs e)
        {
            carsTimer.Enabled = true;
            moveCars();
            Invalidate();   
        }

        private void coinTimer_Tick(object sender, EventArgs e)
        {
            moveCoins();
            Invalidate();
            Rectangle carRec = new Rectangle(player.getCar().getX(), player.getCar().getY(),
                    player.getCar().getwidthcar(), player.getCar().getheight());
            foreach (Coin coin in coins)
            { 
                Rectangle coinRec = new Rectangle(coin.getX(), coin.getY(), 
                    coin.getWidth(), coin.getHeight());

                //Check if a player has come in contact with a coin
                if (carRec.IntersectsWith(coinRec))
                {
                    collectCoin(coin);
                }
            }
        }

        private void panelright_Paint(object sender, PaintEventArgs e)
        {

        }

        private void continuebtn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pitTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            pit.moveDown();
        }
    }
}