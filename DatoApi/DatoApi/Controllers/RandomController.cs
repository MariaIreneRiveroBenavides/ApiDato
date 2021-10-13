﻿using DatoApi.Data;
using DatoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        private readonly AppDbContext _context;
        public RandomController(AppDbContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Dato>> GetDato() 
        {
            var list = await _context.Datos.ToListAsync();

            var max = list.Count;
            int index = new Random().Next(0, max);

            var dato = list[index];

            if(dato == null) 
            {
                return NoContent();
            }
            return dato;
        }
    }
}
