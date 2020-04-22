using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_2_Task1
{
	public partial class Form1 : Form
	{
		private int rowNumber;
		public Form1()
		{
			InitializeComponent();
			_chkProgramming.CheckedChanged += _chkProgramming_CheckedChanged1; 
			_chkEnglishLanguage.CheckedChanged += _chkProgramming_CheckedChanged1;
			dataGridView.Columns[4].Width = 120;
			dataGridView.Columns[5].Width = 200;

		}


		private void _chkProgramming_CheckedChanged1(object sender, EventArgs e)
		{
			if (_chkProgramming.Checked == true)
			{
				_cmbProgrammingLvl.Visible = true;
			}
			else 
			{
				_cmbProgrammingLvl.Visible = false;
			}
			if(_chkEnglishLanguage.Checked == true)
			{
				_cmbEnglishLvl.Visible = true;
			}
			else
			{
				_cmbEnglishLvl.Visible = false;
			}
			if (_chkProgramming.Checked == true || _chkEnglishLanguage.Checked == true)
			{
				_txtCompetecionLvl.Visible = true;
			}
			else
			{
				_txtCompetecionLvl.Visible = false;
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void _btnRecordData_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Сохранить данные?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				dataGridView.Rows.Add();
				dataGridView[0, rowNumber].Value = _txtEnterName.Text;
				dataGridView[1, rowNumber].Value = _txtEnterSurname.Text;
				if (_rdiMale.Checked == true)
				{
					dataGridView[2, rowNumber].Value = _rdiMale.Text;
				}
				else
				{
					dataGridView[2, rowNumber].Value = _rdiFemale.Text;
				}
				dataGridView[3, rowNumber].Value = _cmbChoisePost.SelectedItem;
				dataGridView[4, rowNumber].Value = _cmbProgrammingLvl.SelectedItem;
				dataGridView[5, rowNumber].Value = _cmbEnglishLvl.SelectedItem;
				rowNumber += 1;

			}
		}

		private void _txtEnterName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}

		private void _txtEnterSurname_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}

		
	}
}
