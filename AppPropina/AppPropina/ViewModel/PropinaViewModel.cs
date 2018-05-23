

namespace AppPropina.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Model;
    using Xamarin.Forms;

    public   class PropinaViewModel
    {
        #region propiedades

        public Propina PropinaModel { get; set; }
        public Command CalcularCommand { get; set; }
        #endregion

        public PropinaViewModel()
        {
            PropinaModel = new Propina();
            CalcularCommand = new Command(Calcular);
        }

        private void Calcular(object obj)
        {


            PropinaModel.PropinaTotal = (PropinaModel.Total * PropinaModel.PorcentajePropina) / 100;
            PropinaModel.TotalCuenta = PropinaModel.Total + PropinaModel.PropinaTotal;
            PropinaModel.PropinaPorPersona = PropinaModel.PropinaTotal / PropinaModel.Personas;
            PropinaModel.TotalPersonas = PropinaModel.Total / PropinaModel.Personas;
            
           

          
        }
    }
}
