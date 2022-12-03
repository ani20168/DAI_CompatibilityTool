namespace DAI_CompatibilityTool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.on_button = new System.Windows.Forms.Button();
            this.off_button = new System.Windows.Forms.Button();
            this.path_show = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.path_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.status_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // on_button
            // 
            this.on_button.Location = new System.Drawing.Point(52, 101);
            this.on_button.Name = "on_button";
            this.on_button.Size = new System.Drawing.Size(238, 54);
            this.on_button.TabIndex = 0;
            this.on_button.Text = "使Frosty兼容DAIMM";
            this.on_button.UseVisualStyleBackColor = true;
            this.on_button.Click += new System.EventHandler(this.on_button_Click);
            // 
            // off_button
            // 
            this.off_button.Location = new System.Drawing.Point(52, 179);
            this.off_button.Name = "off_button";
            this.off_button.Size = new System.Drawing.Size(238, 54);
            this.off_button.TabIndex = 1;
            this.off_button.Text = "關閉兼容以進行Mod修改";
            this.off_button.UseVisualStyleBackColor = true;
            this.off_button.Click += new System.EventHandler(this.off_button_Click);
            // 
            // path_show
            // 
            this.path_show.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.path_show.Location = new System.Drawing.Point(90, 38);
            this.path_show.Name = "path_show";
            this.path_show.ReadOnly = true;
            this.path_show.Size = new System.Drawing.Size(155, 22);
            this.path_show.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "執行檔路徑:";
            // 
            // path_button
            // 
            this.path_button.Location = new System.Drawing.Point(256, 37);
            this.path_button.Name = "path_button";
            this.path_button.Size = new System.Drawing.Size(70, 23);
            this.path_button.TabIndex = 4;
            this.path_button.Text = "選擇位置...";
            this.path_button.UseVisualStyleBackColor = true;
            this.path_button.Click += new System.EventHandler(this.path_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 11F);
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "狀態:";
            // 
            // status_show
            // 
            this.status_show.AutoSize = true;
            this.status_show.Font = new System.Drawing.Font("新細明體", 11F);
            this.status_show.Location = new System.Drawing.Point(49, 258);
            this.status_show.Name = "status_show";
            this.status_show.Size = new System.Drawing.Size(37, 15);
            this.status_show.TabIndex = 6;
            this.status_show.Text = "未知";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 292);
            this.Controls.Add(this.status_show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.path_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path_show);
            this.Controls.Add(this.off_button);
            this.Controls.Add(this.on_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "闇龍紀元 Mod Manager兼容軟體";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button on_button;
        private System.Windows.Forms.Button off_button;
        private System.Windows.Forms.TextBox path_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button path_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status_show;
    }
}

