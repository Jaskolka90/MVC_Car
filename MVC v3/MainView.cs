using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_v3
{
    public partial class MainView : Form
    {
        MainController mainController;

        internal void Init(MainController mainController)
        {
            this.mainController = mainController;
        }
        
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Paint(object sender, PaintEventArgs e)
        {
            this.mainController.Redraw();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            this.mainController.ChangeColor();
        }

        private void btnLights_Click(object sender, EventArgs e)
        {
            this.mainController.SwitchLights();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.mainController.Stop();
        }

        private void btnGoForward_Click(object sender, EventArgs e)
        {
            this.mainController.GoForward();
        }

        private void btnGoBackword_Click(object sender, EventArgs e)
        {
            this.mainController.GoBackward();
        }

        internal void Redraw(Color color, bool lightOn, int frontWheelSpeed, int backWheelSpeed)
        {
            Graphics g = this.CreateGraphics();
            //Color
            SolidBrush brush = new SolidBrush(color);
            g.FillRectangle(brush, 250, 60, 250, 100);
            g.FillRectangle(brush, 150, 150, 380, 100);
            //Wheel
            g.FillEllipse(Brushes.Black, 430, 230, 70, 70);
            g.FillEllipse(Brushes.Black, 190, 230, 70, 70);
            //Light
            if (lightOn)
                g.FillEllipse(Brushes.Yellow, 0, 150, 150, 70);
            else
                g.FillEllipse(Brushes.WhiteSmoke, 0, 150, 150, 70);
            //Speed
            Font font = SystemFonts.DialogFont;
            Font size = new Font(font.FontFamily, 20, font.Style);
            g.DrawString(Convert.ToString(frontWheelSpeed), size, Brushes.White, 210, 250);
            g.DrawString(Convert.ToString(backWheelSpeed), size, Brushes.White, 450, 250);
        }
    }
}
