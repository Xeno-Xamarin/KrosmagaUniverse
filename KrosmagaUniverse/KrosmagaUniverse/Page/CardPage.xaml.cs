using KrosmagaUniverse.PageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;


namespace KrosmagaUniverse.Page
{
    public partial class CardPage : ContentPage
    {
        public CardPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = "Krosmaga Universe";
        }
    }
}
