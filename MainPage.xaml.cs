namespace Cambio;
/// <summary>
/// <CreateDate>28/06/2023</CreateDate>
/// <Company>SANDBOX</Company>
/// <Lastmodificationdate>28/06/2023</Lastmodificationdate>
/// <lastmodificationdescript>Se mandara a aimprimir el resultado en ujn label</lastmodificationdescript>
/// <lastmodificationautor>Ingrid Gabriel</lastmodificationautor>
/// </summary>

public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor de la clase
	/// </summary>

	public MainPage()
	{
		InitializeComponent();
	}
	/// <summary>
	/// En el evento del boton se calculara el dinero entregado por el cliente y el costo del articulo
	/// y se imprimira el resultado
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>

    private void Calcular_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(Costo.Text) ||(!string.IsNullOrEmpty(Dinero.Text)))
		{
			int CostoA, dinero, cambio;

			CostoA = Convert.ToInt32(Costo.Text);

			dinero= Convert.ToInt32(Dinero.Text);

			cambio= dinero-CostoA;
			 
			Cambio.Text = cambio.ToString();

		}
		else
		{
			DisplayAlert("ERROR", "Inserte datos", "OK");
		}
    }
}

