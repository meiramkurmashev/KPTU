using KPTU.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace KPTU.Controllers
{
    public class DirectoryController : Controller
    {
        // GET: Directory
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SingOfTr()
        {
            SingOfTr singOfTr = new SingOfTr();

            List<Two> listp = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            singOfTr.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            return View();

        }
        public ActionResult SingOfTrChange(decimal id)
        {
            SingOfTr singOfTrChange = new SingOfTr();
            //coalGradesChange.Get()
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;

            //ViewBag.Id = coalGradesChange.Change;
            //coalGradesChange.Change(id);
            //ViewBag.Name = coalGradesChange.Change(id).number1;

            List<Two> listp = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            singOfTrChange.Change(ref listp, id);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            ViewBag.id = id;
            return View();
        }

        [HttpGet]
        public ActionResult SingOfTrChangeSave(decimal id, string name)
        {
            SingOfTr singOfTrChangeSave = new SingOfTr();

            singOfTrChangeSave.ChangeSave(id, name);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult SingOfTrDelete(decimal id)
        {
            SingOfTr singOfTrDelete = new SingOfTr();
            singOfTrDelete.Delete(id);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult SingOfTrCreate()
        {


            return View();
        }
        public ActionResult SingOfTrLoad(decimal id, string name)
        {
            SingOfTr singOfTrCreate = new SingOfTr();
            singOfTrCreate.Load(id, name);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult CoalSupplier()
        {
            CoalSupplier coalSupplier = new CoalSupplier();

            List<FiveForCoalSupplier> listp = new List<FiveForCoalSupplier>();
            List<Nine> listn1 = new List<Nine>();
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            coalSupplier.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            CoalGrades coalGrades = new CoalGrades();
            coalGrades.Name(ref listn1);
            ViewBag.b = listn1;

            //16.05 делаю sql для вывода НАИМЕНОВАНИЙ поставщиков и марок по КОДу
            return View();
        }
        public ActionResult CoalSupplierChange(decimal kod_post, decimal km)
        {
            CoalSupplier coalSupplierChange = new CoalSupplier();
            //coalGradesChange.Get()
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;

            //ViewBag.Id = coalGradesChange.Change;
            //coalGradesChange.Change(id);
            //ViewBag.Name = coalGradesChange.Change(id).number1;

            List<Seven> listp = new List<Seven>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            coalSupplierChange.Change(ref listp, kod_post, km);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            ViewBag.kod_post = kod_post;
            ViewBag.km = km;
            return View();
        }
        [HttpGet]
        public ActionResult CoalSupplierChangeSave(decimal kod_post, decimal km, decimal zola, decimal vlaga, decimal sera)
        {
            CoalSupplier coalSupplierChangeSave = new CoalSupplier();
            //ViewBag.Ssylka = "Html.ActionLink(\"Удалить\", \"CoalGradesDelete\", \"Directory\", new { id = ViewBag.id }, null)}";
            coalSupplierChangeSave.ChangeSave(kod_post, km, zola, vlaga, sera);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult CoalSupplierDelete(decimal kod_post, decimal km)
        {
            CoalSupplier coalSupplierDelete = new CoalSupplier();
            coalSupplierDelete.Delete(kod_post, km);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult CoalSupplierCreate()
        {
            List<Two> listp = new List<Two>();

            CoalSupplier coalSupplierCreate = new CoalSupplier();


            coalSupplierCreate.Create(ref listp);
            ViewBag.Suppliers = listp;

            List<Nine> listp1 = new List<Nine>();

            CoalGrades coalGrades = new CoalGrades();


            coalGrades.Name(ref listp1);
            ViewBag.Coals = listp1;
            return View();
        }
        public ActionResult CoalSupplierLoad(decimal kod_post, decimal km, decimal zola, decimal vlaga, decimal sera)
        {
            CoalSupplier coalSupplierLoad = new CoalSupplier();
            coalSupplierLoad.Load(kod_post, km, zola, vlaga, sera);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult RouteTypes()
        {
            RouteTypes routeTypes = new RouteTypes();

            List<Two> listp = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            routeTypes.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            return View();
        }

        public ActionResult RouteTypesChange(decimal id)
        {
            RouteTypes routeTypesChange = new RouteTypes();
            //coalGradesChange.Get()
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;

            //ViewBag.Id = coalGradesChange.Change;
            //coalGradesChange.Change(id);
            //ViewBag.Name = coalGradesChange.Change(id).number1;

            List<Two> listp = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            routeTypesChange.Change(ref listp, id);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            ViewBag.id = id;
            return View();
        }
        [HttpGet]
        public ActionResult RouteTypesChangeSave(decimal id, string name)
        {
            RouteTypes routeTypesChangeSave = new RouteTypes();
            routeTypesChangeSave.ChangeSave(id, name);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult RouteTypesDelete(decimal id)
        {
            RouteTypes routeTypesDelete = new RouteTypes();
            routeTypesDelete.Delete(id);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult RouteTypesCreate()
        {




            return View();
        }
        public ActionResult RouteTypesLoad(decimal id, string name)
        {
            RouteTypes RouteTypesLoad = new RouteTypes();
            RouteTypesLoad.Load(id, name);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }

        public ActionResult Suppliers()
        {
            Suppliers suppliers = new Suppliers();

            List<Four> listp = new List<Four>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            suppliers.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            return View();
        }
        public ActionResult SuppliersChange(decimal id1)
        {
            Suppliers suppliersChange = new Suppliers();
            //coalGradesChange.Get()
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;

            //ViewBag.Id = coalGradesChange.Change;
            //coalGradesChange.Change(id);
            //ViewBag.Name = coalGradesChange.Change(id).number1;
            Suppliers railstations = new Suppliers();
            List<Two> listAt = new List<Two>();
            List<TenForSuppliers> listp = new List<TenForSuppliers>();



            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            suppliersChange.Change(ref listp, id1);
            railstations.Railstations(ref listAt);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            ViewBag.b = listAt;
            ViewBag.id = id1;
            return View();
        }
        [HttpGet]
        public ActionResult SuppliersChangeSave(decimal id1, string name, string name2, decimal id2, decimal id3, decimal id4, decimal id5, decimal id6, decimal id7)
        {
            Suppliers suppliersChangeSave = new Suppliers();

            suppliersChangeSave.ChangeSave(id1, id2, id3, id4, id5, id6, id7, name, name2);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult SuppliersDelete(decimal id1)
        {
            Suppliers suppliersDelete = new Suppliers();
            suppliersDelete.Delete(id1);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult SuppliersCreate()
        {
            Suppliers suppliersCreate = new Suppliers();
            List<Two> listAt = new List<Two>();
            suppliersCreate.Railstations(ref listAt);
            ViewBag.b = listAt;

            return View();
        }
        public ActionResult SuppliersLoad(decimal id1, decimal id2, decimal id3, decimal id4, decimal id5, decimal id6, decimal id7, string nm, string nme)
        {
            Suppliers suppliersLoad = new Suppliers();
            suppliersLoad.Load(id1, id2, id3, id4, id5, id6, id7, nm, nme);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult CoalGrades()
        {
            CoalGrades coalGrades = new CoalGrades();

            List<Nine> listp = new List<Nine>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            coalGrades.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;

            return View();
        }
        public ActionResult CoalGradesChange(decimal id)
        {
            CoalGrades coalGradesChange = new CoalGrades();
            //coalGradesChange.Get()
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;

            //ViewBag.Id = coalGradesChange.Change;
            //coalGradesChange.Change(id);
            //ViewBag.Name = coalGradesChange.Change(id).number1;

            List<Nine> listp = new List<Nine>();
            List<Two> listCT = new List<Two>();
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            coalGradesChange.Change(ref listp, id);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            ViewBag.id = id;
            CoalGrades coalTypes = new CoalGrades();
            coalTypes.CoalTypes(ref listCT);
            ViewBag.ct = listCT;

            return View();
        }
        [HttpGet]
        public ActionResult CoalGradesChangeSave(decimal id, string nm, string nme, decimal gr_km, decimal zola, decimal vlaga, decimal sera, decimal cena, string dt_c)
        {
            CoalGrades coalGradesChange = new CoalGrades();
            //ViewBag.Ssylka = "Html.ActionLink(\"Удалить\", \"CoalGradesDelete\", \"Directory\", new { id = ViewBag.id }, null)}";
            coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult CoalGradesDelete(decimal id)
        {
            CoalGrades coalGradesDelete = new CoalGrades();
            coalGradesDelete.Delete(id);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult CoalGradesCreate()
        {
            List<Two> listCT = new List<Two>();
            CoalGrades coalTypes = new CoalGrades();
            coalTypes.CoalTypes(ref listCT);
            ViewBag.ct = listCT;


            return View();
        }
        public ActionResult CoalGradesLoad(decimal id, string nm, string nme, decimal gr_km, decimal zola, decimal vlaga, decimal sera, decimal cena, DateTime dt_c)
        {
            CoalGrades coalGradesLoad = new CoalGrades();
            coalGradesLoad.Load(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult Consumers()
        {
            Consumers consumers = new Consumers();

            List<FiveForConsumers> listp = new List<FiveForConsumers>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            consumers.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            return View();
        }

        public ActionResult ConsumersChange(decimal id1)
        {
            Consumers consumersChange = new Consumers();
            //coalGradesChange.Get()
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;

            //ViewBag.Id = coalGradesChange.Change;
            //coalGradesChange.Change(id);
            //ViewBag.Name = coalGradesChange.Change(id).number1;

            List<ElevenForConsumers> listp = new List<ElevenForConsumers>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            consumersChange.Change(ref listp, id1);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            ViewBag.id = id1;
            RailwayStations stations = new RailwayStations();
            List<Three> listp1 = new List<Three>();
            stations.Name(ref listp1);
            ViewBag.c = listp1;
            ConsumerGroups groups = new ConsumerGroups();
            List<Two> listAt = new List<Two>();
            groups.Name(ref listAt);
            ViewBag.b = listAt;
            return View();

        }
        [HttpGet]
        public ActionResult ConsumersChangeSave(decimal id1, string name, string name2, decimal id2, decimal id3, decimal id4, decimal id5, decimal id6, string adres)
        {
            Consumers consumersChangeSave = new Consumers();

            consumersChangeSave.ChangeSave(id1, id2, id3, id4, id5, id6, adres, name, name2);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult ConsumersDelete(decimal id1)
        {
            Consumers consumersDelete = new Consumers();
            consumersDelete.Delete(id1);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult ConsumersCreate()
        {
            RailwayStations stations = new RailwayStations();
            List<Three> listp = new List<Three>();
            stations.Name(ref listp);
            ViewBag.aw = listp;
            ConsumerGroups groups = new ConsumerGroups();
            List<Two> listAt = new List<Two>();
            groups.Name(ref listAt);
            ViewBag.b = listAt;

            return View();
        }
        public ActionResult ConsumersLoad(decimal id1, decimal id2, decimal id3, decimal id4, decimal id5, decimal id6, string adres, string nm, string nme)
        {
            Consumers consumersLoad = new Consumers();
            consumersLoad.Load(id1, id2, id3, id4, id5, id6, adres, nm, nme);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult ConsumerGroups()
        {
            ConsumerGroups consumerGroups = new ConsumerGroups();

            List<Two> listp = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            consumerGroups.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            return View();
        }
        public ActionResult ConsumerGroupsChange(decimal id)
        {
            ConsumerGroups consumerGroupsChange = new ConsumerGroups();
            //coalGradesChange.Get()
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;

            //ViewBag.Id = coalGradesChange.Change;
            //coalGradesChange.Change(id);
            //ViewBag.Name = coalGradesChange.Change(id).number1;

            List<Two> listp = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            consumerGroupsChange.Change(ref listp, id);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            ViewBag.id = id;
            return View();
        }

        [HttpGet]
        public ActionResult ConsumerGroupsChangeSave(decimal id, string name)
        {
            ConsumerGroups consumerGroupsChangeSave = new ConsumerGroups();

            consumerGroupsChangeSave.ChangeSave(id, name);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult ConsumerGroupsDelete(decimal id)
        {
            ConsumerGroups consumerGroupsDelete = new ConsumerGroups();
            consumerGroupsDelete.Delete(id);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult ConsumerGroupsCreate()
        {


            return View();
        }
        public ActionResult ConsumerGroupsLoad(decimal id, string name)
        {
            ConsumerGroups consumerGroupsLoad = new ConsumerGroups();
            consumerGroupsLoad.Load(id, name);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult RailwayStations()
        {
            RailwayStations railwayStations = new RailwayStations();

            List<Three> listp = new List<Three>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            railwayStations.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            return View();
        }
        public ActionResult RailwayStationsChange(decimal id)
        {
            RailwayStations railroadsChange = new RailwayStations();
            RailwayStations roads = new RailwayStations();
            //coalGradesChange.Get()
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;

            //ViewBag.Id = coalGradesChange.Change;
            //coalGradesChange.Change(id);
            //ViewBag.Name = coalGradesChange.Change(id).number1;

            List<TenForRailwayStations> listp = new List<TenForRailwayStations>();
            List<Two> listAt = new List<Two>();
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);

            railroadsChange.Change(ref listp, id);

            roads.Roads(ref listAt);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            ViewBag.b = listAt;
            ViewBag.id = id;
            return View();
        }
        [HttpGet]
        public ActionResult RailwayStationsChangeSave(decimal id, string name, string nme, string nm_r, decimal kod_dor, decimal par, decimal rast, string prim, decimal kod_st_pog)
        {
            RailwayStations railwayStationsChangeSave = new RailwayStations();
            railwayStationsChangeSave.ChangeSave(id, name, nme, nm_r, kod_dor, par, rast, prim, kod_st_pog);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult RailwayStationsDelete(decimal id)
        {
            RailwayStations railwayStationsDelete = new RailwayStations();
            railwayStationsDelete.Delete(id);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult RailwayStationsCreate()
        {

            RailwayStations roads = new RailwayStations();
            List<Two> listAt = new List<Two>();
            roads.Roads(ref listAt);
            ViewBag.b = listAt;

            return View();
        }
        public ActionResult RailwayStationsLoad(decimal id, string name, string nme, string nm_r, decimal kod_dor, decimal par, decimal rast, string prim, decimal kod_st_pog)
        {


            RailwayStations railwayStationsLoad = new RailwayStations();
            railwayStationsLoad.Load(id, name, nme, nm_r, kod_dor, par, rast, prim, kod_st_pog);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;

            return View();
        }
        public ActionResult Railroads()
        {
            Railroads railroads = new Railroads();

            List<Three> listp = new List<Three>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            railroads.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            return View();
        }

        public ActionResult RailroadsChange(decimal id)
        {
            Railroads railroadsChange = new Railroads();
            //coalGradesChange.Get()
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;

            //ViewBag.Id = coalGradesChange.Change;
            //coalGradesChange.Change(id);
            //ViewBag.Name = coalGradesChange.Change(id).number1;

            List<Three> listp = new List<Three>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            railroadsChange.Change(ref listp, id);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            ViewBag.id = id;
            return View();
        }
        [HttpGet]
        public ActionResult RailroadsChangeSave(decimal id, string name, string about)
        {
            Railroads railroadsChangeSave = new Railroads();
            railroadsChangeSave.ChangeSave(id, name, about);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult RailroadsDelete(decimal id)
        {
            Railroads railroadsDelete = new Railroads();
            railroadsDelete.Delete(id);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult RailroadsCreate()
        {


            return View();
        }
        public ActionResult RailroadsLoad(decimal id, string name, string about)
        {
            Railroads railroadsLoad = new Railroads();
            railroadsLoad.Load(id, name, about);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }

        public ActionResult NegotiatedRate()
        {
            NegotiatedRate negotiatedRate = new NegotiatedRate();

            List<Two> listp = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            negotiatedRate.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            return View();
        }
        public ActionResult NegotiatedRateChange(decimal id)
        {
            NegotiatedRate negotiatedRateChange = new NegotiatedRate();
            //coalGradesChange.Get()
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;

            //ViewBag.Id = coalGradesChange.Change;
            //coalGradesChange.Change(id);
            //ViewBag.Name = coalGradesChange.Change(id).number1;

            List<Two> listp = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            negotiatedRateChange.Change(ref listp, id);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            ViewBag.id = id;
            return View();
        }
        [HttpGet]
        public ActionResult NegotiatedRateChangeSave(decimal id, string name)
        {
            NegotiatedRate negotiatedRateChangeSave = new NegotiatedRate();
            negotiatedRateChangeSave.ChangeSave(id, name);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult NegotiatedRateDelete(decimal id)
        {
            NegotiatedRate negotiatedRateDelete = new NegotiatedRate();
            negotiatedRateDelete.Delete(id);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult NegotiatedRateCreate()
        {


            return View();
        }
        public ActionResult NegotiatedRateLoad(decimal id, string name)
        {
            NegotiatedRate negotiatedRateLoad = new NegotiatedRate();
            negotiatedRateLoad.Load(id, name);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult Turntables()
        {
            Turntables turntables = new Turntables();

            List<Two> listp = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            turntables.Name(ref listp);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            return View();
        }
        public ActionResult TurntablesChange(decimal id)
        {
            Turntables turntablesChange = new Turntables();
            //coalGradesChange.Get()
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;

            //ViewBag.Id = coalGradesChange.Change;
            //coalGradesChange.Change(id);
            //ViewBag.Name = coalGradesChange.Change(id).number1;

            List<Two> listp = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            turntablesChange.Change(ref listp, id);
            //listp.Capacity = 1;
            ViewBag.a = listp;
            ViewBag.id = id;
            return View();
        }

        [HttpGet]
        public ActionResult TurntablesChangeSave(decimal id, string name)
        {
            Turntables turntablesChangeSave = new Turntables();

            turntablesChangeSave.ChangeSave(id, name);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult TurntablesDelete(decimal id)
        {
            Turntables turntablesDelete = new Turntables();
            turntablesDelete.Delete(id);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }
        public ActionResult TurntablesCreate()
        {


            return View();
        }
        public ActionResult TurntablesLoad(decimal id, string name)
        {
            Turntables turntablesLoad = new Turntables();
            turntablesLoad.Load(id, name);
            // coalGradesChange.ChangeSave(id, nm, nme, gr_km, zola, vlaga, sera, cena, dt_c);
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            //coalGradesChange.Name(ref listp);
            //listp.Capacity = 1;
            //ViewBag.a = listp;
            return View();
        }

    }
}