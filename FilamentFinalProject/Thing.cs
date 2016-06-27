using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilamentFinalProject
{
    class Thing
    {

        //class variables
        public String ThingName = "";
        public String ThingColor = "";

        // overload function for ability vs item
        public Thing(string name)
        {
            name = this.ThingName;
        }


        public Thing(string name, string color)
        {
            name = this.ThingName;
            color = this.ThingColor;
        }

    }
}
