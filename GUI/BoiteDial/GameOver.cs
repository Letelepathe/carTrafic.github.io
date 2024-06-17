using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Trafic_1._0.GUI.BoiteDial
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            PanOver.Visible = false;
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
            guna2Transition1.Show(PanOver);
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }
    }
}
