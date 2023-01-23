using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebIteraAPI.Data;
using WebIteraAPI.Models;

namespace WebIteraAPI.Controllers
{
    public class GroupsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GroupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Groups
        public async Task<IActionResult> Index()
        {
            return View(await _context.Groups.ToListAsync());
        }

        // GET: Groups/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Groups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@group == null)
            {
                return NotFound();
            }

            return View(@group);
        }

        // GET: Groups/Create
        public IActionResult Create()
        {
            return View();
        }

        //// POST: Groups/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Nome,category,date_ingestion,Id_Company")] Group @group)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(@group);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(@group);
        //}

        // GET: Groups/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Groups.FindAsync(id);
            if (@group == null)
            {
                return NotFound();
            }
            return View(@group);
        }

        // POST: Groups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Nome,category,date_ingestion,Id_Company")] Group @group)
        {
            if (id != @group.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@group);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupExists(@group.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@group);
        }

        // GET: Groups/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Groups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@group == null)
            {
                return NotFound();
            }

            return View(@group);
        }

        // POST: Groups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var @group = await _context.Groups.FindAsync(id);
            _context.Groups.Remove(@group);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupExists(string id)
        {
            return _context.Groups.Any(e => e.Id == id);
        }

        [HttpGet("{id2}")]
        public IEnumerable<Group> GetGroups(string Id)
        {
            Group grp = _context.Groups.Find(Id);
            if (grp == null) // Caso exista o grupo com id=_id, retornar os dados desse mesmo grupo
            {
                return (IEnumerable<Group>)grp;
            }
            else if (grp != null) //Caso não exista o grupo com o determinado id
            {
                return (IEnumerable<Group>)NotFound();
            }
            else//Caso ocorra algum erro no sistema
            {
                return (IEnumerable<Group>)BadRequest();
            }

        }

        [HttpGet("{date}")]
        public IEnumerable<Group> GetGroups(DateTime date)
        {
            var parsedDate = DateTime.ParseExact(date.ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            var dateFormat = parsedDate.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            Group grp = _context.Groups.Find(date);
            if (grp == null) //Caso não exista o grupo com o determinado id
            {
                return (IEnumerable<Group>)NotFound();
            }
            else if (grp != null) // Caso exista o grupo com id=_id, retornar os dados desse mesmo grupo
            {

                if (grp.date_ingestion <= Convert.ToDateTime(dateFormat))// Retorna todas as empresas que pertencem a grupos com date_ingestion <= ‘date’
                {
                    return (IEnumerable<Group>)grp;
                }
                else // Caso a condicao If acima nao satisfaca a condicao.
                    return (IEnumerable<Group>)NotFound();
            }
            else//Caso ocorra algum erro no sistema
            {
                return (IEnumerable<Group>)BadRequest();
            }

        }

       
        [HttpPut("{id3}")]
        public async Task<ActionResult> Put(string id, [FromBody] Group group)
        {
            if (group.Id != id) //Caso não exista um grupo com id = id, adicionar o grupo no arquivo group.json
            {
                var jsonData = System.IO.File.ReadAllText("/group.json");
                jsonData = JsonConvert.SerializeObject(JsonConvert.DeserializeObject<List<Group>>(jsonData));
                var GroupList = JsonConvert.DeserializeObject<List<Group>>(jsonData);
                GroupList.Add(new Group()
                {
                    Id = id
                });

                return Ok();
            }
            else if (group.Id != id) //Caso exista um grupo com esse id
            {
                return StatusCode(400);
            }
            else // Caso ocorra algum erro no sistema
                return StatusCode(500);
        }

    }
}
