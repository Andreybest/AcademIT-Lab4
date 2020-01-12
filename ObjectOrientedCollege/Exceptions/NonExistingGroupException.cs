using System;

namespace ObjectOrientedCollege
{
    [Serializable]
    public class NonExistingGroupException : Exception
    {
        public NonExistingGroupException() : base(message: "This group does not exists.")
        {
        }
    }
}
