using HW4.Data;
using HW4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace HW4.Controllers
{
    public class VehicleController : Controller
    {
        private VehicleDBContext _context; // variable that will hold a reference to the DBContext

        public VehicleController(VehicleDBContext context) //connects to database
        {
            _context = context;
        }

        public IActionResult Index()//read operation, it will list the vehicles
        {
            var Vehicleslist = _context.Vehicles.ToList();//ToList fetches a list of vehicles from the books table under the database

            return View(Vehicleslist);
        }

        [HttpGet]//optional
        public IActionResult Create() //http get request
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Vehicle VehicleObj) //http post //Overloaded method //need to bring in namespace
        {

            _context.Vehicles.Add(VehicleObj); //adds the object to be added
            _context.SaveChanges(); //runs all the pending commands

            return RedirectToAction("Index", "Vehicle");

        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            //fetch the book from the books table

            Vehicle myVehicle = _context.Vehicles.Find(id);

            return View(myVehicle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("VehicleID, Mileage, DateReceived, DateSold, VehicleStatus, VIN, Make, Model, Year")] Vehicle myVehicle)
        {
            if (ModelState.IsValid)
            {
                //save changes to the database

                _context.Vehicles.Update(myVehicle);
                _context.SaveChanges(true);
            }
            return RedirectToAction("Index", "Vehicle");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var myVehicle = _context.Vehicles.Find(id);

            return View(myVehicle);

        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var myVehicle = _context.Vehicles.Find(id);

            if (myVehicle != null)
                _context.Vehicles.Remove(myVehicle);

            _context.SaveChanges();

            return RedirectToAction("Index");



        }

    }
}
