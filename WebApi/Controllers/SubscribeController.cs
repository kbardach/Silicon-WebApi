using Infrastructure.Contexts;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Attributes;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [UseApiKey]
    public class SubscribeController(ApiContext context) : ControllerBase
    {
        private readonly ApiContext _context = context;

        [HttpGet]
        public async Task<IActionResult> GetSubscribers()
        {
            return Ok(await _context.SubscribeEntities.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe (SubscribeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if(!await _context.SubscribeEntities.AnyAsync(x => x.Email == viewModel.Email))
                {
                    try
                    {
                        _context.SubscribeEntities.Add(SubscribeFactory.Create(viewModel));
                        await _context.SaveChangesAsync();
                        return Created("", null);
                    }
                    catch { }
                    return Problem();
                }
                return Conflict();
            }
            return BadRequest();
        }
    }
}
