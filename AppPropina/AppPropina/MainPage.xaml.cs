using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPropina
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnCalcular.Clicked += BtnCalcular_Clicked;
		}

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            var total = decimal.Parse(entTotal.Text);
            var propina = int.Parse(entPropina.Text);
            var numPersonas = int.Parse(entPersonas.Text);
            var totalPropina = (total * (propina / 100));
            txtTotalPropina.Detail =totalPropina.ToString("C");

            txtTotalPropinaPersona.Detail = (totalPropina / numPersonas).ToString("C");
            txtTotalPersona.Detail = ((totalPropina + total)/numPersonas).ToString("C");
            txtTotal.Detail = (total + totalPropina).ToString("C");

        }
    }
}
