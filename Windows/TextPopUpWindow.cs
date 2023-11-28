using System;
using System.Net.Mime;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class TextPopUpWindow : Form
    {
        public TextPopUpWindow()
        { 
            InitializeComponent();
        }
        public void TextDisplay(string text)
        {
            textBox1.Text = text;
        }
        
        private void TextPopUpWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }
    }
}