using LoginRegistrationUtilities;
using LoginRegistrationUtilities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndRegistrationDAL
{

    public class GetRegistrationInfoDAL : IGetRegisterData
    {
        private RegistrationEntities2 _contex;
       
        //public GetRegistrationInfoDAL(RegistrationEntities2 context)
        //{
        //    _contex = context;
        //}
        public void RegisterUser(RegisterMM registerMM)
        {
            _contex = new RegistrationEntities2();
            Register register = new Register();
            register.ID = registerMM.ID;
            register.FirstName = registerMM.FirstName;
            register.LastName = registerMM.LastName;
            register.UserName = registerMM.UserName;
            register.EmailID = registerMM.EmailID;
            register.DateOfBirth = registerMM.DateOfBirth;
            register.Address = registerMM.Address;
            register.Password = registerMM.Password;
            register.ConfirmPassword = registerMM.ConfirmPassword;
            register.Capta = registerMM.Capta;
            _contex.Registers.Add(register);
        }
    }
}
