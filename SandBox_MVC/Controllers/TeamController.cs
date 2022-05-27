using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SandBox_MVC.Contracts;
using SandBox_MVC.Model;
using SandBox_MVC.Utility;

namespace SandBox_MVC.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamRepository teamRepository;

        public TeamController(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }
        public IActionResult Index()
        {
            var teamList = teamRepository.GetAll();
            return View(teamList);
        }

        public IActionResult Create()
        {
            var ConferenceList = StaticUtility.GetConference().Select(x=> x.Text);
            ViewBag.ConferenceList = ConferenceList;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Team team)
        {
            if (ModelState.IsValid == true)
            {
                
                teamRepository.Add(team);
                return RedirectToAction(nameof(Index));
            }

            return View(team);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var team = teamRepository.GetFirstOrDefault(x => x.Id == id);
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Team team)
        {
            if (ModelState.IsValid == true)
            {
                teamRepository.Update(team);
                return RedirectToAction(nameof(Index));
            }

            return View(team);
        }


  
    }
}
