using Microsoft.EntityFrameworkCore;
using Repository.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.repositories
{
    public interface Icontext
    {
        DbSet<User> UserContext { get; set; }
        DbSet<Child> ChildsContext { get; set; }

          Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
