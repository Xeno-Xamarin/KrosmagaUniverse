using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;
using KrosmagaUniverse.Models;

namespace KrosmagaUniverse.PageModel
{
    public class DeckBuilderPageModel : FreshBasePageModel
    {
        public DeckBuilderPageModel()
        {

        }
        
        public ClassSelectionModel ClickedClass { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);
            if (initData != null)
            {
                ClickedClass = (ClassSelectionModel)initData;
            }
            else
            {
                ClickedClass = new ClassSelectionModel();
            }
        }
        

    }
}

