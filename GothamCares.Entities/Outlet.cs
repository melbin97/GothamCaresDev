using System;
using System.Collections.Generic;
using System.Text;

namespace GothamCares.Entities
{
    public class Outlet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StreetName { get; set; }
        public string Landmark { get; set; }
        public int RequiredVolunteer { get; set; }
        public int AvailablePackets { get; set; }
        public List<Food> Foods { get; set; }

    }
}
