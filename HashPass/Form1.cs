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
                string path = "C:\\HashedPass" + textBox1.Text + textBox2.Text + ".txt";
                byte[] tightSpot = gibHashAndSalt(textBox1.Text, textBox2.Text);
                FileStream guy = new FileStream(path, FileMode.Create);
                guy.Close();
                FileStream bro = new FileStream(path, FileMode.Open);
                bro.Write(tightSpot, 0, 64);
                bro.Close();
            }
        }
        public byte[] gibHashAndSalt(string pass,string name)
        {
            string holder;
            SHA512Managed myHash = new SHA512Managed();
            byte[] buffer = Encoding.UTF32.GetBytes(pass);
            buffer = myHash.ComputeHash(buffer);
            holder = Convert.ToBase64String(buffer);
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
                string check1, check2;
                byte[] tightSpot = gibHashAndSalt(textBox1.Text, textBox2.Text);
                check1 = Convert.ToBase64String(tightSpot);
                string path = "C:\\HashedPass" + textBox3.Text + textBox4.Text + ".txt";
                try
                {     
                    FileStream bro = new FileStream(path, FileMode.Open);
                    byte[] op=new byte[64];
                    bro.Read(op, 0, 64);
                    bro.Close();
                    check2 = Convert.ToBase64String(op);
                    if (check1 == check2)
                    {
                        label2.Visible = false;
                        label1.Visible = true;
                    }
                    else
                    {
                        label2.Visible = true;
                        label1.Visible = false;
                    }
                }
                catch (FileNotFoundException err) {
                    label2.Visible = true;
                    label1.Visible = false;
                }
            }
        }
    }
}
