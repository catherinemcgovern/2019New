using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace Buffteks.Models
{
    public class Student : Person
    {
        //PK - DONE
        //first name - originates in the abstract class called "Person"
        //last name - originates in the abstract class called "Person"
        //phone - originates in the abstract class called "Person"       
        //email - originates in the abstract class called "Person"
        //role

        public int Id { get; set; }
        public Team Team { get; set; }
        public string roles { get; set; }
           public Role theRole { get; set; }
        

    }
}
