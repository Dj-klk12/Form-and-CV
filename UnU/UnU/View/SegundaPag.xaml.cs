using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace generarcv.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UnicaPag : ContentPage
    {
        public UnicaPag(string nombre, string apellido, string direcc, string correo, string contacto, string expe1, string expe2, string expe3, string ingles, string educacion, string aptitud1, string aptitud2, string aptitud3, string descripcion)
        {
            InitializeComponent();
            LabelNombreComp.Text = "Frank Eduardo Calcina Arias";
            direc.Text = "Actualmente vivo en --> Arequipa-Paucarpata " ;
            corr.Text = "Puedes enviarme un correo --> frank.calcina@ucsp.edu.pe" ;
            numero.Text = "Mi WhatsApp es --> 999 999 898" + " suelo responder rápido";
            Experiencia1.Text = "♦ Google ";
            Experiencia2.Text = "♦ BCP " ;
            Experiencia3.Text = "♦ Interbank " ;
            Ingles.Text = "Mi nivel de inglés es --> Intermedio " ;
            edu.Text = "SUPERIOR UCSP CS";
            Ap1.Text = "♦ Liderazgo" ;
            Ap2.Text = "♦ Proactividad" ;
            Ap3.Text = "♦ Organización" ;
            Desc.Text = "Bueno en lo que hago y trabajo en grupo";
        }
    }
}
