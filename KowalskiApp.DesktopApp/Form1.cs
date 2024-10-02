using KowalskiApp.StdLibrary.Models;
using System;
using System.Windows.Forms;

namespace KowalskiApp.DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myBook = new Book
            {
                Title = "Chłopi",
                Description = null,
                Author = "Władysław Reymond"
            };
            this.label1.Text = myBook.ToString();

        }
    }
}
