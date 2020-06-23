# NWindowsKits

Windows Kits wrapper for netstandard2.0.
Parse windows.h and Generate C# code for netstandard2.0 by [ClangCaster](https://github.com/ousttrue/ClangCaster).

## Features

* Support only 64bit
* [user32.dll](NWindowsKits/winuser.cs)

## TODO

* [ ] add HINSTANCE
* [ ] kernel32.dll

## Samples

### HelloWindow

* port from https://github.com/microsoft/Windows-classic-samples/tree/master/Samples/Win7Samples/begin/LearnWin32/HelloWorld

### DXGIEnumerateAdapter

* TODO

### D3D11CreateDevice

* TODO

### D3D11ClearSwapchain

* TODO

### D3D11DrawTriangle

* TODO

## Code Generation

* required `libclang.dll` (LLVM-10).

Use `generate` task on VSCode.

or

```
> cd ../ClangCaster/ClangCaster
> dotnet run -- -ns NWindowsKits -dll user32 -d ../../NWindowsKits/NWindowsKits -h 'C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/Windows.h' -h 'C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winuser.h
```
