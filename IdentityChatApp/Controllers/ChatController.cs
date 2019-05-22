using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityChatApp.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        private ApplicationUserManager _userManager;

        public ChatController()
        {
        }

        public ChatController(ApplicationUserManager userManager)
        {
            _userManager = userManager;
        }

        // GET: Chat
        public ActionResult Index()
        {
            ViewBag.UserName = User.Identity.Name;
            return View();
        }
    }
}