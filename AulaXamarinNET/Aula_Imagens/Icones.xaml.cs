using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AulaXamarinNET.Aula_Imagens
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Icones : ContentPage
	{
		public Icones ()
		{
           
			InitializeComponent ();
            
            btn.Image = (Device.RuntimePlatform == Device.iOS) ? "clock.png" 
                : (Device.RuntimePlatform == Device.Android) ? "clock.png" 
                : (Device.RuntimePlatform == Device.WinPhone) ? "Images/clock.png"
                : null;
		}
	}
}