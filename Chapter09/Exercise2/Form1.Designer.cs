
namespace Exercise2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btGyou = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.btTrance = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGyou
            // 
            this.btGyou.Location = new System.Drawing.Point(3, 12);
            this.btGyou.Name = "btGyou";
            this.btGyou.Size = new System.Drawing.Size(147, 77);
            this.btGyou.TabIndex = 0;
            this.btGyou.Text = "行番号";
            this.btGyou.UseVisualStyleBackColor = true;
            this.btGyou.Click += new System.EventHandler(this.btGyou_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // btTrance
            // 
            this.btTrance.Location = new System.Drawing.Point(3, 122);
            this.btTrance.Name = "btTrance";
            this.btTrance.Size = new System.Drawing.Size(122, 57);
            this.btTrance.TabIndex = 1;
            this.btTrance.Text = "変換先";
            this.btTrance.UseVisualStyleBackColor = true;
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(26, 213);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 2;
            this.btChange.Text = "button1";
            this.btChange.UseVisualStyleBackColor = true;
            // 
            // tbChange
            // 
            this.tbChange.Location = new System.Drawing.Point(156, 41);
            this.tbChange.Multiline = true;
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(433, 419);
            this.tbChange.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 546);
            this.Controls.Add(this.tbChange);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btTrance);
            this.Controls.Add(this.btGyou);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGyou;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.Button btTrance;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.TextBox tbChange;
    }
}

