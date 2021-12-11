using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoresFinalGUI
{
    class Chore
    {
        //variables
        private string name;
        private string hoursToComplete;
        private string priorityLevel;

        //constructors
        public Chore()
        {
            name = null;
            hoursToComplete = null;
            priorityLevel = null;
        }
        public Chore(string name, string hoursToComplete, string priorityLevel)
        {
            this.name = name;
            this.hoursToComplete = hoursToComplete;
            this.priorityLevel = priorityLevel;
        }
        //getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string HoursToComplete
        {
            get { return hoursToComplete; }
            set { hoursToComplete = value; }
        }
        
        public string PriorityLevel
        {
            get { return priorityLevel; }
            set { priorityLevel = value; }
        }
        //methods
        public string toString()
        {
            return "Chore: " + name + " | Hours To Complete: " + hoursToComplete + " | Priority Level: " + priorityLevel;
        }

    } //end of class
} //end of name
