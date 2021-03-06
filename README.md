# Xamarin Plugin Base
![GitHub](https://img.shields.io/github/license/SByteDev/Net.Xamarin.Plugins.Base.svg)
![Nuget](https://img.shields.io/nuget/v/SByteDev.Xamarin.Plugins.Base.svg)
[![CI](https://github.com/SByteDev/Net.Xamarin.Plugins.Base/actions/workflows/ci.yml/badge.svg)](https://github.com/SByteDev/Net.Xamarin.Plugins.Base/actions/workflows/ci.yml)
[![CD](https://github.com/SByteDev/Net.Xamarin.Plugins.Base/actions/workflows/cd.yml/badge.svg)](https://github.com/SByteDev/Net.Xamarin.Plugins.Base/actions/workflows/cd.yml)
[![CodeFactor](https://www.codefactor.io/repository/github/sbytedev/net.xamarin.plugins.base/badge)](https://www.codefactor.io/repository/github/sbytedev/net.xamarin.plugins.base)

Provides base classes to implement a Xamarin Plugin.

## Installation

Use [NuGet](https://www.nuget.org) package manager to install this library.

```bash
Install-Package SByteDev.Xamarin.Plugins.Base
```

## Usage
```cs
using SByteDev.Xamarin.Plugins.Base;

public static class DemoPlugin
{
    private static readonly Plugin<IDemo> Plugin;

    public static bool IsSupported => Plugin.IsSupported;

    public static IDemo Instance => Plugin.Instance;

    static DemoPlugin()
    {
        Plugin = new Plugin<IIDemo>(() => new Demo());
    }
}
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update the tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
