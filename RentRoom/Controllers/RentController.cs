﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentRoom.Classes;
using RentRoom.Context;
using RentRoom.Models;

namespace RentRoom.Controllers
{
    public class RentController : Controller
    {
        private readonly IdentityContext _context;

        public RentController(IdentityContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           

         return View();
        }
        [HttpPost]
        public IActionResult RentRoomChangeWeek( string selecedWeek, string selecedRoom)
        {
            int temp = Int32.Parse(selecedWeek);
            DateTimeManage myDateTimeManage = new DateTimeManage();
            ComJson myData = new ComJson();
            string[] tempTeble = myDateTimeManage.FourWeeksTable(temp - 1);
            RoomDescriptionModel myRoomDescriptionModel = new RoomDescriptionModel();
            
            if (!string.IsNullOrEmpty(selecedRoom))
            {
                var myRoom = _context.RoomDescriptionModels.Where(x => x.NameOfRoom == selecedRoom)
                    .Select(i => i.Id).ToArray();

                var myRents = _context.RoomRent.Where(x => x.RoomDescriptionModelId == myRoom[0]).ToList();

                for (int i = 0; i < myRents.Count; i++)
                {
                    string tempDate = myRents[i].DateOfEvent;

                    for (int ii = 0; ii < tempTeble.Length; ii++)
                    {
                        if (tempTeble[ii] == tempDate)
                        {
                            tempTeble[ii] = tempTeble[ii] + " " + myRents[i].HourOfBeginEvent;
                        }

                    }
                }
            }


            for (int i = 0; i < 7; i++)
            {
                myData.dataTable[i] = tempTeble[i];
            }

            myData.HourPeriod = new string[] { "10", "18" };

            return Json(myData);
        }

        [HttpPost]
        public IActionResult RentRoomReservationTerms(string term, string room)
        {

            RoomRentModel myRentModel = new RoomRentModel();



            var myRoom = _context.RoomDescriptionModels.Where(x => x.NameOfRoom == room)
                .Select(i => i.Id).ToArray();
            var myRents = _context.RoomRent.Where(x => x.RoomDescriptionModelId == myRoom[0]).ToList();

            string[] dateFromViev = term.Split();

            int temp = Int32.Parse(dateFromViev[1]);
         

            var temp2 = HttpContext.User.Identity.Name;

            var temp3 = _context.UserModels.Where(x => x.UserName == temp2)
                .Select(i => i.CustomersID).ToArray();

            var isItFree = _context.RoomRent.Where(x => x.DateOfEvent == dateFromViev[0])
                .Where(d => d.HourOfBeginEvent == dateFromViev[1]).ToList();
            if (isItFree.Count == 0)
            {
             temp = temp + 1;
            myRentModel.StateOfReservation = "New";
            myRentModel.DateOfEvent = dateFromViev[0];
            myRentModel.HourOfBeginEvent = dateFromViev[1];
            myRentModel.HourOfEndEvent = temp.ToString();
            myRentModel.CreatedByUser = HttpContext.User.Identity.Name;
            myRentModel.CreatedByChanel = "Internet";
            myRentModel.CreatedDate = DateTime.Now.ToString("d");
            myRentModel.NameOfEvent = "Cos Tam";
            myRentModel.CustomersId = temp3[0] ;
            myRentModel.RoomDescriptionModelId = myRoom[0];
            myRentModel.OwnerOfEvent = HttpContext.User.Identity.Name;


            _context.Add(myRentModel);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                
            }

            }
            else
            {

            }
            return View();
        }

        [HttpPost]
        public IActionResult RentRoomTerm(string room)
        {
            ComJson myData = new ComJson();
            DateTimeManage myDateTimeManage = new DateTimeManage();
            string[] tempTeble = myDateTimeManage.FourWeeksTable(0);
            string temp = "";
            var myRents = new List<RoomRentModel>();
            
            
            if (!string.IsNullOrEmpty(room))
            {
                var myRoom = _context.RoomDescriptionModels.Where(x => x.NameOfRoom == room)
                    .Select(i => i.Id).ToArray();

                 myRents = _context.RoomRent.Where(x => x.RoomDescriptionModelId == myRoom[0]).ToList();

                for (int i = 0 ; i < myRents.Count; i++)
                {
                    string sTemp = myRents[i].DateOfEvent + " " + myRents[i].HourOfBeginEvent;
                    myData.ReservTerms.Add(sTemp);
                }

            }

            


            for (int i = 0; i < 7; i++)
            {
                myData.dataTable[i] = tempTeble[i];
            }
            
            myData.HourPeriod = new string[] { "10", "18" };

            return Json(myData);
        }

        [HttpPost]
        public IActionResult RentRoomTermSelectListData()
        {
            var listFromDataBase = _context.RoomDescriptionModels.ToList();

            var listOfRooms = new List<string>();

            for (int i = 0; i < listFromDataBase.Count; i++)
            {
                string name = listFromDataBase[i].NameOfRoom;
                listOfRooms.Add(name);

            }

            return Json(listOfRooms);
        }


    }
}