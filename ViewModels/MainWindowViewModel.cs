using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PowerControlsInList.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<int> DimmingControls { get; private set; }

        public MainWindowViewModel()
        {
            this.DimmingControls = new ObservableCollection<int>(new List<int> { 50, 20, 70});
        }
    }
}
