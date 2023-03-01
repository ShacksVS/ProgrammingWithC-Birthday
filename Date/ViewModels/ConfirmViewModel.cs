using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Date.Models;

namespace Date.ViewModels
{
    class ConfirmViewModel
    {
        private UserCandidate _userCandidate = new UserCandidate();

        public DateTime Birthdate
        {
            get
            {
                return _userCandidate.Birthdate;
            }
            set
            {
                _userCandidate.Birthdate = value;
            }
        }


    }
}
