/*
 * file          : FTPConnection.cs
 * brief         : This file contains the connection to the server FTP
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 13.05.2024
 * update Date   : 13.05.2024
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SellBuyAuto
{
    public class FTPConnection
    {
        private string server = "ftp://web24.swisscenter.com/Images";
        private string username = "2024mca_108830";
        private string password = "2024_MCA_Auto";

        public FTPConnection()
        {

        }

        // Méthode qui permet de récupérer les images
        public Bitmap GetImage(string imageName)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(username, password);

            byte[] imageByte = ftpClient.DownloadData(string.Format("{0}/{1}", server, imageName));
            Bitmap bitmap = ByteToImage(imageByte);
            ftpClient.Dispose();
            imageByte = null;
            return bitmap;
        }

        // Méthode qui permet de transformer une image en byte vers une image en bitmap
        private Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public void UploadImage(string localFileName, string newFileName)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(username, password);
            ftpClient.UploadFile(new Uri(string.Format("{0}/{1}", server, newFileName)), localFileName);
            ftpClient.Dispose();
        }
    }
}
