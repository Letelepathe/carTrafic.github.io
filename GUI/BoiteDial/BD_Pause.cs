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
    public partial class BD_Pause : Form
    {
        public BD_Pause()
        {
            InitializeComponent();
            PanPause.Visible = false;
        }

        private void BD_Pause_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            guna2Transition1.Show(PanPause);
            
        }
    }
}
