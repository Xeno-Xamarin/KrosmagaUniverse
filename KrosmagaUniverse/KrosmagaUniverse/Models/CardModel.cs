using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrosmagaUniverse.Models
{
    [ImplementPropertyChanged]
    public class CardModel 
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string NameToUpper { get { return Name.ToUpper(); } }
    }
}
