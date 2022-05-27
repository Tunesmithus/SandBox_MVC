using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SandBox_MVC.Contracts;
using SandBox_MVC.Model;

namespace SandBox_MVC.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerRepository playerRepository;
        private readonly ITeamRepository teamRepository;

        public PlayerController(IPlayerRepository playerRepository, 
            ITeamRepository teamRepository)
        {
            this.playerRepository = playerRepository;
            this.teamRepository = teamRepository;
        }
        // GET: PlayerController
        public ActionResult Index()
        {
            var playerList = playerRepository.GetAll();
                
            return View(playerList);
        }

        // GET: PlayerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlayerController/Create
        public ActionResult Create()
        {
            IEnumerable<SelectListItem> TeamList = teamRepository.GetAll().Select(
                x => new SelectListItem(value: x.Id.ToString(), text: x.Name));

            ViewBag.TeamList = TeamList;    

            return View();
        }

        // POST: PlayerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Player player)
        {
            IEnumerable<SelectListItem> TeamList = teamRepository.GetAll().Select(
                x => new SelectListItem(value: x.Id.ToString(), text: x.Name));

            ViewBag.TeamList = TeamList;

            if (ModelState.IsValid == true)
            {
                playerRepository.Add(player);
                return RedirectToAction(nameof(Index));
            }

            return View(player);
        }

        // GET: PlayerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlayerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlayerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlayerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
