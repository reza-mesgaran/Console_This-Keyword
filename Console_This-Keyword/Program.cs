using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_This_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Reza", "Mesgaran");            
        }
    }
     class Person
    {
          string Fname { get; set; }
          string Lname { get; set; }
        public Person(string Fname,string Lname)      
        {
            this.Fname = Fname;    // -this keyword- represents the current object of class 
                                   // Left Side  of =  :  (this.Fname ==> string Fname { get; set; }) 
                                   // Right Side of =  :   Fname (represents the parameter of the constructor  => public Person(string Fname,...)

            this.Lname = Lname;
        }
    }

}
