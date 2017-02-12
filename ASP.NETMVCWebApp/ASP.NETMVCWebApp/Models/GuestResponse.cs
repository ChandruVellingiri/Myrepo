using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ASP.NETMVCWebApp.Models
{
    public class GuestResponse : IDataErrorInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool?  WillAttend { get; set; }


        //Adding Validations - Validations are done when model binding happens when the form is POST
        public string Error { get { return null; } }
        public string this[string propName]
        {
            get
            {
                if ((propName == "Name") && string.IsNullOrEmpty(Name))
                    return "Please enter your name";
                if ((propName == "Email") && !Regex.IsMatch(Email, ".+\\@.+\\..+"))
                    return "Please enter a valid email address";
                if ((propName == "Phone") && string.IsNullOrEmpty(Phone))
                    return "Please enter your phone number";
                if ((propName == "WillAttend") && !WillAttend.HasValue)
                    return "Please specify whether you'll attend";
                return null;
            }
        }

        public void Submit()
        {
            
        }
    }
}