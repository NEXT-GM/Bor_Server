using Bor.DataAccess.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bor.DataAccess.DbContexts
{
    public class AlbinaContext : DbContext, IContext
    {
        public AlbinaContext(DbContextOptions<AlbinaContext> options) : base(options)
        {
        }
    }
}
