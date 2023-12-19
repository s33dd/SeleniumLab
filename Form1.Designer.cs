namespace SeleniumLab {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			TestBtn = new Button();
			linkBox = new TextBox();
			chromeCheckBox = new CheckBox();
			firefoxCheckBox = new CheckBox();
			edgeCheckBox = new CheckBox();
			folderBrowserDialog1 = new FolderBrowserDialog();
			button1 = new Button();
			folderLabel = new Label();
			isSilent = new CheckBox();
			label1 = new Label();
			sizeLists = new ComboBox();
			label2 = new Label();
			AddSize = new Button();
			newSize = new TextBox();
			progBar = new ProgressBar();
			SuspendLayout();
			// 
			// TestBtn
			// 
			TestBtn.Location = new Point(49, 252);
			TestBtn.Name = "TestBtn";
			TestBtn.Size = new Size(461, 86);
			TestBtn.TabIndex = 0;
			TestBtn.Text = "Протестировать";
			TestBtn.UseVisualStyleBackColor = true;
			TestBtn.Click += TestBtn_Click;
			// 
			// linkBox
			// 
			linkBox.AllowDrop = true;
			linkBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			linkBox.Location = new Point(49, 12);
			linkBox.Name = "linkBox";
			linkBox.Size = new Size(461, 33);
			linkBox.TabIndex = 1;
			// 
			// chromeCheckBox
			// 
			chromeCheckBox.AutoSize = true;
			chromeCheckBox.Location = new Point(49, 211);
			chromeCheckBox.Name = "chromeCheckBox";
			chromeCheckBox.Size = new Size(69, 19);
			chromeCheckBox.TabIndex = 2;
			chromeCheckBox.Text = "Chrome";
			chromeCheckBox.UseVisualStyleBackColor = true;
			// 
			// firefoxCheckBox
			// 
			firefoxCheckBox.AutoSize = true;
			firefoxCheckBox.Location = new Point(264, 211);
			firefoxCheckBox.Name = "firefoxCheckBox";
			firefoxCheckBox.Size = new Size(62, 19);
			firefoxCheckBox.TabIndex = 3;
			firefoxCheckBox.Text = "Firefox";
			firefoxCheckBox.UseVisualStyleBackColor = true;
			// 
			// edgeCheckBox
			// 
			edgeCheckBox.AutoSize = true;
			edgeCheckBox.Location = new Point(458, 211);
			edgeCheckBox.Name = "edgeCheckBox";
			edgeCheckBox.Size = new Size(52, 19);
			edgeCheckBox.TabIndex = 4;
			edgeCheckBox.Text = "Edge";
			edgeCheckBox.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(49, 79);
			button1.Name = "button1";
			button1.Size = new Size(102, 23);
			button1.TabIndex = 5;
			button1.Text = "Выбрать папку";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// folderLabel
			// 
			folderLabel.AutoSize = true;
			folderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			folderLabel.Location = new Point(157, 79);
			folderLabel.Name = "folderLabel";
			folderLabel.Size = new Size(141, 21);
			folderLabel.TabIndex = 6;
			folderLabel.Text = "Папка не выбрана";
			// 
			// isSilent
			// 
			isSilent.AutoSize = true;
			isSilent.Location = new Point(49, 115);
			isSilent.Name = "isSilent";
			isSilent.Size = new Size(100, 19);
			isSilent.TabIndex = 7;
			isSilent.Text = "Тихий режим";
			isSilent.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(157, 111);
			label1.Name = "label1";
			label1.Size = new Size(114, 21);
			label1.TabIndex = 8;
			label1.Text = "Размеры окна:";
			// 
			// sizeLists
			// 
			sizeLists.FormattingEnabled = true;
			sizeLists.Items.AddRange(new object[] { "1920 x 1080", "1440 x 900", "1280 x 720", "800 x 600" });
			sizeLists.Location = new Point(301, 111);
			sizeLists.Name = "sizeLists";
			sizeLists.Size = new Size(121, 23);
			sizeLists.TabIndex = 9;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(133, 158);
			label2.Name = "label2";
			label2.Size = new Size(138, 21);
			label2.TabIndex = 11;
			label2.Text = "Добавить размер:";
			// 
			// AddSize
			// 
			AddSize.Location = new Point(444, 159);
			AddSize.Name = "AddSize";
			AddSize.Size = new Size(75, 23);
			AddSize.TabIndex = 12;
			AddSize.Text = "Добавить";
			AddSize.UseVisualStyleBackColor = true;
			AddSize.Click += AddSize_Click;
			// 
			// newSize
			// 
			newSize.Location = new Point(301, 159);
			newSize.Name = "newSize";
			newSize.Size = new Size(121, 23);
			newSize.TabIndex = 13;
			// 
			// progBar
			// 
			progBar.Location = new Point(49, 367);
			progBar.Name = "progBar";
			progBar.Size = new Size(461, 30);
			progBar.TabIndex = 14;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(572, 429);
			Controls.Add(progBar);
			Controls.Add(newSize);
			Controls.Add(AddSize);
			Controls.Add(label2);
			Controls.Add(sizeLists);
			Controls.Add(label1);
			Controls.Add(isSilent);
			Controls.Add(folderLabel);
			Controls.Add(button1);
			Controls.Add(edgeCheckBox);
			Controls.Add(firefoxCheckBox);
			Controls.Add(chromeCheckBox);
			Controls.Add(linkBox);
			Controls.Add(TestBtn);
			MaximizeBox = false;
			Name = "Form1";
			Text = "Кроссбраузерное тестирование";
			FormClosed += Form1_FormClosed;
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button TestBtn;
		private TextBox linkBox;
		private CheckBox chromeCheckBox;
		private CheckBox firefoxCheckBox;
		private CheckBox edgeCheckBox;
		private FolderBrowserDialog folderBrowserDialog1;
		private Button button1;
		private Label folderLabel;
		private CheckBox isSilent;
		private Label label1;
		private ComboBox sizeLists;
		private Label label2;
		private Button AddSize;
		private TextBox newSize;
		private ProgressBar progBar;
	}
}