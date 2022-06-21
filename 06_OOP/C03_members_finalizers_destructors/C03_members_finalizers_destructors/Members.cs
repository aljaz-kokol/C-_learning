using System;

namespace C03_members_finalizers_destructors
{
    public class Members
    {
        // member private filed
        private string _memberName;
        private string _jobTitle;
        private int _sallery;
        
        // member - public filed
        public int age;
        
        // member property - propertys start with capital letter
        public string JobTitle
        {
            get => _jobTitle;
            set => _jobTitle = value;
        }

        public Members()
        {
            age = 30;
            _memberName = "Lucy";
            _sallery = 60000;
            _jobTitle = "Developer";
        }

        // member - finalizer - destructor
        ~Members()
        {
          // clean up statement  
          Console.WriteLine("Destruction of Member object");
        }

        // public member method
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0} and my job title is {1}, I'm {2} years old", _memberName, _jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My sallrey is {0}", _sallery);
        }
    }
}