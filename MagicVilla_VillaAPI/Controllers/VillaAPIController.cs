using System;
using AutoMapper;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Controllers
{
    //[Route("api/controller")]，给控制器一个路由模版，所有控制器的方法将会继承这个路由的前缀
    [Route("api/VillaAPI")]
    [ApiController] //所有来自 api/VillaAPI 的请求将被路由到 VillaAPIController。
    public class VillaAPIController : ControllerBase
	{

        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public VillaAPIController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
		[HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        // GET api/VillaAPI 请求将被路由到 GetVillas 方法
        public async Task<ActionResult<IEnumerable<VillaDTO>>> GetVillas()
		{
            IEnumerable<Villa> villaList = await _db.Villas.ToListAsync();
            return Ok(_mapper.Map<List<VillaDTO>>(villaList));
		}

        [HttpGet("{id:int}", Name ="GetVilla")] //路由名称，用其引用路由 生成url
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200, Type = typeof(VillaDTO))]
        
        public async Task<ActionResult<VillaDTO>> GetVillas(int id)
        {
            // add some validations
            if(id == 0)
            {
               
                return BadRequest();
            }
            var villa = await _db.Villas.FirstOrDefaultAsync(u => u.Id == id);
            if(villa == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<VillaDTO>(villa));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<VillaDTO>> CreateVilla([FromBody] VillaCreateDTO createDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //unique name
            if (await _db.Villas.FirstOrDefaultAsync(u => u.Name.ToLower() == createDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Villa already Exists!");
                return BadRequest(ModelState);
            }
            if(createDTO == null)
            {
                return BadRequest(createDTO);
            }
            //if(villaDTO.Id > 0)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError);
            //}
                                    // output input
            Villa model = _mapper.Map<Villa>(createDTO);
            
            await _db.Villas.AddAsync(model);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetVilla", new { id = model.Id }, model);
        }

        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = await _db.Villas.FirstOrDefaultAsync(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            _db.Villas.Remove(villa);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)] 
        public async Task<IActionResult> UpdateVilla(int id, [FromBody] VillaUpdateDTO updateDTO)
        {
            if(updateDTO == null || id != updateDTO.Id)
            {
                return BadRequest();
            }

            Villa model = _mapper.Map<Villa>(updateDTO);
            //Villa model = new()
            //{
            //    Amenity = updateDTO.Amenity,
            //    Details = updateDTO.Details,
            //    Id = updateDTO.Id,
            //    ImageUrl = updateDTO.ImageUrl,
            //    Name = updateDTO.Name,
            //    Occupancy = updateDTO.Occupancy,
            //    Rate = updateDTO.Rate,
            //    Sqft = updateDTO.Sqft
            //};
            _db.Villas.Update(model);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            if(patchDTO == null || id == 0)
            {
                return BadRequest();
            }
            var villa = await _db.Villas.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);

            VillaUpdateDTO villaDTO = _mapper.Map<VillaUpdateDTO>(villa);
            
            if (villa == null)
            {
                return BadRequest();
            }
            patchDTO.ApplyTo(villaDTO, ModelState);
            Villa model = _mapper.Map<Villa>(villaDTO);

            _db.Villas.Update(model);
            await _db.SaveChangesAsync();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
       
    }
}

 