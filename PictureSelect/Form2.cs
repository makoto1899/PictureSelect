using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureSelect
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            String richText = "PictureSelectは、画像を気軽に選別できるプログラムです。\r\n";
            richText = richText + "快適な操作性を確保するために、キーボードによるインターフェイスを提供しています。\r\n";
            richText = richText + "FPSで使われる「WSAD」スタイルを採用しています。(変更不可)\r\n";
            richText = richText + "・Dキー: 次の画像を表示します。\r\n";
            richText = richText + "・Aキー: 前の画像を表示します。\r\n";
            richText = richText + "・Wキー: 画像に削除予約をします。次の画像を読み出します。\r\n";
            richText = richText + "・Qキー: 画像を左90度回転させます。\r\n";
            richText = richText + "・Eキー: 画像を右90度回転させます。\r\n";
            richText = richText + "・Sキー: 削除予約されているファイルを削除します。\r\n";
            richText = richText + "・Xキー: 関連プログラムを起動します。\r\n";
            richText = richText + "この画面で動作確認ができます。キーボードを押すと、\r\n";
            richText = richText + "ステータスバーに指示された動作が表示されます。\r\n";

            richTextBox1.Text = richText;
            toolStripStatusLabel1.Text = "説明";
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            // Form も、すべてのキーイベントを受け取るように設定する
            this.KeyPreview = true;
        }

        private void HelpForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                toolStripStatusLabel1.Text = "Dキー: 次の画像を表示";
            }
            else if (e.KeyCode == Keys.A)
            {
                toolStripStatusLabel1.Text = "Aキー: 前の画像を表示";
            }
            else if (e.KeyCode == Keys.E)
            {
                toolStripStatusLabel1.Text = "Eキー: 画像を右90度回転";
            }
            else if (e.KeyCode == Keys.Q)
            {
                toolStripStatusLabel1.Text = "Qキー: 画像を左90度回転";
            }
            else if (e.KeyCode == Keys.W)
            {
                toolStripStatusLabel1.Text = "Wキー: 画像に削除予約";
            }
            else if (e.KeyCode == Keys.S)
            {
                toolStripStatusLabel1.Text = "Sキー: 削除";
            }
            else if (e.KeyCode == Keys.X)
            {
                toolStripStatusLabel1.Text = "Xキー: 関連プログラムを起動";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Qキー: 画像を左90度回転";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Wキー: 画像に削除予約";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Qキー: 画像を左90度回転";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Aキー: 前の画像を表示";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Sキー: 削除";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dキー: 次の画像を表示";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Xキー: 関連プログラムを起動";
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
