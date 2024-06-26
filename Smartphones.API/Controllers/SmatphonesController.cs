﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Smartphones.API.Dto;
using System;
using System.Reflection;

namespace Smartphone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartphonesController : ControllerBase
    {

        [HttpGet("All")]
        public IActionResult GetSmartphones()
        {
            //List of Smartphones
            var allSmartphones = new List<Smartphones.API.Models.Smartphone>()
            {
                new Smartphones.API.Models.Smartphone()
                {
                    Id = 1,
                    Brand = "First Smartphone",
                    LaunchingYear = DateTime.Now.AddYears(-20)
                },
                new Smartphones.API.Models.Smartphone()
                {
                    Id = 2,
                    Brand = "Second Smartphone",
                    LaunchingYear = DateTime.Now.AddYears(-20)
                },
            };

            return Ok(allSmartphones);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetSmartphoneById(int id)
        {
            var newSmartphone = new Smartphones.API.Models.Smartphone()
            {
                Id = 1,
                Brand = "First Smartphone",
                LaunchingYear = DateTime.Now.AddYears(-20)
            };

            return Ok(newSmartphone);
        }


        [HttpPost]
        public IActionResult AddNewSmartphone([FromBody] PostSmartphoneDto payload)
        {
            return Ok(payload);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateSmartphone([FromBody] PutSmartphoneDto payload, int id)
        {
            return Ok(payload);
        }


        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteSmartphone(int id)
        {
            return Ok();
        }

    }
}