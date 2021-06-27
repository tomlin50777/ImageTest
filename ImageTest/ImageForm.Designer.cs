
namespace ImageTest
{
	partial class ImageForm
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
			this.baseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.pepperButton = new System.Windows.Forms.Button();
			this.binaryButton = new System.Windows.Forms.Button();
			this.locateButton = new System.Windows.Forms.Button();
			this.blackNoiceClearButton = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.nowLabel = new System.Windows.Forms.Label();
			this.listBox = new System.Windows.Forms.ListBox();
			this.baseTableLayoutPanel.SuspendLayout();
			this.buttonTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// baseTableLayoutPanel
			// 
			this.baseTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.baseTableLayoutPanel.ColumnCount = 2;
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.baseTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 0, 1);
			this.baseTableLayoutPanel.Controls.Add(this.pictureBox, 0, 0);
			this.baseTableLayoutPanel.Controls.Add(this.nowLabel, 1, 1);
			this.baseTableLayoutPanel.Controls.Add(this.listBox, 1, 0);
			this.baseTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
			this.baseTableLayoutPanel.Name = "baseTableLayoutPanel";
			this.baseTableLayoutPanel.RowCount = 2;
			this.baseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.baseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.baseTableLayoutPanel.Size = new System.Drawing.Size(1019, 553);
			this.baseTableLayoutPanel.TabIndex = 0;
			// 
			// buttonTableLayoutPanel
			// 
			this.buttonTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTableLayoutPanel.ColumnCount = 5;
			this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.buttonTableLayoutPanel.Controls.Add(this.pepperButton, 0, 0);
			this.buttonTableLayoutPanel.Controls.Add(this.binaryButton, 1, 0);
			this.buttonTableLayoutPanel.Controls.Add(this.blackNoiceClearButton, 2, 0);
			this.buttonTableLayoutPanel.Controls.Add(this.locateButton, 3, 0);
			this.buttonTableLayoutPanel.Location = new System.Drawing.Point(3, 445);
			this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
			this.buttonTableLayoutPanel.RowCount = 3;
			this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.buttonTableLayoutPanel.Size = new System.Drawing.Size(707, 105);
			this.buttonTableLayoutPanel.TabIndex = 0;
			// 
			// pepperButton
			// 
			this.pepperButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pepperButton.Location = new System.Drawing.Point(3, 3);
			this.pepperButton.Name = "pepperButton";
			this.pepperButton.Size = new System.Drawing.Size(135, 29);
			this.pepperButton.TabIndex = 1;
			this.pepperButton.Text = "PepperMaker";
			this.pepperButton.UseVisualStyleBackColor = true;
			this.pepperButton.Click += new System.EventHandler(this.PepperButton_Click);
			// 
			// binaryButton
			// 
			this.binaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.binaryButton.Location = new System.Drawing.Point(144, 3);
			this.binaryButton.Name = "binaryButton";
			this.binaryButton.Size = new System.Drawing.Size(135, 29);
			this.binaryButton.TabIndex = 2;
			this.binaryButton.Text = "Binary";
			this.binaryButton.UseVisualStyleBackColor = true;
			this.binaryButton.Click += new System.EventHandler(this.BinaryButton_Click);
			// 
			// locateButton
			// 
			this.locateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.locateButton.Location = new System.Drawing.Point(426, 3);
			this.locateButton.Name = "locateButton";
			this.locateButton.Size = new System.Drawing.Size(135, 29);
			this.locateButton.TabIndex = 3;
			this.locateButton.Text = "Locate";
			this.locateButton.UseVisualStyleBackColor = true;
			this.locateButton.Click += new System.EventHandler(this.LocateButton_Click);
			// 
			// blackNoiceClearButton
			// 
			this.blackNoiceClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.blackNoiceClearButton.Location = new System.Drawing.Point(285, 3);
			this.blackNoiceClearButton.Name = "blackNoiceClearButton";
			this.blackNoiceClearButton.Size = new System.Drawing.Size(135, 29);
			this.blackNoiceClearButton.TabIndex = 4;
			this.blackNoiceClearButton.Text = "Black Noice Clear";
			this.blackNoiceClearButton.UseVisualStyleBackColor = true;
			this.blackNoiceClearButton.Click += new System.EventHandler(this.BlackNoiceClearButton_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox.Location = new System.Drawing.Point(3, 3);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(707, 436);
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			// 
			// nowLabel
			// 
			this.nowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nowLabel.AutoSize = true;
			this.nowLabel.Location = new System.Drawing.Point(716, 491);
			this.nowLabel.Name = "nowLabel";
			this.nowLabel.Size = new System.Drawing.Size(300, 12);
			this.nowLabel.TabIndex = 2;
			this.nowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBox
			// 
			this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 12;
			this.listBox.Items.AddRange(new object[] {
            "共 : 0 S"});
			this.listBox.Location = new System.Drawing.Point(716, 3);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(300, 436);
			this.listBox.TabIndex = 3;
			// 
			// ImageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1043, 577);
			this.Controls.Add(this.baseTableLayoutPanel);
			this.Name = "ImageForm";
			this.Text = "Image Form";
			this.baseTableLayoutPanel.ResumeLayout(false);
			this.baseTableLayoutPanel.PerformLayout();
			this.buttonTableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel baseTableLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
		private System.Windows.Forms.Button pepperButton;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button binaryButton;
		private System.Windows.Forms.Button locateButton;
		private System.Windows.Forms.Button blackNoiceClearButton;
		private System.Windows.Forms.Label nowLabel;
		private System.Windows.Forms.ListBox listBox;
	}
}

