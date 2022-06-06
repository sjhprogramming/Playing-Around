using Playing_Around.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Playing_Around.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}