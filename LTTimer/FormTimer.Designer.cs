namespace LTTimer
{
    partial class FormTimer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimer));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.リセットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.時間設定toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.時間設定toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.フォント変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色変更toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.位置移動ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.切替toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.userControlSystemDateView1 = new LTTimer.UserContols.TEMPLATES.UserControlSystemDateView();
            this.labelTime = new LTTimer.LabelTime();
            this.位置リセットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.リセットToolStripMenuItem,
            this.時間設定toolStripMenuItem,
            this.toolStripMenuItem1,
            this.フォント変更ToolStripMenuItem,
            this.色変更toolStripMenuItem,
            this.位置移動ToolStripMenuItem,
            this.位置リセットToolStripMenuItem,
            this.toolStripSeparator1,
            this.切替toolStripMenuItem,
            this.終了toolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 192);
            // 
            // リセットToolStripMenuItem
            // 
            this.リセットToolStripMenuItem.Name = "リセットToolStripMenuItem";
            this.リセットToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.リセットToolStripMenuItem.Text = "リセット(&R)";
            this.リセットToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemReset_Click);
            // 
            // 時間設定toolStripMenuItem
            // 
            this.時間設定toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.時間設定toolStripTextBox});
            this.時間設定toolStripMenuItem.Name = "時間設定toolStripMenuItem";
            this.時間設定toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.時間設定toolStripMenuItem.Text = "時間設定";
            this.時間設定toolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemTimeSet_Click);
            // 
            // 時間設定toolStripTextBox
            // 
            this.時間設定toolStripTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.6F);
            this.時間設定toolStripTextBox.Name = "時間設定toolStripTextBox";
            this.時間設定toolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.時間設定toolStripTextBox.Text = "5:00";
            this.時間設定toolStripTextBox.TextChanged += new System.EventHandler(this.時間設定toolStripTextBox_TextChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // フォント変更ToolStripMenuItem
            // 
            this.フォント変更ToolStripMenuItem.Name = "フォント変更ToolStripMenuItem";
            this.フォント変更ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.フォント変更ToolStripMenuItem.Text = "フォント変更";
            this.フォント変更ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemChangeFont_Click);
            // 
            // 色変更toolStripMenuItem
            // 
            this.色変更toolStripMenuItem.Name = "色変更toolStripMenuItem";
            this.色変更toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.色変更toolStripMenuItem.Text = "色変更";
            this.色変更toolStripMenuItem.Click += new System.EventHandler(this.色変更toolStripMenuItem_Click);
            // 
            // 位置移動ToolStripMenuItem
            // 
            this.位置移動ToolStripMenuItem.Name = "位置移動ToolStripMenuItem";
            this.位置移動ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.位置移動ToolStripMenuItem.Text = "位置移動";
            this.位置移動ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemMove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 切替toolStripMenuItem
            // 
            this.切替toolStripMenuItem.Checked = true;
            this.切替toolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.切替toolStripMenuItem.Name = "切替toolStripMenuItem";
            this.切替toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.切替toolStripMenuItem.Text = "時計切替";
            this.切替toolStripMenuItem.Click += new System.EventHandler(this.切替toolStripMenuItem_Click);
            // 
            // 終了toolStripMenuItem
            // 
            this.終了toolStripMenuItem.Name = "終了toolStripMenuItem";
            this.終了toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了toolStripMenuItem.Text = "終了(&E)";
            this.終了toolStripMenuItem.Click += new System.EventHandler(this.終了toolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LTTimer";
            this.notifyIcon1.Visible = true;
            // 
            // userControlSystemDateView1
            // 
            this.userControlSystemDateView1.BackColor = System.Drawing.Color.Black;
            this.userControlSystemDateView1.ContextMenuStrip = this.contextMenuStrip1;
            this.userControlSystemDateView1.ForeColor = System.Drawing.Color.White;
            this.userControlSystemDateView1.Location = new System.Drawing.Point(0, 0);
            this.userControlSystemDateView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlSystemDateView1.Name = "userControlSystemDateView1";
            this.userControlSystemDateView1.Size = new System.Drawing.Size(526, 147);
            this.userControlSystemDateView1.TabIndex = 2;
            this.userControlSystemDateView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTimer_MouseDown);
            this.userControlSystemDateView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTimer_MouseMove);
            this.userControlSystemDateView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormTimer_MouseUp);
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip1;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.LimitTime = System.TimeSpan.Parse("00:05:00");
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(526, 147);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "00:00.000";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTimer_MouseDown);
            this.labelTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTimer_MouseMove);
            this.labelTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormTimer_MouseUp);
            // 
            // 位置リセットToolStripMenuItem
            // 
            this.位置リセットToolStripMenuItem.Name = "位置リセットToolStripMenuItem";
            this.位置リセットToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.位置リセットToolStripMenuItem.Text = "位置リセット";
            this.位置リセットToolStripMenuItem.Click += new System.EventHandler(this.位置リセットToolStripMenuItem_Click);
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(526, 147);
            this.Controls.Add(this.userControlSystemDateView1);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormTimer";
            this.Text = "Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormTimer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTimer_KeyDown);
            this.Resize += new System.EventHandler(this.FormTimer_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem フォント変更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 位置移動ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem リセットToolStripMenuItem;
        private LabelTime labelTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 時間設定toolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 切替toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox 時間設定toolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem 色変更toolStripMenuItem;
        private UserContols.TEMPLATES.UserControlSystemDateView userControlSystemDateView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 位置リセットToolStripMenuItem;
    }
}

