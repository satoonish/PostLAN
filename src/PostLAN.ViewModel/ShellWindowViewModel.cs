using CommunityToolkit.Mvvm.Input;
using Kamishibai;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLAN.ViewModel
{
    [Navigate]
    public class ShellWindowViewModel
    {
        private readonly IPresentationService _presentationService;
        
        public ShellWindowViewModel(IPresentationService presentationService)
        {
            _presentationService = presentationService;

            GoBackCommand = new(OnGoBack, CanGoBack);
        }

        public AsyncRelayCommand GoBackCommand { get; }

        private bool CanGoBack()
            => _presentationService.CanGoBack();

        private Task OnGoBack()
            => _presentationService.GoBackAsync();

        private void NavigateTo(Type? targetViewModel)
        {
            if (targetViewModel is not null)
            {
                _presentationService.NavigateAsync(targetViewModel);
            }
        }
    }
}
