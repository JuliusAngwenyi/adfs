using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;
using System.Web;

namespace JuliusA.MyFirstADFSWebApp.Models
{
    public class UserClaimsModel
    {
        public IEnumerable<Claim> Claims { get; set; }
    }
}