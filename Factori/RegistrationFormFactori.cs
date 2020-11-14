using LastOne.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastOne.Factori
{
    public class RegistrationFormFactori
    {

        public static RegistrationFormModel FillForm()
        {
            return new RegistrationFormModel()
            {
                FirstName = $"GoroMoro",
                //LastName = "Grumnul"
            };
        }
    }
}
