using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnEnkripto_Click(object sender, EventArgs e)
        {
            string key = "123@abc";

            MD5CryptoServiceProvider mdHash = new MD5CryptoServiceProvider();
            byte[] keyArr = mdHash.ComputeHash(Encoding.UTF8.GetBytes(key));
            mdHash.Clear();

            byte[] simpletext = Encoding.UTF8.GetBytes(txtplaintext.Text);
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = keyArr;
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.Zeros;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(simpletext, 0, simpletext.Length);
            cs.Close();

            byte[] res = ms.ToArray();
            txtciphertext.Text = Convert.ToBase64String(res);
          
        }

        private void bttnDekripto_Click(object sender, EventArgs e)
        {
            string key = "123@abc";
            MD5CryptoServiceProvider mdHash = new MD5CryptoServiceProvider();
            byte[] keyArr = mdHash.ComputeHash(Encoding.UTF8.GetBytes(key));
            mdHash.Clear();

            byte[] ciphertext = Convert.FromBase64String(txtciphertext.Text);
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = keyArr;
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.Zeros;

            MemoryStream ms = new MemoryStream(ciphertext);
            byte[] textbytes = new byte[ms.Length];
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Read);
            cs.Read(textbytes, 0, textbytes.Length);
            cs.Close();

            

            txtdekriptuar.Text = Encoding.UTF8.GetString(textbytes);


        }
    }
}
