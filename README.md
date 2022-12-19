# TsunaCan.HelloWorld

[![GitHub](https://img.shields.io/github/license/tsuna-can-se/hello-world?color=purple&style=for-the-badge)](https://github.com/tsuna-can-se/hello-world/blob/main/LICENSE)
[![Nuget](https://img.shields.io/nuget/v/TsunaCan.HelloWorld?style=for-the-badge)](https://www.nuget.org/packages/TsunaCan.HelloWorld)

[![GitHub release (latest by date)](https://img.shields.io/github/v/release/tsuna-can-se/hello-world?color=deep-green&label=latest%20version&style=for-the-badge)](https://github.com/tsuna-can-se/hello-world/releases)
[![GitHub Release Date](https://img.shields.io/github/release-date/tsuna-can-se/hello-world?color=deep-green&label=released%20in&style=for-the-badge)](https://github.com/tsuna-can-se/hello-world/releases)
[![GitHub release (latest by date including pre-releases)](https://img.shields.io/github/v/release/tsuna-can-se/hello-world?color=green&include_prereleases&label=latest%20dev%20version&style=for-the-badge)](https://github.com/tsuna-can-se/hello-world/releases)
[![GitHub (Pre-)Release Date](https://img.shields.io/github/release-date-pre/tsuna-can-se/hello-world?color=green&label=released%20in&style=for-the-badge)](https://github.com/tsuna-can-se/hello-world/releases)

This project is sample of NuGet package csharp project.
"Hello World" ASCII art string can be shown on the console.

## Installation

On the Package Manager Console, execute the following command to install the NuGet package.

```winbatch
Install-Package TsunaCan.HelloWorld
```

## Usage

Create console application project and call static methods of `TsunaCan.HelloWorld.Echo` class.

```csharp
using TsunaCan.HelloWorld;

Echo.Hello();
Echo.World();
```

## License

[MIT License](https://github.com/tsuna-can-se/hello-world/blob/main/LICENSE)
