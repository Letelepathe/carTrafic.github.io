namespace Car_Trafic_1._0.GUI.BoiteDial
{
    partial class BDPret
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.AnimatorNS.Animation animation5 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BDPret));
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.lblPret = new System.Windows.Forms.Label();
            this.PanPause = new Guna.UI2.WinForms.Guna2Panel();
            this.PanPause.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.guna2Transition1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation5;
            // 
            // lblPret
            // 
            this.lblPret.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lblPret, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPret.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPret.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPret.Location = new System.Drawing.Point(28, 21);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(102, 23);
            this.lblPret.TabIndex = 1;
            this.lblPret.Text = "1";
            this.lblPret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanPause
            // 
            this.PanPause.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanPause.BorderRadius = 30;
            this.PanPause.BorderThickness = 3;
            this.PanPause.Controls.Add(this.lblPret);
            this.guna2Transition1.SetDecoration(this.PanPause, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanPause.Location = new System.Drawing.Point(12, 12);
            this.PanPause.Name = "PanPause";
            this.PanPause.ShadowDecoration.Parent = this.PanPause;
            this.PanPause.Size = new System.Drawing.Size(158, 65);
            this.PanPause.TabIndex = 1;
            // 
            // BDPret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 94);
            this.Controls.Add(this.PanPause);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BDPret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BDPret";
            this.TopMost = true;
            this.PanPause.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Panel PanPause;
        public System.Windows.Forms.Label lblPret;
    }
}