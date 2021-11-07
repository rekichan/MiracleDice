
namespace MiracleDice
{
    partial class frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ExecuteCount = new System.Windows.Forms.TextBox();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.dgv_Result = new System.Windows.Forms.DataGridView();
            this.col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Chance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SingleSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DoubleSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_1To3 = new System.Windows.Forms.Label();
            this.lbl_3Until6 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "摇骰次数";
            // 
            // txt_ExecuteCount
            // 
            this.txt_ExecuteCount.Location = new System.Drawing.Point(87, 12);
            this.txt_ExecuteCount.Name = "txt_ExecuteCount";
            this.txt_ExecuteCount.Size = new System.Drawing.Size(100, 27);
            this.txt_ExecuteCount.TabIndex = 1;
            this.txt_ExecuteCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ExecuteCount_KeyPress);
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(280, 3);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(90, 45);
            this.btn_Execute.TabIndex = 2;
            this.btn_Execute.Text = "好骰我摇";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // dgv_Result
            // 
            this.dgv_Result.AllowUserToAddRows = false;
            this.dgv_Result.AllowUserToDeleteRows = false;
            this.dgv_Result.AllowUserToResizeColumns = false;
            this.dgv_Result.AllowUserToResizeRows = false;
            this.dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Time,
            this.col_Count,
            this.col_Chance,
            this.col_SingleSum,
            this.col_DoubleSum});
            this.dgv_Result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Result.Location = new System.Drawing.Point(0, 80);
            this.dgv_Result.Name = "dgv_Result";
            this.dgv_Result.RowHeadersVisible = false;
            this.dgv_Result.RowHeadersWidth = 51;
            this.dgv_Result.RowTemplate.Height = 27;
            this.dgv_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Result.Size = new System.Drawing.Size(382, 475);
            this.dgv_Result.TabIndex = 3;
            // 
            // col_Time
            // 
            this.col_Time.HeaderText = "时间";
            this.col_Time.MinimumWidth = 6;
            this.col_Time.Name = "col_Time";
            this.col_Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Time.Width = 75;
            // 
            // col_Count
            // 
            this.col_Count.HeaderText = "次数";
            this.col_Count.MinimumWidth = 6;
            this.col_Count.Name = "col_Count";
            this.col_Count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Count.Width = 75;
            // 
            // col_Chance
            // 
            this.col_Chance.HeaderText = "平均";
            this.col_Chance.MinimumWidth = 6;
            this.col_Chance.Name = "col_Chance";
            this.col_Chance.Width = 75;
            // 
            // col_SingleSum
            // 
            this.col_SingleSum.HeaderText = "总数";
            this.col_SingleSum.MinimumWidth = 6;
            this.col_SingleSum.Name = "col_SingleSum";
            this.col_SingleSum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_SingleSum.Width = 75;
            // 
            // col_DoubleSum
            // 
            this.col_DoubleSum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DoubleSum.HeaderText = "8点";
            this.col_DoubleSum.MinimumWidth = 6;
            this.col_DoubleSum.Name = "col_DoubleSum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "[1,3):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "[3,6]:";
            // 
            // lbl_1To3
            // 
            this.lbl_1To3.AutoSize = true;
            this.lbl_1To3.Location = new System.Drawing.Point(63, 57);
            this.lbl_1To3.Name = "lbl_1To3";
            this.lbl_1To3.Size = new System.Drawing.Size(44, 20);
            this.lbl_1To3.TabIndex = 6;
            this.lbl_1To3.Text = "?????";
            // 
            // lbl_3Until6
            // 
            this.lbl_3Until6.AutoSize = true;
            this.lbl_3Until6.Location = new System.Drawing.Point(283, 57);
            this.lbl_3Until6.Name = "lbl_3Until6";
            this.lbl_3Until6.Size = new System.Drawing.Size(44, 20);
            this.lbl_3Until6.TabIndex = 7;
            this.lbl_3Until6.Text = "?????";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "次";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "次";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 555);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_3Until6);
            this.Controls.Add(this.lbl_1To3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Result);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.txt_ExecuteCount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "frm_Main";
            this.Text = "骰好?";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ExecuteCount;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.DataGridView dgv_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Chance;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SingleSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DoubleSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_1To3;
        private System.Windows.Forms.Label lbl_3Until6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

