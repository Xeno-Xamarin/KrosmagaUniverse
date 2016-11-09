using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrosmagaUniverse.KrosData
{
    public class KrosCardText
    {
        public uint CardId { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }

        public uint idLanguage { get; set; }

        public override string ToString()
        {
            return "=====" + "id=" + CardId + "=====" + '\n' +
                    "Nom =" + Name + '\n' +
                    "Desc =" + Descr + '\n' +
                    "================" + '\n'
                ;
        }
    }
}
