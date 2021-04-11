using System;
using System.Threading;

namespace SByteDev.Xamarin.Plugins.Base
{
    public sealed class Plugin<T> where T : class
    {
        private readonly Func<T> _factory;
        private readonly Lazy<T> _lazy;

        public bool IsSupported => _lazy.Value != null;

        public T Instance => _lazy.Value ?? throw new PluginNotImplementedException();

        public Plugin(Func<T> factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

            _lazy = new Lazy<T>(CreateInstance, LazyThreadSafetyMode.PublicationOnly);
        }

        private T CreateInstance()
        {
#if NETSTANDARD2_0
            return null;
#else
            return _factory();
#endif
        }
    }
}