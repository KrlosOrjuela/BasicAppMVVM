using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FirstApp
{	
	public partial class HomePage : ContentPage
	{	
		public HomePage ()
		{
			InitializeComponent ();
			NavigationPage.SetBackButtonTitle(this, "");
		}

    }
}

