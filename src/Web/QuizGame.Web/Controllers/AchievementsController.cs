using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuizGame.Data;
using QuizGame.Data.Models;
using QuizGame.Services.DataServices.Contracts;
using QuizGame.Services.Models.Achievements;

namespace QuizGame.Web.Controllers
{
    public class AchievementsController : Controller
    {
        private readonly IAchievementsService achievementsService;

        public AchievementsController(IAchievementsService achievementsService)
        {
            this.achievementsService = achievementsService;
        }

        // GET: Achievements
        public async Task<IActionResult> Index()
        {
            return View(await achievementsService.GetAll().ToListAsync());
        }

        // GET: Achievements/Details/5
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var achievement = await _context.Achievements
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (achievement == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(achievement);
        //}

        // GET: Achievements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Achievements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] CreateAchievementIn model)
        {
            if (ModelState.IsValid)
            {
                await this.achievementsService.AddAsync(model);

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        //// GET: Achievements/Edit/5
        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var achievement = await _context.Achievements.FindAsync(id);
        //    if (achievement == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(achievement);
        //}

        //// POST: Achievements/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("Name,CorrectAnswers,RewardAmount,Id")] Achievement achievement)
        //{
        //    if (id != achievement.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(achievement);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!AchievementExists(achievement.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(achievement);
        //}

        // GET: Achievements/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var achievement = await this.achievementsService.FindByIdAsync(id);

            if (achievement == null)
            {
                return NotFound();
            }

            return View(achievement);
        }

        // POST: Achievements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var achievement = await this.achievementsService.FindByIdAsync(id);
            this.achievementsService.Delete(achievement);

            return RedirectToAction(nameof(Index));
        }

        //private bool AchievementExists(string id)
        //{
        //    return _context.Achievements.Any(e => e.Id == id);
        //}
    }
}
