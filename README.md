Get or set Cursor color in Windows Console.
> 1. Download [exe file](https://raw.githubusercontent.com/winp/extra-bel/master/ecd.cmd).
> 2. Copy to `C:\Program_Files\Scripts`.
> 3. Add `C:\Program_Files\Scripts` to `PATH` environment variable.


```batch
> ocolor [[+|-]<foreground color>] [[+|-]<background color>]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: get current cursor color as "<foreground color> <background color>"
> ocolor

:: set cursor foreground color to 1
> ocolor 1

:: set cursor foreground color to darkgray
> ocolor darkgray

:: set cursor color to default
> ocolor 7 0

:: set cursor color to foreground=14, background=5
> ocolor 14 5

:: set cursor color to foreground=yellow, background=darkcyan
> ocolor yellow darkcyan

:: update cursor foreground color to next color
> ocolor +1

:: update cursor background color to next color
> ocolor +0 +1
```
