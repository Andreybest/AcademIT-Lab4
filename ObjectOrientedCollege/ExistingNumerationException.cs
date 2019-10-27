using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
