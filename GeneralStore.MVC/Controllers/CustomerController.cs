﻿using GeneralStore.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralStore.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customerList = _db.Customers.ToList();
            List<Customer> orderedList = customerList.OrderBy(cust => cust.LastName).ToList();
            return View(orderedList);
        }

        //Get: Customer
        public ActionResult Create()
        {
            return View();
        }

        //Post: Customer
        [HttpPost]
        public ActionResult Create (Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Add(customer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        //Get: Delete
        //Customer/Delete/{id}




        //Post:Delete
        //Customer/Delete/{id}



        //Get:Edit
        //Customer/Edit/{id}



        //Post: Edit
        //Customer/Edit/{id}



        //Get: Details
        //Customer/Details/{id}



    }
}