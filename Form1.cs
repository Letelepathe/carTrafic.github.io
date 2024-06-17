using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Car_Trafic_1._0
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        GUI.BoiteDial.BDPret pret = new GUI.BoiteDial.BDPret();
        private void Form1_Load(object sender, EventArgs e)
        {
            // with:747, height:494
            //new GUI.BoiteDial.BDPret().Show;
            pret.Show();
            timer3.Start();
            timer2.Start();
            this.KeyPreview = true;
        }
        int count = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
         
            if (count == 5)
            {

               // pret.lblPret.Text = "GO !!!";
                if (distance > 1000)
                {
                    deplaceBar(5);
                    deplaceIA(3);
                    deplaceCoins(3);
                }
                deplaceBar(4);
                deplaceIA(2);
                deplaceCoins(2);
                gameOver();
                Distance();
            }
             
        }
        void Distance()
        {
            distance++;
            if (distance < 1000)
                lblDistances.Text = "" + distance + " M";
            else
                
                lblDistances.Text = "" +((float) distance/1000).ToString() + " KM";
        }

        void temps()
        {
           

        }
        int x,distance,TP;
        DateTime date;
        void placeAleaIA(PictureBox IA,int ran1,int ran2)
        {
           
            Random ran = new Random();
            x = ran.Next(ran1, ran2);
            
            IA.Location = new Point(x, 0);
        }

        void placeCoins(Guna.UI2.WinForms.Guna2Button coins, int ran1, int ran2)
        {
            int x;
            Random ran = new Random();
            x = ran.Next(ran1, ran2);

            coins.Location = new Point(x, 0);
        }

        void gameOver()
        {
            collusion(picIA1, picVoiture);
            collusion(picIA2, picVoiture);
            collusion(picIA3, picVoiture);
            collusion(picIA4, picVoiture);
        }
        int coins = 0;
        void collusion(PictureBox IA, PictureBox voiture)
        {
             
            if (picVoiture.Bounds.IntersectsWith(IA.Bounds))
            {
                timer1.Enabled = false;
                new GUI.BoiteDial.GameOver().ShowDialog();
            }

            if (picVoiture.Bounds.IntersectsWith(Coins1.Bounds))
            {
                coins++;
                lblCoins.Text = "" + coins.ToString();
                Random ran = new Random();
                x = ran.Next(209, 240);

                Coins1.Location = new Point(x, 0);
                 
            }
            if (picVoiture.Bounds.IntersectsWith(Coins4.Bounds))
            {
                coins++;
                lblCoins.Text = "" + coins.ToString();
                Random ran = new Random();
                x = ran.Next(200, 290);

                Coins4.Location = new Point(x, 0);
            }
            if (picVoiture.Bounds.IntersectsWith(Coins2.Bounds))
            {
                coins++;
                lblCoins.Text = "" + coins.ToString();
                Random ran = new Random();
                x = ran.Next(86, 110);

                Coins2.Location = new Point(x, 0);
            }
            if (picVoiture.Bounds.IntersectsWith(Coins3.Bounds))
            {
                coins++;
                lblCoins.Text = "" + coins.ToString();
                Random ran = new Random();
                x = ran.Next(14,140);

                Coins3.Location = new Point(x, 0);
            }
        }

        void deplaceBar(int speed)
        {
            if (picCircuit1.Top >= 500)
            { picCircuit1.Top = 0; }
            else { picCircuit1.Top += speed; }

            if (picCircuit2.Top >= 500)
            { picCircuit2.Top = 0; }
            else { picCircuit2.Top += speed; }

            if (picCircuit3.Top >= 500)
            { picCircuit3.Top = 0; }
            else { picCircuit3.Top += speed; }

            if (picCircuit4.Top >= 500)
            { picCircuit4.Top = 0; }
            else { picCircuit4.Top += speed; }
        }

        void deplaceIA(int speed)
        {
            if (picIA1.Top >= 500)
            { placeAleaIA(picIA1,14,150); }
            else { picIA1.Top += speed; }

            if (picIA2.Top >= 500)
            { placeAleaIA(picIA2,200,260); }
            else { picIA2.Top += speed; }

            if (picIA3.Top >= 500)
            { placeAleaIA(picIA3,86,102); }
            else { picIA3.Top += speed; }

            if (picIA4.Top >= 500)
            { placeAleaIA(picIA4,271,291); }
            else { picIA4.Top += speed; }
        }

        void deplaceCoins(int speed)
        {
            if (Coins1.Top >= 500)
            { placeCoins(Coins1, 171, 240); }
            else { Coins1.Top += speed; }

            if (Coins2.Top >= 500)
            { placeCoins(Coins2, 64, 171); }
            else { Coins2.Top += speed; }

            if (Coins3.Top >= 500)
            { placeCoins(Coins3, 14, 190); }
            else { Coins3.Top += speed; }

            if (Coins4.Top >= 500)
            { placeCoins(Coins4, 140, 210); }
            else { Coins4.Top += speed; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          //  GUI.BoiteDial.BD_Pause Pause = new GUI.BoiteDial.BD_Pause();
            GUI.BoiteDial.GameOver Pause = new GUI.BoiteDial.GameOver();
            Pause.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            temps();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
                    if (e.KeyCode == Keys.S)
                    {
                         if(picVoiture.Left>18)
                            picVoiture.Left +=- 10;
                         if (distance > 1000)
                         {
                             picVoiture.Left += -15;
                         }
                    }

                    if (e.KeyCode == Keys.D)
                    {
                         if(picVoiture.Left<290)
                            picVoiture.Left += 10;
                         if (distance > 1000)
                         {
                             picVoiture.Left += 15;
                         }
                    }
                    if (e.KeyCode == Keys.V)
                    {
                      
                    }
            
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Coins2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            count += 1;
            if (count < 4)
            {
               
                pret.lblPret.Text =  count.ToString();
            }


            if (count == 4)
            { pret.lblPret.Text = "GO !!!"; }
            if (count == 5)
            {
                
                Thread.Sleep(500);
                pret.Close();
                timer3.Stop();
            }
        }
    }
}
