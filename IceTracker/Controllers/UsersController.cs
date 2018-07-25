﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IceTracker.Models;


namespace IceTracker.Controllers
{
    public class UsersController : Controller
    {

        [HttpGet("/users/sign-up")]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost("/users/sign-up")]
        public IActionResult CreateAccountForm(string firstName, string lastName, string phoneNumber)
        {
            User newUser = new User(firstName, lastName, phoneNumber);
            newUser.SaveUser();
            return View("Login");
        }

        [HttpGet("/users/login")]
        public IActionResult Login()
        {
            return View();  
    
        }


        [HttpPost("/users/login")]
        public IActionResult AccountLogin(string phoneNumber)
        {
            User newUser = IceTracker.Models.User.FindAUser(phoneNumber);
            if(newUser.Id == 0)
            {
                return View("CreateAccount");
            }
            return RedirectToAction("UserAccount", new { id = newUser.Id });
        }
        [HttpGet("/users/{id}")]
        public IActionResult UserAccount(int id)
        {
            User newUser = IceTracker.Models.User.FindAUserById(id);
            return View(newUser);
        }
    }
}