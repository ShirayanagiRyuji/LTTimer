using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTimer
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            // 画面外に出ないよう補正
            EnsureWindowVisible();
        }

        private void buttonResetPosition_Click(object sender, EventArgs e)
        {
            // 保存位置を (0,0) にリセットして保存
            Properties.Settings.Default.FormTimer_LocationX = 0;
            Properties.Settings.Default.FormTimer_LocationY = 0;
            Properties.Settings.Default.FormTimer_HasSavedLocation = true;
            Properties.Settings.Default.Save();

            MessageBox.Show("位置をリセットしました。次回起動時は左上(0,0)で起動します。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClearSavedPosition_Click(object sender, EventArgs e)
        {
            // 保存位置をクリア
            Properties.Settings.Default.FormTimer_HasSavedLocation = false;
            Properties.Settings.Default.Save();

            MessageBox.Show("保存位置をクリアしました。次回起動時は前回位置は復元されません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// このウィンドウが画面外に出ないように補正する
        /// </summary>
        private void EnsureWindowVisible()
        {
            try
            {
                Point center = new Point(this.Left + this.Width / 2, this.Top + this.Height / 2);
                Screen scr = Screen.FromPoint(center);
                var wa = scr.WorkingArea;

                int newLeft = this.Left;
                int newTop = this.Top;

                if (this.Width >= wa.Width)
                {
                    newLeft = wa.Left;
                }
                else
                {
                    if (newLeft < wa.Left) newLeft = wa.Left;
                    if (newLeft + this.Width > wa.Right) newLeft = wa.Right - this.Width;
                }

                if (this.Height >= wa.Height)
                {
                    newTop = wa.Top;
                }
                else
                {
                    if (newTop < wa.Top) newTop = wa.Top;
                    if (newTop + this.Height > wa.Bottom) newTop = wa.Bottom - this.Height;
                }

                if (newLeft != this.Left || newTop != this.Top)
                {
                    this.Location = new Point(newLeft, newTop);
                }
            }
            catch
            {
                // noop
            }
        }
    }
}
