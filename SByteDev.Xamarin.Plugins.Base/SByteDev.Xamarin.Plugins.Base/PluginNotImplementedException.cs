using System;

namespace SByteDev.Xamarin.Plugins.Base
{
    public sealed class PluginNotImplementedException : NotImplementedException
    {
        private const string NotImplementedMessage =
            "This functionality is not implemented in the portable version of this assembly." +
            "You should reference the NuGet package from your main application project " +
            "in order to reference the platform-specific implementation.";

        public PluginNotImplementedException() : base(NotImplementedMessage)
        {
            /* Required constructor */
        }
    }
}