using SandBox_MVC.Model;

namespace SandBox_MVC.ViewModels
{
    public class PlayerFilterVM
    {
        public IEnumerable<Player> PlayersDetails { get; set; }
        public Player Player { get; set; }
    }
}
