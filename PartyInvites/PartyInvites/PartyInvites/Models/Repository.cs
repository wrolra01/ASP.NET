using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<Guest> responses = new List<Guest>();

        public static IEnumerable<Guest> Responses 
        {
            get { return responses; }
        }

        public static void AddResponse(Guest guest) 
        {
            responses.Add(guest);
        }
    }
}
