using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autarization.ViewModel
{
    class AuthorizationViewModel : BaseViewModel
    {
        private string _login;
        private string _password;

        public string Login { get => _login; set => SetProperty(ref _login, value); }

        public string Password { get => _password; set => SetProperty(ref _password, value); }

        public AuthorizationViewModel()
        {

        }
    }
   
}
