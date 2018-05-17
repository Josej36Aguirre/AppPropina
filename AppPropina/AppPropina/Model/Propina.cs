

namespace AppPropina.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ViewModel;
    public class Propina: Notificable
    {
        #region atributos
        private double total;
        private int personas;
        private double propinaTotal;
        private double totalPersonas;
        private double propinaPorPersona;
        private double porcentajePropina;
        private double totalCuenta;
        #endregion
        #region Propiedades
        public double TotalCuenta
        {
            get { return totalCuenta; }
            set
            {
                if (totalCuenta == value)
                {
                    return;
                }
                totalCuenta = value;
                OnPropertyChanged();
            }
        }


        public double PorcentajePropina
        {
            get { return porcentajePropina; }
            set
            {
                if (porcentajePropina == value)
                {
                    return;
                }
                porcentajePropina = value;
                OnPropertyChanged();
            }
        }


        public double PropinaPorPersona
        {
            get { return propinaPorPersona; }
            set
            {
                if (propinaPorPersona == value)
                {
                    return;
                }
                propinaPorPersona = value;
                OnPropertyChanged();
            }
        }


        public double TotalPersonas
        {
            get { return totalPersonas; }
            set
            {
                if (total == value)
                {
                    return;
                }
                totalPersonas = value;
                OnPropertyChanged();
            }
        }


        public double PropinaTotal
        {
            get { return propinaTotal; }
            set
            {
                if (propinaTotal == value)
                {
                    return;
                }
                propinaTotal = value;
                OnPropertyChanged();
            }

        }


        public int Personas
        {
            get { return personas; }
            set
            {
                if (personas == value)
                {
                    return;
                }
                personas = value;
                OnPropertyChanged();
            }
        }

        public double Total
        {
            get { return total; }
            set
            {
                if (total == value)
                {
                    return;
                }
                total = value;
                OnPropertyChanged();
            }
        }
        #endregion





    }
}
