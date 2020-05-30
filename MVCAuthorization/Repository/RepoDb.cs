using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthorization.Repository
{
    public class RepoDb
    {
        public USER GetUserDetails(string UserName,string Password)
        {
            USER user = new USER();
            using (UserDBContext _context = new UserDBContext()) {
                user  = _context.USERS.Where(u => u.UserName.ToLower() == UserName.ToLower() &&
                                  u.Password == Password).FirstOrDefault();
            }
            return user;
        }
    }
}