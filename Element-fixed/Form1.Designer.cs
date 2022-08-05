namespace Element_fixed;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.chromium = new CefSharp.WinForms.ChromiumWebBrowser();
            this.guna2ResizeBox1 = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconContextMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.trayIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.CustomClick = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(955, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.guna2ControlBox3);
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 29);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.titleLabel.Location = new System.Drawing.Point(7, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(153, 15);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Element fixed by Hermes :D";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(859, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(907, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // chromium
            // 
            this.chromium.ActivateBrowserOnCreation = false;
            this.chromium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.chromium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromium.Location = new System.Drawing.Point(0, 29);
            this.chromium.Margin = new System.Windows.Forms.Padding(15);
            this.chromium.Name = "chromium";
            this.chromium.Padding = new System.Windows.Forms.Padding(5);
            this.chromium.Size = new System.Drawing.Size(1000, 771);
            this.chromium.TabIndex = 2;
            this.chromium.TitleChanged += new System.EventHandler<CefSharp.TitleChangedEventArgs>(this.chromium_TitleChanged);
            // 
            // guna2ResizeBox1
            // 
            this.guna2ResizeBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ResizeBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.guna2ResizeBox1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.guna2ResizeBox1.FillColor = System.Drawing.Color.LightGray;
            this.guna2ResizeBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ResizeBox1.Location = new System.Drawing.Point(984, 784);
            this.guna2ResizeBox1.Name = "guna2ResizeBox1";
            this.guna2ResizeBox1.Size = new System.Drawing.Size(16, 16);
            this.guna2ResizeBox1.TabIndex = 3;
            this.guna2ResizeBox1.TargetControl = this;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayIconContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Element (Fixed by Hermes)";
            this.notifyIcon.Visible = true;
            // 
            // trayIconContextMenu
            // 
            this.trayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.trayIconContextMenu.Name = "trayIconContextMenu";
            this.trayIconContextMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.trayIconContextMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.trayIconContextMenu.RenderStyle.ColorTable = null;
            this.trayIconContextMenu.RenderStyle.RoundedEdges = true;
            this.trayIconContextMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.trayIconContextMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(189)))), ((int)(((byte)(139)))));
            this.trayIconContextMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.trayIconContextMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.trayIconContextMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.trayIconContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Pokaż/Ukryj kurwe";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Zamknij pizde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.guna2ResizeBox1);
            this.Controls.Add(this.chromium);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Element (fixed)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.trayIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    private Panel panel1;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private CefSharp.WinForms.ChromiumWebBrowser chromium;
    private Label titleLabel;
    private Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox1;
    private NotifyIcon notifyIcon;
    private Guna.UI2.WinForms.Guna2ContextMenuStrip trayIconContextMenu;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem toolStripMenuItem2;
}