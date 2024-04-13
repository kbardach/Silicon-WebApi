using Infrastructure.Contexts;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController(ApiContext context) : ControllerBase
    {

        private readonly ApiContext _context = context;

        [HttpPost]
        public async Task<IActionResult> Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var entity = ContactFactory.CreateContactEntity(model);
                    _context.Contact.Add(entity);
                    await _context.SaveChangesAsync();
                    return Ok();

                }
                catch { }
            }
            return BadRequest();
        }
    }
}