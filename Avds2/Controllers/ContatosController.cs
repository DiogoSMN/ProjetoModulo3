using avds.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace avds.Controllers
{
    public class ContatoController : Controller
    {
        private Context _context;

        public ContatoController(Context context)
        {
            _context = context;
        }

       
        [HttpPost]
        public IActionResult CreateContato(Contatos contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return RedirectToAction("Contatos");
        }

        public IActionResult Contatos()
        {
            ViewBag.contatos = _context.Contatos.ToList();


            if (ViewBag.contatos == null)
            {
                return NotFound();
            }
            return View();


        }


        [HttpGet]
        
        public IActionResult Edit(int id)
        {

            var contatos = _context.Contatos.Where(c => c.IdContatos == id).FirstOrDefault();


            if (contatos == null)
            {
                return NotFound();
            }

            return View(contatos);
        }


        [HttpPost]
        public IActionResult Edit(Contatos contatos)
        {



            _context.Contatos.Update(contatos);
            _context.SaveChanges();


            return RedirectToAction("Contatos");
        }

        public IActionResult Details(int id)
        {
            var contatos = _context.Contatos.Where(p => p.IdContatos == id).FirstOrDefault();
            return View(contatos); ;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contatos = _context.Contatos.Where(p => p.IdContatos == id).FirstOrDefault();

            return View(contatos); ;
        }

        [HttpPost]
        public IActionResult Delete(Contatos contatos)
        {
            var contatosDel = _context.Contatos.Where(p => p.IdContatos == contatos.IdContatos).FirstOrDefault();

            _context.Contatos.Remove(contatosDel);

            _context.SaveChanges();


            return RedirectToAction("Contatos");

        }
    }
}
