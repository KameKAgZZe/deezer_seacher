using prkt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace prkt.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        { 
            
                XDocument xdoc;
                xdoc = XDocument.Load("http://msiter.ru/sites/default/files/msiter_files/cd_catalog.xml");
                var q = FromXml(xdoc);
                return View(q);

        }

        private Models.CATALOG FromXml(XDocument xd)
        {

            XmlSerializer s = new XmlSerializer(typeof(CATALOG));
            return (CATALOG)s.Deserialize(xd.CreateReader());
        }
    }
}
