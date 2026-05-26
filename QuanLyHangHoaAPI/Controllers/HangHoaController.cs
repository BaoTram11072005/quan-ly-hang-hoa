using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyHangHoaAPI.Data;
using QuanLyHangHoaAPI.Models;

namespace QuanLyHangHoaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HangHoaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HangHoaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ds = await _context.HangHoas.ToListAsync();
            return Ok(ds);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var hangHoa = await _context.HangHoas.FindAsync(id);

            if (hangHoa == null)
                return NotFound();

            return Ok(hangHoa);
        }

        [HttpPost]
        public async Task<IActionResult> Create(HangHoa hangHoa)
        {
            _context.HangHoas.Add(hangHoa);
            await _context.SaveChangesAsync();

            return Ok(hangHoa);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, HangHoa hangHoa)
        {
            if (id != hangHoa.MaHang)
                return BadRequest();

            _context.Entry(hangHoa).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Ok(hangHoa);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var hangHoa = await _context.HangHoas.FindAsync(id);

            if (hangHoa == null)
                return NotFound();

            _context.HangHoas.Remove(hangHoa);

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}