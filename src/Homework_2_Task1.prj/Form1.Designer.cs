namespace Homework_2_Task1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this._txtName = new System.Windows.Forms.Label();
			this._txtSurname = new System.Windows.Forms.Label();
			this._txtEnterName = new System.Windows.Forms.TextBox();
			this._txtEnterSurname = new System.Windows.Forms.TextBox();
			this._txtGender = new System.Windows.Forms.Label();
			this._rdiMale = new System.Windows.Forms.RadioButton();
			this._rdiFemale = new System.Windows.Forms.RadioButton();
			this._txtСompetencies = new System.Windows.Forms.Label();
			this._chkProgramming = new System.Windows.Forms.CheckBox();
			this._chkEnglishLanguage = new System.Windows.Forms.CheckBox();
			this._txtPosts = new System.Windows.Forms.Label();
			this._cmbChoisePost = new System.Windows.Forms.ComboBox();
			this._txtCompetecionLvl = new System.Windows.Forms.Label();
			this._cmbProgrammingLvl = new System.Windows.Forms.ComboBox();
			this._cmbEnglishLvl = new System.Windows.Forms.ComboBox();
			this._grpElements = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this._txtNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._txtSurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._txtGenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._txtPostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._txtProgrammingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._txtEnglishColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._btnRecordData = new System.Windows.Forms.Button();
			this._grpElements.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// _txtName
			// 
			this._txtName.AutoSize = true;
			this._txtName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtName.Location = new System.Drawing.Point(17, 25);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(46, 19);
			this._txtName.TabIndex = 0;
			this._txtName.Text = "Имя:";
			// 
			// _txtSurname
			// 
			this._txtSurname.AutoSize = true;
			this._txtSurname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtSurname.Location = new System.Drawing.Point(17, 55);
			this._txtSurname.Name = "_txtSurname";
			this._txtSurname.Size = new System.Drawing.Size(84, 19);
			this._txtSurname.TabIndex = 1;
			this._txtSurname.Text = "Фамилия:";
			// 
			// _txtEnterName
			// 
			this._txtEnterName.Location = new System.Drawing.Point(105, 23);
			this._txtEnterName.Name = "_txtEnterName";
			this._txtEnterName.Size = new System.Drawing.Size(143, 20);
			this._txtEnterName.TabIndex = 2;
			this._txtEnterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEnterName_KeyPress);
			// 
			// _txtEnterSurname
			// 
			this._txtEnterSurname.Location = new System.Drawing.Point(105, 55);
			this._txtEnterSurname.Name = "_txtEnterSurname";
			this._txtEnterSurname.Size = new System.Drawing.Size(143, 20);
			this._txtEnterSurname.TabIndex = 3;
			this._txtEnterSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEnterSurname_KeyPress);
			// 
			// _txtGender
			// 
			this._txtGender.AutoSize = true;
			this._txtGender.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtGender.Location = new System.Drawing.Point(20, 88);
			this._txtGender.Name = "_txtGender";
			this._txtGender.Size = new System.Drawing.Size(43, 19);
			this._txtGender.TabIndex = 4;
			this._txtGender.Text = "Пол:";
			// 
			// _rdiMale
			// 
			this._rdiMale.AutoSize = true;
			this._rdiMale.Location = new System.Drawing.Point(66, 90);
			this._rdiMale.Name = "_rdiMale";
			this._rdiMale.Size = new System.Drawing.Size(34, 17);
			this._rdiMale.TabIndex = 5;
			this._rdiMale.TabStop = true;
			this._rdiMale.Text = "М";
			this._rdiMale.UseVisualStyleBackColor = true;
			// 
			// _rdiFemale
			// 
			this._rdiFemale.AutoSize = true;
			this._rdiFemale.Location = new System.Drawing.Point(105, 90);
			this._rdiFemale.Name = "_rdiFemale";
			this._rdiFemale.Size = new System.Drawing.Size(36, 17);
			this._rdiFemale.TabIndex = 6;
			this._rdiFemale.TabStop = true;
			this._rdiFemale.Text = "Ж";
			this._rdiFemale.UseVisualStyleBackColor = true;
			// 
			// _txtСompetencies
			// 
			this._txtСompetencies.AutoSize = true;
			this._txtСompetencies.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtСompetencies.Location = new System.Drawing.Point(20, 158);
			this._txtСompetencies.Name = "_txtСompetencies";
			this._txtСompetencies.Size = new System.Drawing.Size(117, 19);
			this._txtСompetencies.TabIndex = 7;
			this._txtСompetencies.Text = "Компетенции:";
			// 
			// _chkProgramming
			// 
			this._chkProgramming.AutoSize = true;
			this._chkProgramming.Location = new System.Drawing.Point(24, 184);
			this._chkProgramming.Name = "_chkProgramming";
			this._chkProgramming.Size = new System.Drawing.Size(127, 17);
			this._chkProgramming.TabIndex = 8;
			this._chkProgramming.Text = "Программирование";
			this._chkProgramming.UseVisualStyleBackColor = true;
			// 
			// _chkEnglishLanguage
			// 
			this._chkEnglishLanguage.AutoSize = true;
			this._chkEnglishLanguage.Location = new System.Drawing.Point(24, 211);
			this._chkEnglishLanguage.Name = "_chkEnglishLanguage";
			this._chkEnglishLanguage.Size = new System.Drawing.Size(115, 17);
			this._chkEnglishLanguage.TabIndex = 9;
			this._chkEnglishLanguage.Text = "Английский язык";
			this._chkEnglishLanguage.UseVisualStyleBackColor = true;
			// 
			// _txtPosts
			// 
			this._txtPosts.AutoSize = true;
			this._txtPosts.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtPosts.Location = new System.Drawing.Point(20, 119);
			this._txtPosts.Name = "_txtPosts";
			this._txtPosts.Size = new System.Drawing.Size(101, 19);
			this._txtPosts.TabIndex = 10;
			this._txtPosts.Text = "Должность:";
			// 
			// _cmbChoisePost
			// 
			this._cmbChoisePost.FormattingEnabled = true;
			this._cmbChoisePost.Items.AddRange(new object[] {
            "Программист",
            "Системный администратор",
            "Разработчик",
            "Data scientist",
            "Аналитик"});
			this._cmbChoisePost.Location = new System.Drawing.Point(127, 120);
			this._cmbChoisePost.Name = "_cmbChoisePost";
			this._cmbChoisePost.Size = new System.Drawing.Size(121, 21);
			this._cmbChoisePost.TabIndex = 11;
			// 
			// _txtCompetecionLvl
			// 
			this._txtCompetecionLvl.AutoSize = true;
			this._txtCompetecionLvl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtCompetecionLvl.Location = new System.Drawing.Point(155, 158);
			this._txtCompetecionLvl.Name = "_txtCompetecionLvl";
			this._txtCompetecionLvl.Size = new System.Drawing.Size(154, 19);
			this._txtCompetecionLvl.TabIndex = 12;
			this._txtCompetecionLvl.Text = "Уровень владения:";
			this._txtCompetecionLvl.Visible = false;
			// 
			// _cmbProgrammingLvl
			// 
			this._cmbProgrammingLvl.FormattingEnabled = true;
			this._cmbProgrammingLvl.Items.AddRange(new object[] {
            "Zero",
            "Junior",
            "Middle",
            "Senior",
            "Jedi"});
			this._cmbProgrammingLvl.Location = new System.Drawing.Point(159, 180);
			this._cmbProgrammingLvl.Name = "_cmbProgrammingLvl";
			this._cmbProgrammingLvl.Size = new System.Drawing.Size(192, 21);
			this._cmbProgrammingLvl.TabIndex = 13;
			this._cmbProgrammingLvl.Visible = false;
			// 
			// _cmbEnglishLvl
			// 
			this._cmbEnglishLvl.FormattingEnabled = true;
			this._cmbEnglishLvl.Items.AddRange(new object[] {
            "I tak soidet",
            "London is the capital of Great Britain",
            "Intermediate",
            "Advanced"});
			this._cmbEnglishLvl.Location = new System.Drawing.Point(159, 207);
			this._cmbEnglishLvl.Name = "_cmbEnglishLvl";
			this._cmbEnglishLvl.Size = new System.Drawing.Size(192, 21);
			this._cmbEnglishLvl.TabIndex = 14;
			this._cmbEnglishLvl.Visible = false;
			// 
			// _grpElements
			// 
			this._grpElements.BackColor = System.Drawing.Color.Black;
			this._grpElements.Controls.Add(this._txtGender);
			this._grpElements.Controls.Add(this._cmbEnglishLvl);
			this._grpElements.Controls.Add(this._txtName);
			this._grpElements.Controls.Add(this._cmbProgrammingLvl);
			this._grpElements.Controls.Add(this._txtSurname);
			this._grpElements.Controls.Add(this._txtCompetecionLvl);
			this._grpElements.Controls.Add(this._txtEnterName);
			this._grpElements.Controls.Add(this._cmbChoisePost);
			this._grpElements.Controls.Add(this._txtEnterSurname);
			this._grpElements.Controls.Add(this._txtPosts);
			this._grpElements.Controls.Add(this._rdiMale);
			this._grpElements.Controls.Add(this._chkEnglishLanguage);
			this._grpElements.Controls.Add(this._rdiFemale);
			this._grpElements.Controls.Add(this._chkProgramming);
			this._grpElements.Controls.Add(this._txtСompetencies);
			this._grpElements.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this._grpElements.Location = new System.Drawing.Point(12, 12);
			this._grpElements.Name = "_grpElements";
			this._grpElements.Size = new System.Drawing.Size(357, 251);
			this._grpElements.TabIndex = 15;
			this._grpElements.TabStop = false;
			this._grpElements.Text = "Введите данные";
			// 
			// dataGridView
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
			this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView.BackgroundColor = System.Drawing.Color.Black;
			this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._txtNameColumn,
            this._txtSurnameColumn,
            this._txtGenderColumn,
            this._txtPostColumn,
            this._txtProgrammingColumn,
            this._txtEnglishColumn});
			this.dataGridView.GridColor = System.Drawing.Color.DimGray;
			this.dataGridView.Location = new System.Drawing.Point(0, 272);
			this.dataGridView.Name = "dataGridView";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView.Size = new System.Drawing.Size(754, 150);
			this.dataGridView.TabIndex = 16;
			// 
			// _txtNameColumn
			// 
			this._txtNameColumn.HeaderText = "Имя";
			this._txtNameColumn.Name = "_txtNameColumn";
			// 
			// _txtSurnameColumn
			// 
			this._txtSurnameColumn.HeaderText = "Фамилия";
			this._txtSurnameColumn.Name = "_txtSurnameColumn";
			// 
			// _txtGenderColumn
			// 
			this._txtGenderColumn.HeaderText = "Пол";
			this._txtGenderColumn.Name = "_txtGenderColumn";
			// 
			// _txtPostColumn
			// 
			this._txtPostColumn.HeaderText = "Должность";
			this._txtPostColumn.Name = "_txtPostColumn";
			// 
			// _txtProgrammingColumn
			// 
			this._txtProgrammingColumn.HeaderText = "Программирование";
			this._txtProgrammingColumn.Name = "_txtProgrammingColumn";
			this._txtProgrammingColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this._txtProgrammingColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// _txtEnglishColumn
			// 
			this._txtEnglishColumn.HeaderText = "Английский";
			this._txtEnglishColumn.Name = "_txtEnglishColumn";
			this._txtEnglishColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this._txtEnglishColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// _btnRecordData
			// 
			this._btnRecordData.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnRecordData.Location = new System.Drawing.Point(375, 240);
			this._btnRecordData.Name = "_btnRecordData";
			this._btnRecordData.Size = new System.Drawing.Size(119, 23);
			this._btnRecordData.TabIndex = 17;
			this._btnRecordData.Text = "Записать данные";
			this._btnRecordData.UseVisualStyleBackColor = true;
			this._btnRecordData.Click += new System.EventHandler(this._btnRecordData_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Crimson;
			this.ClientSize = new System.Drawing.Size(752, 404);
			this.Controls.Add(this._btnRecordData);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this._grpElements);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximumSize = new System.Drawing.Size(768, 443);
			this.Name = "Form1";
			this.Text = "Устройство на работу";
			this.TransparencyKey = System.Drawing.Color.Maroon;
			this.Load += new System.EventHandler(this.Form1_Load);
			this._grpElements.ResumeLayout(false);
			this._grpElements.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label _txtName;
		private System.Windows.Forms.Label _txtSurname;
		private System.Windows.Forms.TextBox _txtEnterName;
		private System.Windows.Forms.TextBox _txtEnterSurname;
		private System.Windows.Forms.Label _txtGender;
		private System.Windows.Forms.RadioButton _rdiMale;
		private System.Windows.Forms.RadioButton _rdiFemale;
		private System.Windows.Forms.Label _txtСompetencies;
		private System.Windows.Forms.CheckBox _chkProgramming;
		private System.Windows.Forms.CheckBox _chkEnglishLanguage;
		private System.Windows.Forms.Label _txtPosts;
		private System.Windows.Forms.ComboBox _cmbChoisePost;
		private System.Windows.Forms.Label _txtCompetecionLvl;
		private System.Windows.Forms.ComboBox _cmbProgrammingLvl;
		private System.Windows.Forms.ComboBox _cmbEnglishLvl;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button _btnRecordData;
		private System.Windows.Forms.DataGridViewTextBoxColumn _txtNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _txtSurnameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _txtGenderColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _txtPostColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _txtProgrammingColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _txtEnglishColumn;
		private System.Windows.Forms.GroupBox _grpElements;
	}
}

