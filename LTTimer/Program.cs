using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace LTTimer
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// アイコン：
    /// https://icooon-mono.com/11617-%E3%82%B9%E3%83%88%E3%83%83%E3%83%97%E3%82%A6%E3%82%A9%E3%83%83%E3%83%81%E3%81%AE%E3%82%A2%E3%82%A4%E3%82%B3%E3%83%B3/
    /// </remarks>
    static class Program
    {
        /// <summary>
        /// プログラム起動時オプション
        /// </summary>
        public static ProgramOption Option;

        /// <summary>
        /// ミューテックス名
        /// </summary>
        public static readonly string MutexName = "ShirayanagiRyuji.LTTimer";

        /// <summary>
        /// 複数インスタンス起動時
        /// </summary>
        public static bool IsDuplicateInstance;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ミューテックスが他のプロセスで既に取得されているかチェック
            using (Mutex mutex = new Mutex(false, MutexName, out bool isNewInstance))
            {
                // 複数起動中フラグ
                IsDuplicateInstance = !isNewInstance;

                // コマンドラインからプログラム起動オプションを設定
                ConfigureOptionsFromCommandLineArgs(args);

                FormTimer timerGui = new FormTimer();
                Application.Run(timerGui);
            }
        }

        /// <summary>
        /// コマンドライン引数からオプションを設定する
        /// </summary>
        /// <param name="args"></param>
        private static void ConfigureOptionsFromCommandLineArgs(string[] args)
        {
            // 各オプションの初期化
            Option.IsStartupClock = false;
            Option.IsZeroPoint = false;
            Option.IsStartPoint = false;
            Option.StartPoint = new System.Drawing.Point(0, 0);

            for (int argIdx = 0; argIdx < args.Length; argIdx++)
            {
                switch (args[argIdx].ToLower())
                {
                    // 起動時時計表示
                    case "/c":
                        if (IsDuplicateInstance == false)
                        {
                            Option.IsStartupClock = true;   // 複数起動時には無効
                        }
                        break;

                    // 起動時座標指定
                    case "/p":
                        string pointX = args[argIdx + 1];  // 座標X（文字）
                        string pointY = args[argIdx + 2];  // 座標Y（文字）

                        if (Option.SetStartPointIfValid(pointX, pointY) == true)
                        {
                            Option.IsStartPoint = true;
                            argIdx += 2;
                        }

                        break;

                    // 起動時座標 [0, 0]
                    case "/z":
                        Option.IsZeroPoint = true;
                        break;
                    
                    default:
                        // 何もしない
                        break;
                }
            }            
        }
    }
}
