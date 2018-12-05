using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCustomer
{
    public class Operation
    {
        #region Public Properties
        public string RightSide { get; set; }
        public string LeftSide { get; set; }
        public OperationType OperationType { get; set; }
        #endregion

        #region Constructor

        public Operation()
        {
            this.RightSide = string.Empty;
            this.LeftSide = string.Empty;
        }
        #endregion
    }
}
