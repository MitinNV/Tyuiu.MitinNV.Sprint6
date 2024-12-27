namespace Tyuiu.MitinNV.Sprint6.Task6.V29;
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
        groupBoxRes = new GroupBox();
        resText = new Label();
        groupBoxCondition_MNV.SuspendLayout();
        groupBoxRes.SuspendLayout();
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
        groupBoxCondition_MNV.Size = new Size(776, 74);
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
        labelCond_MNV.Size = new Size(274, 20);
        labelCond_MNV.TabIndex = 6;
        labelCond_MNV.Text = "Выбор слов из файла, содержащих \"i\"";
        labelCond_MNV.Click += labelCond_MNV_Click;
        // 
        // groupBoxRes
        // 
        groupBoxRes.Controls.Add(resText);
        groupBoxRes.Location = new Point(12, 92);
        groupBoxRes.Name = "groupBoxRes";
        groupBoxRes.Size = new Size(773, 233);
        groupBoxRes.TabIndex = 7;
        groupBoxRes.TabStop = false;
        groupBoxRes.Text = "Результат";
        // 
        // resText
        // 
        resText.AutoSize = true;
        resText.Location = new Point(16, 41);
        resText.Name = "resText";
        resText.Size = new Size(18, 20);
        resText.TabIndex = 0;
        resText.Text = "...";
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(797, 393);
        Controls.Add(groupBoxRes);
        Controls.Add(groupBoxCondition_MNV);
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
        groupBoxRes.ResumeLayout(false);
        groupBoxRes.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonResult_MNV;
    private Button buttonToGetInfo_MNV;
    private GroupBox groupBoxCondition_MNV;
    private Label labelCond_MNV;
    private GroupBox groupBoxRes;
    private Label resText;
}