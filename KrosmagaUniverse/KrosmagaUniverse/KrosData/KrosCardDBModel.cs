using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrosmagaUniverse.KrosData
{
    public class KrosCardDBModel
    {
        [PrimaryKey,Unique,NotNull,Column("Id")]
        public int Id { get; set; }
        [Column("CardType")]
        public string CardType { get; set; }
        [Column("CostAP")]
        public int CostAP { get; set; }
        [Column("Life")]
        public int Life { get; set; }
        [Column("Attack")]
        public int Attack { get; set; }
        [Column("MouvementPoint")]
        public int MovementPoint { get; set; }
        [Ignore]
        public List<uint> Families { get; set; }
        [Column("IsToken")]
        public bool IsToken { get; set; }
        [Column("Rarity")]
        public int Rarity { get; set; }
        [Column("GodType")]
        public uint GodType { get; set; }
        [Column("Image")]
        public string Image { get; set; }
        [Column("Extension")]
        public int Extension { get; set; }
        [Ignore]
        public List<uint> LinkedCards { get; set; }

      
    }
}
