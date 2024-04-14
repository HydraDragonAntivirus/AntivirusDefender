@echo off

echo using System; >> temp.cs
echo using System.Runtime.InteropServices; >> temp.cs
echo public class Win32 { >> temp.cs
echo     [DllImport("user32.dll")] >> temp.cs
echo     public static extern IntPtr GetDC(IntPtr hwnd); >> temp.cs
echo     [DllImport("user32.dll")] >> temp.cs
echo     public static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc); >> temp.cs
echo     [DllImport("gdi32.dll")] >> temp.cs
echo     public static extern IntPtr CreatePen(int fnPenStyle, int nWidth, int crColor); >> temp.cs
echo     [DllImport("gdi32.dll")] >> temp.cs
echo     public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObject); >> temp.cs
echo     [DllImport("gdi32.dll")] >> temp.cs
echo     public static extern bool DeleteObject(IntPtr hObject); >> temp.cs
echo     [DllImport("gdi32.dll")] >> temp.cs
echo     public static extern bool MoveToEx(IntPtr hdc, int x, int y, IntPtr lpPoint); >> temp.cs
echo     [DllImport("gdi32.dll")] >> temp.cs
echo     public static extern bool LineTo(IntPtr hdc, int x, int y); >> temp.cs
echo } >> temp.cs

echo $HWND = [System.Diagnostics.Process]::GetCurrentProcess().MainWindowHandle; >> temp.ps1
echo $DC = [Win32]::GetDC($HWND); >> temp.ps1
echo if (-not $DC) { >> temp.ps1
echo     Write-Host "Failed to get device context (DC)." >> temp.ps1
echo     exit 1 >> temp.ps1
echo } >> temp.ps1
echo $pen = [Win32]::CreatePen(0, 1, 0x000000); >> temp.ps1
echo if (-not $pen) { >> temp.ps1
echo     Write-Host "Failed to create pen." >> temp.ps1
echo     exit 1 >> temp.ps1
echo } >> temp.ps1
echo $prevPen = [Win32]::SelectObject($DC, $pen); >> temp.ps1
echo if (-not $prevPen) { >> temp.ps1
echo     Write-Host "Failed to select pen." >> temp.ps1
echo     exit 1 >> temp.ps1
echo } >> temp.ps1
echo for ($i=0; $i -lt 100; $i++) { >> temp.ps1
echo     $x1 = Get-Random -Minimum 0 -Maximum 500; >> temp.ps1
echo     $y1 = Get-Random -Minimum 0 -Maximum 500; >> temp.ps1
echo     $x2 = $x1 + (Get-Random -Minimum 0 -Maximum 100) - 50; >> temp.ps1
echo     $y2 = $y1 + (Get-Random -Minimum 0 -Maximum 30); >> temp.ps1
echo     [Win32]::MoveToEx($DC, $x1, $y1, [System.IntPtr]::Zero); >> temp.ps1
echo     [Win32]::LineTo($DC, $x2, $y2); >> temp.ps1
echo     Start-Sleep -Milliseconds 100; >> temp.ps1
echo     [Win32]::MoveToEx($DC, $x1, $y1, [System.IntPtr]::Zero); >> temp.ps1
echo     [Win32]::LineTo($DC, $x2, $y2); >> temp.ps1
echo     Start-Sleep -Milliseconds 100; >> temp.ps1
echo } >> temp.ps1
echo [Win32]::SelectObject($DC, $prevPen); >> temp.ps1
echo [Win32]::DeleteObject($pen); >> temp.ps1
echo [Win32]::ReleaseDC($HWND, $DC); >> temp.ps1

powershell.exe -ExecutionPolicy Bypass -File temp.ps1

del temp.ps1
del temp.cs