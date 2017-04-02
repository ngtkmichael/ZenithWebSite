using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZenithWebSite.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ZenithWebSite.Controllers
{
    public class RoleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoleController(ApplicationDbContext context)
        {
            _context = context;

        }

        /// <summary>
        /// Get All Roles
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var Roles = _context.Roles.ToList();
            return View(Roles);
        }

        /// <summary>
        /// Create a New role
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        /// <summary>
        /// Create a New Role
        /// </summary>
        /// <param name="Role"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            Role.Name = Role.NormalizedName;
            _context.Roles.Add(Role);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Role/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id.Equals(null) || id.Equals(""))
            {
                return NotFound();
            }

            var role = await _context.Roles
                .SingleOrDefaultAsync(r => r.Id.Equals(id));
            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }

        // POST: Role/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var role = await _context.Roles.SingleOrDefaultAsync(r => r.Id.Equals(id));
            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
