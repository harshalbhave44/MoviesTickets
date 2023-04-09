using MoviesTickets.Data.Base;
using MoviesTickets.Models;

namespace MoviesTickets.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
