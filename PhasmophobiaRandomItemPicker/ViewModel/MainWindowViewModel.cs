using PhasmophobiaRandomItemPicker.Logic;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhasmophobiaRandomItemPicker.ViewModel
{
    public class MainWindowViewModel : ReactiveObject
    {
        public List<PlayerViewViewModel> PlayerViewVMs { get; set; }

        public MainWindowViewModel()
        {
            PlayerViewVMs = new List<PlayerViewViewModel>
            {
                new PlayerViewViewModel(),
                new PlayerViewViewModel(),
                new PlayerViewViewModel(),
                new PlayerViewViewModel()
            };
        }

        private void RollItems()
        {
            var picker = new ItemPicker();
        }
    }
}
