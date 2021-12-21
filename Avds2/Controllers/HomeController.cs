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
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Destino()
        {
            return View();
        }
        public IActionResult Compras()
        {
            ViewBag.pessoa = _context.Pessoa.ToList();


            if (ViewBag.pessoa == null)
            {
                return NotFound();
            }


            return View();
        }
        public IActionResult Promocoes()
        {
            return View();
        }
       

        [HttpPost]
        public IActionResult Create(Pessoa pessoa)
        {
            _context.Add(pessoa);
            _context.SaveChanges();
            return RedirectToAction("Destino");
        }

        
        public IActionResult Edit(int id)
        {

            var pessoa = _context.Pessoa.Where(p => p.IdPessoa == id).FirstOrDefault();


            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }


        [HttpPost]
        public IActionResult Edit(Pessoa pessoa)
        {



            _context.Pessoa.Update(pessoa);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var pessoa = _context.Pessoa.Where(p => p.IdPessoa == id).FirstOrDefault();
            return View(pessoa); ;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var pessoa = _context.Pessoa.Where(p => p.IdPessoa == id).FirstOrDefault();

            return View(pessoa); ;
        }

        [HttpPost]
        public IActionResult Delete(Pessoa pessoa)
        {
            var pessoaDel = _context.Pessoa.Where(p => p.IdPessoa == pessoa.IdPessoa).FirstOrDefault();

            _context.Pessoa.Remove(pessoaDel);

            _context.SaveChanges();


            return RedirectToAction("Compras");

        }
    }
}
