using System;

namespace observer
{
    class User
    {
        public string name { get; set; }


        public string email { get; set; }


        public User(String name, String email)
        {
            this.name = name;
            this.email = email;
        }


    }
}
