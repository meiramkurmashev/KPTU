using KPTU.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace KPTU.Controllers
{
    public class RoutesController : Controller
    {
        public ActionResult Index()
        {


            ////извлечение данных из таблицы Wagons
            //IEnumerable<Wagon> wagons = wagonContext.Wagons;
            //ViewBag.Wagons = wagons; 
            Wagon wagons = new Wagon();
            //wagons.Lee();
            List<Loading> listp = new List<Loading>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            wagons.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;

            //ViewBag.wagons.www;
            return View();

        }

        public ActionResult Add()
        {
            RouteTypes routeTypes = new RouteTypes();
            List<Two> listRourtes = new List<Two>();
            routeTypes.Name(ref listRourtes);
            ViewBag.listRoutes = listRourtes;

            Turntables turntables = new Turntables();
            List<Two> listTurntables = new List<Two>();
            turntables.Name(ref listTurntables);
            ViewBag.listTurntables = listTurntables;

            RailwayStations stations = new RailwayStations();
            List<Three> listStations = new List<Three>();
            stations.Name(ref listStations);
            ViewBag.listStations = listStations;

            RailwayStations roads = new RailwayStations();
            List<Two> listRoads = new List<Two>();
            roads.Roads(ref listRoads);
            ViewBag.listRoads = listRoads;

            Consumers consumers = new Consumers();
            List<FiveForConsumers> listConsumers = new List<FiveForConsumers>();
            consumers.Name(ref listConsumers);
            ViewBag.listConsumers = listConsumers;



            return View();


        }
        public ActionResult Complete(decimal id, DateTime date1, string type, string vert, string codest, string coderote, string potreb, string codepotreb, DateTime timepr, DateTime timedel, DateTime timeclose)
        {

            Wagon wagons = new Wagon();
            wagons.Load(id, date1, type, vert, codest, coderote, potreb, codepotreb, timepr, timedel, timeclose);
            //ViewBag.Id = id;
            //ViewBag.Id = id;

            return View();

        }

        public ActionResult Change(decimal id, string date1, string type, string vert, string codest, string coderote, string potreb, string codepotreb, DateTime timepr, DateTime timedel, DateTime timeclose, string type_name, string vert_name, string codest_name, string coderote_name, string potreb_name)
        {
            RouteTypes routeTypes = new RouteTypes();
            List<Two> listRourtes = new List<Two>();
            routeTypes.Name(ref listRourtes);
            ViewBag.listRoutes = listRourtes;

            Turntables turntables = new Turntables();
            List<Two> listTurntables = new List<Two>();
            turntables.Name(ref listTurntables);
            ViewBag.listTurntables = listTurntables;

            RailwayStations stations = new RailwayStations();
            List<Three> listStations = new List<Three>();
            stations.Name(ref listStations);
            ViewBag.listStations = listStations;

            RailwayStations roads = new RailwayStations();
            List<Two> listRoads = new List<Two>();
            roads.Roads(ref listRoads);
            ViewBag.listRoads = listRoads;

            Consumers consumers = new Consumers();
            List<FiveForConsumers> listConsumers = new List<FiveForConsumers>();
            consumers.Name(ref listConsumers);
            ViewBag.listConsumers = listConsumers;



            Wagon wagons = new Wagon();

            //wagons.Load(id);
            ViewBag.Id = id;
            string day = date1.ToString();



            //ViewBag.Date1 = date1;
            ViewBag.Date1 = date1;

            ViewBag.Type = type;
            ViewBag.Vert = vert;
            ViewBag.Codest = codest;
            ViewBag.Coderote = coderote;
            ViewBag.Potreb = potreb;
            ViewBag.Codepotreb = codepotreb;
            ViewBag.Timepr = timepr.ToString("HH:mm");
            ViewBag.Timedel = timedel.ToString("HH:mm");
            ViewBag.Timeclose = timeclose.ToString("HH:mm");
            ViewBag.TypeName = type_name;
            ViewBag.VertName = vert_name;
            ViewBag.CodestName = codest_name;
            ViewBag.CoderoteName = coderote_name;
            ViewBag.PotrebName = potreb_name;
            //ViewBag.Id = id;

            return View();

        }
        public ActionResult ChangeSave(decimal id, DateTime date1, string type, string vert, string codest, string coderote, string potreb, string codepotreb, DateTime timepr, DateTime timedel, DateTime timeclose)
        {

            Wagon wagons = new Wagon();

            wagons.Change(id, date1, type, vert, codest, coderote, potreb, codepotreb, timepr, timedel, timeclose);
            //ViewBag.Id = id;
            //ViewBag.Date1 = date1;
            //ViewBag.Date1.ToString("dd.MM.yyyy hh24:mi:ss");
            //ViewBag.Type = type;
            //ViewBag.Vert = vert;
            //ViewBag.Codest = codest;
            //ViewBag.Coderote = coderote;
            //ViewBag.Potreb = potreb;
            //ViewBag.Codepotreb = codepotreb;
            //ViewBag.Timepr = timepr;
            //ViewBag.Timedel = timedel;
            //ViewBag.Timeclose = timeclose;
            //ViewBag.Id = id;

            return View();

        }
        public ActionResult Delete(decimal id)
        {
            Wagon wagonDelete = new Wagon();
            wagonDelete.Delete(id);
            return View();

        }

        public ActionResult DeleteSave(decimal id)
        {
            ViewBag.Id = id;
            return View();

        }
        public ActionResult Search(DateTime dateTo, DateTime dateFrom)
        {
            dateTo.ToString("yyyy-MM-dd");
            dateFrom.ToString("yyyy-MM-dd");
            ViewBag.DateTo = dateTo.ToString("yyyy-MM-dd");
            ViewBag.DateFrom = dateFrom.ToString("yyyy-MM-dd");
            ////извлечение данных из таблицы Wagons

            //IEnumerable<Wagon> wagons = wagonContext.Wagons;
            //ViewBag.Wagons = wagons; 
            Wagon wagons = new Wagon();
            //wagons.Lee();
            List<Loading> listp = new List<Loading>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            wagons.Name2(ref listp, dateFrom, dateTo);
            //listp.Capacity = 1;
            ViewBag.a = listp;

            //ViewBag.wagons.www;
            return View();

        }
        public ActionResult SearchForNumber(int number)
        {

            ViewBag.number = number;
            //  ViewBag.DateFrom = dateFrom.ToString("yyyy-MM-dd");
            ////извлечение данных из таблицы Wagons

            //IEnumerable<Wagon> wagons = wagonContext.Wagons;
            //ViewBag.Wagons = wagons; 
            Wagon wagons = new Wagon();
            //wagons.Lee();
            List<Loading> listp = new List<Loading>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            wagons.Name3(ref listp, number);
            //listp.Capacity = 1;
            ViewBag.a = listp;

            //ViewBag.wagons.www;
            return View();

        }


        public ActionResult Archive()
        {


            ////извлечение данных из таблицы Wagons
            //IEnumerable<Wagon> wagons = wagonContext.Wagons;
            //ViewBag.Wagons = wagons; 
            Wagon wagons = new Wagon();
            //wagons.Lee();
            List<Loading> listp = new List<Loading>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            wagons.Archive(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;

            //ViewBag.wagons.www;
            return View();

        }
    }

}