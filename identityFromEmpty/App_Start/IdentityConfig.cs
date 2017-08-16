using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace identityFromEmpty.App_Start
{
    public class IdentityConfig
    {
        //IUser: interface 包: Microsoft.AspNet.Identity
        //IUserStore: User Store 包: Microsoft.AspNet.Identity
        //UserManager<IUser>: 用于 UserStore操作,增删改  包: Microsoft.AspNet.Identity
        //SignInManager<> 包:  Microsoft.AspNet.Identity.Owin;
        //-------------------------------------
        //IdentityUser 是从EF里出来的, 也可以自定义用户信息,   包: Microsoft.AspNet.Identity.EntityFramework; 
        //UserStore<IdentityUser> 也是从EF,一般都要配置DbContext。 包: using Microsoft.AspNet.Identity.EntityFramework;
        //IdentityDbContext<IdentityUser> 也是从EF, 一般都要配置DbContext。 包: using Microsoft.AspNet.Identity.EntityFramework;
    }
}