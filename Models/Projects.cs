using System;

namespace Buffteks.Models
{
    public class Projects
    {
        //PK - DONE
        //name - DONE
        //leader FK team lead
        //required hours - DONE
        //client - FK client - DONE
        //deadline - DONE
        public int ProjectID { get; set; }
        
        public string ProjectName { get; set; }
        public int RequiredHours { get; set; }
        public DateTime Deadline  { get; set; }

          public int ClientId { get; set; }  //this is the first part of setting up the client foreign key
          public Client Client { get; set; }  //this is the second part of setting up the client foreign key




    }
}
