using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace Buffteks.Models
{
    public class Client : Person
    {
        //project list
        //PK - DONE
        //first name  - originates in the abstract class called "Person"
        //last name - originates in the abstract class called "Person"
        //phone - originates in the abstract class called "Person"
        //email - originates in the abstract class called "Person"
        //organization
        public int ClientId { get; set; }
        public ICollection<Projects> Project{ get; set; }
        public string organization { get; set; }


        

    }
}
