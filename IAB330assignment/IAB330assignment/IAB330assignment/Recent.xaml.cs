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
	public partial class Recent : ContentPage
	{
		public Recent ()
		{
			InitializeComponent();

            listRecent.ItemsSource = new List<RecentSearchModel>
            {
                //making dummie files to view
                //all of that is based from file named: "modelMyList.cs"
                new RecentSearchModel {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/1", Price="40$", Location ="check1"},
                 new RecentSearchModel  {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/2", Price = "50$", Location = "check2"},
                 new RecentSearchModel  {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/3", Price ="60$", Location = "check3"},
            };
        }
	}
}