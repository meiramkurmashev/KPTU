using KPTU.Models;
using System.Web.Mvc;

namespace KPTU.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Meiram()
        //{
        //    //Wagon wagons = new Wagon();
        //    ////wagons.Lee();
        //    //string www;
        //    //www = wagons.Name;
        //    ////Console.WriteLine(www);
        //    //Convert.ToUInt32(www);
        //    //ViewBag.www;
        //    ////ViewBag.wagons.www;
        //    //return View();
        //}

        WagonContext wagonContext = new WagonContext();
        Wagon wagons = new Wagon();

        public ActionResult Index()
        {

            return View();

        }
        public ActionResult Routes()
        {

            return View();

        }
        public ActionResult Directory()
        {

            return View();

        }
        public ActionResult Auth()
        {

            return View();

        }
        public ActionResult AuthComplete()
        {

            return View();

        }

    }
}