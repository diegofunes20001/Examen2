using Examen2.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Examen2.ViewModels
{
	public class EcuacionCuadradaViewModel : INotifyPropertyChanged
	{
		private EcuacionCuadradaModel _model;
		public EcuacionCuadradaViewModel()
		{
			_model = new EcuacionCuadradaModel();
		}

		public double A
		{
			get => _model.A;
			set
			{
				_model.A = value;
				OnPropertyChanged(nameof(A));
				OnPropertyChanged(nameof(IsValid));
			}
		}

		public double B
		{
			get => _model.B;
			set
			{
				_model.B = value;
				OnPropertyChanged(nameof(B));
				OnPropertyChanged(nameof(IsValid));
			}
		}

		public double C
		{
			get => _model.C;
			set
			{
				_model.C = value;
				OnPropertyChanged(nameof(C));
				OnPropertyChanged(nameof(IsValid));
			}
		}

		public double X1
		{
			get => _model.X1;
			set => _model.X1 = value;
		}

		public double X2
		{
			get => _model.X2;
			set => _model.X2 = value;
		}

		public bool IsValid => _model.IsValid;
		public string ErrorMessage => _model.ErrorMessage;

		public ICommand CalculateCommand => new Command(Calculate);
		public ICommand ClearCommand => new Command(Clear);

		private void Calculate()
		{
			if (IsValid)
			{
				var discriminante = B * B - 4 * A * C;
				X1 = (-B + Math.Sqrt(discriminante)) / (2 * A);
				X2 = (-B - Math.Sqrt(discriminante)) / (2 * A);
			}
		}

		private void Clear()
		{
			A = 0;
			B = 0;
			C = 0;
			X1 = 0;
			X2 = 0;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
