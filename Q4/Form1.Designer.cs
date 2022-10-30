namespace Q4
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
			this.PinputTextBox = new System.Windows.Forms.TextBox();
			this.CinputTextBox = new System.Windows.Forms.TextBox();
			this.CalcButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// PinputTextBox
			// 
			this.PinputTextBox.Location = new System.Drawing.Point(112, 148);
			this.PinputTextBox.Name = "PinputTextBox";
			this.PinputTextBox.Size = new System.Drawing.Size(100, 25);
			this.PinputTextBox.TabIndex = 2;
			// 
			// CinputTextBox
			// 
			this.CinputTextBox.Location = new System.Drawing.Point(112, 76);
			this.CinputTextBox.Name = "CinputTextBox";
			this.CinputTextBox.Size = new System.Drawing.Size(100, 25);
			this.CinputTextBox.TabIndex = 2;
			// 
			// CalcButton
			// 
			this.CalcButton.Location = new System.Drawing.Point(179, 219);
			this.CalcButton.Name = "CalcButton";
			this.CalcButton.Size = new System.Drawing.Size(75, 23);
			this.CalcButton.TabIndex = 3;
			this.CalcButton.Text = "計算";
			this.CalcButton.UseVisualStyleBackColor = true;
			this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "車輛:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 151);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "人數:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(275, 291);
			this.Controls.Add(this.CalcButton);
			this.Controls.Add(this.CinputTextBox);
			this.Controls.Add(this.PinputTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.TextBox PinputTextBox;
		private System.Windows.Forms.TextBox CinputTextBox;
		private System.Windows.Forms.Button CalcButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

