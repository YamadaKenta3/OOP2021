
namespace Exercise4
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
            this.kenchan = new System.Windows.Forms.TextBox();
            this.button5_4 = new System.Windows.Forms.Button();
            this.Strtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kenchan
            // 
            this.kenchan.Location = new System.Drawing.Point(49, 39);
            this.kenchan.Name = "kenchan";
            this.kenchan.Size = new System.Drawing.Size(366, 19);
            this.kenchan.TabIndex = 0;
            // 
            // button5_4
            // 
            this.button5_4.Location = new System.Drawing.Point(39, 102);
            this.button5_4.Name = "button5_4";
            this.button5_4.Size = new System.Drawing.Size(75, 23);
            this.button5_4.TabIndex = 1;
            this.button5_4.Text = "出力";
            this.button5_4.UseVisualStyleBackColor = true;
            this.button5_4.Click += new System.EventHandler(this.button5_4_Click);
            // 
            // Strtext
            // 
            this.Strtext.Location = new System.Drawing.Point(178, 102);
            this.Strtext.Multiline = true;
            this.Strtext.Name = "Strtext";
            this.Strtext.Size = new System.Drawing.Size(471, 112);
            this.Strtext.TabIndex = 2;
            this.Strtext.TextChanged += new System.EventHandler(this.Strtext_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Strtext);
            this.Controls.Add(this.button5_4);
            this.Controls.Add(this.kenchan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kenchan;
        private System.Windows.Forms.Button button5_4;
        private System.Windows.Forms.TextBox Strtext;
    }
}

