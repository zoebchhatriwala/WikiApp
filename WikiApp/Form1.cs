using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(web.CanGoBack.ToString()=="True")
            {
                web.GoBack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (web.CanGoForward.ToString() == "True")
            {
                web.GoForward();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (keyword.Text!="")
            {
                nav(1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WikiApp is a Wikipedia Unofficial Application.\nApplication Developed By: Zoeb Chhatriwala");
        }

        private void search_Click(object sender, EventArgs e)
        {
            web.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            if (keyword.Text != "")
            {
                nav(1);
            }
              
        }
        private string nav(int check)
        {
            string search = keyword.Text;
            search = search.Replace(" ", "+");
            search = "en.wikipedia.org/w/index.php?search=" + search + "&title=Special%3ASearch&fulltext=Search";
            if (check == 1)
            {
                web.Navigate(search);
                return search;
            }
            else
            { return search; }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            web.Navigate(nav(0), true);
        }

        private void web_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            search.Text = "Loading";
            search.Enabled = false;
        }

        private void web_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            search.Text = "Search";
            search.Enabled = true;
        }
    }
}
