﻿
namespace Maps.HelpWindows
{
    partial class ItemConfigurationWindow
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
            if (disposing && (components != null))
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
            this.EnvironmentCheckBox = new System.Windows.Forms.CheckBox();
            this.EnvironmentGroupBox = new System.Windows.Forms.GroupBox();
            this.EnvironmentsComboBox = new System.Windows.Forms.ComboBox();
            this.m_AcceptButton = new System.Windows.Forms.Button();
            this.m_CancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.IssueGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SeriesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IssuesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ObjectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ObjectNameTextBox = new System.Windows.Forms.TextBox();
            this.IssueCheckBox = new System.Windows.Forms.CheckBox();
            this.EmissionGroupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AvgEmissionValueTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MaxEmissionValueTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MonthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ElementsComboBox = new System.Windows.Forms.ComboBox();
            this.EmissionCheckBox = new System.Windows.Forms.CheckBox();
            this.EnvironmentGroupBox.SuspendLayout();
            this.IssueGroupBox.SuspendLayout();
            this.EmissionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // EnvironmentCheckBox
            // 
            this.EnvironmentCheckBox.AutoSize = true;
            this.EnvironmentCheckBox.Location = new System.Drawing.Point(21, 134);
            this.EnvironmentCheckBox.Name = "EnvironmentCheckBox";
            this.EnvironmentCheckBox.Size = new System.Drawing.Size(158, 17);
            this.EnvironmentCheckBox.TabIndex = 0;
            this.EnvironmentCheckBox.Text = "Прив\'язка по середовищу";
            this.EnvironmentCheckBox.UseVisualStyleBackColor = true;
            this.EnvironmentCheckBox.CheckedChanged += new System.EventHandler(this.EnvironmentCheckBox_CheckedChanged);
            // 
            // EnvironmentGroupBox
            // 
            this.EnvironmentGroupBox.Controls.Add(this.EnvironmentsComboBox);
            this.EnvironmentGroupBox.Location = new System.Drawing.Point(12, 136);
            this.EnvironmentGroupBox.Name = "EnvironmentGroupBox";
            this.EnvironmentGroupBox.Size = new System.Drawing.Size(292, 51);
            this.EnvironmentGroupBox.TabIndex = 2;
            this.EnvironmentGroupBox.TabStop = false;
            // 
            // EnvironmentsComboBox
            // 
            this.EnvironmentsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnvironmentsComboBox.FormattingEnabled = true;
            this.EnvironmentsComboBox.Location = new System.Drawing.Point(6, 19);
            this.EnvironmentsComboBox.Name = "EnvironmentsComboBox";
            this.EnvironmentsComboBox.Size = new System.Drawing.Size(276, 21);
            this.EnvironmentsComboBox.TabIndex = 5;
            // 
            // m_AcceptButton
            // 
            this.m_AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_AcceptButton.Location = new System.Drawing.Point(230, 345);
            this.m_AcceptButton.Name = "m_AcceptButton";
            this.m_AcceptButton.Size = new System.Drawing.Size(80, 23);
            this.m_AcceptButton.TabIndex = 3;
            this.m_AcceptButton.Text = "Підтвердити";
            this.m_AcceptButton.UseVisualStyleBackColor = true;
            this.m_AcceptButton.Click += new System.EventHandler(this.m_AcceptButton_Click);
            // 
            // m_CancelButton
            // 
            this.m_CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_CancelButton.Location = new System.Drawing.Point(316, 345);
            this.m_CancelButton.Name = "m_CancelButton";
            this.m_CancelButton.Size = new System.Drawing.Size(80, 23);
            this.m_CancelButton.TabIndex = 4;
            this.m_CancelButton.Text = "Відміна";
            this.m_CancelButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "* - обов\'язкові поля";
            // 
            // IssueGroupBox
            // 
            this.IssueGroupBox.Controls.Add(this.label2);
            this.IssueGroupBox.Controls.Add(this.SeriesComboBox);
            this.IssueGroupBox.Controls.Add(this.label1);
            this.IssueGroupBox.Controls.Add(this.IssuesComboBox);
            this.IssueGroupBox.Location = new System.Drawing.Point(12, 12);
            this.IssueGroupBox.Name = "IssueGroupBox";
            this.IssueGroupBox.Size = new System.Drawing.Size(292, 118);
            this.IssueGroupBox.TabIndex = 10;
            this.IssueGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Серія";
            // 
            // SeriesComboBox
            // 
            this.SeriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeriesComboBox.FormattingEnabled = true;
            this.SeriesComboBox.Location = new System.Drawing.Point(6, 86);
            this.SeriesComboBox.Name = "SeriesComboBox";
            this.SeriesComboBox.Size = new System.Drawing.Size(276, 21);
            this.SeriesComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Задача";
            // 
            // IssuesComboBox
            // 
            this.IssuesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IssuesComboBox.FormattingEnabled = true;
            this.IssuesComboBox.Location = new System.Drawing.Point(6, 41);
            this.IssuesComboBox.Name = "IssuesComboBox";
            this.IssuesComboBox.Size = new System.Drawing.Size(276, 21);
            this.IssuesComboBox.TabIndex = 1;
            this.IssuesComboBox.SelectedIndexChanged += new System.EventHandler(this.IssuesComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Опис";
            // 
            // ObjectDescriptionTextBox
            // 
            this.ObjectDescriptionTextBox.Location = new System.Drawing.Point(130, 250);
            this.ObjectDescriptionTextBox.MaxLength = 200;
            this.ObjectDescriptionTextBox.Multiline = true;
            this.ObjectDescriptionTextBox.Name = "ObjectDescriptionTextBox";
            this.ObjectDescriptionTextBox.Size = new System.Drawing.Size(388, 89);
            this.ObjectDescriptionTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Назва *";
            // 
            // ObjectNameTextBox
            // 
            this.ObjectNameTextBox.Location = new System.Drawing.Point(130, 211);
            this.ObjectNameTextBox.MaxLength = 45;
            this.ObjectNameTextBox.Name = "ObjectNameTextBox";
            this.ObjectNameTextBox.Size = new System.Drawing.Size(388, 20);
            this.ObjectNameTextBox.TabIndex = 5;
            // 
            // IssueCheckBox
            // 
            this.IssueCheckBox.AutoSize = true;
            this.IssueCheckBox.Location = new System.Drawing.Point(21, 11);
            this.IssueCheckBox.Name = "IssueCheckBox";
            this.IssueCheckBox.Size = new System.Drawing.Size(127, 17);
            this.IssueCheckBox.TabIndex = 11;
            this.IssueCheckBox.Text = "Прив\'язка по задачі";
            this.IssueCheckBox.UseVisualStyleBackColor = true;
            this.IssueCheckBox.CheckedChanged += new System.EventHandler(this.IssueCheckBox_CheckedChanged);
            // 
            // EmissionGroupBox
            // 
            this.EmissionGroupBox.Controls.Add(this.label12);
            this.EmissionGroupBox.Controls.Add(this.label11);
            this.EmissionGroupBox.Controls.Add(this.AvgEmissionValueTextBox);
            this.EmissionGroupBox.Controls.Add(this.label10);
            this.EmissionGroupBox.Controls.Add(this.label9);
            this.EmissionGroupBox.Controls.Add(this.MaxEmissionValueTextBox);
            this.EmissionGroupBox.Controls.Add(this.label8);
            this.EmissionGroupBox.Controls.Add(this.label6);
            this.EmissionGroupBox.Controls.Add(this.DayNumericUpDown);
            this.EmissionGroupBox.Controls.Add(this.MonthNumericUpDown);
            this.EmissionGroupBox.Controls.Add(this.YearNumericUpDown);
            this.EmissionGroupBox.Controls.Add(this.label7);
            this.EmissionGroupBox.Controls.Add(this.ElementsComboBox);
            this.EmissionGroupBox.Location = new System.Drawing.Point(325, 12);
            this.EmissionGroupBox.Name = "EmissionGroupBox";
            this.EmissionGroupBox.Size = new System.Drawing.Size(292, 175);
            this.EmissionGroupBox.TabIndex = 11;
            this.EmissionGroupBox.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Значення викидів";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Середнє значення";
            // 
            // AvgEmissionValueTextBox
            // 
            this.AvgEmissionValueTextBox.Location = new System.Drawing.Point(157, 144);
            this.AvgEmissionValueTextBox.Name = "AvgEmissionValueTextBox";
            this.AvgEmissionValueTextBox.Size = new System.Drawing.Size(125, 20);
            this.AvgEmissionValueTextBox.TabIndex = 15;
            this.AvgEmissionValueTextBox.Text = "0";
            this.AvgEmissionValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmissionValueTextBox_KeyPress);
            this.AvgEmissionValueTextBox.Leave += new System.EventHandler(this.EmissionValueTextBox_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Максимальне значення";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "День";
            // 
            // MaxEmissionValueTextBox
            // 
            this.MaxEmissionValueTextBox.Location = new System.Drawing.Point(6, 144);
            this.MaxEmissionValueTextBox.Name = "MaxEmissionValueTextBox";
            this.MaxEmissionValueTextBox.Size = new System.Drawing.Size(125, 20);
            this.MaxEmissionValueTextBox.TabIndex = 13;
            this.MaxEmissionValueTextBox.Text = "0";
            this.MaxEmissionValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmissionValueTextBox_KeyPress);
            this.MaxEmissionValueTextBox.Leave += new System.EventHandler(this.EmissionValueTextBox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Місяць";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Рік";
            // 
            // DayNumericUpDown
            // 
            this.DayNumericUpDown.Location = new System.Drawing.Point(222, 84);
            this.DayNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DayNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DayNumericUpDown.Name = "DayNumericUpDown";
            this.DayNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.DayNumericUpDown.TabIndex = 5;
            this.DayNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MonthNumericUpDown
            // 
            this.MonthNumericUpDown.Location = new System.Drawing.Point(133, 85);
            this.MonthNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MonthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonthNumericUpDown.Name = "MonthNumericUpDown";
            this.MonthNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.MonthNumericUpDown.TabIndex = 4;
            this.MonthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Location = new System.Drawing.Point(6, 84);
            this.YearNumericUpDown.Name = "YearNumericUpDown";
            this.YearNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.YearNumericUpDown.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Елемент";
            // 
            // ElementsComboBox
            // 
            this.ElementsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElementsComboBox.FormattingEnabled = true;
            this.ElementsComboBox.Location = new System.Drawing.Point(6, 41);
            this.ElementsComboBox.Name = "ElementsComboBox";
            this.ElementsComboBox.Size = new System.Drawing.Size(276, 21);
            this.ElementsComboBox.TabIndex = 1;
            this.ElementsComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ElementsComboBox_Format);
            // 
            // EmissionCheckBox
            // 
            this.EmissionCheckBox.AutoSize = true;
            this.EmissionCheckBox.Location = new System.Drawing.Point(337, 12);
            this.EmissionCheckBox.Name = "EmissionCheckBox";
            this.EmissionCheckBox.Size = new System.Drawing.Size(140, 17);
            this.EmissionCheckBox.TabIndex = 12;
            this.EmissionCheckBox.Text = "Прив\'язка по викидам";
            this.EmissionCheckBox.UseVisualStyleBackColor = true;
            this.EmissionCheckBox.CheckedChanged += new System.EventHandler(this.EmissionCheckBox_CheckedChanged);
            // 
            // ItemConfigurationWindow
            // 
            this.AcceptButton = this.m_AcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_CancelButton;
            this.ClientSize = new System.Drawing.Size(627, 397);
            this.Controls.Add(this.EmissionCheckBox);
            this.Controls.Add(this.EmissionGroupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnvironmentCheckBox);
            this.Controls.Add(this.ObjectDescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IssueCheckBox);
            this.Controls.Add(this.ObjectNameTextBox);
            this.Controls.Add(this.IssueGroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_CancelButton);
            this.Controls.Add(this.m_AcceptButton);
            this.Controls.Add(this.EnvironmentGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ItemConfigurationWindow";
            this.Text = "Налаштування маркеру";
            this.Load += new System.EventHandler(this.ItemConfigurationWindow_Load);
            this.EnvironmentGroupBox.ResumeLayout(false);
            this.IssueGroupBox.ResumeLayout(false);
            this.IssueGroupBox.PerformLayout();
            this.EmissionGroupBox.ResumeLayout(false);
            this.EmissionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox EnvironmentCheckBox;
        private System.Windows.Forms.GroupBox EnvironmentGroupBox;
        private System.Windows.Forms.Button m_AcceptButton;
        private System.Windows.Forms.Button m_CancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox IssueGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ObjectDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SeriesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IssuesComboBox;
        private System.Windows.Forms.CheckBox IssueCheckBox;
        private System.Windows.Forms.ComboBox EnvironmentsComboBox;
        private System.Windows.Forms.TextBox ObjectNameTextBox;
        private System.Windows.Forms.GroupBox EmissionGroupBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AvgEmissionValueTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MaxEmissionValueTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown DayNumericUpDown;
        private System.Windows.Forms.NumericUpDown MonthNumericUpDown;
        private System.Windows.Forms.NumericUpDown YearNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ElementsComboBox;
        private System.Windows.Forms.CheckBox EmissionCheckBox;
    }
}