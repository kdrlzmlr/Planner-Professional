using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Planner_Professional.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;


        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            Text.Trim();
            Items.Add(Text);    
            Text = string.Empty;
        }

        [RelayCommand]
        void Remove(string s)
        {
            if (Items.Contains(s))
                Items.Remove(s);
        }
    }
}
