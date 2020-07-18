using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using fullstack_gregslist.Models;
using fullstack_gregslist.Services;

namespace fullstack_gregslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _hs;
        public HousesController(HousesService hs)
        {
            _hs = hs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<House>> GetAll()
        {
            try
            {
                return Ok(_hs.GetAll());
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("user")]
        [Authorize]
        public ActionResult<IEnumerable<House>> GetHousesByUser()
        {
            try
            {
                string userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                return Ok(_hs.GetByUserId(userId));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<House> GetById(int id)
        {
            try
            {
                return Ok(_hs.GetById(id));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult<House> Create([FromBody] House newHouse)
        {
            try
            {
                newHouse.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                return Ok(_hs.Create(newHouse));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        public ActionResult<House> Edit(int id, [FromBody] House houseToUpdate)
        {
            try
            {
                houseToUpdate.Id = id;
                string userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                return Ok(_hs.Edit(houseToUpdate, userId));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                string userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                return Ok(_hs.Delete(id, userId));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }    
    }
}