﻿using E_Commerce_App_Practices_1.Data;
using E_Commerce_App_Practices_1.Data.Base;
using E_Commerce_App_Practices_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Commerce_App_Practices_1.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.getAllAsync();
            return View(allProducers);
        }


        // Get : Producers/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.getByIdAsync(id);
            if (producerDetails == null) return View("NotFound");

            return View(producerDetails);
        }



        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }


        // Get : Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.getByIdAsync(id);
            if (producerDetails == null) return View("NotFound");

            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, ProfilePictureURL, Bio")] Producer producer)
        {
            if(!ModelState.IsValid) return View(producer);

            if(id == producer.Id)
            {
                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }
    }
}
