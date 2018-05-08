using MVC_v3.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_v3
{
    class MainController
    {
        private MainView mainView;
        private Car car;

        public MainController(MainView mainView)
        {
            this.mainView = mainView;
            this.car = new Car();
            this.car.onCarRedrawHandler += Car_onCarRedrawHandler;
            mainView.Init(this);
        }

        private void Car_onCarRedrawHandler(Color color, bool lightOn, int frontWheelSpeed, int backWheelSpeed)
        {
            this.mainView.Redraw(color, lightOn, frontWheelSpeed, backWheelSpeed);
        }

        internal void Redraw()
        {
            this.car.Redraw();
        }

        internal void Run()
        {
            Application.Run(this.mainView);
        }

        internal void ChangeColor()
        {
            car.ChangeColor();
        }

        internal void SwitchLights()
        {
            car.SwitchLights();
        }

        internal void Stop()
        {
            car.Stop();
        }

        internal void GoForward()
        {
            car.GoForward();
        }

        internal void GoBackward()
        {
            car.GoBackward();
        }
    }
}
