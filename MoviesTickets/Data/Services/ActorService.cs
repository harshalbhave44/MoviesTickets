using Microsoft.EntityFrameworkCore;
using MoviesTickets.Data.Base;
using MoviesTickets.Models;

namespace MoviesTickets.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorService
    {
        public ActorService(AppDbContext context) : base(context) { }

    }
}
