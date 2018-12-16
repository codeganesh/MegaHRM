using MegaHRM.Admin.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MegaHRM.Admin.Data.Context
{
    public class MegaHrmAdminContext : IdentityDbContext<MegaHrmUser,MegaHrmRole,int>
    {
        public MegaHrmAdminContext(DbContextOptions<MegaHrmAdminContext> options)
            :base(options)
        {

        }
    }
}
