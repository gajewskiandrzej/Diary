using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstName;
        string lastName;
        string address;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            firstName = "Andrzej";
            lastName = "Gajewski";
            age = 18;
        }

        public Person(int id, string firstname, string lastname, string address, int age, string gender)
        {
            this.id = id;
            firstName = firstname;
            lastName = lastname;
            this.address = address;
            this.age = age;
            this.gender = gender;
        }

        public Person(int id, string firstname, string lastname)
        {
            this.id = id;
            firstName = firstname;
            lastName = lastname;
            address = "Bobrowniki";
            age = 21;
        }

        public Person(int id, string firstname)
        {
            this.id = id;
            firstName = firstname;
        }
    }
}
