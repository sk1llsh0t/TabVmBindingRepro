using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TabVmBindingRepro.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] 
    private int selectedViewModelIndex;
    
    [ObservableProperty] 
    private string pageTitle;
    
    [ObservableProperty] 
    private string tabATitle;
    
    [ObservableProperty] 
    private string tabBTitle;
    
    [ObservableProperty] 
    private string tabCTitle;

    [RelayCommand]
    public void TabAButton()
    {
        TabATitle = "Tab A button tapped!";
        PageTitle = TabATitle;
    }
    
    [RelayCommand]
    public void TabBButton()
    {
        TabBTitle = "Tab B button tapped!";
        PageTitle = TabBTitle;
    }
    
    [RelayCommand]
    public void TabCButton()
    {
        TabCTitle = "Tab C button tapped!";
        PageTitle = TabCTitle;
    }
}