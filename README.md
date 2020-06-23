# NWindowsKits

Windows Kits wrapper for netstandard2.0.
Parse windows.h and Generate C# code for netstandard2.0 by [ClangCaster](https://github.com/ousttrue/ClangCaster).

## TODO

* [ ] fix IntPtr to ref XXX 
* [ ] add HINSTANCE

## Samples

### HelloWindow

WIP

## Code Generation

* required `libclang.dll` (LLVM-10).

Use `generate` task on VSCode.

or

```
> cd ClangCaster/ClangCaster
> dotnet run -- -ns NWindowsKits -dll user32 -d ../../NWindowsKits -h 'C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/Windows.h' -h 'C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winuser.h
```
