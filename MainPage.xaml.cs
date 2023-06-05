namespace ER_evaluacion2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Editor.Equals(count, 0);
        if (count == 0)
        {
            DisplayAlert("Confirmación", "Recarga Exitosa", "Aceptar");
        }
        else
        {
            DisplayAlert("Finaliza", "No se pudo hacer la recarga", "Cancelar");
        }
        SemanticScreenReader.Announce(Recarga.Text);
    }
}

