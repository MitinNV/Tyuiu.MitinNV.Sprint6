namespace Tyuiu.MitinNV.Sprint6.Task4.V25;
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        buttonResult_MNV = new Button();
        textBoxValueX_MNV = new TextBox();
        groupBoxValueX_MNV = new GroupBox();
        buttonToGetInfo_MNV = new Button();
        pictureBoxFormula_MNV = new PictureBox();
        groupBoxCondition_MNV = new GroupBox();
        labelCond_MNV = new Label();
        groupBoxValueY_MNV = new GroupBox();
        textBoxValueY_MNV = new TextBox();
        groupResultBox_MNV = new GroupBox();
        dataGridViewRes_MNV = new DataGridView();
        xColumn = new DataGridViewTextBoxColumn();
        resColumn = new DataGridViewTextBoxColumn();
        buttonSaveToFile_MNV = new Button();
        groupBoxValueX_MNV.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_MNV).BeginInit();
        groupBoxCondition_MNV.SuspendLayout();
        groupBoxValueY_MNV.SuspendLayout();
        groupResultBox_MNV.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewRes_MNV).BeginInit();
        SuspendLayout();
        // 
        // buttonResult_MNV
        // 
        buttonResult_MNV.Cursor = Cursors.Hand;
        buttonResult_MNV.Location = new Point(715, 329);
        buttonResult_MNV.Name = "buttonResult_MNV";
        buttonResult_MNV.Size = new Size(147, 50);
        buttonResult_MNV.TabIndex = 0;
        buttonResult_MNV.Text = "Результат";
        buttonResult_MNV.UseVisualStyleBackColor = true;
        buttonResult_MNV.Click += buttonDone_Click;
        // 
        // textBoxValueX_MNV
        // 
        textBoxValueX_MNV.Location = new Point(51, 26);
        textBoxValueX_MNV.Name = "textBoxValueX_MNV";
        textBoxValueX_MNV.Size = new Size(125, 27);
        textBoxValueX_MNV.TabIndex = 2;
        // 
        // groupBoxValueX_MNV
        // 
        groupBoxValueX_MNV.Controls.Add(textBoxValueX_MNV);
        groupBoxValueX_MNV.Location = new Point(12, 317);
        groupBoxValueX_MNV.Name = "groupBoxValueX_MNV";
        groupBoxValueX_MNV.Size = new Size(234, 66);
        groupBoxValueX_MNV.TabIndex = 3;
        groupBoxValueX_MNV.TabStop = false;
        groupBoxValueX_MNV.Text = "Введите начальное значение";
        groupBoxValueX_MNV.Enter += groupBoxValueX_Enter;
        // 
        // buttonToGetInfo_MNV
        // 
        buttonToGetInfo_MNV.FlatStyle = FlatStyle.Flat;
        buttonToGetInfo_MNV.Font = new Font("Segoe UI", 11F);
        buttonToGetInfo_MNV.Location = new Point(506, 329);
        buttonToGetInfo_MNV.Name = "buttonToGetInfo_MNV";
        buttonToGetInfo_MNV.Size = new Size(50, 50);
        buttonToGetInfo_MNV.TabIndex = 4;
        buttonToGetInfo_MNV.Text = "?";
        buttonToGetInfo_MNV.UseVisualStyleBackColor = true;
        buttonToGetInfo_MNV.Click += buttonInfoDone_Click;
        // 
        // pictureBoxFormula_MNV
        // 
        pictureBoxFormula_MNV.Image = (Image)resources.GetObject("pictureBoxFormula_MNV.Image");
        pictureBoxFormula_MNV.InitialImage = (Image)resources.GetObject("pictureBoxFormula_MNV.InitialImage");
        pictureBoxFormula_MNV.Location = new Point(431, 26);
        pictureBoxFormula_MNV.Name = "pictureBoxFormula_MNV";
        pictureBoxFormula_MNV.Size = new Size(413, 60);
        pictureBoxFormula_MNV.TabIndex = 5;
        pictureBoxFormula_MNV.TabStop = false;
        pictureBoxFormula_MNV.Click += pictureBox1_Click;
        // 
        // groupBoxCondition_MNV
        // 
        groupBoxCondition_MNV.Controls.Add(labelCond_MNV);
        groupBoxCondition_MNV.Controls.Add(pictureBoxFormula_MNV);
        groupBoxCondition_MNV.Location = new Point(12, 12);
        groupBoxCondition_MNV.Name = "groupBoxCondition_MNV";
        groupBoxCondition_MNV.Size = new Size(850, 299);
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
        labelCond_MNV.Size = new Size(182, 20);
        labelCond_MNV.TabIndex = 6;
        labelCond_MNV.Text = "Табулирование функции";
        labelCond_MNV.Click += labelCond_MNV_Click;
        // 
        // groupBoxValueY_MNV
        // 
        groupBoxValueY_MNV.Controls.Add(textBoxValueY_MNV);
        groupBoxValueY_MNV.Location = new Point(262, 317);
        groupBoxValueY_MNV.Name = "groupBoxValueY_MNV";
        groupBoxValueY_MNV.Size = new Size(234, 66);
        groupBoxValueY_MNV.TabIndex = 7;
        groupBoxValueY_MNV.TabStop = false;
        groupBoxValueY_MNV.Text = "Введите конечное значение";
        // 
        // textBoxValueY_MNV
        // 
        textBoxValueY_MNV.Location = new Point(51, 26);
        textBoxValueY_MNV.Name = "textBoxValueY_MNV";
        textBoxValueY_MNV.Size = new Size(125, 27);
        textBoxValueY_MNV.TabIndex = 2;
        // 
        // groupResultBox_MNV
        // 
        groupResultBox_MNV.Controls.Add(dataGridViewRes_MNV);
        groupResultBox_MNV.Location = new Point(868, 12);
        groupResultBox_MNV.Name = "groupResultBox_MNV";
        groupResultBox_MNV.Size = new Size(257, 369);
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
        dataGridViewRes_MNV.Columns.AddRange(new DataGridViewColumn[] { xColumn, resColumn });
        dataGridViewRes_MNV.Location = new Point(6, 26);
        dataGridViewRes_MNV.Name = "dataGridViewRes_MNV";
        dataGridViewRes_MNV.ReadOnly = true;
        dataGridViewRes_MNV.RowHeadersVisible = false;
        dataGridViewRes_MNV.RowHeadersWidth = 51;
        dataGridViewRes_MNV.Size = new Size(248, 337);
        dataGridViewRes_MNV.TabIndex = 0;
        dataGridViewRes_MNV.CellContentClick += dataGridView1_CellContentClick;
        // 
        // xColumn
        // 
        xColumn.HeaderText = "x";
        xColumn.MinimumWidth = 6;
        xColumn.Name = "xColumn";
        xColumn.ReadOnly = true;
        xColumn.Width = 125;
        // 
        // resColumn
        // 
        resColumn.HeaderText = "F(x)";
        resColumn.MinimumWidth = 6;
        resColumn.Name = "resColumn";
        resColumn.ReadOnly = true;
        resColumn.Width = 125;
        // 
        // buttonSaveToFile_MNV
        // 
        buttonSaveToFile_MNV.Cursor = Cursors.Hand;
        buttonSaveToFile_MNV.Location = new Point(562, 329);
        buttonSaveToFile_MNV.Name = "buttonSaveToFile_MNV";
        buttonSaveToFile_MNV.Size = new Size(147, 50);
        buttonSaveToFile_MNV.TabIndex = 8;
        buttonSaveToFile_MNV.Text = "Сохранить в txt\r\n";
        buttonSaveToFile_MNV.UseVisualStyleBackColor = true;
        buttonSaveToFile_MNV.Click += buttonSaveToFile_MNV_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1137, 393);
        Controls.Add(buttonSaveToFile_MNV);
        Controls.Add(groupBoxValueY_MNV);
        Controls.Add(groupBoxCondition_MNV);
        Controls.Add(groupResultBox_MNV);
        Controls.Add(buttonToGetInfo_MNV);
        Controls.Add(groupBoxValueX_MNV);
        Controls.Add(buttonResult_MNV);
        Cursor = Cursors.Help;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormMain";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Спринт #6 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
        Load += FormMain_Load;
        groupBoxValueX_MNV.ResumeLayout(false);
        groupBoxValueX_MNV.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_MNV).EndInit();
        groupBoxCondition_MNV.ResumeLayout(false);
        groupBoxCondition_MNV.PerformLayout();
        groupBoxValueY_MNV.ResumeLayout(false);
        groupBoxValueY_MNV.PerformLayout();
        groupResultBox_MNV.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewRes_MNV).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonResult_MNV;
    private TextBox textBoxValueX_MNV;
    private GroupBox groupBoxValueX_MNV;
    private Button buttonToGetInfo_MNV;
    private PictureBox pictureBoxFormula_MNV;
    private GroupBox groupBoxCondition_MNV;
    private Label labelCond_MNV;
    private GroupBox groupBoxValueY_MNV;
    private TextBox textBoxValueY_MNV;
    private GroupBox groupResultBox_MNV;
    private DataGridView dataGridViewRes_MNV;
    private DataGridViewTextBoxColumn xColumn;
    private DataGridViewTextBoxColumn resColumn;
    private Button buttonSaveToFile_MNV;
}