using Microsoft.Maui.Controls;

namespace MyFirstMAUIApp.View;

public partial class ControlsStepperMenu : ContentPage
{
    private Stepper? _stepper;
    private Label? _rotatingLabel;
    private Label? _displayLabel;

    public ControlsStepperMenu()
    {
        InitializeComponent();

        // Resolve controls at runtime (safe if XAML does not create fields)
        _stepper = this.FindByName<Stepper>("stepper");
        _rotatingLabel = this.FindByName<Label>("RotatingLabel");
        _displayLabel = this.FindByName<Label>("DisplayLabel");

        if (_stepper != null)
        {
            _stepper.ValueChanged += OnStepperValueChanged;
            UpdateUI(_stepper.Value);
        }
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (_stepper != null)
            _stepper.ValueChanged -= OnStepperValueChanged;
    }

    private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateUI(e.NewValue);
    }

    private void UpdateUI(double value)
    {
        if (_rotatingLabel != null)
            _rotatingLabel.Rotation = value;

        if (_displayLabel != null)
            _displayLabel.Text = $"The Stepper value is {value:F0}";
    }
}