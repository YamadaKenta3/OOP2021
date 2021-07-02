
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
            this.inStrNum = new System.Windows.Forms.TextBox();
            this.button5_2 = new System.Windows.Forms.Button();
            this.outStrNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inStrNum
            // 
            this.inStrNum.Location = new System.Drawing.Point(86, 26);
            this.inStrNum.Name = "inStrNum";
            this.inStrNum.Size = new System.Drawing.Size(210, 19);
            this.inStrNum.TabIndex = 0;
            // 
            // button5_2
            // 
            this.button5_2.Location = new System.Drawing.Point(357, 26);
            this.button5_2.Name = "button5_2";
            this.button5_2.Size = new System.Drawing.Size(75, 23);
            this.button5_2.TabIndex = 1;
            this.button5_2.Text = "問題5.2";
            this.button5_2.UseVisualStyleBackColor = true;
            this.button5_2.Click += new System.EventHandler(this.button5_2_Click);
            // 
            // outStrNum
            // 
            this.outStrNum.Location = new System.Drawing.Point(91, 91);
            this.outStrNum.Name = "outStrNum";
            this.outStrNum.Size = new System.Drawing.Size(210, 19);
            this.outStrNum.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5_2);
            this.Controls.Add(this.outStrNum);
            this.Controls.Add(this.inStrNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inStrNum;
        private System.Windows.Forms.Button button5_2;
        private System.Windows.Forms.TextBox outStrNum;
    }
}

