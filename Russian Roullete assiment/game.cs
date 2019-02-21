using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roullete_assiment
{
    public partial class game : Form
    {
        shooter shooter_obj = new shooter();

        public game()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //code below load the gif to piture box
            pictureBox1.Image = Image.FromFile(@"C:\Users\25lov\Desktop\Russian Roullete assiment\Res\load.gif");
            //code below plays the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\25lov\Desktop\Russian Roullete assiment\Res\load.wav");

            shooter_obj.loader = 1;//sets the value of loader =1


          btn_spin.Enabled = true;//enables the spin button
            btn_load.Enabled = false;//disable the load button
        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            //code below load the gif to piture box

            pictureBox1.Image = Image.FromFile(@"C:\Users\25lov\Desktop\Russian Roullete assiment\Res\spin.gif");
            //code below plays the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\25lov\Desktop\Russian Roullete assiment\Res\spin.wav");


            Random rnd = new Random();

            shooter_obj.spiner = rnd.Next(1, 6);

            btn_Shoot.Enabled = true;// enables the shoot button
            btn_spin.Enabled = false;// diable the spin button

        }

        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            //code below load the gif to piture box
            pictureBox1.Image = Image.FromFile(@"C:\Users\25lov\Desktop\Russian Roullete assiment\Res\shoot.gif");
            //code below plays the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\25lov\Desktop\Russian Roullete assiment\Res\shoot.wav");
            player.Play();
            int p = 0;
             p = shooter_obj.point(p);
            if (p == 100) 
            {
                MessageBox.Show("winner  your score is 100");//message pop up
                btn_Shoot.Enabled = false;

            }
            else if (p ==50)
            {
                MessageBox.Show("winner  your score is 5");//message pop up
                btn_Shoot.Enabled = false;

            }
            else if (p == 1)
            {
                btn_Shoot.Enabled = false;//disable the shoot button
                btn_spin.Enabled = false;// diable the shoot button
                btn_load.Enabled = false;// disable the shoot button
            }
            else
            {
                MessageBox.Show("you loss");//message pop up
                btn_Shoot.Enabled = false;

            }
           

        }

        private void btn_retry_Click(object sender, EventArgs e)
        {
            (new game()).Show();// relodes the form 
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
