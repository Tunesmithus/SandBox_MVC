using SandBox_MVC.Contracts;
using SandBox_MVC.Data;
using SandBox_MVC.Model;

namespace SandBox_MVC.Repositories
{
    public class PlayerRepository:GenericRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext context): base(context)
        {
                
        }

    }
}
