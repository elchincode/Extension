using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Extension
{
    public class User
    {

        private string pin;
        public string Name { get; set; }

        public string Surname { get; set; }

        public enum RegistrationMonth 
        {
            january = 1,
            february,
            marth,
            aprel,
            may,
            june,
            july,
            august,
            september,
            october,
            november,
            december

        }
        public RegistrationMonth registrationMonth { get; set; }





        public string PIN

        {
            get { return pin; }


            set
            {
                if(value.Set() == true)
                {
                    pin = value; 
                }
                else
                {
                    pin = "Something went wrong (((" ;
                }
            }



        }




        //public string PIN ////// Mellim ama mence buda bir usuldur  bunun methodu LINE:109-125

        //{
        //    get { return pin.Set(); }


        //    set
        //    {
        //        pin = value;
        //    } 



        //}




  



        public User(string Name , string Surname  , string PIN , RegistrationMonth registrationMonth  )
        {
            this.Name = Name;
            this.Surname = Surname;
            this.registrationMonth= registrationMonth;
            this.PIN = PIN;
            

        }
       
        public string GetDeatails()
        {
            return $"Student Name : {Name} \nStudent Surname : {Surname} \nStudent Registration Month : {registrationMonth} \nStudent PIN : {PIN}";
        }




    }

    //public static class user   ///
    //{
    //    public static string Set(this string PIN)
    //    {
    //        if (PIN.Length == 7 && PIN == PIN.ToUpper()) 
    //        {
    //            return PIN;
    //        }
    //        else
    //        {
    //            return "error" ;
    //        }


    //    }

    //}
    public static class user
    {
        public static  bool Set(this string PIN)
        {
            if (PIN.Length == 7 && PIN == PIN.ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }

}
