using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 追加した参照
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LTTimer
{
    /// <summary>
    /// タイマー用ラベルコントロール
    /// </summary>
    internal class LabelTime : System.Windows.Forms.Label
    {
        #region インスタンスフィールド
        /// <summary>
        /// タイマー
        /// </summary>
        private System.Threading.Timer f_Timer;

        /// <summary>
        /// タイマー開始フラグ
        /// </summary>
        private bool f_StartTimer;

        /// <summary>
        /// 残り時間
        /// </summary>
        private TimeSpan f_Time;

        /// <summary>
        /// 
        /// </summary>
        private DateTime f_StartTime;

        #endregion インスタンスフィールド


        #region プロパティ
        /// <summary>
        /// 制限時間
        /// </summary>
        public TimeSpan LimitTime { get; set; }

        #endregion プロパティ


        #region コンストラクタ
        public LabelTime()
        {
            LimitTime = new TimeSpan(0, 5, 0);
        }
        #endregion コンストラクタ


        #region イベント
        /// <summary>
        /// タイマー処理
        /// </summary>
        /// <param name="e"></param>
        public void OnTimer(object e)
        {
            // タイマーカウントダウン＆更新
#if false
            f_Time += new TimeSpan(0, 0, 0, 0, -1);
#else
            TimeSpan time = LimitTime - (DateTime.Now - f_StartTime);
#endif
            // カウントゼロ
            if (time.TotalMilliseconds <= 0)
            {
                // タイマー停止
                StopTimer();
                time = new TimeSpan();
            }

            // タイマー描画
            Draw(time);
        }

        #endregion イベント


        #region メソッド
        /// <summary>
        /// タイマー描画
        /// </summary>
        private void Draw(TimeSpan time)
        {
            if (this.InvokeRequired)   // メインスレッド以外から呼ばれた場合
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Text = string.Format("{0:00}:{1:00}.{2:00}", time.Minutes, time.Seconds, time.Milliseconds / 10);
                });
            }
            else
            {
                this.Text = string.Format("{0:00}:{1:00}.{2:00}", time.Minutes, time.Seconds, time.Milliseconds / 10);
            }
        }

        /// <summary>
        /// タイマー開始状態取得
        /// </summary>
        public bool IsStartTimer()
        {
            return f_StartTimer;
        }

        /// <summary>
        /// サイズ設定
        /// </summary>
        /// <param name="size"></param>
        public void labelResize(Size size)
        {
            this.Location = new Point(0, 0);
            this.Size = size;
        }

        /// <summary>
        /// タイマーリセット
        /// </summary>
        public void ResetTimer()
        {
            // タイマー停止
            StopTimer();

            // タイマー初期化
            f_Time = LimitTime;
            Draw(f_Time);
        }

        /// <summary>
        /// タイマー開始
        /// </summary>
        public void StartTimer()
        {
            StopTimer();
            f_StartTime = DateTime.Now;
            f_Timer = new System.Threading.Timer(OnTimer, this, 0, 10);
            f_StartTimer = true;
        }

        /// <summary>
        /// タイマー停止
        /// </summary>
        public void StopTimer()
        {
            if (f_Timer != null)
            {
                f_Timer.Dispose();
            }
            f_Timer = null;
            f_StartTimer = false;
        }

        #endregion メソッド
    }
}
