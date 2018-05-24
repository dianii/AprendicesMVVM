
namespace AprendicesMVVM.View
{
    using AprendicesMVVM.Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xamarin.Forms;

    public partial class DetalleAprendiz:ContentPage
    {
        public DetalleAprendiz(Aprendiz aprendizSeleccionado) {
            InitializeComponent();
            this.BindingContext = aprendizSeleccionado;
        }
    }
}
