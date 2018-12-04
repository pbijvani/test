using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public void OnOptionsDrawerOpen(object sender, EventArgs e)
        {
            //optionsDrawer.IsOpen = !optionsDrawer.IsOpen;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<int> list = new List<int>() { 1, 2, 3 };
            listView.ItemsSource = list;

        }

    }
}
