using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ControlEntryVMPage : ContentPage
{
    public ControlEntryVMPage()
    {
        BindingContext = new ControlEntryVMViewModel();

        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (BindingContext is ControlEntryVMViewModel vm
            && query.TryGetValue("entryText", out var value)
            && value is string text)
        {
            vm.EntryText = text;
        }
    }
}