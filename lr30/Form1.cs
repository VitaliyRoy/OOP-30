using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            FadList.Items.Clear();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            while (!reader.EndOfStream)
            {
                FadList.Items.Add(reader.ReadLine());
            }

            MessageBox.Show(response.WelcomeMessage);
            reader.Close();
            response.Close();
        }

        private void btnGetSize_Click(object sender, EventArgs e)
        {
            string filePath = tbFilePath.Text;
            Uri uri = new Uri(filePath);

            if (uri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                return;
            }

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    long size = response.ContentLength;
                    MessageBox.Show($"Розмір файлу: {size} байт");
                    response.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAPPE_Click(object sender, EventArgs e)
        {
            string filePath = tbFilePath.Text;
            Uri uri = new Uri(filePath);

            if (uri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                return;
            }

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.AppendFile;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Файл додано успішно.");
                    response.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDELE_Click(object sender, EventArgs e)
        {
            string filePath = tbFilePath.Text;
            Uri uri = new Uri(filePath);

            if (uri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                return;
            }

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.DeleteFile;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Файл видалено успішно.");
                    response.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRETR_Click(object sender, EventArgs e)
        {
            string filePath = tbFilePath.Text;
            Uri uri = new Uri(filePath);

            if (uri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                return;
            }

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        string fileName = Path.GetFileName(uri.LocalPath);
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.FileName = fileName;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                            {
                                stream.CopyTo(fileStream);
                            }

                            MessageBox.Show("Файл завантажено успішно.");
                        }
                    }

                    response.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMDT_Click(object sender, EventArgs e)
        {
            string directoryPath = tbDirectoryPath.Text;
            Uri uri = new Uri(directoryPath);

            if (uri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                return;
            }

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Директорію створено успішно.");
                    response.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSIZE_Click(object sender, EventArgs e)
        {
            string filePath = tbFilePath.Text;
            Uri uri = new Uri(filePath);

            if (uri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                return;
            }

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    long size = response.ContentLength;
                    MessageBox.Show($"Розмір файлу: {size} байт");
                    response.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNLIST_Click(object sender, EventArgs e)
        {
            string directoryPath = tbDirectoryPath.Text;
            Uri uri = new Uri(directoryPath);

            if (uri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                return;
            }

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);

                    FadList.Items.Clear();

                    while (!reader.EndOfStream)
                    {
                        FadList.Items.Add(reader.ReadLine());
                    }

                    reader.Close();
                    response.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLIST_Click(object sender, EventArgs e)
        {
            string directoryPath = tbDirectoryPath.Text;
            Uri uri = new Uri(directoryPath);

            if (uri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                return;
            }

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);

                    FadList.Items.Clear();

                    while (!reader.EndOfStream)
                    {
                        FadList.Items.Add(reader.ReadLine());
                    }

                    reader.Close();
                    response.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMKD_Click(object sender, EventArgs e)
        {
            string directoryPath = tbDirectoryPath.Text;
            Uri uri = new Uri(directoryPath);

            if (uri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                return;
            }

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Директорію створено успішно.");
                    response.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRMD_Click(object sender, EventArgs e)
        {
            string directoryPath = tbDirectoryPath.Text;
            Uri uri = new Uri(directoryPath);

            if (uri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                return;
            }

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.RemoveDirectory;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Директорію видалено успішно.");
                    response.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRENAME_Click(object sender, EventArgs e)
        {
            string oldFilePath = tbFilePath.Text;
            string newFileName = tbNewFileName.Text;

            Uri oldUri = new Uri(oldFilePath);

            if (oldUri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                return;
            }

            Uri newUri = new Uri(oldUri, newFileName);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(oldUri);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.Rename;
            request.RenameTo = newFileName;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Файл перейменовано успішно.");
                    response.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSTOR_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                Uri uri = new Uri(tbHost.Text + "/" + Path.GetFileName(filePath));

                if (uri.Scheme != Uri.UriSchemeFtp)
                {
                    MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                    return;
                }

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                try
                {
                    using (Stream fileStream = File.OpenRead(filePath))
                    {
                        using (Stream requestStream = request.GetRequestStream())
                        {
                            fileStream.CopyTo(requestStream);
                        }
                    }

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        MessageBox.Show("Файл завантажено успішно.");
                        response.Close();
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSTOU_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                Uri uri = new Uri(tbHost.Text + "/" + Path.GetFileName(filePath));

                if (uri.Scheme != Uri.UriSchemeFtp)
                {
                    MessageBox.Show("Помилка: Посилання не є FTP-з'єднанням.");
                    return;
                }

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.UploadFileWithUniqueName;

                try
                {
                    using (Stream fileStream = File.OpenRead(filePath))
                    {
                        using (Stream requestStream = request.GetRequestStream())
                        {
                            fileStream.CopyTo(requestStream);
                        }
                    }

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        MessageBox.Show("Файл завантажено успішно.");
                        response.Close();
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}