﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IAB330assignment
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyList : ContentPage
	{
		public MyList ()
		{
			InitializeComponent();

            //setting up things to show
            listView.ItemsSource = new List<modelMyList>
            {
                //making dummie files to view
                //all of that is based from file named: "modelMyList.cs"
                new modelMyList {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/1", Price="40$"},
                 new modelMyList {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/2", Price = "50$"},
                 new modelMyList {Name = "Nike", ImageUrl ="http://lorempixel.com/100/100/people/3", Price ="60$"},
            };
        }
	}
}