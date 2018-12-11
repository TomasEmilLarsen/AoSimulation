using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileCompleted);
            Uri imageUrl = new Uri(textBox1.Text);
            wc.DownloadFileAsync(imageUrl, "morathi.pdf");

        }
        private void FileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download completed");
        }
    }
}
