
namespace Exercise1
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
            this.btButton = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.btReadLine = new System.Windows.Forms.Button();
            this.btReadLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btButton
            // 
            this.btButton.Location = new System.Drawing.Point(54, 32);
            this.btButton.Name = "btButton";
            this.btButton.Size = new System.Drawing.Size(96, 41);
            this.btButton.TabIndex = 0;
            this.btButton.Text = "開く";
            this.btButton.UseVisualStyleBackColor = true;
            this.btButton.Click += new System.EventHandler(this.btButton_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(54, 79);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(547, 320);
            this.tbOutput.TabIndex = 1;
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "キーワード";
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(181, 53);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(179, 19);
            this.tbKeyword.TabIndex = 3;
            // 
            // btReadLine
            // 
            this.btReadLine.Location = new System.Drawing.Point(390, 33);
            this.btReadLine.Name = "btReadLine";
            this.btReadLine.Size = new System.Drawing.Size(103, 40);
            this.btReadLine.TabIndex = 4;
            this.btReadLine.Text = "readline";
            this.btReadLine.UseVisualStyleBackColor = true;
            this.btReadLine.Click += new System.EventHandler(this.btReadLine_Click);
            // 
            // btReadLines
            // 
            this.btReadLines.Location = new System.Drawing.Point(543, 23);
            this.btReadLines.Name = "btReadLines";
            this.btReadLines.Size = new System.Drawing.Size(121, 31);
            this.btReadLines.TabIndex = 5;
            this.btReadLines.Text = "readlines";
            this.btReadLines.UseVisualStyleBackColor = true;
            this.btReadLines.Click += new System.EventHandler(this.btReadLines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReadLines);
            this.Controls.Add(this.btReadLine);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btButton;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Button btReadLine;
        private System.Windows.Forms.Button btReadLines;
    }
}

