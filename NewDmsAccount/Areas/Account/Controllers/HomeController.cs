using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDmsAccount.Areas.Account.Controllers
{
    [Area("Account")]
    public class HomeController :Controller
    {
        public IActionResult Index()
        {
            return View();
        }   
    }
}
