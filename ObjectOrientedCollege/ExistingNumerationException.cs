using System;

namespace ObjectOrientedCollege
{
    [Serializable]
    public class ExistingNumerationException : Exception
    {
        public ExistingNumerationException() :base(message: "You can't give same number as for existing class.")
        {
        }
    }
}
