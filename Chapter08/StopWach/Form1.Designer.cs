
namespace StopWach
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
            this.components = new System.ComponentModel.Container();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.stButton = new System.Windows.Forms.Button();
            this.rtButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tm
            // 
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // stButton
            // 
            this.stButton.Location = new System.Drawing.Point(47, 141);
            this.stButton.Name = "stButton";
            this.stButton.Size = new System.Drawing.Size(112, 53);
            this.stButton.TabIndex = 0;
            this.stButton.Text = "start";
            this.stButton.UseVisualStyleBackColor = true;
            // 
            // rtButton
            // 
            this.rtButton.Location = new System.Drawing.Point(209, 141);
            this.rtButton.Name = "rtButton";
            this.rtButton.Size = new System.Drawing.Size(107, 64);
            this.rtButton.TabIndex = 1;
            this.rtButton.Text = "button2";
            this.rtButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(209, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 77);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(47, 62);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(310, 19);
            this.tbTimer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rtButton);
            this.Controls.Add(this.stButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Button stButton;
        private System.Windows.Forms.Button rtButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbTimer;
    }
}

