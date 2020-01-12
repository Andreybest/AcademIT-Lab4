using System;

namespace ObjectOrientedCollege
{
    public class Audience
    {
        public readonly int roomNumber;
        public const int MaxClearness = 100;
        private int _clearness;
        public int Clearness
        {
            get => _clearness;
            set
            {
                if (value < 0)
                {
                    _clearness = 0;
                }
                else
                {
                    _clearness = Math.Min(MaxClearness, value);
                }
            }
        }

        public Audience(int roomNumber, int clearness = MaxClearness)
        {
            this.roomNumber = roomNumber;
            this._clearness = clearness;
        }
    }
}