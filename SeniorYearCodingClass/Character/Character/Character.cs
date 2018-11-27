using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    class Character
    {
        public string name;
        public int age;
        public float height;
        public string eyecolor;
        public string gender;

        public Character(string name = "", int age = 0, float height = 0f, string eyecolor = "", string gender = "")
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.eyecolor = eyecolor;
            this.gender = gender;
        }
    }
}
