using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_v3.Model
{
    public class Wheel
    {
        public int Speed { get; private set; }

        public Wheel()
        {
            this.Speed = 0;
        }

        public void SpeedUp()
        {
            Speed++;
        }

        public void SpeedDown()
        {
            Speed--;
        }

        public void SpeedStop()
        {
            Speed = 0;
        }
    }
}
