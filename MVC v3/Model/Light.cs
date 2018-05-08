using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_v3.Model
{
    public class Light
    {
        public bool LightOn { get; private set; }

        public Light()
        {
            this.LightOn = false;
        }

        public void SwitchLight()
        {
            LightOn = !LightOn;
        }
    }
}
