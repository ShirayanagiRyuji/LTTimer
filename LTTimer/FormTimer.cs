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

        private TimeSpan f_LimitTime;

        #endregion インスタンスフィールド


        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormTimer()
        {
            InitializeComponent();

            // インスタンスの初期化
            f_MoveMode = false;
            f_LimitTime = new TimeSpan(0, 5, 0);
        }
        #endregion コンストラクタ


        #region イベント

        #region イベント From
        /// <summary>
        /// フォーム ロード時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTimer_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            // フォントサイズ変更
            ChangeFontSize();

            // 時間設定テキスト設定
            UpdateTimeSettingText();

            // 時計切替設定
            切替toolStripMenuItem.Checked = false;
            ChangeClockView();

            // タイマーリセット
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
        /// マウス押した時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTimer_MouseDown(object sender, MouseEventArgs e)
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

            if (e.KeyCode == Keys.Decimal)
            {
                labelTime.StopTimer();

                if ((e.KeyData & Keys.Control) == (int)Keys.None)
                {
                    // Ctrlキー同時押しなし：1秒追加
                    labelTime.LimitTimeAddSec(1);
                }
                else
                {
                    // Shiftキー同時押しあり：10秒追加
                    labelTime.LimitTimeAddSec(10);
                }

                labelTime.ResetTimer();
            }

            // 制限時間リセット
            if (e.KeyCode == Keys.Delete)
            {
                labelTime.StopTimer();
                labelTime.LimitTime = f_LimitTime;
                labelTime.ResetTimer();
            }
        }
        #endregion イベント From

        #region イベント メニュー
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
#if false
            //int retMinutes = 
            labelTime.LimitTime = new TimeSpan(0, 30, 0);
#endif
            labelTime.LimitTime = f_LimitTime;
            labelTime.ResetTimer();
        }

        /// <summary>
        /// メニュー：時間設定テキスト更新時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 時間設定toolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            TimeSpan res;
            if (TimeSpan.TryParse(時間設定toolStripTextBox.Text, out res) == true)
            {
                if (res.Days > 0)
                {
                    // 入力[9] は 「9日0時0分」となる為、「9分0秒」となる様にずらす
                    f_LimitTime = new TimeSpan(0, res.Days, 0);
                }
                else if (res.Hours > 0)
                {
                    // 入力[5:30] は 「5時30分」となる為、「5分30秒」となる様にずらす
                    f_LimitTime = new TimeSpan(0, res.Hours, res.Minutes);
                }
                else
                {
                    //　そのまま設定する
                    f_LimitTime = res;
                }

                // テキストフォーマット
                UpdateTimeSettingText();
            }
            else
            {
                // 入力[30:24]はエラーになる為、戦闘に[0:]を補って再度変換する
                if (TimeSpan.TryParse("0:" + 時間設定toolStripTextBox.Text, out res) == true)
                {
                    f_LimitTime = res;          // 入力[0:30:24] は 「30分24秒」となる為、そのまま設定する
                    UpdateTimeSettingText();    // テキストフォーマット
                }
            }
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

                    // フォントサイズの更新
                    ChangeFontSize();                
                }
            }
            catch
            {
            }
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
        /// メニュー：時計切替
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 切替toolStripMenuItem_Click(object sender, EventArgs e)
        {
            // チェック切替
            切替toolStripMenuItem.Checked = !切替toolStripMenuItem.Checked;
            ChangeClockView();
        }

        /// <summary>
        /// メニュー：終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 終了toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion イベント メニュー

        #endregion イベント


        #region メソッド
        /// <summary>
        /// 時間設定テキスト設定
        /// </summary>
        private void UpdateTimeSettingText()
        {
            時間設定toolStripTextBox.Text = string.Format("{0}:{1:00}", f_LimitTime.Minutes, f_LimitTime.Seconds);
        }

        /// <summary>
        /// フォントサイズ変更
        /// </summary>
        private void ChangeFontSize()
        {
            SizeF stringSize = this.CreateGraphics().MeasureString("88:88.88", labelTime.Font);
            this.Size = stringSize.ToSize();

            userControlSystemDateView1.Location = new Point(0, 0);
            userControlSystemDateView1.Size = this.Size;
            userControlSystemDateView1.UpdateSize(this.Size, labelTime.Font);
        }

        /// <summary>
        /// 時計表示切り替え
        /// </summary>
        private void ChangeClockView()
        {
            if (切替toolStripMenuItem.Checked == true)
            {
                userControlSystemDateView1.Visible = true;
                userControlSystemDateView1.StarUpdate();    // 時計更新開始
            }
            else
            {
                userControlSystemDateView1.Visible = false;
                userControlSystemDateView1.StarUpdate();    // 時計更新停止
            }
        }

        #endregion メソッド

    }
}
