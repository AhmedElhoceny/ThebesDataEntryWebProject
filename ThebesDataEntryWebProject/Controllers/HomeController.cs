using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ThebesDataEntryWebProject.Models;

namespace ThebesDataEntryWebProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonRepo PersonMethods;
        private readonly IHostingEnvironment hosting;
        private readonly ContextClass MYDB;
        public HomeController(PersonRepo PersonMethods, IHostingEnvironment hosting , ContextClass MYDB )
        {
            this.PersonMethods = PersonMethods;
            this.hosting = hosting;
            this.MYDB = MYDB;
        }
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SuccessPage()
        {
            return View();
        }
        public ActionResult FailPage()
        {
            return View();
        }
        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult ShowMore(int ID)
        {
            Person SearchedPerson = MYDB.Person.Find(ID);
            return View(SearchedPerson);
        }
        public ActionResult DeletePerson(int ID)
        {
            Person SearchedPerson = MYDB.Person.Find(ID);
            PersonMethods.RemovePerson(SearchedPerson.Person_Name);
            return RedirectToAction(nameof(ControllAction));
        }
        public ActionResult LogInPost(string Email , string Password)
        {
            if(Email == "ThebesAdmin@gmail.com" && Password == "Admin")
            {
                List<Person> ShowedData = PersonMethods.GetAllPersons();
                return RedirectToAction(nameof(ControllAction));
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }

            }
        public ActionResult ControllAction(string SearchedName)
        {
            if (SearchedName != null)
            {
                List<Person> Data =  MYDB.Person.Where(x => x.Person_Name == SearchedName).ToList();
                return View(Data);
            }
            else
            {
                List<Person> Data = PersonMethods.GetAllPersons();
                return View(Data);
            }
             
        }
        public ActionResult DataEntryPost(string Person_Name , string Person_Nationality , string Person_NationalID , string Person_Address , string Person_TelephoneNumber , string Person_PhoneNumber , string Person_Email , string Person_GraduationDate , string Person_Department , string Person_Division , string Person_Grad , string Person_PresentJob , IFormFile Person_CV)
        {
            try
            {
                if(MYDB.Person.Where(x => x.Person_NationalID == Person_NationalID).SingleOrDefault() != null){
                    return RedirectToAction(nameof(FailPage));
                }
                else
                {
                    if (Person_CV != null)
                    {
                        string upload1 = Path.Combine(hosting.WebRootPath, "CVs");
                        string fileName1 = Person_CV.FileName;
                        string FullPath1 = Path.Combine(upload1, Person_Name + fileName1);
                        Person_CV.CopyTo(new FileStream(FullPath1, FileMode.Create));
                        PersonMethods.AddPerson(new Person() { Person_Address = Person_Address, Person_CV_Destination = Person_CV.FileName, Person_Department = Person_Department, Person_Division = Person_Division, Person_Email = Person_Email, Person_Grad = Person_Grad, Person_GraduationDate = Person_GraduationDate, Person_Name = Person_Name, Person_NationalID = Person_NationalID, Person_Nationality = Person_Nationality, Person_PhoneNumber = Person_PhoneNumber, Person_PresentJob = Person_PresentJob, Person_TelephoneNumber = Person_TelephoneNumber });
                    }
                    else
                    {
                        PersonMethods.AddPerson(new Person() { Person_Address = Person_Address, Person_CV_Destination = null, Person_Department = Person_Department, Person_Division = Person_Division, Person_Email = Person_Email, Person_Grad = Person_Grad, Person_GraduationDate = Person_GraduationDate, Person_Name = Person_Name, Person_NationalID = Person_NationalID, Person_Nationality = Person_Nationality, Person_PhoneNumber = Person_PhoneNumber, Person_PresentJob = Person_PresentJob, Person_TelephoneNumber = Person_TelephoneNumber });
                    }
                    return RedirectToAction(nameof(SuccessPage));
                }
            }
            catch
            {
                return RedirectToAction(nameof(FailPage));
            }
        }

    }
}
