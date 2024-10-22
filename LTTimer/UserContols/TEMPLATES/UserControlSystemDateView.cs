using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;

namespace LTTimer.UserContols.TEMPLATES
{
    public partial class UserControlSystemDateView : UserControl
    {
        #region インスタンスフィールド
        /// <summary>
        /// タイマー
        /// </summary>
        private System.Threading.Timer f_Timer;

        private static readonly CultureInfo CultureJaJP = new CultureInfo("ja-JP");
        private static readonly CultureInfo CultureEnUS = new CultureInfo("en-US");

        #endregion インスタンスフィールド

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UserControlSystemDateView()
        {
            InitializeComponent();

            f_Timer = new System.Threading.Timer(OnTimer);
        }


        #region イベント
        /// <summary>
        /// マウス押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            // MouseDownイベントを発火する
            OnMouseDown(e);
        }

        /// <summary>
        /// マウス移動時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            // MouseMoveイベントを発火する
            OnMouseMove(e);
        }

        /// <summary>
        /// マウス離した時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            // MouseUpイベントを発火する
            OnMouseUp(e);
        }

        /// <summary>
        /// タイマー処理
        /// </summary>
        /// <param name="e"></param>
        public void OnTimer(object e)
        {
            // 日時描画
            Draw();
        }

        #endregion イベント


        #region メソッド
        /// <summary>
        /// タイマー描画
        /// </summary>
        private void Draw()
        {
            var now = DateTime.Now;
            var dayOfWeek = now.ToString("ddd", CultureJaJP);
            //var dayOfWeek = now.ToString("ddd", CultureEnUS);

            if (this.InvokeRequired)   // メインスレッド以外から呼ばれた場合
            {
                this.Invoke((MethodInvoker)delegate
                {
                    labelDate.Text = $"{now.Year}年{now.Month}月{now.Day}日（{dayOfWeek}）";
                    labelTime.Text = $"{now.Hour:00}:{now.Minute:00}:{now.Second:00}";
                });
            }
            else
            {
                labelDate.Text = $"{now.Year}年{now.Month}月{now.Day}日（{dayOfWeek}）";
                labelTime.Text = $"{now.Hour:00}:{now.Minute:00}:{now.Second:00}";
            }
}

        /// <summary>
        /// 時計更新開始
        /// </summary>
        public void StarUpdate()
        {
            f_Timer.Change(0, 20);  // 初回即時更新、30ミリSecごと更新
        }

        /// <summary>
        /// 時計更新停止
        /// </summary>
        public void StopUpdate()
        {
            f_Timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
        }

        /// <summary>
        /// フォントサイズ更新
        /// </summary>
        public void UpdateSize(Size controlSize, Font labelBaseFont)
        {
            // 位置・サイズ変更
            labelDate.Location = new Point(0, 0);
            labelDate.Size = new Size(controlSize.Width, (int)(controlSize.Height * (64.0f / 184)));
            labelTime.Location = new Point(0, labelDate.Size.Height);
            labelTime.Size = new Size(controlSize.Width, (int)(controlSize.Height * (120.0f / 184)));

            // フォントサイズ変更
            labelDate.Font = new Font(labelBaseFont.FontFamily, labelBaseFont.Size * (36.0f / 108));
            labelTime.Font = new Font(labelBaseFont.FontFamily, labelBaseFont.Size * (72.0f / 108));
        }

        #endregion メソッド

    }
}
