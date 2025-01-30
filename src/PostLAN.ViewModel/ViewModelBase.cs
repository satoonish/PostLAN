using Reactive.Bindings.Disposables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLAN.ViewModel
{
    public abstract class ViewModelBase : IDisposable
    {
        public readonly CompositeDisposable _disposables = [];

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}
