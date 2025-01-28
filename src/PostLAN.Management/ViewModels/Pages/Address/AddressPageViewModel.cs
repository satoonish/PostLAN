using Kamishibai;
using PostLAN.Management.Models.Address;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLAN.Management.ViewModels.Pages.Address
{
    [Navigate]
    public class AddressPageViewModel
    {
        public ReactiveCollection<AddressModel> AddressModel { get; } = [];
        public ReactivePropertySlim<AddressModel> SelectedAddressModel { get; } = new();

        public ReactivePropertySlim<string> InputName { get; } = new();
        public ReactivePropertySlim<string> InputIP { get; } = new();
        public ReactivePropertySlim<string> InputPort { get; } = new();

        public ReactiveCommandSlim RegistrationAddressCommand { get; } = new();
        public ReactiveCommandSlim DeleteAddressCommand { get; } = new();

        public AddressPageViewModel()
        {
            RegistrationAddressCommand.Subscribe(ExeRegistrationAddressCommand);
            DeleteAddressCommand.Subscribe(ExeDeleteAddressCommand);
        }

        private void ExeRegistrationAddressCommand()
        {
            var item = new AddressModel()
            {
                Name = InputName.Value,
                IP = InputIP.Value,
                Port = InputPort.Value
            };
            AddressModel.Add(item);

            InputName.Value = InputIP.Value = InputPort.Value = "";
        }

        private void ExeDeleteAddressCommand()
        {
            AddressModel.Remove(SelectedAddressModel.Value);
        }
    }
}
