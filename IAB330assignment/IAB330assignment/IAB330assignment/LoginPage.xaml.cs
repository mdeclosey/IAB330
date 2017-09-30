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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //logo
            image.Source = ImageSource.FromResource("UI.images.shopping.png");
            password.IsPassword = true;
        }

        void logUser(object sender, System.EventArgs e)
        {
            //THESE are the variables receiving input
            var userValue = username.Text;
            var passwordValue = password.Text;

            throw new NotImplementedException();
        }
    }
}