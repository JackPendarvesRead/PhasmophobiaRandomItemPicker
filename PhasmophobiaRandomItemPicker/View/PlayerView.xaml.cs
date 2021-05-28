﻿using PhasmophobiaRandomItemPicker.ViewModel;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhasmophobiaRandomItemPicker.View
{
    /// <summary>
    /// Interaction logic for PlayerView.xaml
    /// </summary>
    public partial class PlayerView : ReactiveUserControl<PlayerViewViewModel>
    {
        public PlayerView()
        {
            InitializeComponent();
        }
    }
}
