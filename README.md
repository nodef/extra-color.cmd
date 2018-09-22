Get or set Cursor color in Windows Console.
> 1. Download [exe file](https://github.com/winp/extra-color/releases/download/1.0.0/ecolor.exe).
> 2. Copy to `C:\Program_Files\Scripts`.
> 3. Add `C:\Program_Files\Scripts` to `PATH` environment variable.


```batch
> ecolor [[+|-]<foreground color>] [[+|-]<background color>]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: get current cursor color as "<foreground color> <background color>"
> ecolor

:: set cursor foreground color to 1
> ecolor 1

:: set cursor foreground color to darkgray
> ecolor darkgray

:: set cursor color to default
> ecolor 7 0

:: set cursor color to foreground=14, background=5
> ecolor 14 5

:: set cursor color to foreground=yellow, background=darkcyan
> ecolor yellow darkcyan

:: update cursor foreground color to next color
> ecolor +1

:: update cursor background color to next color
> ecolor +0 +1
```


[![Merferry](https://i.imgur.com/2T3H86Y.jpg)](https://merferry.github.io)
