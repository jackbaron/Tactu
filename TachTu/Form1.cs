using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TachTu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool KiemTraTuTrongTuDien(string tu)
        {

            string line;
            StreamReader read = new StreamReader("wordlist.txt");
            while ((line = read.ReadLine()) != null)
            {

                if (line == tu)
                    return true;

            }
            read.Close();
            return false;
 
        }

        string[] mangNhapTu;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhap.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ketqua="";
            bool timduoc = false;
            string nhap = txtNhap.Text + "  ";
            nhap = nhap.ToLower();
            nhap = nhap.Replace(".", " . ");
            nhap = nhap.Replace(",", " , ");
            mangNhapTu = nhap.Split(' ');

            for (int i = 0; i < mangNhapTu.Length-2; i++)
            {
                
                if(timduoc==true)
                {
                    timduoc = false;
                    continue;
                    
                }

                if (KiemTraTuTrongTuDien(mangNhapTu[i] + " " + mangNhapTu[i + 1]))
                {
                    ketqua +=" "+ mangNhapTu[i] + "_" + mangNhapTu[i + 1];
                    timduoc=true;
                    
                }
                if (timduoc == false)
                {
                    ketqua += " " + mangNhapTu[i];
                }
                    
                

            }

            txtketQua.Text = ketqua;

        }
    }
}
