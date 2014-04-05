using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LogViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.LogFolder.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void Process_Click(object sender, EventArgs e)
        {

            try
            {
                
                StreamWriter sw = new StreamWriter("D:\\indexingqa522.txt");
                DirectoryInfo LogDirectory = new DirectoryInfo(this.LogFolder.Text);
                FileInfo[] logfiles = LogDirectory.GetFiles();
                logfiles = logfiles.OrderBy(item => item.LastWriteTime).ToArray();
                foreach (FileInfo logfile in logfiles)
                {
                    string lineText;
                    string logtime;
                    string threaddetails;
                    string count;
                  
                    string[] arrDetails;
                    //FileInfo logfile = logfiles[0];
                    //this.LogInfoBox.AppendText(logfile.FullName + Environment.NewLine);
                    using (StreamReader reader = logfile.OpenText())
                    {
                        this.LogInfoBox.AppendText(logfile.Name +   Environment.NewLine);
                        while (reader.Peek() >= 0)
                        {
                            lineText = reader.ReadLine();
                            //if (lineText.Contains("IndexBatchResource succeeded for Batch"))
                            //{
                            //    logtime = lineText.Substring(0, 19);
                            //    threaddetails = lineText.Substring(71);
                            //    arrDetails = threaddetails.Split(new char[] { ':'});
                            //    //this.LogInfoBox.AppendText(logtime + " $ " + threaddetails +   Environment.NewLine);
                            //    sw.WriteLine(logtime + " $ " + arrDetails[0] + " $ " + arrDetails[1] + " $ " + arrDetails[2]);
                            //    sw.Flush();
                            //}

                            if (lineText.Contains("resources requested to process"))
                            {
                                logtime = lineText.Substring(0, 13);
                                count = lineText.Substring(lineText.IndexOf('-') + 1, lineText.IndexOf("resources requested to process") - (lineText.IndexOf('-')+1) );
                                //this.LogInfoBox.AppendText(logtime + " $ " + threaddetails +   Environment.NewLine);
                                sw.WriteLine(logtime + " $ " + count);
                                sw.Flush();
                            }
                        }
                    }
                    
                }
                sw.Close();
            }                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
