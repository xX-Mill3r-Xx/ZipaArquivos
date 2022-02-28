using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ZipDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Selecione o Caminho para a Pasta.";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_Folder.Text = fbd.SelectedPath;
            }
        }

        private void btn_FileName_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    txt_FileName.Text = ofd.FileName;
                }
            }
        }

        private void btn_ZipFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Folder.Text))
            {
                MessageBox.Show("Por Favor, Selecione a Pasta!", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Folder.Focus();
                return;
            }
            string path = txt_Folder.Text;
            Thread thread = new Thread(t =>
            {
                using(Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    zip.AddDirectory(path);
                    DirectoryInfo di = new DirectoryInfo(path);
                    zip.SaveProgress += Zip_SaveProgress;
                    zip.Save(string.Format("{0}{1}.zip", di.Parent.FullName, di.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
        }

        private void Zip_SaveProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar1.Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Maximum = e.EntriesTotal;
                    progressBar1.Value = e.EntriesSaved + 1;
                    progressBar1.Update();
                }));
            }
        }

        private void Zip_SaveFileProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBar1.Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Maximum = 100;
                    progressBar1.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar1.Update();
                }));
            }
        }

        private void btn_ZipFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_FileName.Text))
            {
                MessageBox.Show("Por Favor, Selecione o Arquivo!", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_FileName.Focus();
                return;
            }
            string fileName = txt_FileName.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    FileInfo fi = new FileInfo(fileName);
                    zip.AddFile(fileName);
                    DirectoryInfo di = new DirectoryInfo(fileName);
                    zip.SaveProgress += Zip_SaveFileProgress;
                    zip.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, di.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
