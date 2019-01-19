using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
