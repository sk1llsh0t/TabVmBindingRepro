using TabVmBindingRepro.ViewModels;

namespace TabVmBindingRepro;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        
        BindingContext = new MainViewModel();
    }
}