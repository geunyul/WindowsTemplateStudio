﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace RootNamespace.Services
{
    public class NavigationService
    {
        private static readonly NavigationService _instance = new NavigationService();
        public static NavigationService Instance
        {
            get => _instance;
        }

        private Frame _frame;

        private NavigationService()
        {
            _frame = Window.Current.Content as Frame;
        }        

        public void SetNavigationFrame(Frame frame) => _frame = frame;

        public bool CanGoBack => _frame.CanGoBack;
        public bool CanGoForward => _frame.CanGoForward;

        public void GoBack() => _frame.GoBack();
        public void GoForward() => _frame.GoForward();

        public bool Navigate<T>() where T : Page => _frame.Navigate(typeof(T));
        public bool Navigate<T>(object parameter) where T : Page => _frame.Navigate(typeof(T), parameter);
        public bool Navigate<T>(object parameter, NavigationTransitionInfo infoOverride) where T : Page => _frame.Navigate(typeof(T), parameter, infoOverride);

        public bool Navigate(Type pageType) => _frame.Navigate(pageType);
        public bool Navigate(Type pageType, object parameter) => _frame.Navigate(pageType, parameter);
        public bool Navigate(Type pageType, object parameter, NavigationTransitionInfo infoOverride) => _frame.Navigate(pageType, parameter, infoOverride);
    }
}