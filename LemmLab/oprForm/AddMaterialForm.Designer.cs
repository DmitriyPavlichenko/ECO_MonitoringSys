﻿namespace oprForm
{
    partial class AddMaterialForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nameTB = new System.Windows.Forms.TextBox();
			this.descTB = new System.Windows.Forms.TextBox();
			this.addBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Назва";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 43);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Опис";
			// 
			// nameTB
			// 
			this.nameTB.Location = new System.Drawing.Point(70, 19);
			this.nameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nameTB.Name = "nameTB";
			this.nameTB.Size = new System.Drawing.Size(153, 20);
			this.nameTB.TabIndex = 2;
			// 
			// descTB
			// 
			this.descTB.Location = new System.Drawing.Point(70, 41);
			this.descTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.descTB.Name = "descTB";
			this.descTB.Size = new System.Drawing.Size(153, 20);
			this.descTB.TabIndex = 3;
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(258, 19);
			this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(63, 33);
			this.addBtn.TabIndex = 4;
			this.addBtn.Text = "Додати";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// AddMaterialForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 85);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.descTB);
			this.Controls.Add(this.nameTB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "AddMaterialForm";
			this.Text = "Новый ресурс";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox descTB;
        private System.Windows.Forms.Button addBtn;
    }
}