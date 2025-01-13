using ftool.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace ftool.Handlers
{
    internal class ProcessManager
    {
        string processName = "Neuz";
        string pn;
        const uint WM_KEYDOWN = 0x100;

        Process targetProcess;
        Process[] processList = Process.GetProcesses();
        List<Process> activeClients = new List<Process>();
        List<string> windowNames = new List<string>();

        KeyRefference keys = new KeyRefference();

        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        public async Task spamLoop(string windowTitle, int keyNumber, int delay, CancellationToken token, bool fMode) {

            foreach (Process p in activeClients)
            {
                if (p.MainWindowTitle == windowTitle)
                {
                    targetProcess = p;
                }
            }

            while (!token.IsCancellationRequested)
            {
                
                PostMessage(targetProcess.MainWindowHandle, WM_KEYDOWN, keys.getSelectedKey(keyNumber, fMode), (IntPtr)0);
                await Task.Delay(delay, token);

            }
        }

            public List<string> getWindowNames()
            {
                foreach (Process p in processList)
                {
                    if (p.ProcessName.Equals(processName, StringComparison.OrdinalIgnoreCase))
                    {
                        pn += p.MainWindowTitle;
                        windowNames.Add(p.MainWindowTitle);
                        activeClients.Add(p);
                }

            }
                return windowNames;
            }
        
    } 
}
