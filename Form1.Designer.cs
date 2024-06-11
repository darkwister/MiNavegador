namespace MiNavegador
{
    partial class Navegador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navegador));
            this.NavToolTip = new System.Windows.Forms.ToolStrip();
            this.NavBackbutton = new System.Windows.Forms.ToolStripButton();
            this.NavForwardButton = new System.Windows.Forms.ToolStripButton();
            this.NavReloadButton = new System.Windows.Forms.ToolStripButton();
            this.NavHomeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NavSeachBox = new System.Windows.Forms.ToolStripTextBox();
            this.NavGoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NavegadorwebBrowser = new System.Windows.Forms.WebBrowser();
            this.NavStopButton = new System.Windows.Forms.ToolStripButton();
            this.NavToolTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavToolTip
            // 
            this.NavToolTip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavToolTip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NavBackbutton,
            this.NavForwardButton,
            this.NavReloadButton,
            this.NavStopButton,
            this.NavHomeButton,
            this.toolStripSeparator1,
            this.NavSeachBox,
            this.NavGoButton,
            this.toolStripSeparator2});
            this.NavToolTip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.NavToolTip.Location = new System.Drawing.Point(0, 0);
            this.NavToolTip.Name = "NavToolTip";
            this.NavToolTip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.NavToolTip.Size = new System.Drawing.Size(986, 31);
            this.NavToolTip.TabIndex = 0;
            // 
            // NavBackbutton
            // 
            this.NavBackbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavBackbutton.Image = ((System.Drawing.Image)(resources.GetObject("NavBackbutton.Image")));
            this.NavBackbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavBackbutton.Name = "NavBackbutton";
            this.NavBackbutton.Size = new System.Drawing.Size(29, 28);
            this.NavBackbutton.Text = "NavBackbutton";
            this.NavBackbutton.Click += new System.EventHandler(this.NavBackbutton_Click);
            // 
            // NavForwardButton
            // 
            this.NavForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("NavForwardButton.Image")));
            this.NavForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavForwardButton.Name = "NavForwardButton";
            this.NavForwardButton.Size = new System.Drawing.Size(29, 28);
            this.NavForwardButton.Text = "NavForwardButton";
            this.NavForwardButton.Click += new System.EventHandler(this.NavForwardButton_Click);
            // 
            // NavReloadButton
            // 
            this.NavReloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavReloadButton.Image = ((System.Drawing.Image)(resources.GetObject("NavReloadButton.Image")));
            this.NavReloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavReloadButton.Name = "NavReloadButton";
            this.NavReloadButton.Size = new System.Drawing.Size(29, 28);
            this.NavReloadButton.Text = "NavReloadButton";
            this.NavReloadButton.Click += new System.EventHandler(this.NavReloadButton_Click);
            // 
            // NavHomeButton
            // 
            this.NavHomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("NavHomeButton.Image")));
            this.NavHomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavHomeButton.Name = "NavHomeButton";
            this.NavHomeButton.Size = new System.Drawing.Size(29, 28);
            this.NavHomeButton.Text = "NavHomeButton";
            this.NavHomeButton.Click += new System.EventHandler(this.NavHomeButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // NavSeachBox
            // 
            this.NavSeachBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NavSeachBox.Name = "NavSeachBox";
            this.NavSeachBox.Size = new System.Drawing.Size(635, 31);
            // 
            // NavGoButton
            // 
            this.NavGoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavGoButton.Image = ((System.Drawing.Image)(resources.GetObject("NavGoButton.Image")));
            this.NavGoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavGoButton.Name = "NavGoButton";
            this.NavGoButton.Size = new System.Drawing.Size(29, 28);
            this.NavGoButton.Text = "toolStripButton5";
            this.NavGoButton.Click += new System.EventHandler(this.NavGoButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // NavegadorwebBrowser
            // 
            this.NavegadorwebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavegadorwebBrowser.Location = new System.Drawing.Point(0, 0);
            this.NavegadorwebBrowser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NavegadorwebBrowser.MinimumSize = new System.Drawing.Size(22, 29);
            this.NavegadorwebBrowser.Name = "NavegadorwebBrowser";
            this.NavegadorwebBrowser.Size = new System.Drawing.Size(986, 638);
            this.NavegadorwebBrowser.TabIndex = 1;
            // 
            // NavStopButton
            // 
            this.NavStopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavStopButton.Image = ((System.Drawing.Image)(resources.GetObject("NavStopButton.Image")));
            this.NavStopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavStopButton.Name = "NavStopButton";
            this.NavStopButton.Size = new System.Drawing.Size(29, 28);
            this.NavStopButton.Text = "toolStripButton1";
            this.NavStopButton.Click += new System.EventHandler(this.NavStopButton_Click);
            // 
            // Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 638);
            this.Controls.Add(this.NavToolTip);
            this.Controls.Add(this.NavegadorwebBrowser);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Navegador";
            this.Text = "Navegador";
            this.NavToolTip.ResumeLayout(false);
            this.NavToolTip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip NavToolTip;
        private System.Windows.Forms.ToolStripButton NavBackbutton;
        private System.Windows.Forms.ToolStripButton NavForwardButton;
        private System.Windows.Forms.ToolStripButton NavReloadButton;
        private System.Windows.Forms.ToolStripButton NavHomeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox NavSeachBox;
        private System.Windows.Forms.ToolStripButton NavGoButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.WebBrowser NavegadorwebBrowser;
        private System.Windows.Forms.ToolStripButton NavStopButton;
    }
}

