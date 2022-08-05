using CefSharp;
using CefSharp.WinForms;
using System.Runtime.InteropServices;

namespace Element_fixed;

public partial class Form1 : Form
{
    private bool IsHidden = false;

    private const int WmNclbuttondown = 0xA1;
    private const int HtCaption = 0x2;

    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImport("user32.dll")]
    private static extern bool ReleaseCapture();

    public Form1()
    { 
        InitializeComponent();

        Cef.Initialize(new CefSettings()
        {
            CachePath = @$"{Environment.CurrentDirectory}\\cache",
            PersistSessionCookies = true
        });
    }

    private async void Form1_Load(object sender, EventArgs e)
        => await chromium.LoadUrlAsync("https://app.element.io");

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
    }

    private void chromium_TitleChanged(object sender, TitleChangedEventArgs e)
    {
        titleLabel.Invoke((MethodInvoker) (() => titleLabel.Text = e.Title));
        Invoke((MethodInvoker) (() => Text = e.Title));
    }

    private void zamknijPizdeToolStripMenuItem_Click(object sender, EventArgs e) 
        => Environment.Exit(1);

    private void guna2ControlBox1_Click(object sender, EventArgs e)
        => ShowOrHide();

    private void ShowHideItem_Click(object sender, EventArgs e) 
        => ShowOrHide();

    private void ShowOrHide()
    {
        if (!IsHidden)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }
        else
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }
    }
}