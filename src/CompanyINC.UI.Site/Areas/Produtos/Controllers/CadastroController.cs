﻿using Microsoft.AspNetCore.Mvc;

namespace CompanyINC.UI.Site.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
