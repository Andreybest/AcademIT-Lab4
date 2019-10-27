using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedCollege
{
    public class Audience
    {
        public readonly int roomNumber;
        public const int maxClearness = 100;
        private int clearness;
        public int Clearness
        {
            get => clearness;
            set
            {
                clearness = Math.Min(maxClearness, value);
            }
        }

        public Audience(int roomNumber, int clearness = maxClearness)
        {
            this.roomNumber = roomNumber;
            this.clearness = clearness;
        }
    }
}