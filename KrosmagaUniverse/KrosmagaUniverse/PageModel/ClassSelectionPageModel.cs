using KrosmagaUniverse.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using FreshMvvm;

namespace KrosmagaUniverse.PageModel
{
    [ImplementPropertyChanged]
    public class ClassSelectionPageModel : FreshBasePageModel
    {
        private ClassSelectionModel _selectedClass;

        public List<ClassSelectionModel> ClassList { get; set; }

        public ClassSelectionPageModel()
        {
          
            //ItemTappedCommand = new BaseCommand((param) =>
            //{

            //    var item = LastTappedItem as ClassSelectionModel;
            //    if (item != null)
            //        System.Diagnostics.Debug.WriteLine("Tapped {0}", item.ClassName);

            //});
        }

        public override void Init(object initData)
        {
            base.Init(initData);
 
            var list = new List<ClassSelectionModel>();

            list = new List<ClassSelectionModel>();
            list.Add(new ClassSelectionModel {ClassName = "Crâ", ClassImgPath = "WPcra.png" });
            list.Add(new ClassSelectionModel {ClassName = "Ecaflip",  ClassImgPath = "WPecaflip.png" });
            list.Add(new ClassSelectionModel {ClassName = "Eniripsa",  ClassImgPath = "WPeniripsa.png" });
            list.Add(new ClassSelectionModel {ClassName = "Iop",  ClassImgPath = "WPiop.png" });
            list.Add(new ClassSelectionModel {ClassName = "Sacrieur",  ClassImgPath = "WPsacrieur.png" });
            list.Add(new ClassSelectionModel {ClassName = "Sadida",  ClassImgPath = "WPsadida.png" });
            list.Add(new ClassSelectionModel {ClassName = "Sram",  ClassImgPath = "WPsram.png" });
            list.Add(new ClassSelectionModel {ClassName = "Xélor",  ClassImgPath = "WPxelor.png" });

            ClassList = list;

        }


        public void FreeResources()
        {
            ClassList = null;
        }
        public ClassSelectionModel SelectedItem
        {
            get
            {
                return _selectedClass;
            }
            set
            {
                _selectedClass = value;

                if (_selectedClass == null)
                    return;

                SelectedItem = null;
            }
        }

        //public ICommand ItemTappedCommand
        //{
        //    get { return GetField<ICommand>(); }
        //    set { SetField(value); }
        //}
        //public object LastTappedItem
        //{
        //    get { return GetField<object>(); }
        //    set { SetField(value); }
        //}
    }
}
