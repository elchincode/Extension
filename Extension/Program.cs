using System;
using Extension;
using static Extension.User;

namespace Extension
{
    
    class Program
    {
        static void Main(string[] args)
        {

       
            
            User user = new User("Elchin", "Ismayilov", "2003JUL", RegistrationMonth.july);

            Console.WriteLine(user.GetDeatails());

            Console.WriteLine();





            User user1 = new User("Robert ", "Downey", "1965APR", RegistrationMonth.aprel);

            Console.WriteLine(user1.GetDeatails());

            Console.WriteLine();





            User user2 = new User("Jonny", "Deep", "1963JUN", RegistrationMonth.june);

            Console.WriteLine(user2.GetDeatails());

            Console.WriteLine();






            User user3 = new User("Ryan", "Reynolds", "1976OCT", RegistrationMonth.october);

            Console.WriteLine(user3.GetDeatails());
            Console.WriteLine();





            User user4 = new User("Scarlett", "Johansson", "1984NO", RegistrationMonth.november);

            Console.WriteLine(user4.GetDeatails());



        }
    }

}
