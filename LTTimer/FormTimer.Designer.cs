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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.リセットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.フォント変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.位置移動ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTime = new LTTimer.LabelTime();
            this.時間設定toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.リセットToolStripMenuItem,
            this.時間設定toolStripMenuItem,
            this.toolStripMenuItem1,
            this.フォント変更ToolStripMenuItem,
            this.位置移動ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 120);
            // 
            // リセットToolStripMenuItem
            // 
            this.リセットToolStripMenuItem.Name = "リセットToolStripMenuItem";
            this.リセットToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.リセットToolStripMenuItem.Text = "リセット(&R)";
            this.リセットToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemReset_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // フォント変更ToolStripMenuItem
            // 
            this.フォント変更ToolStripMenuItem.Name = "フォント変更ToolStripMenuItem";
            this.フォント変更ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.フォント変更ToolStripMenuItem.Text = "フォント変更";
            this.フォント変更ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemChangeFont_Click);
            // 
            // 位置移動ToolStripMenuItem
            // 
            this.位置移動ToolStripMenuItem.Name = "位置移動ToolStripMenuItem";
            this.位置移動ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.位置移動ToolStripMenuItem.Text = "位置移動";
            this.位置移動ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemMove_Click);
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip1;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
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
            // 時間設定toolStripMenuItem
            // 
            this.時間設定toolStripMenuItem.Name = "時間設定toolStripMenuItem";
            this.時間設定toolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.時間設定toolStripMenuItem.Text = "時間設定";
            this.時間設定toolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemTimeSet_Click);
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(526, 147);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTimer";
            this.Text = "Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormTimer_Load);
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

    }
}

