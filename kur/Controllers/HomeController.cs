using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace kur.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            XmlTextReader oku = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlDocument dok = new XmlDocument();
            dok.Load(oku);
            XmlNode xdollar = dok.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='US DOLLAR']");
            XmlNode xeuro = dok.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='EURO']");
            XmlNode xsterling = dok.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='POUND STERLING']");


            double dolar = double.Parse(xdollar.ChildNodes[4].InnerText);
            double euro = double.Parse(xeuro.ChildNodes[4].InnerText);
            double sterling = double.Parse(xsterling.ChildNodes[4].InnerText);



            ViewData["dolar"] = dolar;
            ViewData["euro"] = euro;
            ViewData["sterling"] = sterling;


        /*    List<kılas>
            kurlar = new List<kılas>
                {
                
                new kılas { ID=1, Adi = "USD" },
                new kılas { ID=2, Adi = "EURO" },
                new kılas { ID=3, Adi = "Sterling" }

                };
           
           ViewBag.kurlar = new SelectList(kurlar, "ID", "Adi");
            return View();*/
            List<SelectListItem> elemanlar = new List<SelectListItem>() // SelectListItem içeren bir liste oluşturduk
        {
            // Oluşan listeye elemanlar ekledik
            new SelectListItem {Text = "Seç", Value = "0", Selected = true}, // "Seç" isimli eleman varsayılan olarak seçili gelecek
            new SelectListItem {Text = "USD", Value = "1"},
            new SelectListItem {Text = "EURO", Value = "2"},
            new SelectListItem {Text = "Sterling", Value = "3"},
        };
            ViewBag.ListItem = elemanlar; // Elemanlar nesnesini ListItem isimli bir  ViewBag' e atadık.
            return View();
        }
        public ActionResult Goster()
        {
           

            return View();
        }


        
    }
}
