using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrosmagaUniverse.KrosData
{
    public class KrosCard
    {
        [PrimaryKey]
        public uint Id { get; set; }
         
        public string CardType { get; set; }
         
        public int CostAP { get; set; }
         
        public int Life { get; set; }
         
        public int Attack { get; set; }
         
        public int MovementPoint { get; set; }
        [Ignore]
        public List<uint> Families { get; set; }
         
        public bool IsToken { get; set; }
         
        public uint Rarity { get; set; }
         
        public uint GodType { get; set; }
        public string Image { get; set; }
         
        public uint Extension { get; set; }
        [Ignore]
        public List<uint> LinkedCards { get; set; }

        public override string ToString()
        {
            return "=====" + "id=" + Id + "=====" + '\n' +
                    "Type =" + CardType + '\n' +
                    "PA =" + CostAP + '\n' +
                    "Atq =" + Attack + '\n' +
                    "PV =" + Life + '\n' +
                    "PM =" + MovementPoint + '\n' +
                    "================" + '\n'
                ;
        }
    }
}
