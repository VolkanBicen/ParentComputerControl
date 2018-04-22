using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace EbebeynPcKontrol
{
    public partial class AnaEkran : Form
    {
        int zaman = 4;
        public AnaEkran()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void btnAclose_Click(object sender, EventArgs e)
        {
            unblockedTask();
            Application.Exit();
          //  System.Diagnostics.Process.Start("shutdown", "-h");
        }
        private void btnAok_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ServiceController sc = new ServiceController();
            sc.ServiceName = "SCardSvr";
            if (sc.Status == ServiceControllerStatus.Running)
            {
                try
                {
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped);
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = @"C:\Program Files (x86)\Metin2\config.exe";
                    prc.Start();
                }
                catch (InvalidOperationException)
                {
                 
                }
            }
        }
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
            timer1.Interval = 1000;
             timer1.Start();           
             FormState formState = new FormState();
             formState.Maximize(this);
             if (Class1.kontrol() == false)
             {
               message.Text=("İnternet Bağlantınızı Kontrol Ediniz");
             } 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // blockedTask();
            zaman--;
            label2.Text = (zaman.ToString() + " DAKİKA İÇERİSİNDE BİLGİSAYARINIZ KAPATILACAK");
            timer1.Interval = timer1.Interval + 1;
            if (timer1.Interval == 60004)
            {
                unblockedTask();
                //  System.Diagnostics.Process.Start("shutdown", "-h");
            }
        }
        
       public void blockedTask()
        {
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies", true);
            rkey.CreateSubKey("System", RegistryKeyPermissionCheck.Default);
            rkey.Close();
            RegistryKey rkey2 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
            rkey2.SetValue("DisableTaskMgr", 1);
            rkey2.Close();
        }
        public void unblockedTask()
        {
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies", true);
            rkey.CreateSubKey("System", RegistryKeyPermissionCheck.Default);
            rkey.Close();
            RegistryKey rkey2 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
            rkey2.SetValue("DisableTaskMgr", 0);
            rkey2.Close();
        }
        private void AnaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            unblockedTask();
            if (AnaEkran.ModifierKeys == Keys.Alt || AnaEkran.ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || objKeyInfo.key == Keys.Escape && (ModifierKeys & Keys.Control) == Keys.Control)
                {
                    return (IntPtr)1; 
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }
        bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
