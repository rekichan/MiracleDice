using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiracleDice
{
    public partial class frm_Main : Form
    {
        #region Property
        private int _1To3 = 0;
        private int _3Until6 = 0;
        #endregion

        #region Constructor
        public frm_Main()
        {
            InitializeComponent();
        }
        #endregion

        #region Event
        private void btn_Execute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ExecuteCount.Text))
                return;

            int count = Convert.ToInt32(txt_ExecuteCount.Text);
            if (count <= 0)
                return;

            var seed = Guid.NewGuid().GetHashCode();
            Random rd = new Random(seed);
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += rd.Next(1, 7);
            }

            double chance = Math.Round((double)sum / count, 2);
            string now = DateTime.Now.ToString("HH:mm:ss");

            DataGridViewRow dgvr = new DataGridViewRow();
            DataGridViewCell cellChange = new DataGridViewTextBoxCell();
            cellChange.Value = chance.ToString();
            DataGridViewCell cellCount = new DataGridViewTextBoxCell();
            cellCount.Value = txt_ExecuteCount.Text;
            DataGridViewCell cellTime = new DataGridViewTextBoxCell();
            cellTime.Value = now;
            DataGridViewCell cellSingle = new DataGridViewTextBoxCell();
            cellSingle.Value = sum.ToString();
            DataGridViewCell cellDouble = new DataGridViewTextBoxCell();
            cellDouble.Value = (sum * 2).ToString();
            if (chance >= 3)
                _3Until6++;
            else
                _1To3++;

            if (sum >= count * 3.5)
            {
                cellSingle.Style.BackColor = Color.YellowGreen;
                cellDouble.Style.BackColor = Color.YellowGreen;
            }
            else if (sum <= count * 2.5)
            {
                cellSingle.Style.BackColor = Color.Khaki;
                cellDouble.Style.BackColor = Color.Khaki;
            }
            dgvr.Cells.Add(cellTime);
            dgvr.Cells.Add(cellCount);
            dgvr.Cells.Add(cellChange);
            dgvr.Cells.Add(cellSingle);
            dgvr.Cells.Add(cellDouble);
            dgv_Result.Rows.Add(dgvr);
            lbl_1To3.Text = _1To3.ToString();
            lbl_3Until6.Text = _3Until6.ToString();
            dgv_Result.FirstDisplayedScrollingRowIndex = dgv_Result.Rows.Count - 1;
        }

        private void txt_ExecuteCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 31 && (e.KeyChar < '0' || e.KeyChar > '9'))
                e.Handled = true;
        }
        #endregion

    }
}
