using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

using Web.Models;

namespace Web.Identity
{
    public class AppUser : IdentityUser
    {
        public NguoiDung nguoiDung { get; set; }
    }
}