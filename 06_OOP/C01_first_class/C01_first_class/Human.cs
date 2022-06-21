using System;

namespace C01_first_class
{
    public class Human
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _eyeColor;
        private readonly int _age;

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._eyeColor = eyeColor;
            this._age = age;
        }

        public Human() : this(null, null, null, -1)
        {
        }

        public void IntroduceMySelf()
        {
            if (_firstName == null || _lastName == null || _eyeColor == null || _age == -1)
            {
                Console.WriteLine("Invalid user data");
            } 
            else
            {
                Console.WriteLine($"Hi, I'm {_firstName} {_lastName} and I'm {_age} years old. I have {_eyeColor.ToLower()} color eyes");    
            }
        }
        }
}