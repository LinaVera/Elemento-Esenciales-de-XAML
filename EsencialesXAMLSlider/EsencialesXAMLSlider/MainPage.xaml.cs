using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EsencialesXAMLSlider
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        string[] Frases = new string[] { "Hay dos maneras de vivir la vida: una como si nada fuese un milagro, la otra como si todo fuese un milagro. \n -Albert Einstein",
            "¿Amas la vida? Pues no desperdicies el tiempo, porque es la sustancia de la que está hecha.\n -Benjamín Franklin",
            "Si das pescado a un hombre hambriento lo nutrirás durante una jornada. Si le enseñas a pescar, le nutrirás toda su vida. \n-Lao-Tsé",
        "El éxito no se mide en el dinero, sino en la diferencia que marca en las personas.\n -Michelle Obama"};
        int cont = 0;
        public MainPage()
        {
            InitializeComponent();
            lFrase.Text = Frases[0];
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lFrase.FontSize = e.NewValue;
            lTamaño.Text = String.Format("Font size: {0}", slider.Value);

        }

        private void Sig_Clicked(object sender, EventArgs e)
        {
            cont++;
            if (cont>=Frases.Length) {
                cont = 0;
            }
            lFrase.Text = Frases[cont];
        }
    }
}
