using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook
{
    class User
    {
        public User()
        {

        }
        public User(string Name,string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public User(string Name,string Surname,int Age):this(Name,Surname)
        {

            this.Age = Age;
        }
        public User(string Name,string Surname,string Bday,bool Issingle):this(Name,Surname)
        {
            DateOfBirth = Bday;
            this.IsSingle = Issingle;

        }

        public string Name;
        public string Surname;
        public int Age;
        public string Email;
        public string DateOfBirth;
        public bool IsSingle;

        public Post[] Posts;
    }
   








}
