/***
 * PictureSelect
 * Copyright (C) 2011-2015 Seiji HAMAGUCHI All Rights Reserved.
 ***/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PictureSelect
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        /// 
        // Ver 0.0.0.12
        // ショートカットキーの設定
        // 前回表示していたディレクトリの再表示
        // 重複起動の禁止

        [STAThread]
        static void Main()
        {
            // アプリケーションの二重起動を抑止する
            // http://www.ipentec.com/document/document.aspx?page=csharp-singleexec

            //ミューテックス作成
            System.Threading.Mutex _mutex = new System.Threading.Mutex(false, "PictureSelect");

            //ミューテックスの所有権を要求する
            if (_mutex.WaitOne(0, false) == false) {
                MessageBox.Show("本ソフトウェアは複数起動できません。");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
