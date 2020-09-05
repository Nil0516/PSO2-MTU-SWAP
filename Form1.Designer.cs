namespace MTU
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
            this.onBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.setNetNameBtn = new System.Windows.Forms.Button();
            this.displayTb = new System.Windows.Forms.TextBox();
            this.idxTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtuOnTb = new System.Windows.Forms.TextBox();
            this.mtuOffTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.offBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // onBtn
            // 
            this.onBtn.Location = new System.Drawing.Point(410, 12);
            this.onBtn.Name = "onBtn";
            this.onBtn.Size = new System.Drawing.Size(93, 40);
            this.onBtn.TabIndex = 0;
            this.onBtn.Text = "開";
            this.onBtn.UseVisualStyleBackColor = true;
            this.onBtn.Click += new System.EventHandler(this.onBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(13, 367);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(590, 51);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "查詢";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // setNetNameBtn
            // 
            this.setNetNameBtn.Location = new System.Drawing.Point(410, 65);
            this.setNetNameBtn.Name = "setNetNameBtn";
            this.setNetNameBtn.Size = new System.Drawing.Size(193, 38);
            this.setNetNameBtn.TabIndex = 2;
            this.setNetNameBtn.Text = "設定網路";
            this.setNetNameBtn.UseVisualStyleBackColor = true;
            this.setNetNameBtn.Click += new System.EventHandler(this.setNetNameBtn_Click);
            // 
            // displayTb
            // 
            this.displayTb.Location = new System.Drawing.Point(13, 114);
            this.displayTb.Multiline = true;
            this.displayTb.Name = "displayTb";
            this.displayTb.ReadOnly = true;
            this.displayTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTb.Size = new System.Drawing.Size(590, 247);
            this.displayTb.TabIndex = 3;
            // 
            // idxTb
            // 
            this.idxTb.Location = new System.Drawing.Point(95, 70);
            this.idxTb.Name = "idxTb";
            this.idxTb.Size = new System.Drawing.Size(309, 29);
            this.idxTb.TabIndex = 4;
            this.idxTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "MTU On";
            // 
            // mtuOnTb
            // 
            this.mtuOnTb.Location = new System.Drawing.Point(95, 18);
            this.mtuOnTb.Name = "mtuOnTb";
            this.mtuOnTb.ReadOnly = true;
            this.mtuOnTb.Size = new System.Drawing.Size(100, 29);
            this.mtuOnTb.TabIndex = 6;
            this.mtuOnTb.Text = "576";
            this.mtuOnTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtuOffTb
            // 
            this.mtuOffTb.Location = new System.Drawing.Point(295, 18);
            this.mtuOffTb.Name = "mtuOffTb";
            this.mtuOffTb.ReadOnly = true;
            this.mtuOffTb.Size = new System.Drawing.Size(100, 29);
            this.mtuOffTb.TabIndex = 8;
            this.mtuOffTb.Text = "1500";
            this.mtuOffTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "MTU Off";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "輸入Idx";
            // 
            // offBtn
            // 
            this.offBtn.Location = new System.Drawing.Point(510, 12);
            this.offBtn.Name = "offBtn";
            this.offBtn.Size = new System.Drawing.Size(93, 40);
            this.offBtn.TabIndex = 10;
            this.offBtn.Text = "關";
            this.offBtn.UseVisualStyleBackColor = true;
            this.offBtn.Click += new System.EventHandler(this.offBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 434);
            this.Controls.Add(this.offBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtuOffTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtuOnTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idxTb);
            this.Controls.Add(this.displayTb);
            this.Controls.Add(this.setNetNameBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.onBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MTU_Swaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button setNetNameBtn;
        private System.Windows.Forms.TextBox displayTb;
        private System.Windows.Forms.TextBox idxTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mtuOnTb;
        private System.Windows.Forms.TextBox mtuOffTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button offBtn;
    }
}

