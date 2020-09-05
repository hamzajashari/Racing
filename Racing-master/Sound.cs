using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Race_of_Death
{
   public class Sound
    {
        private SoundPlayer Intro;
        private SoundPlayer Playing;
        private SoundPlayer GameOver;
      //  private SoundPlayer CollectCoin;
      //  private SoundPlayer BreakCar;
        private SoundPlayer CrashCar;

        public Sound()
        {
            Intro = new SoundPlayer(Properties.Resources.IntroSoundWAV);
            Playing = new SoundPlayer(Properties.Resources.Playing);
            GameOver = new SoundPlayer(Properties.Resources.GameOver);
        //    CollectCoin = new SoundPlayer(Properties.Resources.CollectCoin);
        //    BreakCar= new SoundPlayer(Properties.Resources.BreakCar);
            CrashCar = new SoundPlayer(Properties.Resources.CrashCar);
        }
        public void playIntro()
        {
            Intro.PlayLooping();
        }
        public void PlayingSound()
        {
            Playing.PlayLooping();
           
        }
      /*  public void collectCoinSound()
        {
            CollectCoin.Play();
        }
        public void BreakSound()
        {
            BreakCar.Play();
        }*/
        public void CrashSound()
        {
            CrashCar.Play();
        }
        public void GameOverSound()
        {
            GameOver.Play();
        }

    }
}
