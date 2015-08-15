using NinjaDomain.Classes;
using System.Data.Entity;

namespace NinjaDomain.Datamodel
{
    public class NinjaContext:DbContext
    {
        public DbSet<NinjaDomain.Classes.Ninja> Ninjas { get; set; }
        public DbSet<NinjaDomain.Classes.Clan> Clans { get; set; }
        public DbSet<NinjaDomain.Classes.NinjaEquipment> Equipment { get; set; }
    }
}
