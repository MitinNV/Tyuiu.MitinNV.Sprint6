namespace Tyuiu.MitinNV.Sprint6.Task7.V15;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonResult_MNV = new Button();
        buttonToGetInfo_MNV = new Button();
        groupBoxCondition_MNV = new GroupBox();
        labelCond_MNV = new Label();
        groupResultBox_MNV = new GroupBox();
        dataGridRes_MNV = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
        Column1 = new DataGridViewTextBoxColumn();
        Column2 = new DataGridViewTextBoxColumn();
        Column3 = new DataGridViewTextBoxColumn();
        Column4 = new DataGridViewTextBoxColumn();
        Column5 = new DataGridViewTextBoxColumn();
        groupBoxCondition_MNV.SuspendLayout();
        groupResultBox_MNV.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridRes_MNV).BeginInit();
        SuspendLayout();
        // 
        // buttonResult_MNV
        // 
        buttonResult_MNV.Cursor = Cursors.Hand;
        buttonResult_MNV.Location = new Point(641, 331);
        buttonResult_MNV.Name = "buttonResult_MNV";
        buttonResult_MNV.Size = new Size(147, 50);
        buttonResult_MNV.TabIndex = 0;
        buttonResult_MNV.Text = "Результат";
        buttonResult_MNV.UseVisualStyleBackColor = true;
        buttonResult_MNV.Click += buttonDone_Click;
        // 
        // buttonToGetInfo_MNV
        // 
        buttonToGetInfo_MNV.FlatStyle = FlatStyle.Flat;
        buttonToGetInfo_MNV.Font = new Font("Segoe UI", 11F);
        buttonToGetInfo_MNV.Location = new Point(585, 331);
        buttonToGetInfo_MNV.Name = "buttonToGetInfo_MNV";
        buttonToGetInfo_MNV.Size = new Size(50, 50);
        buttonToGetInfo_MNV.TabIndex = 4;
        buttonToGetInfo_MNV.Text = "?";
        buttonToGetInfo_MNV.UseVisualStyleBackColor = true;
        buttonToGetInfo_MNV.Click += buttonInfoDone_Click;
        // 
        // groupBoxCondition_MNV
        // 
        groupBoxCondition_MNV.Controls.Add(labelCond_MNV);
        groupBoxCondition_MNV.Location = new Point(12, 12);
        groupBoxCondition_MNV.Name = "groupBoxCondition_MNV";
        groupBoxCondition_MNV.Size = new Size(776, 299);
        groupBoxCondition_MNV.TabIndex = 6;
        groupBoxCondition_MNV.TabStop = false;
        groupBoxCondition_MNV.Text = "Условие";
        groupBoxCondition_MNV.Enter += groupBoxCondition_MNV_Enter;
        // 
        // labelCond_MNV
        // 
        labelCond_MNV.AutoSize = true;
        labelCond_MNV.Location = new Point(16, 26);
        labelCond_MNV.Name = "labelCond_MNV";
        labelCond_MNV.Size = new Size(659, 20);
        labelCond_MNV.TabIndex = 6;
        labelCond_MNV.Text = "Из файла прочитать матрицу и заменить в 7 столбце элементы, которы < 10 и кратны 3, на 0";
        labelCond_MNV.Click += labelCond_MNV_Click;
        // 
        // groupResultBox_MNV
        // 
        groupResultBox_MNV.Controls.Add(dataGridRes_MNV);
        groupResultBox_MNV.Location = new Point(794, 12);
        groupResultBox_MNV.Name = "groupResultBox_MNV";
        groupResultBox_MNV.Size = new Size(404, 369);
        groupResultBox_MNV.TabIndex = 1;
        groupResultBox_MNV.TabStop = false;
        groupResultBox_MNV.Text = "Результат";
        groupResultBox_MNV.Enter += groupBoxResult_Enter;
        // 
        // dataGridRes_MNV
        // 
        dataGridRes_MNV.AllowUserToAddRows = false;
        dataGridRes_MNV.AllowUserToDeleteRows = false;
        dataGridRes_MNV.AllowUserToOrderColumns = true;
        dataGridRes_MNV.AllowUserToResizeColumns = false;
        dataGridRes_MNV.AllowUserToResizeRows = false;
        dataGridRes_MNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridRes_MNV.ColumnHeadersVisible = false;
        dataGridRes_MNV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, Column1, Column2, Column3, Column4, Column5 });
        dataGridRes_MNV.Location = new Point(6, 26);
        dataGridRes_MNV.Name = "dataGridRes_MNV";
        dataGridRes_MNV.RowHeadersVisible = false;
        dataGridRes_MNV.RowHeadersWidth = 51;
        dataGridRes_MNV.Size = new Size(392, 337);
        dataGridRes_MNV.TabIndex = 8;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.HeaderText = "";
        dataGridViewTextBoxColumn1.MinimumWidth = 6;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.Width = 35;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.HeaderText = "";
        dataGridViewTextBoxColumn2.MinimumWidth = 6;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.Width = 35;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.HeaderText = "";
        dataGridViewTextBoxColumn3.MinimumWidth = 6;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.Width = 35;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.HeaderText = "";
        dataGridViewTextBoxColumn4.MinimumWidth = 6;
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.Width = 35;
        // 
        // dataGridViewTextBoxColumn5
        // 
        dataGridViewTextBoxColumn5.HeaderText = "";
        dataGridViewTextBoxColumn5.MinimumWidth = 6;
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        dataGridViewTextBoxColumn5.Width = 35;
        // 
        // Column1
        // 
        Column1.HeaderText = "";
        Column1.MinimumWidth = 6;
        Column1.Name = "Column1";
        Column1.Width = 35;
        // 
        // Column2
        // 
        Column2.HeaderText = "";
        Column2.MinimumWidth = 6;
        Column2.Name = "Column2";
        Column2.Width = 35;
        // 
        // Column3
        // 
        Column3.HeaderText = "";
        Column3.MinimumWidth = 6;
        Column3.Name = "Column3";
        Column3.Width = 35;
        // 
        // Column4
        // 
        Column4.HeaderText = "";
        Column4.MinimumWidth = 6;
        Column4.Name = "Column4";
        Column4.Width = 35;
        // 
        // Column5
        // 
        Column5.HeaderText = "";
        Column5.MinimumWidth = 6;
        Column5.Name = "Column5";
        Column5.Width = 35;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1210, 393);
        Controls.Add(groupBoxCondition_MNV);
        Controls.Add(groupResultBox_MNV);
        Controls.Add(buttonToGetInfo_MNV);
        Controls.Add(buttonResult_MNV);
        Cursor = Cursors.Help;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormMain";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Спринт #6 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
        Load += FormMain_Load;
        groupBoxCondition_MNV.ResumeLayout(false);
        groupBoxCondition_MNV.PerformLayout();
        groupResultBox_MNV.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridRes_MNV).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonResult_MNV;
    private Button buttonToGetInfo_MNV;
    private GroupBox groupBoxCondition_MNV;
    private Label labelCond_MNV;
    private GroupBox groupResultBox_MNV;
    private DataGridView dataGridRes_MNV;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
}