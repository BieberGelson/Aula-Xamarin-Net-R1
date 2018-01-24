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
	public partial class ImagensFromResource : ContentPage
	{
		public ImagensFromResource ()
		{
			InitializeComponent ();
            var layout = new Xamarin.Forms.StackLayout();
            var image = new Image();
            //Colocar o arquivo em uma pasta e em "Ação de Compilação" colocar "Recurso Inserido", seguir o padrão de nome conforme abaixo ad
            var imagesource = ImageSource.FromResource("AulaXamarinNET.ImagensDoProjeto.background.jpg");
            image.Source = imagesource;
            
            layout.Children.Add(image);
            Content = layout;
        }
	}
}