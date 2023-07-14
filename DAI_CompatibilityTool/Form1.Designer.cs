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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.on_button = new System.Windows.Forms.Button();
            this.off_button = new System.Windows.Forms.Button();
            this.path_show = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.path_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.status_show = new System.Windows.Forms.Label();
            this.language_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // on_button
            // 
            resources.ApplyResources(this.on_button, "on_button");
            this.on_button.Name = "on_button";
            this.on_button.UseVisualStyleBackColor = true;
            this.on_button.Click += new System.EventHandler(this.on_button_Click);
            // 
            // off_button
            // 
            resources.ApplyResources(this.off_button, "off_button");
            this.off_button.Name = "off_button";
            this.off_button.UseVisualStyleBackColor = true;
            this.off_button.Click += new System.EventHandler(this.off_button_Click);
            // 
            // path_show
            // 
            resources.ApplyResources(this.path_show, "path_show");
            this.path_show.Name = "path_show";
            this.path_show.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // path_button
            // 
            resources.ApplyResources(this.path_button, "path_button");
            this.path_button.Name = "path_button";
            this.path_button.UseVisualStyleBackColor = true;
            this.path_button.Click += new System.EventHandler(this.path_button_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // status_show
            // 
            resources.ApplyResources(this.status_show, "status_show");
            this.status_show.Name = "status_show";
            // 
            // language_button
            // 
            resources.ApplyResources(this.language_button, "language_button");
            this.language_button.Name = "language_button";
            this.language_button.UseVisualStyleBackColor = true;
            this.language_button.Click += new System.EventHandler(this.language_button_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.language_button);
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
        private System.Windows.Forms.Button language_button;
    }
}

