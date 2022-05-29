namespace GameWer.UI.UniversalDevblog
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.version_value = new System.Windows.Forms.Label();
            this.status_value = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DiscordChannelServer_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VKGroupServer_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Support_Get_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Contacts_Get_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VKGroup_Get_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiscrodChannel_Get_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OfficialSite_Get_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetUpdates_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseGameWer_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.steamid_value = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // version_value
            // 
            this.version_value.BackColor = System.Drawing.Color.Transparent;
            this.version_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version_value.ForeColor = System.Drawing.Color.White;
            this.version_value.Location = new System.Drawing.Point(426, 213);
            this.version_value.Name = "version_value";
            this.version_value.Size = new System.Drawing.Size(134, 18);
            this.version_value.TabIndex = 8;
            this.version_value.Text = "[DEVBLOG]";
            this.version_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // status_value
            // 
            this.status_value.BackColor = System.Drawing.Color.Transparent;
            this.status_value.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.status_value.ForeColor = System.Drawing.Color.White;
            this.status_value.Location = new System.Drawing.Point(83, 238);
            this.status_value.Name = "status_value";
            this.status_value.Size = new System.Drawing.Size(278, 25);
            this.status_value.TabIndex = 9;
            this.status_value.Text = "status";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "GameWer Client";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DiscordChannelServer_StripMenuItem,
            this.VKGroupServer_StripMenuItem,
            this.Support_Get_StripMenuItem,
            this.toolStripSeparator1,
            this.Contacts_Get_StripMenuItem,
            this.GetUpdates_StripMenuItem,
            this.toolStripSeparator2,
            this.CloseGameWer_StripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 148);
            // 
            // DiscordChannelServer_StripMenuItem
            // 
            this.DiscordChannelServer_StripMenuItem.Image = global::GameWer.UI.UniversalDevblog.Properties.Resources.discord_support;
            this.DiscordChannelServer_StripMenuItem.Name = "DiscordChannelServer_StripMenuItem";
            this.DiscordChannelServer_StripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.DiscordChannelServer_StripMenuItem.Text = "Discord сервера";
            this.DiscordChannelServer_StripMenuItem.Click += new System.EventHandler(this.DiscordChannelServer_StripMenuItem_Click);
            // 
            // VKGroupServer_StripMenuItem
            // 
            this.VKGroupServer_StripMenuItem.Image = global::GameWer.UI.UniversalDevblog.Properties.Resources.vk;
            this.VKGroupServer_StripMenuItem.Name = "VKGroupServer_StripMenuItem";
            this.VKGroupServer_StripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.VKGroupServer_StripMenuItem.Text = "Группа сервера";
            this.VKGroupServer_StripMenuItem.Click += new System.EventHandler(this.VKGroupServer_StripMenuItem_Click);
            // 
            // Support_Get_StripMenuItem
            // 
            this.Support_Get_StripMenuItem.Image = global::GameWer.UI.UniversalDevblog.Properties.Resources.question;
            this.Support_Get_StripMenuItem.Name = "Support_Get_StripMenuItem";
            this.Support_Get_StripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.Support_Get_StripMenuItem.Text = "Поддержка GameWer";
            this.Support_Get_StripMenuItem.Click += new System.EventHandler(this.Support_Get_StripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // Contacts_Get_StripMenuItem
            // 
            this.Contacts_Get_StripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VKGroup_Get_StripMenuItem,
            this.DiscrodChannel_Get_StripMenuItem,
            this.OfficialSite_Get_StripMenuItem});
            this.Contacts_Get_StripMenuItem.Name = "Contacts_Get_StripMenuItem";
            this.Contacts_Get_StripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.Contacts_Get_StripMenuItem.Text = "Контакты";
            // 
            // VKGroup_Get_StripMenuItem
            // 
            this.VKGroup_Get_StripMenuItem.Image = global::GameWer.UI.UniversalDevblog.Properties.Resources.vk;
            this.VKGroup_Get_StripMenuItem.Name = "VKGroup_Get_StripMenuItem";
            this.VKGroup_Get_StripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.VKGroup_Get_StripMenuItem.Text = "Группа Вконтакте";
            this.VKGroup_Get_StripMenuItem.Click += new System.EventHandler(this.VKGroup_Get_StripMenuItem_Click);
            // 
            // DiscrodChannel_Get_StripMenuItem
            // 
            this.DiscrodChannel_Get_StripMenuItem.Image = global::GameWer.UI.UniversalDevblog.Properties.Resources.discord_support;
            this.DiscrodChannel_Get_StripMenuItem.Name = "DiscrodChannel_Get_StripMenuItem";
            this.DiscrodChannel_Get_StripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.DiscrodChannel_Get_StripMenuItem.Text = "Discrod канал";
            this.DiscrodChannel_Get_StripMenuItem.Click += new System.EventHandler(this.DiscrodChannel_Get_StripMenuItem_Click);
            // 
            // OfficialSite_Get_StripMenuItem
            // 
            this.OfficialSite_Get_StripMenuItem.Enabled = false;
            this.OfficialSite_Get_StripMenuItem.Name = "OfficialSite_Get_StripMenuItem";
            this.OfficialSite_Get_StripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.OfficialSite_Get_StripMenuItem.Text = "Официальный сайт";
            // 
            // GetUpdates_StripMenuItem
            // 
            this.GetUpdates_StripMenuItem.Enabled = false;
            this.GetUpdates_StripMenuItem.Name = "GetUpdates_StripMenuItem";
            this.GetUpdates_StripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.GetUpdates_StripMenuItem.Text = "Проверить обновление";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // CloseGameWer_StripMenuItem
            // 
            this.CloseGameWer_StripMenuItem.Name = "CloseGameWer_StripMenuItem";
            this.CloseGameWer_StripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.CloseGameWer_StripMenuItem.Text = "Отключиться от GameWer";
            this.CloseGameWer_StripMenuItem.Click += new System.EventHandler(this.CloseGameWer_StripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GameWer.UI.UniversalDevblog.Properties.Resources.discord__3_;
            this.pictureBox1.InitialImage = global::GameWer.UI.UniversalDevblog.Properties.Resources.discord__3_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 32F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(585, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 63);
            this.label1.TabIndex = 11;
            this.label1.Text = "×";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Steam64ID:";
            // 
            // steamid_value
            // 
            this.steamid_value.BackColor = System.Drawing.Color.Transparent;
            this.steamid_value.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.steamid_value.ForeColor = System.Drawing.Color.White;
            this.steamid_value.Location = new System.Drawing.Point(139, 309);
            this.steamid_value.Name = "steamid_value";
            this.steamid_value.Size = new System.Drawing.Size(187, 18);
            this.steamid_value.TabIndex = 13;
            this.steamid_value.Text = "steamid";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "GameWer Support";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameWer.UI.UniversalDevblog.Properties.Resources.gamewer_discord_banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.steamid_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.status_value);
            this.Controls.Add(this.version_value);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 360);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameWer AntiCheat [Devblog]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label version_value;
        private System.Windows.Forms.Label status_value;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label steamid_value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Support_Get_StripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Contacts_Get_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VKGroup_Get_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiscrodChannel_Get_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OfficialSite_Get_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GetUpdates_StripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CloseGameWer_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiscordChannelServer_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VKGroupServer_StripMenuItem;
    }
}

