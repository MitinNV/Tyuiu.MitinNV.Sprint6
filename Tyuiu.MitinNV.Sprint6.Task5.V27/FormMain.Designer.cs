namespace Tyuiu.MitinNV.Sprint6.Task5.V27;

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
        dataGridViewRes_MNV = new DataGridView();
        xColumn = new DataGridViewTextBoxColumn();
        groupBoxCondition_MNV.SuspendLayout();
        groupResultBox_MNV.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewRes_MNV).BeginInit();
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
        labelCond_MNV.Size = new Size(251, 60);
        labelCond_MNV.TabIndex = 6;
        labelCond_MNV.Text = "Чтение чисел из файла\r\n\r\nВывод чисел, которые не кратны 5";
        labelCond_MNV.Click += labelCond_MNV_Click;
        // 
        // groupResultBox_MNV
        // 
        groupResultBox_MNV.Controls.Add(dataGridViewRes_MNV);
        groupResultBox_MNV.Location = new Point(794, 12);
        groupResultBox_MNV.Name = "groupResultBox_MNV";
        groupResultBox_MNV.Size = new Size(127, 369);
        groupResultBox_MNV.TabIndex = 1;
        groupResultBox_MNV.TabStop = false;
        groupResultBox_MNV.Text = "Результат";
        groupResultBox_MNV.Enter += groupBoxResult_Enter;
        // 
        // dataGridViewRes_MNV
        // 
        dataGridViewRes_MNV.AllowUserToDeleteRows = false;
        dataGridViewRes_MNV.AllowUserToOrderColumns = true;
        dataGridViewRes_MNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewRes_MNV.Columns.AddRange(new DataGridViewColumn[] { xColumn });
        dataGridViewRes_MNV.Location = new Point(6, 26);
        dataGridViewRes_MNV.Name = "dataGridViewRes_MNV";
        dataGridViewRes_MNV.ReadOnly = true;
        dataGridViewRes_MNV.RowHeadersVisible = false;
        dataGridViewRes_MNV.RowHeadersWidth = 51;
        dataGridViewRes_MNV.Size = new Size(112, 337);
        dataGridViewRes_MNV.TabIndex = 0;
        dataGridViewRes_MNV.CellContentClick += dataGridView1_CellContentClick;
        dataGridViewRes_MNV.Columns[0].Width = 75;
        // 
        // xColumn
        // 
        xColumn.HeaderText = "x";
        xColumn.Width = 75;
        xColumn.MinimumWidth = 6;
        xColumn.Name = "xColumn";
        xColumn.ReadOnly = true;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(926, 393);
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
        ((System.ComponentModel.ISupportInitialize)dataGridViewRes_MNV).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonResult_MNV;
    private Button buttonToGetInfo_MNV;
    private GroupBox groupBoxCondition_MNV;
    private Label labelCond_MNV;
    private GroupBox groupResultBox_MNV;
    private Panel panelResult_MNV;
    private DataGridView dataGridViewRes_MNV;
    private DataGridViewTextBoxColumn xColumn;
}