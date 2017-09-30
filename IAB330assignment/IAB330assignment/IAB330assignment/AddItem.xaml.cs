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
	public partial class AddItem : ContentPage
	{
		public AddItem ()
		{
			InitializeComponent ();
            //image, should be chancged after
            upload.Source = ImageSource.FromResource("UI.images.upload");
        }

        //upload button with all variables that are needed for the back end
        void uploadItem(object sender, System.EventArgs e)
        {
            var nameValue = productName.Text;
            var priceValue = productPrice.Text;
            var categoryValue = productCategory.Text;
            var locationValue = productLocation.Text;

            throw new NotImplementedException();
        }
    }
}