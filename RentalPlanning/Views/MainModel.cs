using System;
using System.Collections.Generic;
using System.Windows;
using Microsoft.UI.Xaml.Controls;
using RentalPlanning.Models;
using RentalPlanning.ViewContent;

namespace RentalPlanning.Views
{
    public partial class MainModel
    {
        private INavigator _navigator;
        public string? Title { get; }
        public Session Session { get; set; }

        public MainModel(
            IStringLocalizer localizer,
            IOptions<AppConfig> appInfo,
            INavigator navigator)
        {
            _navigator = navigator;
            Title = "Main";
            Title += $" - {localizer["ApplicationName"]}";
            Title += $" - {appInfo?.Value?.Environment}";
            Session = new Session();

        }

        public async Task GoToClient()
        {
            await _navigator.NavigateViewModelAsync<ClientModel>(this);
        }
        public async Task GoToEntryModel()
        {
            await _navigator.NavigateViewModelAsync<EntryModel>(this);
        }
    }
}