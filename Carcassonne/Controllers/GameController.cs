using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carcassonne.Controllers
{
    public class GameController : Controller
    {
        //
        // GET: /Game/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(int Players)
        {

            Carcassonne.Models.GameModel model = new Models.GameModel();

            model.NumberOfPlayers = Players;
            model.Players = new List<Models.Player>(Players);

            return PartialView("~/Views/Partials/EnterPlayers.cshtml", model);
        }

    }
}
