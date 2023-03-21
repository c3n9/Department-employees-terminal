using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeesTerminal.Model
{
    public partial class PassLog
    {
        public DateTime EnterOrExit
        {
            get
            {
                DateTime result = DateTime.Now;
                if (IsEnter)
                {
                    result = DateTime;
                }
                if (IsEnter == false)
                {
                    result = DateTime;
                }
                return result;
            }
        }

    }
}
