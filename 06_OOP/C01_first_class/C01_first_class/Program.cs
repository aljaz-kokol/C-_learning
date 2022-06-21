using System;

namespace C01_first_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Human aljaz = new Human("Aljaz", "Kokol", "Green Brown", 19);
            aljaz.IntroduceMySelf();
            
            Human barbara = new Human("Barbara", "Kokol", "Brown", 18);
            barbara.IntroduceMySelf();

            Human franzl = new Human("Franzl", "Muller", "Blue", 30);
            franzl.IntroduceMySelf();

            Human errorUser = new Human();
            errorUser.IntroduceMySelf();
        }
    }

}
