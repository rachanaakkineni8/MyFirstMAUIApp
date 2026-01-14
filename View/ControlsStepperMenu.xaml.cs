using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ControlsStepperMenu : ContentPage
{
	public ControlsStepperMenu()
	{
		InitializeComponent();
		BindingContext = new ControlsStepperViewModel();

		UpdateUI(stepper.Value);

	}

	private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
	{
		UpdateUI(e.NewValue);
	}

	private void UpdateUI(double value)
	{
		RotatingLabel.Rotation = value;
		DisplayLabel.Text = $"The Stepper value is {value:F0}";
	}
}