using GameAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameAPI.Context
{
    public class GameContext: DbContext
    {
        public DbSet<Game> Games { get; set; }

        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }

    }
}