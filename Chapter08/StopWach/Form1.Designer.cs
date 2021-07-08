
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
            this.St = new System.Windows.Forms.Button();
            this.rap = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.LB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tm
            // 
            this.tm.Tick += new System.EventHandler(this.tm_Tick_1);
            // 
            // stButton
            // 
            this.stButton.Location = new System.Drawing.Point(36, 134);
            this.stButton.Name = "stButton";
            this.stButton.Size = new System.Drawing.Size(147, 76);
            this.stButton.TabIndex = 0;
            this.stButton.Text = "start";
            this.stButton.UseVisualStyleBackColor = true;
            this.stButton.Click += new System.EventHandler(this.stButton_Click);
            // 
            // rtButton
            // 
            this.rtButton.Location = new System.Drawing.Point(211, 134);
            this.rtButton.Name = "rtButton";
            this.rtButton.Size = new System.Drawing.Size(142, 76);
            this.rtButton.TabIndex = 1;
            this.rtButton.Text = "リセっと";
            this.rtButton.UseVisualStyleBackColor = true;
            this.rtButton.Click += new System.EventHandler(this.rtButton_Click);
            // 
            // St
            // 
            this.St.Location = new System.Drawing.Point(36, 240);
            this.St.Name = "St";
            this.St.Size = new System.Drawing.Size(147, 89);
            this.St.TabIndex = 2;
            this.St.Text = "ストップ";
            this.St.UseVisualStyleBackColor = true;
            this.St.Click += new System.EventHandler(this.St_Click);
            // 
            // rap
            // 
            this.rap.Location = new System.Drawing.Point(211, 240);
            this.rap.Name = "rap";
            this.rap.Size = new System.Drawing.Size(142, 89);
            this.rap.TabIndex = 3;
            this.rap.Text = "ラップ";
            this.rap.UseVisualStyleBackColor = true;
            this.rap.Click += new System.EventHandler(this.rap_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(150, 82);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 21);
            this.label.TabIndex = 4;
            this.label.Text = "label1";
            // 
            // LB
            // 
            this.LB.FormattingEnabled = true;
            this.LB.ItemHeight = 12;
            this.LB.Location = new System.Drawing.Point(428, 82);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(242, 292);
            this.LB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.label);
            this.Controls.Add(this.rap);
            this.Controls.Add(this.St);
            this.Controls.Add(this.rtButton);
            this.Controls.Add(this.stButton);
            this.Name = "Form1";
            this.Text = "すっとぷウォッチ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Button stButton;
        private System.Windows.Forms.Button rtButton;
        private System.Windows.Forms.Button St;
        private System.Windows.Forms.Button rap;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox LB;
    }
}

