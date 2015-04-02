using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using InfiniteScroll.Models;

namespace InfiniteScroll.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult ObterProdutos(int ultimoRegistro)
        {
            List<MarcaProdutoCategoria> produtos;
            using (var context = new EfDbContext())
            {
                produtos = context.Produtos
                    .OrderBy(p => p.Id)
                    .Skip((ultimoRegistro - 1)*10)
                    .Take(10).ToList();
            }


            return Json(new { Result = produtos }, JsonRequestBehavior.AllowGet);
        }
    }
}