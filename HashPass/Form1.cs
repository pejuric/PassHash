using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace HashPass
{
    public partial class PassKeeper : Form
    {
        public PassKeeper()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=null&&textBox1.Text!=""&& 
               textBox2.Text != null && textBox2.Text != "")
            {
                string desktopath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filepath = desktopath + "\\HashedPass" + textBox1.Text + ".txt";
                byte[] hashbyte = gibHashAndSalt(textBox1.Text, textBox2.Text);
                FileStream fcreatestream = new FileStream(filepath, FileMode.Create);
                fcreatestream.Close();
                FileStream fopenstream = new FileStream(filepath, FileMode.Open);
                fopenstream.Write(hashbyte, 0, 64);
                fopenstream.Close();
            }
        }
        public byte[] gibHashAndSalt(string pass,string name)
        {
            SHA512Managed myHash = new SHA512Managed();
            byte[] buffer = Encoding.UTF32.GetBytes(pass);
            buffer = myHash.ComputeHash(buffer);
            string holder = Convert.ToBase64String(buffer);
            holder = holder + name;
            buffer = Encoding.UTF32.GetBytes(holder);
            buffer = myHash.ComputeHash(buffer);
            return buffer;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != null && textBox3.Text != "" &&
                textBox4.Text != null && textBox4.Text != "")
            {              
                byte[] hashbyte = gibHashAndSalt(textBox3.Text, textBox4.Text);
                string check1 = Convert.ToBase64String(hashbyte);
                string desktopath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filepath = desktopath + "\\HashedPass" + textBox3.Text + ".txt";
                try
                {     
                    FileStream fopenstream = new FileStream(filepath, FileMode.Open);
                    byte[] op=new byte[64];
                    fopenstream.Read(op, 0, 64);
                    fopenstream.Close();
                    string check2 = Convert.ToBase64String(op);
                    if (check1 == check2)
                    {
                        label2.Visible = false;
                        label1.Visible = true;
                        label3.Visible = false;
                        fopenstream.Close();
                    }
                    else
                    {
                        label2.Visible = false;
                        label1.Visible = false;
                        label3.Visible = true;
                        fopenstream.Close();
                    }
                }
                catch (Exception) {
                    label2.Visible = true;
                    label1.Visible = false;
                    label3.Visible = false;                  
                }
            }
        }
    }
}
