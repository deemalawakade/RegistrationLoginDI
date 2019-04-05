using LoginAndRegistrationDAL;
using LoginRegistrationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndRegistrationBAL
{
    public class LoginRegistrationBAL
    {
        public void GetRegisterFromBAL()
        {

            GetRegistrationInfoDAL dal = new GetRegistrationInfoDAL();
            RegisterMM register = new RegisterMM();
            dal.RegisterUser(register);
        }

    }
}
