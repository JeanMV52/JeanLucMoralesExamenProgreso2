using JeanLucMoralesExamenProgreso2.Modelos;

namespace JeanLucMoralesExamenProgreso2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void btn_guardar_Clicked(object sender, EventArgs e)
        {
            MoralesJeanRecarga recarga = new MoralesJeanRecarga
            {
                Numero = Int32.Parse(MoralesJeanEditor_numero.Text),
                Nombre = MoralesJeanLucEditor_nombre.Text,
            };

        }

    }

}
