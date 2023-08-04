using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L
{
    public abstract class Car
    {
        public abstract void StartEngine();

        public abstract void StopEngine();

        public abstract void OpenSunroof();

        public abstract void SetIdealTemprature();
    }
}
