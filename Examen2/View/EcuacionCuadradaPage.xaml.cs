using Examen2.ViewModels;

namespace Examen2.View;

public partial class EcuacionCuadradaPage : ContentPage
{
	public EcuacionCuadradaPage()
	{
		InitializeComponent();
		BindingContext = new EcuacionCuadradaViewModel();
	}

}