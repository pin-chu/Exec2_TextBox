namespace Exec2_TextBox
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
            this.trybutton = new System.Windows.Forms.Button();
            this.inputtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // trybutton
            // 
            this.trybutton.Location = new System.Drawing.Point(232, 94);
            this.trybutton.Name = "trybutton";
            this.trybutton.Size = new System.Drawing.Size(75, 23);
            this.trybutton.TabIndex = 0;
            this.trybutton.Text = "try";
            this.trybutton.UseVisualStyleBackColor = true;
            this.trybutton.Click += new System.EventHandler(this.trybutton_Click);
            // 
            // inputtextBox
            // 
            this.inputtextBox.Location = new System.Drawing.Point(50, 94);
            this.inputtextBox.Name = "inputtextBox";
            this.inputtextBox.Size = new System.Drawing.Size(165, 22);
            this.inputtextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 218);
            this.Controls.Add(this.inputtextBox);
            this.Controls.Add(this.trybutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button trybutton;
        private System.Windows.Forms.TextBox inputtextBox;
    }
}

