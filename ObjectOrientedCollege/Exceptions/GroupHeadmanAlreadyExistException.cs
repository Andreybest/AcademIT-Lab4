using System;

namespace ObjectOrientedCollege
{
    [Serializable]
    public class GroupHeadmanAlreadyExistException : Exception
    {
        public GroupHeadmanAlreadyExistException() : base(message: "This group already has a headman.")
        {
        }
    }
}
