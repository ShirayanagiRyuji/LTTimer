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
    public partial class FormTimer : Form
    {
        #region インスタンスフィールド
        /// <summary>
        /// 移動モード設定
        /// </summary>
        private bool f_MoveMode;

        /// <summary>
        /// マウス位置記憶
        /// </summary>
        private Point f_MousePoint;

        #endregion インスタンスフィールド


        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormTimer()
        {
            InitializeComponent();

            f_MoveMode = false;
        }
        #endregion コンストラクタ

        /// <summary>
        /// フォーム ロード時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTimer_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            // サイズ変更
            SizeF stringSize =  this.CreateGraphics().MeasureString("88:88.88", labelTime.Font);
            this.Size = stringSize.ToSize();
            labelTime.ResetTimer();
        }

        /// <summary>
        /// フォーム サイズ変更時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTimer_Resize(object sender, EventArgs e)
        {
            labelTime.labelResize(this.Size);
        }

        /// <summary>
        /// メニュー：リセット
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemReset_Click(object sender, EventArgs e)
        {
            labelTime.ResetTimer();
        }

        /// <summary>
        /// メニュー：時間設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemTimeSet_Click(object sender, EventArgs e)
        {
            //int retMinutes = 
            labelTime.LimitTime = new TimeSpan(0, 30, 0);
            labelTime.ResetTimer();
        }

        /// <summary>
        /// メニュー：移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemMove_Click(object sender, EventArgs e)
        {
            f_MoveMode = true;
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
        }

        /// <summary>
        /// メニュー：フォント変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemChangeFont_Click(object sender, EventArgs e)
        {
            try
            {
                using (FontDialog fd = new FontDialog())
                {
                    fd.Font = labelTime.Font;
                    fd.ShowDialog(this);

                    labelTime.Font = fd.Font;
                    SizeF stringSize = this.CreateGraphics().MeasureString("88:88.88", labelTime.Font);
                    this.Size = stringSize.ToSize();
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// マウス押した時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTimer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (f_MoveMode == true)
                {
                    //位置を記憶する
                    f_MousePoint = new Point(e.X, e.Y);
                }
                else if (labelTime.IsStartTimer() == false)
                {
                    // タイマー開始
                    labelTime.StartTimer();
                }
            }
        }

        /// <summary>
        /// マウス離した時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTimer_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (f_MoveMode == true)
                {
                    f_MoveMode = false;
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                }
            }
        }

        /// <summary>
        /// マウスを動かした時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTimer_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (f_MoveMode == true)
                {

                    this.Left += e.X - f_MousePoint.X;
                    this.Top += e.Y - f_MousePoint.Y;
                    //または、つぎのようにする
                    //this.Location = new Point(
                    //    this.Location.X + e.X - mousePoint.X,
                    //    this.Location.Y + e.Y - mousePoint.Y);
                }
            }
        }

        /// <summary>
        /// キーダウン時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTimer_KeyDown(object sender, KeyEventArgs e)
        {
            // 制限時間増加
            if ((e.KeyCode == Keys.Add)         // テンキー'+'
             || (e.KeyCode == Keys.Oemplus))    // 文字キー'+'
            {
                labelTime.StopTimer();
                labelTime.LimitTimeAdd(1);
                labelTime.ResetTimer();
            }

            // 制限時間減少
            if ((e.KeyCode == Keys.Subtract)    // テンキー'-'
             || (e.KeyCode == Keys.OemMinus))   // 文字キー'-'
            {
                labelTime.StopTimer();
                labelTime.LimitTimeAdd(-1);
                labelTime.ResetTimer();
            }

            // 制限時間リセット
            if (e.KeyCode == Keys.Delete)
            {
                labelTime.StopTimer();
                labelTime.LimitTime = new TimeSpan(0, 5, 0);
                labelTime.ResetTimer();
            }
        }
    }
}
