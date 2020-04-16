using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gran.OS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void email_Click_2(object sender, EventArgs e)
        {
            Process.Start("firefox", "https://mail.google.com");
        }

        private void internet_Click(object sender, EventArgs e)
        {
            Process.Start("firefox", "www.google.com/");
        }

        private void fileExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer");
        }

        private void spotify_Button_Click(object sender, EventArgs e)
        {
            var spot = "spotify";
            Process.Start(spot);
        }

        private void whatsapp_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pas encore configurer veuillez cliquer sur ok puis continuer");
            Process.Start("WhatsApp Desktop");
        }

        private void store_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pas encore configurer veuillez cliquer sur ok puis continuer");
            Process.Start("WSHost.exe");
        }
    }
}
