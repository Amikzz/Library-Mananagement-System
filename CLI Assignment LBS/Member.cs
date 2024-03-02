using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Assignment_LBS
{
    internal class Member
    {
        private string name;
        private int age;
        private int id;

        public Member()
        {
            // Default constructor
        }

        public Member(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public Member(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public int getID()
        {
            return id;
        }
    }
}
