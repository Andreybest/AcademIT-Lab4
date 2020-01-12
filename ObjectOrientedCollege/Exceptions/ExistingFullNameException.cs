using System;

namespace ObjectOrientedCollege
{
    [Serializable]
    public class ExistingFullNameException : Exception
    {
        public ExistingFullNameException() : base(message: "You can't give same first and last name for new person.")
        {
        }
    }
}
