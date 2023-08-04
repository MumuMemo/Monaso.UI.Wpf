using DemoProject.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Windows.Input;

namespace DemoProject.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentView;
        public ViewModelBase CurrentView
        {
            get { return _currentView; }
            set { Set(ref _currentView, value); }
        }

        public ICommand ButtonPageCommand { get; private set; }
        public ICommand TextBoxPageCommand { get; private set; }
        public MainViewModel()
        {
            ButtonPageCommand = new RelayCommand(ButtonPageClick);
            TextBoxPageCommand = new RelayCommand(TextBoxPageClick);
        }

        private void TextBoxPageClick()
        {
            CurrentView = new TextBoxPageViewModel();
        }

        private void ButtonPageClick()
        {
            CurrentView = new ButtonPageViewModel();
        }
    }
}