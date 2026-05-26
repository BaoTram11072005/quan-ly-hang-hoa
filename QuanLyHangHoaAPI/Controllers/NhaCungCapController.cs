using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyHangHoaAPI.Data;
using QuanLyHangHoaAPI.Models;

namespace QuanLyHangHoaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NhaCungCapController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NhaCungCapController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.NhaCungCaps.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create(NhaCungCap ncc)
        {
            _context.NhaCungCaps.Add(ncc);

            await _context.SaveChangesAsync();

            return Ok(ncc);
        }
    }
}