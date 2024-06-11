using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNavegador
{
    public partial class Navegador : Form
    {
        public Navegador()
        {
            InitializeComponent();
            NavegadorwebBrowser.Navigate("www.google.com");
        }

        private void NavBackbutton_Click(object sender, EventArgs e)
        {
            NavegadorwebBrowser.GoBack();
        }

        private void NavForwardButton_Click(object sender, EventArgs e)
        {
            NavegadorwebBrowser.GoForward();
        }

        private void NavReloadButton_Click(object sender, EventArgs e)
        {
            NavegadorwebBrowser.Refresh();
        }

        private void NavHomeButton_Click(object sender, EventArgs e)
        {
            NavegadorwebBrowser.Navigate("www.google.com");
        }

        private void NavGoButton_Click(object sender, EventArgs e)
        {
            NavegadorwebBrowser.Navigate(NavSeachBox.Text);
        }

        private void NavStopButton_Click(object sender, EventArgs e)
        {
            NavegadorwebBrowser.Stop();
        }
    }
}
