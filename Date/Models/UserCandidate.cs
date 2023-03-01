using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date.Models
{
    class UserCandidate
    {
        #region Fields
        private DateTime _birthdate;
        #endregion

        #region Properties
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
        #endregion

    }
}
