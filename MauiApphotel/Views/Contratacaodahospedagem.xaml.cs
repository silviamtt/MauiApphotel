namespace MauiApphotel.Views;

public partial class Contratacaodahospedagem : ContentPage
{
	public Contratacaodahospedagem()
	{
		InitializeComponent();
	}
    private async void Button_Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MauiApphotel.Views.Sobre());
    }


}