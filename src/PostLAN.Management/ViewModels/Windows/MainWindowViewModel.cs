using CommunityToolkit.Mvvm.Input;
using ModernWpf.Controls;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System.ComponentModel;
using System.Windows.Input;

namespace PostLAN.Management.ViewModels.Windows
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IPresentationService _presentationService;

        /// <summary>
        /// ナビゲーションメニューの選択項目が変更された際のコマンド
        /// </summary>
        public ReactiveCommand<NavigationViewSelectionChangedEventArgs> SelectionChangedCommand { get; }
            = new();

        /// <summary>
        /// 画面が読み込まれた際のコマンド
        /// </summary>
        public ReactiveCommand LoadedCommand { get; } = new();

        /// <summary>
        /// デザイナー用
        /// </summary>
        public MainWindowViewModel() {}

        public MainWindowViewModel(IPresentationService presentationService)
        {
            _presentationService = presentationService;

            SelectionChangedCommand
                .Subscribe(ExeSelectionChangedCommand)
                .AddTo(Disposables);
            LoadedCommand
                .Subscribe(ExeLoadedCommand)
                .AddTo(Disposables);
        }

        private void ExeSelectionChangedCommand(NavigationViewSelectionChangedEventArgs args)
        {
            switch (args.SelectedItemContainer.Tag)
            {
                case "DashBoard":
                    _presentationService.NavigateToDashboardAsync();
                    break;
                case "Address":
                    _presentationService.NavigateToAddressPageAsync();
                    break;
                case "Settings":
                    _presentationService.NavigateToSettingsPageAsync();
                    break;
            }
        }

        private void ExeLoadedCommand()
        {
            _presentationService.NavigateToDashboardAsync();
        }
    }
}
