using CommunityToolkit.Mvvm.ComponentModel;

namespace Examen2.Models
{
	public partial class EcuacionCuadradaModel : ObservableObject
	{
		
		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }
		public double X1 { get; set; }
		public double X2 { get; set; }

		public bool IsValid => A != 0 && (B * B - 4 * A * C) >= 0;
		public string ErrorMessage => IsValid ? string.Empty : "Error: Valor de A no puede ser 0 o el resultado dentro de la raíz cuadrada es negativa";
	}
}
