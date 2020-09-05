using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_of_Death
{
   
   public class Award
    {
        public Image awardImage;
        public int X;
        public int Y;
        

        public Award(int highscore)
        {
            X = 50;
            Y = 50;
           if(highscore >=0 && highscore < 10)
            {
                awardImage = Race_of_Death.Properties.Resources.BRONZE;
            }
           else if(highscore >=10 && highscore < 20)
            {
                awardImage = Race_of_Death.Properties.Resources.SILVER;
            }
            else
            {
                awardImage=Race_of_Death.Properties.Resources.GOLD;
            }

        }
        public void Draw(Graphics g)
        {
            g.DrawImage(awardImage,X,Y,300,300);
        }
        
    }
}
