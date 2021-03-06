using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateAssisment
{
    public class MainClass
    {
        public int Lifelines = 0;
        public int Bullet, spinBullet;
        
        //Below code is used to load the bullet in the chamber and play the sound for loading time.
        public void WeaponReload()
         {
                Bullet = 1;
                SoundPlayer sound = new SoundPlayer(TemplateAssisment.Properties.Resources.Reload);
                sound.Play();
                
        }

        //Code to spin the chamber after loading the bullet using Next function of the Random class as well as set the lifeline variable.
        public void Forspin()
           {
            Random rand = new Random();
            spinBullet = rand.Next(1, 7);
            Lifelines = 2;
            MessageBox.Show("Your Weapon spinned ");
        }

        public string Shoot()
        //code to shoot the bullet on head
        {
            if (Bullet == spinBullet)
            {
                return "Game Over !! You Loose the game";
            }
            else
            {
                SoundPlayer sound = new SoundPlayer(TemplateAssisment.Properties.Resources.Bomber);
                sound.Play();
                Bullet += 1;
                return "Empty Bullet";
                
            }
        }
       public void AwayShooting()
        //code to shoot the bullet away from head
        {
                if (Bullet == spinBullet)
                  {
                    SoundPlayer sound = new SoundPlayer(TemplateAssisment.Properties.Resources.gunsound);
                    sound.Play();
                    MessageBox.Show("Wow !! You win the game");
                Application.Restart();
            }
                else 
                {
                    Bullet = Bullet + 1;
                    Lifelines = Lifelines - 1;
                    MessageBox.Show("Empty Bullet");
                    if (Lifelines == 0)
                    {
                        MessageBox.Show("Game Over !! You loose the game");
                    Application.Restart();
                }
                }
             }
    }            
}
    
