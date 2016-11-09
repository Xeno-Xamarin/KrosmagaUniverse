using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrosmagaUniverse.Models
{
    [ImplementPropertyChanged]
    public class CardModernModel
    {
      
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description { get; set; }

        private string imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }



        public int PA { get; set; }
        public int ATQ { get; set; }
        public int PV { get; set; }
        public int PM { get; set; }

        public string NameToUpper { get { return Name.ToUpper(); } }
    }
}
