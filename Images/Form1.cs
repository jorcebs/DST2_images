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

namespace Images
{
    public partial class Form1 : Form
    {
        int i = 32565;
        Int16 i16 = 65;
        Int64 i64 = 65;
        double d = 3.141592;
        string s = "Esta es una cadena";
        byte b = 64;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            sfd1.ShowDialog();
            FileStream fs = new FileStream(sfd1.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(i);
            sw.WriteLine(i16);
            sw.WriteLine(i64);
            sw.WriteLine(d);
            sw.WriteLine(s);
            sw.WriteLine(b);
            sw.Close();
            fs.Close();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            sfd1.ShowDialog();
            FileStream fs = new FileStream(sfd1.FileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(i);
            bw.Write(i16);
            bw.Write(i64);
            bw.Write(d);
            bw.Write(s);
            bw.Write(b);
            bw.Close();
            fs.Close();
        }
    }
}