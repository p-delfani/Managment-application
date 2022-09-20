namespace Library_Managment
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.کاربرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.افزودنکاربرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کتابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.همهکتابهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پشتیبانیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشخرابیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سرویسهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کاربرToolStripMenuItem,
            this.کتابToolStripMenuItem,
            this.پشتیبانیToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(579, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // کاربرToolStripMenuItem
            // 
            this.کاربرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.افزودنکاربرToolStripMenuItem});
            this.کاربرToolStripMenuItem.Name = "کاربرToolStripMenuItem";
            this.کاربرToolStripMenuItem.Size = new System.Drawing.Size(52, 32);
            this.کاربرToolStripMenuItem.Text = "کاربر";
            // 
            // افزودنکاربرToolStripMenuItem
            // 
            this.افزودنکاربرToolStripMenuItem.Name = "افزودنکاربرToolStripMenuItem";
            this.افزودنکاربرToolStripMenuItem.Size = new System.Drawing.Size(169, 32);
            this.افزودنکاربرToolStripMenuItem.Text = "مدیریت کاربران";
            this.افزودنکاربرToolStripMenuItem.Click += new System.EventHandler(this.افزودنکاربرToolStripMenuItem_Click);
            // 
            // کتابToolStripMenuItem
            // 
            this.کتابToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.همهکتابهاToolStripMenuItem});
            this.کتابToolStripMenuItem.Name = "کتابToolStripMenuItem";
            this.کتابToolStripMenuItem.Size = new System.Drawing.Size(52, 32);
            this.کتابToolStripMenuItem.Text = "کتاب";
            // 
            // همهکتابهاToolStripMenuItem
            // 
            this.همهکتابهاToolStripMenuItem.Name = "همهکتابهاToolStripMenuItem";
            this.همهکتابهاToolStripMenuItem.Size = new System.Drawing.Size(171, 32);
            this.همهکتابهاToolStripMenuItem.Text = "مدیریت کتاب ها";
            this.همهکتابهاToolStripMenuItem.Click += new System.EventHandler(this.همهکتابهاToolStripMenuItem_Click);
            // 
            // پشتیبانیToolStripMenuItem
            // 
            this.پشتیبانیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشخرابیToolStripMenuItem,
            this.سرویسهاToolStripMenuItem});
            this.پشتیبانیToolStripMenuItem.Name = "پشتیبانیToolStripMenuItem";
            this.پشتیبانیToolStripMenuItem.Size = new System.Drawing.Size(67, 32);
            this.پشتیبانیToolStripMenuItem.Text = "پشتیبانی";
            // 
            // گزارشخرابیToolStripMenuItem
            // 
            this.گزارشخرابیToolStripMenuItem.Name = "گزارشخرابیToolStripMenuItem";
            this.گزارشخرابیToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.گزارشخرابیToolStripMenuItem.Text = "گزارش خرابی";
            this.گزارشخرابیToolStripMenuItem.Click += new System.EventHandler(this.گزارشخرابیToolStripMenuItem_Click);
            // 
            // سرویسهاToolStripMenuItem
            // 
            this.سرویسهاToolStripMenuItem.Name = "سرویسهاToolStripMenuItem";
            this.سرویسهاToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.سرویسهاToolStripMenuItem.Text = "درباره ی نرم افزار";
            this.سرویسهاToolStripMenuItem.Click += new System.EventHandler(this.سرویسهاToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.main_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem کاربرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem افزودنکاربرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کتابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem پشتیبانیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem همهکتابهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشخرابیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سرویسهاToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}