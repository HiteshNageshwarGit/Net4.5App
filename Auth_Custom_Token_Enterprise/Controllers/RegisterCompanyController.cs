﻿using Auth_Custom_Token_Enterprise.Filters;
using Auth_Custom_Token_Enterprise.Models;
using Auth_Custom_Token_Enterprise.Repository;
using System;
using System.Web.Mvc;

namespace Auth_Custom_Token_Enterprise.Controllers
{
    [ValidateSessionAttribute]
    public class RegisterCompanyController : Controller
    {
        IRegisterCompany _IRegister;
        public RegisterCompanyController()
        {
            _IRegister = new RegisterCompanyConcrete();
        }

        // GET: Register
        [HttpGet]
        public ActionResult Index()
        {
            var RegisterList = _IRegister.ListofCompanies(Convert.ToInt32(Session["UserID"]));
            return View(RegisterList);
        }

        // GET: Register/Create
        [HttpGet]
        public ActionResult Create()
        {
            var Company = _IRegister.CheckIsCompanyRegistered(Convert.ToInt32(Session["UserID"]));
            if (Company)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        // POST: Register/Create
        [HttpPost]
        public ActionResult Create(RegisterCompany RegisterCompany)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", RegisterCompany);
                }

                if (_IRegister.ValidateCompanyName(RegisterCompany))
                {
                    ModelState.AddModelError("", "Company is Already Registered");
                    return View("Create", RegisterCompany);
                }
                RegisterCompany.UserID = Convert.ToInt32(Session["UserID"]);
                RegisterCompany.CreateOn = DateTime.Now;
                _IRegister.Add(RegisterCompany);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

     
    }
}
