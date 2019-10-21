using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class Audience
    {
        private int roomNumber;
        private int clearness;
        public Audience(int roomNumber, int clearness = 100)
        {
            this.roomNumber = roomNumber;
            this.clearness = clearness;
        }
    }
}