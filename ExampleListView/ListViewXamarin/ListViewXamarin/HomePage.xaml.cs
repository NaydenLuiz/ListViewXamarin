using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListViewXamarin
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            //MainListView.ItemsSource = new List<string> {
            //    "Harry Potter",
            //    "Herminion",
            //    "Ron",
            //    "Moddy",
            //    "Malfoy"
            //};
            MainListView.ItemsSource = new List<Person> {
                new Person {Name="Harry",Age="19" },
                new Person {Name="Ron",Age="18" },
                new Person {Name="Herminione",Age="18" },
                new Person {Name="Malfoy",Age="18" },
                new Person {Name="Moddy",Age="40" },
                new Person {Name="Snape",Age="105" }

            };
        }
    }
}
