using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            WebApiSampleContext context = new WebApiSampleContext();
            List<AdminUser> adminUsers = context.AdminUser.ToList();

            return Ok(adminUsers);

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            WebApiSampleContext context = new WebApiSampleContext();
            var adminUser = context.AdminUser.FirstOrDefault(x => x.Id == id);

            if (adminUser == null)
            {
                return NotFound();
            }

            return Ok(adminUser);

        }
        [HttpPut("{id}")]
        public IActionResult Update(AdminUser adminUser)
        {
            WebApiSampleContext ctx = new WebApiSampleContext();
            AdminUser admin = ctx.AdminUser.FirstOrDefault(x => x.Id == adminUser.Id);
            if (admin == null)
            {
                return NotFound();
            }
            adminUser.Name = admin.Name;
            adminUser.SurName = admin.SurName;
            ctx.SaveChanges();
            return Ok(adminUser);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            WebApiSampleContext ctx = new WebApiSampleContext();
            AdminUser adminUser = ctx.AdminUser.Find(id);
            if (adminUser == null)
            {
                return NotFound();
            }

            adminUser.IsDeleted = false;
            ctx.SaveChanges();
            return Ok(adminUser);


        }
        [HttpPost]
        public IActionResult Add(AdminUser adminUser)
        {
            WebApiSampleContext context = new WebApiSampleContext();
            context.AdminUser.Add(adminUser);
            context.SaveChanges();
            return Ok(adminUser);


        }
    }
}
