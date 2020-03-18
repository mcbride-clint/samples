using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleArchitecture.Models.DomainModels;
using SimpleArchitecture.Models.Filters;
using SimpleArchitecture.Services;

namespace SimpleArchitecture.Mvc.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly UserService _userService;

        public UsersController(ILogger<UsersController> logger, UserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        // GET: Users
        public ActionResult Index()
        {
            var users = _userService.Find(new UserFilter() );
            return View(users);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            var user = _userService.Find(id);
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User entity)
        {
            try
            {
                _userService.Save(entity);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(entity);
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            var user = _userService.Find(id);
            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User entity)
        {
            try
            {
                _userService.Save(entity);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(entity);
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            var user = _userService.Find(id);
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, User entity)
        {
            try
            {
                entity = _userService.Find(id);
                _userService.Delete(entity);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(entity);
            }
        }
    }
}