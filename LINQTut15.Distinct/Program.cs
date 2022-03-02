using Shared;
using System;
using System.Linq;

namespace LINQTut15.Distinct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var participantsm1m2 = Repository.Meeting1.Participants.Concat(Repository.Meeting2.Participants);
            participantsm1m2.Print(" Meeting 1 and Meeting 2 Participants");

            var distinctParticipantsm1m2 = participantsm1m2.Distinct();
            distinctParticipantsm1m2.Print(" Meeting 1 and Meeting 2 distinct Participants");

            var distinctParticipantsm1m2DistinctBy = participantsm1m2.DistinctBy(x => x.EmployeeNo);
            distinctParticipantsm1m2DistinctBy.Print(" Meeting 1 and Meeting 2 distinctby(x => x.EmployeeNo) Participants");

            Console.ReadKey();
        }
    }
}
