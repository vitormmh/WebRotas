using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebRotas.Models;

namespace WebRotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> todasAsNoticias;

        public HomeController()
        {
            todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(m=>m.Data);

        }

        public ActionResult Index()
        {
            var ultimasNoticias = todasAsNoticias.Take(3);
            var todasAsCategorias = todasAsNoticias.Select(m =>m.Categoria).Distinct().ToList();
            ViewBag.Categorias = todasAsCategorias; //viewbag para passar as categorias para a view
            // passar tambem as ultimas noticias para a view

            return View(ultimasNoticias);
        }

        public ActionResult TodasAsNoticias()
        {
            return View(todasAsNoticias);
        }

        //porquê os parametros categoria e titulo se só vamos passa noticiaId ?
        //porque vamos necessitar de passar categoria e titulo para fazer a nossa URL amigavel - (ver rotas) 
        public ActionResult MostraNoticia(int noticiaId, string categoria, string titulo)
        {
            
            return View(todasAsNoticias.FirstOrDefault(n=>n.NoticiaId==noticiaId));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(c => c.Categoria == categoria).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaEspecifica);
        }
    }
}