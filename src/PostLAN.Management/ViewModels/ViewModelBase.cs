using Reactive.Bindings;
using Reactive.Bindings.Disposables;

namespace PostLAN.Management.ViewModels
{
    public abstract class ViewModelBase
    {
        /// <summary>
        /// View のタイトルを定義します
        /// </summary>
        public ReactivePropertySlim<string> ViewTitle { get; } = new();

        /// <summary>
        /// ReactiveProperty 系のリソースコンテナ
        /// </summary>
        public CompositeDisposable Disposables { get; } = [];

        ~ViewModelBase()
        {
            Disposables.Dispose();
        }
    }
}
