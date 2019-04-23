using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_s03.Models;
using Vidly_s03.ViewModels;

namespace Vidly_s03.Controllers
{
    public class CustomersController : Controller
    {

        //need a DBContext to access a database, this needs to be initialized in the constructor
        //NOTE: this is a disposable object
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //we also need to properly dispose of the dbcontext
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Customers
        public ActionResult Index()
        {
            //customers property is a dbset we define in our dbcontext
            //NOTE: addition of toList() executes query

            //To load customers and their membership tyes together use Include
            var customers = _context.customers.Include(c => c.MembershipType).ToList();
            //at this point, enitity framework does not usualy query the db, but it will in this case
            //due to the addition of ToList
            

            //the db is queried only when we iterate the customers object: this is called defered execution
     
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        //for forms

        //to add new customer
        public ActionResult New()
        {
            /*In order to display the membership types in the New view the approach commented out below
             * will present a problem because later when we implement editing customer because there
             * we also need to pass a customer object to the view so best way is to implement a View Model
             */
            //var membershipTypes = _context.membershipTypes.ToList();
            //return View(membershipTypes);

            //ViewModel Approach
            var membershipTypes = _context.membershipTypes.ToList();

            var newCustomerViewModel = new CustomerFormViewModel
            {
                //We give a new customer so that we have default values. Id will be 0
                //we have hidden field in customerForm view. if we do not give a new customer here
                //an error msg "id cannot be empty" will show in validation summary
                Customer = new Customer(), 
                MembershipTypes = membershipTypes
            };

            //we overide mvc convetnoion to specify CustomerForm as the View
            return View("CustomerForm", newCustomerViewModel);
        }

        /*//input is customer not ViewModel. mvc will still bind data because all the 
        //fields are prefixed with 'Customer' in view even though we have ViewModel in view
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            //first we need to add this data to dbcontext. which means it will be saved in memory
            //not in db yet
            _context.customers.Add(customer);
            //this will persist the changes
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        } NO LONGER BEING USED IN VIEW. WE WILL JUST DEFINE SAVE FOR CREATING AND UPDATING*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {

            if (!ModelState.IsValid) //similar to if form.is_Valid on django
            {
                //we send back to CustomerForm View
                var customerformViewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.membershipTypes.ToList()
                };

                return View("CustomerForm", customerformViewModel);
            }


            //if the id is = 0  then this is a new customer
            //NOTE: WE ADDED ID AS HIDDEN FIELD IN FORM
            if (customer.Id == 0)
            {
                _context.customers.Add(customer);
            } else
            {
                var customerInDb = _context.customers.SingleOrDefault(c => c.Id == customer.Id);
                //2 ways to update models

                //1
                //TryUpdateModel(customerInDb); can cause security holes in application
                //because maybe we do not want to update ALL PROPERTIES in customer due to permission
                //levels. malicious user can add his own key value pairs

                //can do TryUpdateModel(customerInDb, new String[] {"Name", "Birthdate"});
                //to specify which properties get updated. but what if one day we decide to change Name to
                //name. MAny hole

                //2 better way
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;



            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            //first we get the cistomer with this id
            var customer = _context.customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            var customerformViewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.membershipTypes.ToList()
            };

            //must overide default mvc convention to send this data to New View. Otherwise
            //mvc will look for a view called Edit since that is the name of this Action
            return View("CustomerForm", customerformViewModel);
        }


    }
}