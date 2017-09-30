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
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1 ()
        {
            InitializeComponent();
            AddPage(new AddItem(), "Add Item");
            AddPage(new MyList(), "My List");
            AddPage(new Recent(), "Recent");
            AddPage(new Search(), "Search");
        }

        public void AddPage(Page pageObj, String title, String icon="") {
            var page = pageObj;
            page.Icon = icon;
            page.Title = title;
            Children.Add(page);
        }
    }
}