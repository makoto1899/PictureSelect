/***
 * PictureSelect
 * Copyright (C) 2011-2015 Seiji HAMAGUCHI All Rights Reserved.
 ***/
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using LevDan.Exif;

namespace PictureSelect
{

    public partial class Form1 : Form
    {

        // C#で配列を宣言するには？
        // http://www.atmarkit.co.jp/fdotnet/dotnettips/261arrayinit/arrayinit.html

        // Coding4Fun: .NET で Flickr を使用する
        // http://msdn.microsoft.com/ja-jp/library/bb932361.aspx

        // ExifTagCollection - An EXIF metadata extraction library
        // http://www.codeproject.com/KB/graphics/exiftagcol.aspx
        // 

        // 全画像ファイルパス
        string[] pictureFiles = null;
        string[] deletePictureFiles = null;
        bool[] deletePictureFlag = null;
        string selectPath = null;
        // string editProgram = null;
        long pictureNowCount;
        long deletePictoureCount;

        public Form1()
        {
            InitializeComponent();

            noSecondToolStripMenuItem.Checked = true;
            disableEXIFToolStripMenuItem.Checked = true;

            //アプリケーションの設定を読み込む
            Properties.Settings.Default.Reload();

            // 設定からバックグラウンド色を取得する
            pictureBox1.BackColor = Properties.Settings.Default.BackColor;
            //dataGridView1.BackgroundColor = Properties.Settings.Default.BackColor;

            // 設定からExif表示ある/なしを取得する
            if (Properties.Settings.Default.ExifFlag)
            {
                enableEXIFToolStripMenuItem.Checked = true;
                disableEXIFToolStripMenuItem.Checked = false;
            }
            else
            {
                enableEXIFToolStripMenuItem.Checked = false;
                disableEXIFToolStripMenuItem.Checked = true;
            }

            // 最後に読み込んだディレクトリを取得する
            selectPath = Properties.Settings.Default.LastSelectPath;
            if (selectPath != "" || selectPath == null)
            {
                // 指定されたディレクトリを取得する
                folderOpen(selectPath);
            }

            // 最後のWindows状態を取得する
            FormWindowState windowState = Properties.Settings.Default.WindowState;
            this.WindowState = windowState;

            // 編集プログラムを取得する
            // editProgram = Properties.Settings.Default.EditProgram;

            // ユーザーによる新しい行の追加禁止
            dataGridView1.AllowUserToAddRows = false;
            // ユーザーによる行の変更、削除の禁止
            dataGridView1.ReadOnly = true;
            //DataGridView1の列の幅をユーザーが変更できないようにする
            dataGridView1.AllowUserToResizeColumns = false;
            //DataGridView1の行の高さをユーザーが変更できないようにする
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form も、すべてのキーイベントを受け取るように設定する
            this.KeyPreview = true;
            // タイマーは無効にする
            timer1.Enabled = false;

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                VersionDialog VersionDialog = new VersionDialog();
                VersionDialog.ShowDialog();
                VersionDialog.Dispose();
            }
        }

        private void selectDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 新規のフォルダを作るを禁止
            folderBrowserDialog1.ShowNewFolderButton = false;

            // もしもフォルダが開けたら
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                //// 選択したパスを保存する
                selectPath = folderBrowserDialog1.SelectedPath;

                // 指定されたディレクトリを取得する
                folderOpen(selectPath);

