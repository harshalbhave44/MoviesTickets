using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesTickets.Data.Base
{
    public interface IEntityBase
    {
        int Id { get; set; }     // cause id is the common attribute among all the classes
    }
}
