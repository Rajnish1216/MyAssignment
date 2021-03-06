using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateAssisment

    /*For play this game firstly click spin button
     * then reload button and
     * then you are able to play shoot button
     */ 

{
    public partial class MainForm : Form
    {
        MainClass MainClass = new MainClass();    
        
        public MainForm()
        {
            InitializeComponent();
            ReloadButton.Enabled = true;
            SpinBTN.Enabled = false;
            Shoot.Enabled = false;
            AwayShootBTN.Enabled = false;
        }
     
        private void ReloadButton_Click(object sender, EventArgs e)
            // After taking life from spin this button is come to play that give bullets to the player.
        {
            MainClass.WeaponReload();
            SpinBTN.Enabled = true;
        }

        private void SpinBTN_Click(object sender, EventArgs e)
            // This is the first button that give life to the player before click on this your not able to click other button
        {
            MainClass.Forspin();
            SoundPlayer sound = new SoundPlayer(TemplateAssisment.Properties.Resources.SpinS);
            sound.Play();
            Shoot.Enabled = true;
            AwayShootBTN.Enabled = true;
            ReloadButton.Enabled = false;
        }

        private void AwayShootBTN_Click(object sender, EventArgs e)
            //After successful reloading you can play this button
        {
            MainClass.AwayShooting();

        }

        private void Shoot_Click(object sender, EventArgs e)
        {
            string Mess = MainClass.Shoot();
           MessageBox.Show(Mess);
           if(Mess == "Game Over !! You Loose the game")
            {
                Application.Restart();
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart(); // Code to restart the application again
        }
        private void Exitthegame_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Code to stop the application and all tasks relkated to applications
        }
    }
}
