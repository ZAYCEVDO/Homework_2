﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
	public partial class MainForm : Form
	{
		private string _fileName;
		private string _path;
		private int rowNumber;
		private IEnumerable<string> _filesDirectory;

		public MainForm()
		{
			InitializeComponent();

			_cmbEnterMath.Items.Add("1");
			_cmbEnterMath.Items.AddRange(new string[] {"2", "3", "4" });
			_cmbEnterMath.Items.Insert(4, "5");

			_txtMath.Visible = false;
			_cmbEnterMath.Visible = false;

			_txtRus.Visible = false;
			_cmbEnterRus.Visible = false;

			_txtHistory.Visible = false;
			_cmbEnterHistory.Visible = false;

			_txtH20.Visible = false;
			_cmbEnterH20.Visible = false;

			_rdiKids.CheckedChanged += _rdiKids_CheckedChanged1;
			_rdiTeeneger.CheckedChanged += _rdiKids_CheckedChanged1;
			_rdiPeople.CheckedChanged += _rdiKids_CheckedChanged1;

			_openFileDialog.Filter = "Image|*.png; *.jpg|Video|*.avi; *.mp4";

			DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();

			col1.Name = "Имя";
			col2.Name = "Фамилия";
			col3.Name = "Математика";
			col4.Name = "Русский язык";
			col5.Name = "История";
			col6.Name = "Химия";

			dataGridView.Columns.Add(col1);
			dataGridView.Columns.Add(col2);
			dataGridView.Columns.Add(col3);
			dataGridView.Columns.Add(col4);
			dataGridView.Columns.Add(col5);
			dataGridView.Columns.Add(col6);

		}

		private void _rdiKids_CheckedChanged1(object sender, EventArgs e)
		{
			if(_rdiKids.Checked == true)
			{
				_txtMath.Visible = true;
				_cmbEnterMath.Visible = true;

				_txtRus.Visible = true;
				_cmbEnterRus.Visible = true;

				_txtHistory.Visible = false;
				_cmbEnterHistory.Visible = false;

				_txtH20.Visible = false;
				_cmbEnterH20.Visible = false;
			}

			else if(_rdiTeeneger.Checked == true)
			{
				_txtMath.Visible = true;
				_cmbEnterMath.Visible = true;

				_txtRus.Visible = true;
				_cmbEnterRus.Visible = true;

				_txtHistory.Visible = true;
				_cmbEnterHistory.Visible = true;

				_txtH20.Visible = false;
				_cmbEnterH20.Visible = false;
			}

			else if(_rdiPeople.Checked == true)
			{
				_txtMath.Visible = true;
				_cmbEnterMath.Visible = true;

				_txtRus.Visible = true;
				_cmbEnterRus.Visible = true;

				_txtHistory.Visible = true;
				_cmbEnterHistory.Visible = true;

				_txtH20.Visible = true;
				_cmbEnterH20.Visible = true;
			}
		}

		/// <summary>Открытие файла.</summary>
		private void OpenFile(object sender, EventArgs e)
		{
			if(_openFileDialog.ShowDialog() == DialogResult.Cancel) return;

			_fileName = _openFileDialog.FileName;

			_txtFile.Text = _fileName;
		}

		/// <summary>Открытие директории.</summary>
		private void OpenDirectory(object sender, EventArgs e)
		{
			if(_folderBrowserDialog.ShowDialog() == DialogResult.Cancel) return;

			_path = _folderBrowserDialog.SelectedPath;

			_txtFile.Text = _path;

			_filesDirectory = Directory.EnumerateFiles(_path, "*.*", SearchOption.TopDirectoryOnly)
				.Where(s => s.EndsWith("*.png") || s.EndsWith("*.jpg"));
		}

		private void _btnSave_Click(object sender, EventArgs e)
		{
			dataGridView.Rows.Add();
			dataGridView[0, rowNumber].Value = _txtEnterName.Text;
			dataGridView[1, rowNumber].Value = _txtEnterLastName.Text;
			dataGridView[2, rowNumber].Value = _cmbEnterMath.SelectedItem;
			dataGridView[3, rowNumber].Value = _cmbEnterRus.SelectedItem;
			dataGridView[4, rowNumber].Value = _cmbEnterHistory.SelectedItem;
			dataGridView[5, rowNumber].Value = _cmbEnterH20.SelectedItem;
			rowNumber += 1;

			MessageBox.Show("Данные добавлены", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void _txtEnterName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}

		private void _txtEnterLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}
	}
}
