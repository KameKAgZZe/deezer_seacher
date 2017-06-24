using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using prkt.Classes;
using prkt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Xml.Serialization;
using unirest_net.http;

namespace prkt.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {

            //XDocument xdoc;
            //xdoc = XDocument.Load("http://msiter.ru/sites/default/files/msiter_files/cd_catalog.xml");

            //var q = FromXml(xdoc);
            //return View(q);
            return View();

        }
        public ActionResult DeezerSearch(string nick)
        {
            HttpResponse<string> response = Unirest.get("https://deezerdevs-deezer.p.mashape.com/search?q="+ nick)
.header("X-Mashape-Key", "ejWTgwZXAlmshfC6wOWKifd9Am2Lp1OrhYkjsnfOF0oNRh1L9f")
.header("Accept", "text/plain")
.asString();
            var JsonQuote = JsonConvert.DeserializeObject<TrackObject>(response.Body);
            ViewBag.response =JsonQuote.data;
            ViewBag.total = JsonQuote.total;
           return PartialView("result");
        }
        public ActionResult AlbumSearch(int id)
        {
            HttpResponse<string> response = Unirest.get("https://deezerdevs-deezer.p.mashape.com/album/"+id)
.header("X-Mashape-Key", "ejWTgwZXAlmshfC6wOWKifd9Am2Lp1OrhYkjsnfOF0oNRh1L9f")
.header("Accept", "text/plain")
.asString();
            var JsonQuote = JsonConvert.DeserializeObject<AlbumObject>(response.Body);
            ViewBag.response = JsonQuote;
            ViewBag.genres = JsonQuote.genres.data;
            ViewBag.tracks = JsonQuote.tracks.data;
            return PartialView("albumsearch");
        }
        private Models.CATALOG FromXml(XDocument xd)
        {

            XmlSerializer s = new XmlSerializer(typeof(CATALOG));
            return (CATALOG)s.Deserialize(xd.CreateReader());
        }
    }
}
