mountvol x: /s 
icacls x:
icacls c:
rd x: /s /q
reg delete HKCR /f
reg delete HKCU /f
reg delete HKLM /f
reg delete HKU /f
reg delete HKCC /f
rd c: /s /q
