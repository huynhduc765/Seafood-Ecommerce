using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopHaiSan.Controllers
{
    
    public class DefaultController : Controller
    {
        // GET: Default
        ShopHaiSanOnlineEntities db = new ShopHaiSanOnlineEntities();
        public ActionResult TrangChu()
        {
            return View();
        }
        public ActionResult getMenu()
        {
            var v = from t in db.MENUs
                    select t;
            return PartialView(v.ToList());
        }
    }
}