using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC_DB2_sp.Data;
using WebMVC_DB2_sp.Models;
using Type = WebMVC_DB2_sp.Models.Type;

namespace WebMVC_DB2_sp.Controllers
{
    public class AnimalsBySelfController : Controller
    {

        private readonly WebMVC_DB2_spContext _context;


        public AnimalsBySelfController(WebMVC_DB2_spContext context)
        {
            _context = context;
        }

        //Get all animals
        public async Task<IActionResult> Index()
        {
            Informations i = new Informations();

            i.animals =  await _context.Animal.Include(a => a.Type).ToListAsync();
            i.types =  await _context.Type.ToListAsync();

            return View(i);
        }

        //view create

        public async Task<IActionResult> Create()
        {
            var types = await _context.Type.ToListAsync();

            return View(types);
        }
        // post create
        [HttpPost]

        public async Task<IActionResult> Create(string Name,int Weight,int TypeId)
        {
            if(Name == null || Weight == null)
            {
                return View();
            }
            try
            {
                Animal animal = new Animal();
                animal.Name = Name;
                animal.Weight = Weight;
                animal.TypeId = TypeId;

                _context.Add(animal);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //Delete forwarding

        public async Task<IActionResult> Delete(int? id)
        {
            var animal = await _context.Animal.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }                                   
        //Delete
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirm(int id)
        {
            Animal animal = await _context.Animal.FindAsync(id);

            try
            {
                _context.Remove(animal);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        //Get edit
        public async Task<IActionResult> Edit(int? id)
        {
            Informations i = new Informations();

            List<Animal> Animal = new List<Animal>();
            var animal = await _context.Animal.FindAsync(id);
            Animal.Add(animal);

            var type = await _context.Type.ToListAsync();
            
            i.types = type;
            i.animals = Animal;

            if (animal == null)
            {
                return NotFound();
            }

            return View(i);
            
        }
        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit(int id,string name,int weight,int TypeId)
        {
            Animal animal = new Animal();
            animal.Id = id;
            animal.Name = name;
            animal.Weight = weight;
            animal.TypeId = TypeId;

            _context.Update(animal);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        //create Type

        public async Task<IActionResult> CreateType()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> CreateType(int NrCage, string Food,string Img)
        {
            if (NrCage == null || Food == null)
            {
                return View();
            }
            try
            {
                Type type = new Type();
                type.Food = Food;
                type.NrCage = NrCage;
                type.Img = Img;

                _context.Add(type);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public async Task<IActionResult> DeleteType(int? id)
        {
            var type = await _context.Type.FindAsync(id);
            if (type == null)
            {
                return NotFound();
            }

            return View(type);
        }
        [HttpPost, ActionName("DeleteType")]

        public async Task<IActionResult> DeleteTypeConfirm(int id)
        {
            Type type = await _context.Type.FindAsync(id);

            try
            {
                _context.Remove(type);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
