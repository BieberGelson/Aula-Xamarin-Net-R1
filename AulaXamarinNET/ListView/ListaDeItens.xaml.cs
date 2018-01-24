using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AulaXamarinNET.ListView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaDeItens : ContentPage
	{
        private ObservableCollection<GrupoDeContatos> _contatos;
		public ListaDeItens ()
		{
			InitializeComponent ();
            _contatos = new ObservableCollection<GrupoDeContatos>
            {
                new GrupoDeContatos("Ge", "Ge"){
                    new Contato { Name = "Gelson", Status = "Pai", ImageUrl = "http://lorempixel.com/100/100/people/1" }, },

                new GrupoDeContatos("Ga", "Ga") {
                    new Contato{ Name = "Gabatha", Status = "Mae", ImageUrl = "http://lorempixel.com/100/100/people/2"},
                    new Contato{ Name = "Gaianna", Status = "Filha", ImageUrl = "http://lorempixel.com/100/100/people/4"}},

                new GrupoDeContatos("Gui", "Gui"){
                    new Contato{ Name = "Guidyanne", Status = "Filha", ImageUrl = "http://lorempixel.com/100/100/people/3"}}
             

            };
            listview.ItemsSource = _contatos;
            
		}
        void Call_Clicked(object sender, System.EventArgs e)
        {
            var menuitem = sender as MenuItem;
            var contato = menuitem.CommandParameter as Contato;
            DisplayAlert("Call", contato.Name, "OK");
        }
        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var contato = (sender as MenuItem).CommandParameter as Contato;
            for(int i = 0; i < _contatos.Count(); i++)
            {
                for(int j = 0; j < _contatos[i].Count; j++)
                {
                    if(_contatos[i][j].Name == contato.Name)
                    {
                        _contatos[i].Remove(contato);
                    }
                }
               
            }
        }
    }
}