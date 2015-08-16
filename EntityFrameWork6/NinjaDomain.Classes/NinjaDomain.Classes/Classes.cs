using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace NinjaDomain.Classes
{
    public class Ninja
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool ServedInOniwaban { get; set; }
        public Clan Clan { get; set; }
        public int ClanID { get; set; }
        public List<NinjaEquipment> EquipmentOwned { get; set; }
        public System.DateTime DateOfBirth { get; set; }
    }

    public class Clan
    {
        public int ID { get; set; }
        public string ClanName { get; set; }
        public List<Ninja> Ninjas { get; set; }
    }

    public class NinjaEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        [Required]
        public Ninja Ninja { get; set; }
    }
    
}
