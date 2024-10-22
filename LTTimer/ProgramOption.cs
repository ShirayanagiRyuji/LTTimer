using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LTTimer
{
    /// <summary>
    /// プログラムオプション構造体
    /// </summary>
    /// <remarks>
    /// プログラム起動時に設定されるオプション設定をまとめた構造体
    /// </remarks>
    public struct ProgramOption
    {
        /// <summary>
        /// 起動時に時計表示を行う [/c /C]
        /// </summary>
        /// <remarks>
        /// 重複起動時には無効になる
        /// </remarks>
        public bool IsStartupClock;

        /// <summary>
        /// 座標[0, 0]で起動する [/z /Z]
        /// </summary>s
        public bool IsZeroPoint;

        /// <summary>
        /// 指定座標で起動する [/p x座標 y座標 /P x座標 y座標]
        /// </summary>
        /// <remarks>
        /// 続く座標指定２つのパラメータが有効ではない場合、無効になる
        /// 設定の「前回座標」よりこちらの設定が優先される
        /// </remarks>
        public bool IsStartPoint;

        /// <summary>
        /// 起動時座標
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Point StartPoint;


        /// <summary>
        /// 座標指定の適切化判定
        /// 適切な場合は起動時座標として登録を行う
        /// </summary>
        /// <param name="pointX">X座標</param>
        /// <param name="pointY">Y座標</param>
        /// <returns>
        /// true:適切 false:不適切
        /// </returns>
        public bool SetStartPointIfValid(string pointX, string pointY)
        {
            int pointXi;    // 座標X（数値）
            int pointYi;    // 座標Y（数値）

            // X軸Y軸のパラメータが適正の場合のみ設定を行う
            if ((int.TryParse(pointX, out pointXi) == true)
             && (int.TryParse(pointY, out pointYi) == true))
            {
                StartPoint = new Point(pointXi, pointYi);
                return true;
            }

            return false;
        }
    }
}
