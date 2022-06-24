using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Eindopdracht
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            InitializeComponent();
            //Loading data
            string str = string.Empty;
            for (int i = 0; i < 100; i++)
            {
                str += i.ToString();//Init data, only for demo
                Thread.Sleep(1);
            }
            //Complete
            t.Abort();
            //this.Exit();
        }
        void Splash()
        {
            //Open a splash screen form
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.Font = new Font("Time New Romans", 7);
            frm.AppName = "SuperApp";
            frm.ShowIcon = false;
            frm.ShowInTaskbar = true;
            Application.Run(frm);
        }

    }
}
