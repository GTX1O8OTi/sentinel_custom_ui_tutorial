using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bridge; // Referencing sentinel's "API" (Explorer -> References -> Add Reference -> find bridge.dll -> ??? -> profit)

namespace imatest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // double click the form window

            Authenticator.LoginViaHWIDAsync(); // As the name suggests, login via hwid
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sentinel.ExecuteScript(richTextBox1.Text); // do i even need to tell what this does?
        }

        private /*optional*/async void button2_Click(object sender, EventArgs e)
        {
            InjectionResult inj = Injector.Inject(); // Gets the result from Injector.Inject

            if (inj.Result == InjectionError.Success) // if the injection result is pog, then idk the rest lol just make code
            {
                // OPTIONAL
                await Task.Delay(500);

                // NOT OPTIONAL, MUST HAVE THIS
                Sentinel.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // there is 2 ways as far as i know on how to do it

            // 1
            richTextBox1.Clear();

            // 2
            richTextBox1.Text = "";

            // both do the same thing, just use the one you find easier
        }
    }
}
