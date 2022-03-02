using System;
using System.Collections.Generic;
using System.Linq;

namespace Shared
{
    public class Meeting
    {
        public string Title { get; set; }

        public DateOnly Date { get; set; } // yyyy-MM-dd
       
        public TimeOnly StartAt { get; set; } // hh:mm:ss PM/AM

        public TimeOnly EndAt { get; set; }

        public List<Employee> Participants { get; set; } = new ();
 
         
        public override string ToString()
        {
            var participentsList = "";

            var length = Participants.Count;
            for (var i = 0; i < length; i++)
            {
                var branchSymbol = i < length - 1 ? "├" : "└";
                participentsList += $"\n\t\t{branchSymbol}─── {Participants[i]}";
            }
            return $"\n\t┌ {Date.ToString("D")}  [{StartAt.ToString("hh:mm")} - {EndAt.ToString("hh:mm")}] '{Title}' ({length}) participants" +
                   $"\n\t└───────┐" +
                   $"{participentsList}";
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            Meeting other = (Meeting)obj;

            return Title.Equals(other.Title)
                 && Date == other.Date
                 && StartAt == other.StartAt
                 && EndAt == other.EndAt
                 && Participants.SequenceEqual(other.Participants);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            //check null
            hash = hash * 23 + Title.GetHashCode();
            hash = hash * 23 + Date.GetHashCode();
            hash = hash * 23 + StartAt.GetHashCode();
            hash = hash * 23 + EndAt.GetHashCode();
            return hash;
        }

    } 
}
