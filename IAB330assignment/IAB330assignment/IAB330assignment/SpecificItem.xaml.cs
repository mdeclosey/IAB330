using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IAB330assignment
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SpecificItem : ContentPage
	{
		public SpecificItem ()
		{
			InitializeComponent();
            product.Source = ImageSource.FromResource("UI.images.red.jpeg");
        }
	}
}