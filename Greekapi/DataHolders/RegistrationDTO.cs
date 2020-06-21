using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Greekapi.DataHolders
{
    public class RegistrationDTO
    {
        public string emailaddress { get; set; }
        public string msisdn { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }
        public string physicaladdress { get; set; }
        public string useridcreds { get; set; }
        public string password { get; set; }
        public static RegistrationDTO SetRegistrationDTO(string email,string Msisdn,string Name, string Surname, string Age, string PAddress, string idcreds,string Password)
        {
            RegistrationDTO registrationDTO = new RegistrationDTO()
            {
                emailaddress = email,
                surname = Surname,
                age = Age,
                msisdn = Msisdn,
                name = Name,
                password = Password,
                physicaladdress = PAddress,
                useridcreds = idcreds,
            };
            return registrationDTO;
        }
    }
}