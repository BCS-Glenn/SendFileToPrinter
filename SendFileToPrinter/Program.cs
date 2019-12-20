using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Printing;
using System.IO;
using System.Diagnostics;

namespace SendFileToPrinter
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var dialog = new OpenFileDialog() { Multiselect = false, Title = "選擇PDF", Filter = "PDF檔案(*.pdf)|*.pdf" };            
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = dialog.FileName;


                var info = new ProcessStartInfo(fileName) { UseShellExecute = true, Verb = "print" };
                var process = Process.Start(info);

            }
            
        }
    }
}
