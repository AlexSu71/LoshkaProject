using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using LoshkaWebApi.DTOModels.DTO;
using LoshkaDAL.Interfaces;
using LoshkaDAL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoshkaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController(IMapper mapper, IUnitRepository unitRepository, IUnitOfWork unitOfWork) : ControllerBase
    {
        private readonly IMapper _mapper = mapper;
        private readonly IUnitRepository _unitRepository = unitRepository;
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        // GET: api/<UnitsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var units = await _unitOfWork.UnitRepository.GetAllUnitsAsync();
            var unitsDto = _mapper.Map<List<UnitDto>>(units);
            return Ok(unitsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var unit = await _unitOfWork.UnitRepository.GetUnitByIdAsync(id);
            if (unit == null)
            {
                return NotFound();
            }
            var unitDto = _mapper.Map<UnitDto>(unit);
            return Ok(unitDto);
        }

        // POST api/<UnitsController>
        [HttpPost]
        public async Task<IActionResult> Post(string? UnitName, [FromBody] UnitDto unitDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unit = _mapper.Map<Unit>(unitDto);

            try
            {
                await _unitOfWork.UnitRepository.AddUnitAsync(UnitName, unit);
                await _unitOfWork.CompleteAsync();

                return CreatedAtAction(nameof(Get), new { unit.UnitID }, unitDto);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Произошла ошибка при сохранении единицы измерения: {ex.Message}");
            }
        }

        // PUT api/<UnitsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UnitDto unitDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unit = _mapper.Map<Unit>(unitDto);

            try
            {
                await _unitRepository.UpdateUnitByIdAsync(id, unit);
                await _unitOfWork.CompleteAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Произошла ошибка при обновлении единицы измерения: {ex.Message}");
            }
        }

        // DELETE api/<UnitsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var unit = await _unitOfWork.UnitRepository.GetUnitByIdAsync(id);
                if (unit == null)
                {
                    return NotFound($"Unit c ID {id} не найден.");
                }

                await _unitOfWork.UnitRepository.DeleteUnitByIdAsync(id);
                await _unitOfWork.CompleteAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Произошла ошибка при удалении единицы измерения: {ex.Message}");
            }
        }
    }
}
