using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSOLIDDemo.Utils.Helpers.Primitives
{

    public static class SpaceTimeHelper
    {

        public static int DaysInAYear { get { return 365; } }

        public static int DaysInThisYear
        {
            get
            {
                return (new DateTime(DateTime.Now.Year + 1, 1, 1) - new DateTime(DateTime.Now.Year, 1, 1)).Days;

            }
        }

        public static int DaysInThisMonth
        {
            get
            {
                return (new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1) - new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).Days;

            }
        }
    }
}
