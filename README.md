# TsunaCan.HelloWorld

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