                folderBrowserDialog1.Dispose();
            }
        }

        private void folderOpen(String selectPath)
        {
            try
            {

                // フォルダーオープン時点で、現在の画像番号を初期化する
                pictureNowCount = 0;

                // フォルダーオープン時点で、削除ファイル番号を初期化する。
                deletePictoureCount = 0;

                // 拡張子が .jpg を抽出する
                string[] files_jpg = Directory.GetFiles(selectPath, "*.jpg");
                // 拡張子が .jpeg を抽出する
                string[] files_jpeg = Directory.GetFiles(selectPath, "*.jpeg");
                // 拡張子が .png を抽出する
                string[] files_png = Directory.GetFiles(selectPath, "*.png");
                // 拡張子が .bmp を抽出する
                string[] files_bmp = Directory.GetFiles(selectPath, "*.bmp");
                // 拡張子が .gif を抽出する
                string[] files_gif = Directory.GetFiles(selectPath, "*.gif");

                pictureFiles = files_jpg;
                pictureFiles = pictureFiles.Concat(files_jpeg).ToArray();
                pictureFiles = pictureFiles.Concat(files_png).ToArray();
                pictureFiles = pictureFiles.Concat(files_bmp).ToArray();
                pictureFiles = pictureFiles.Concat(files_gif).ToArray();

                if (pictureFiles.Length > 0)
                {
                    this.pictureFilesLoad();
                }

                // ステータスバーのプログレッシブバーのMAX/MINをセット
                toolStripProgressBar1.Minimum = 0;
                toolStripProgressBar1.Maximum = pictureFiles.Length;

                // 削除予約文字列を初期化
                deletePictureFiles = new String[pictureFiles.Length];

                // 削除予約フラグを初期化
                deletePictureFlag = new bool[pictureFiles.Length];

                for (int i = 0; i < pictureFiles.Length; i++)
                {
                    deletePictureFlag[i] = false;
                }

                // 読み込んだディレクトリをセーブ
                Properties.Settings.Default.LastSelectPath = selectPath;
            }
            catch
            {
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // プログラム終了
            //this.pictureFiles.Initialize();
            //this.deletePictureFiles.Initialize();
            //this.deletePictureFlag.Initialize();

            // Windows状態を保存します。
            Properties.Settings.Default.WindowState = this.WindowState;
            // 編集プログラムを保持します。
            // Properties.Settings.Default.EditProgram = editProgram;

            //アプリケーションの設定を保存する
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (pictureFiles == null)
            {
                return;
            }

            if (e.KeyCode == Keys.D)
            {
                // 画像カウントを+1する
                pictureNowCount++;
                // 次の画像を表示
                this.pictureFilesLoad();

            }
            else if (e.KeyCode == Keys.A)
            {
                // 画像カウントを-1にする
                pictureNowCount--;
                // 次の画像を表示
                this.pictureFilesLoad();
            }
            else if (e.KeyCode == Keys.E)
            {
                // 画像を回転させる(右90度回転)
                pictureBox1.Load(pictureFiles[pictureNowCount]);
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();

            }
            else if (e.KeyCode == Keys.Q)
            {
                // 画像を回転させる(左90度回転)
                pictureBox1.Load(pictureFiles[pictureNowCount]);
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Refresh();
            }
            else if (e.KeyCode == Keys.W)
            {
                // 削除する変数にファイルを追加
                deletePictureFiles[deletePictoureCount] = pictureFiles[pictureNowCount];
                // 削除フラグをtrueにする
                deletePictureFlag[pictureNowCount] = true;
                // 削除ファイル番号を+1する
                deletePictoureCount++;

                // 画像カウントを+1する
                pictureNowCount++;
                // 次の画像を表示
                this.pictureFilesLoad();
            }
            else if (e.KeyCode == Keys.S)
            {
                this.deleteToolStripMenuItem_Click(null, null);
            }
            else if (e.KeyCode == Keys.X)
            {
                editPictureStart();
            }

        }

        private void pictureFilesLoad()
        {
            try
            {

                // 画像を表示させる
                pictureBox1.Load(pictureFiles[pictureNowCount]);

            }
            catch
            {
                // MessageBox.Show("画像が最後まで読み込まれました。最初から読み出します。", "インフォメーション", MessageBoxButtons.OK, MessageBoxIcon.Information );

                // 画像カウントを0にする
                pictureNowCount = 0;

                try
                {
                    // 画像を表示させる
                    pictureBox1.Load(pictureFiles[pictureNowCount]);
                }
                catch (Exception e)
                {
                    MessageBox.Show("読み込みエラーが発生しました。\r\n違うディレクトリを指定して下さい。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            try
            {
                // 削除予約の場合、ステータスバーに「削除予定」と表示
                if (deletePictureFlag[pictureNowCount] == true)
                {
                    deleteStatusLabel.Text = "削除予定";
                    deleteStatusLabel.Visible = true;
                }
                else
                {
                    //deleteStatusLabel.Text = "";
                    deleteStatusLabel.Visible = false;
                }
            }
            catch
            {

            }

            // ステータスバーにファイルパスを表示する
            pictureFilePath.Text = pictureFiles[pictureNowCount];
            
            // 画像サイズは、Zoom
            // PictureBox.SizeMode
            // http://msdn.microsoft.com/ja-jp/library/system.windows.forms.picturebox.sizemode.aspx
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            toolStripProgressBar1.Value = (int)pictureNowCount;

            ExifTagCollection exif = new ExifTagCollection(pictureFiles[pictureNowCount]);

            // 画像の回転
            pictureOrientation(pictureFiles[pictureNowCount], exif);

            // Exif情報表示                
            if (enableEXIFToolStripMenuItem.Checked == true)
            {
                dataGridView1.Rows.Clear();

                foreach (ExifTag tag in exif)
                {
                    dataGridView1.Rows.Add(tag.FieldName, tag.Value);
                }

                dataGridView1.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;

            }

        }

        /**
         * 画像の回転
         */
        private void pictureOrientation(String filename, ExifTagCollection exif)
        {

            foreach (ExifTag tag in exif)
            {
                if (tag.FieldName == "Orientation")
                {
                    //    case 1: value = "The 0th row is at the visual top of the image, and the 0th column is the visual left-hand side."; break;
                    if (tag.Value == "1")
                    {
                        // 正常
                    }
                    //    case 2: value = "The 0th row is at the visual top of the image, and the 0th column is the visual right-hand side."; break;
                    else if (tag.Value == "2")
                    {
                        MessageBox.Show("Orientation:2 No,Support");
                    }
                    //    case 3: value = "The 0th row is at the visual bottom of the image, and the 0th column is the visual right-hand side."; break;
                    else if (tag.Value == "3")
                    {
                        // 右180度回転
                        pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        pictureBox1.Refresh();
                    }
                    //    case 4: value = "The 0th row is at the visual bottom of the image, and the 0th column is the visual left-hand side."; break;
                    else if (tag.Value == "4")
                    {
                        MessageBox.Show("Orientation:4 No,Support");
                    }
                    //    case 5: value = "The 0th row is the visual left-hand side of the image, and the 0th column is the visual top."; break;
                    else if (tag.Value == "5")
                    {
                        MessageBox.Show("Orientation:5 No,Support");
                    }
                    //    case 6: value = "The 0th row is the visual right-hand side of the image, and the 0th column is the visual top."; break;
                    else if (tag.Value == "6")
                    {
                        // 右90度回転
                        pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        pictureBox1.Refresh();
                    }
                    //    case 7: value = "The 0th row is the visual right-hand side of the image, and the 0th column is the visual bottom."; break;
                    else if (tag.Value == "7")
                    {
                        // 右90度回転
                        pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        pictureBox1.Refresh();
                    }
                    //    case 8: value = "The 0th row is the visual left-hand side of the image, and the 0th column is the visual bottom."; break;
                    else if (tag.Value == "8")
                    {
                        // 左90度回転
                        pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        pictureBox1.Refresh();
                    }

                }
            }

        }

        private void deleteFiles(String filename)
        {
            try
            {
                // ファイル削除
                System.IO.File.Delete(filename);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deletePictureFiles == null)
            {
                return;
            }

            String xMessage = "画像ファイル: ";
            xMessage = xMessage + deletePictoureCount + "枚を削除します。";

            DialogResult result = MessageBox.Show(xMessage, "インフォメーション", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < deletePictoureCount; i++)
                {
                    this.deleteFiles(deletePictureFiles[i]);
                }
                deletePictureFiles = null;
                deletePictoureCount = 0;

                // フォルダーを開き直す
                pictureFiles = null;
                folderOpen(selectPath);
                MessageBox.Show("ファイルを削除しました。", "インフォメーション", MessageBoxButtons.OK, MessageBoxIcon.Information);

                deleteStatusLabel.Visible = false;
            }
            else if (result == DialogResult.No)
            {
                // 「いいえ」が選択された時

            }
            else if (result == DialogResult.Cancel)
            {
                //「キャンセル」が選択された時 
            }
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
                dataGridView1.BackgroundColor = colorDialog1.Color;
                Properties.Settings.Default.BackColor = colorDialog1.Color;
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelpForm HelpForm = new HelpForm();
            HelpForm.StartPosition = FormStartPosition.CenterParent;
            HelpForm.ShowDialog();
            HelpForm.Dispose();
        }

        private void noSecondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            second3ToolStripMenuItem.Checked = false;
            second8ToolStripMenuItem.Checked = false;
            second5ToolStripMenuItem.Checked = false;

            // タイマーを止めます。
            timer1.Enabled = false;

        }

        private void second3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noSecondToolStripMenuItem.Checked = false;
            second5ToolStripMenuItem.Checked = false;
            second8ToolStripMenuItem.Checked = false;

            // タイマーを3秒にする
            timer1.Interval = 3000;
            timer1.Enabled = true;

        }

        private void second5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noSecondToolStripMenuItem.Checked = false;
            second3ToolStripMenuItem.Checked = false;
            second8ToolStripMenuItem.Checked = false;

            // タイマーを5秒にする
            timer1.Interval = 5000;
            timer1.Enabled = true;

        }

        private void second8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noSecondToolStripMenuItem.Checked = false;
            second3ToolStripMenuItem.Checked = false;
            second5ToolStripMenuItem.Checked = false;

            // タイマーを3秒にする
            timer1.Interval = 8000;
            timer1.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureFiles != null)
            {
                // 画像カウントを+1する
                pictureNowCount++;
                // 次の画像を表示
                this.pictureFilesLoad();
            }

        }

        private void disableEXIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableEXIFToolStripMenuItem.Checked = false;
            Properties.Settings.Default.ExifFlag = false;
        }

        private void enableEXIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disableEXIFToolStripMenuItem.Checked = false;
            Properties.Settings.Default.ExifFlag = true;
        }

        //private void editProgramToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    openFileDialog2.Filter = "exe files (*.exe)|*.exe";
        //    openFileDialog2.FilterIndex = 1;
        //    openFileDialog2.RestoreDirectory = true;
        //    openFileDialog2.Title = "画像編集ソフト選択";

        //    DialogResult result = openFileDialog2.ShowDialog();

        //    if (result == DialogResult.OK)
        //    {
        //        editProgram = openFileDialog2.FileName;
        //    }
        //}

        private void editPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editPictureStart();
        }

        private void editPictureStart()
        {
            try
            {
                // 関連プログラムの起動
                Process.Start(@pictureFiles[pictureNowCount]);
            }
            catch (Exception e)
            {
                MessageBox.Show("はじめに、画像を表示して下さい。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
