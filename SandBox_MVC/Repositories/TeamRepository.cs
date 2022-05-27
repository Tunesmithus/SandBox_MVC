using SandBox_MVC.Contracts;
using SandBox_MVC.Data;
using SandBox_MVC.Model;

namespace SandBox_MVC.Repositories
{
    public class TeamRepository:GenericRepository<Team>, ITeamRepository
    {

        public TeamRepository(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
