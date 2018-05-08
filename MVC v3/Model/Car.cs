using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_v3.Model
{
    public class Car
    {
        private Color color;
        private Light light;
        private Wheel frontWheel;
        private Wheel backWheel;
        Random random;
        
        public delegate void CarRedrawHandler(Color color, bool lightOn, int frontWheelSpeed, int backWheelSpeed);
        public event CarRedrawHandler onCarRedrawHandler;

        public Car()
        {
            this.color = Color.Red;
            this.light = new Light();
            this.frontWheel = new Wheel();
            this.backWheel = new Wheel();
            this.random = new Random();
        }

        internal void Redraw()
        {
            onCarRedrawHandlerFunction();
        }

        internal void ChangeColor()
        {
            int redShade = random.Next(0, 256);
            int greenShare = random.Next(0, 256);
            int blueShade = random.Next(0, 256);
            this.color = Color.FromArgb(redShade, greenShare, blueShade);
            onCarRedrawHandlerFunction();
        }

        internal void SwitchLights()
        {
            this.light.SwitchLight();
            onCarRedrawHandlerFunction();
        }

        internal void Stop()
        {
            this.frontWheel.SpeedStop();
            this.backWheel.SpeedStop();
            onCarRedrawHandlerFunction();
        }

        internal void GoForward()
        {
            this.frontWheel.SpeedUp();
            this.backWheel.SpeedUp();
            onCarRedrawHandlerFunction();
        }

        internal void GoBackward()
        {
            this.frontWheel.SpeedDown();
            this.backWheel.SpeedDown();
            onCarRedrawHandlerFunction();
        }

        internal void onCarRedrawHandlerFunction()
        {
            if (onCarRedrawHandler != null)
            {
                onCarRedrawHandler(this.color, this.light.LightOn, this.frontWheel.Speed, this.backWheel.Speed);
            }
        }
    }
}
