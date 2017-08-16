using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace identityFromEmpty.Controllers
{
    public class HomeController : Controller
    {
        private IdentityDbContext db=new IdentityDbContext();
        // GET: Home
        public async Task<ActionResult> Index()
        {
            var context=new IdentityDbContext<IdentityUser>("EntityFrameworkIdentityContext");    
            //var context=new IdentityDbContext<IdentityUser>();
            var store=new UserStore<IdentityUser>(context);
            var manager=new UserManager<IdentityUser>(store);
            var email = "gaoxin.huang@gmail.com";
            var password = "Passw0rd";
            var user = await manager.FindByEmailAsync(email);
            if (user==null)
            {
                user=new IdentityUser()
                {
                    UserName  =email,
                    Email = email
                };
                await manager.CreateAsync(user, password);
            }
            return View();

        }
    }
}