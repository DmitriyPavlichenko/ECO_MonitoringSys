﻿namespace Maps
{
    partial class Map
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
            this.components = new System.ComponentModel.Container();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.x = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSavePolygon = new System.Windows.Forms.Button();
            this.ZoomAdd = new System.Windows.Forms.Button();
            this.ZoomMinus = new System.Windows.Forms.Button();
            this.btnStartPointPolygon = new System.Windows.Forms.Button();
            this.btnCancelPolygon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClearMarker = new System.Windows.Forms.Button();
            this.btnDeleteMarker = new System.Windows.Forms.Button();
            this.btnShowExpertsMarkers = new System.Windows.Forms.Button();
            this.btnShowAllMarkers = new System.Windows.Forms.Button();
            this.btnCancelMarker = new System.Windows.Forms.Button();
            this.btnSaveMarker = new System.Windows.Forms.Button();
            this.btnAddMarker = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeletePolygon = new System.Windows.Forms.Button();
            this.btnClearPolygons = new System.Windows.Forms.Button();
            this.btnShowExpertsPolygons = new System.Windows.Forms.Button();
            this.btnShowAllPolygons = new System.Windows.Forms.Button();
            this.btnShowPolygon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnColorPolygon = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteTube = new System.Windows.Forms.Button();
            this.btnClearTube = new System.Windows.Forms.Button();
            this.btnShowExpertsTubes = new System.Windows.Forms.Button();
            this.btnShowAllTubes = new System.Windows.Forms.Button();
            this.btnCancelTube = new System.Windows.Forms.Button();
            this.btnSaveTube = new System.Windows.Forms.Button();
            this.btnStartTube = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CollapseButton = new System.Windows.Forms.Button();
            this.cbTownSearch = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl
            // 
            this.gMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.ContextMenuStrip = this.contextMenuStrip2;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(-2, 0);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(1349, 730);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 0D;
            this.gMapControl.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl_OnMarkerClick);
            this.gMapControl.OnPolygonClick += new GMap.NET.WindowsForms.PolygonClick(this.gMapControl_OnPolygonClick);
            this.gMapControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gMapControl_KeyDown);
            this.gMapControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(141, 70);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(140, 22);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem4.Text = "Refresh map";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(140, 22);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(183, 577);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(0, 13);
            this.x.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem1.Text = "New company";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem2.Text = "View emmissions";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // btnSavePolygon
            // 
            this.btnSavePolygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))));
            this.btnSavePolygon.Enabled = false;
            this.btnSavePolygon.FlatAppearance.BorderSize = 0;
            this.btnSavePolygon.FlatAppearance.CheckedBackColor = System.Drawing.Color.Fuchsia;
            this.btnSavePolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSavePolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnSavePolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePolygon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSavePolygon.Location = new System.Drawing.Point(113, 35);
            this.btnSavePolygon.Name = "btnSavePolygon";
            this.btnSavePolygon.Size = new System.Drawing.Size(77, 33);
            this.btnSavePolygon.TabIndex = 38;
            this.btnSavePolygon.Text = "Зберегти";
            this.btnSavePolygon.UseVisualStyleBackColor = false;
            this.btnSavePolygon.Click += new System.EventHandler(this.btnSavePolygon_Click);
            // 
            // ZoomAdd
            // 
            this.ZoomAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomAdd.Location = new System.Drawing.Point(1004, 29);
            this.ZoomAdd.Name = "ZoomAdd";
            this.ZoomAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ZoomAdd.Size = new System.Drawing.Size(24, 23);
            this.ZoomAdd.TabIndex = 41;
            this.ZoomAdd.Text = "+";
            this.ZoomAdd.UseVisualStyleBackColor = true;
            this.ZoomAdd.Click += new System.EventHandler(this.ZoomAdd_Click);
            // 
            // ZoomMinus
            // 
            this.ZoomMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomMinus.Location = new System.Drawing.Point(1004, 58);
            this.ZoomMinus.Name = "ZoomMinus";
            this.ZoomMinus.Size = new System.Drawing.Size(24, 23);
            this.ZoomMinus.TabIndex = 42;
            this.ZoomMinus.Text = "-";
            this.ZoomMinus.UseVisualStyleBackColor = true;
            this.ZoomMinus.Click += new System.EventHandler(this.ZoomMinus_Click);
            // 
            // btnStartPointPolygon
            // 
            this.btnStartPointPolygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))));
            this.btnStartPointPolygon.FlatAppearance.BorderSize = 0;
            this.btnStartPointPolygon.FlatAppearance.CheckedBackColor = System.Drawing.Color.Fuchsia;
            this.btnStartPointPolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStartPointPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnStartPointPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPointPolygon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartPointPolygon.Location = new System.Drawing.Point(17, 35);
            this.btnStartPointPolygon.Name = "btnStartPointPolygon";
            this.btnStartPointPolygon.Size = new System.Drawing.Size(77, 33);
            this.btnStartPointPolygon.TabIndex = 45;
            this.btnStartPointPolygon.Text = "Почати";
            this.btnStartPointPolygon.UseVisualStyleBackColor = false;
            this.btnStartPointPolygon.Click += new System.EventHandler(this.btnStartPointPolygon_Click);
            // 
            // btnCancelPolygon
            // 
            this.btnCancelPolygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))));
            this.btnCancelPolygon.FlatAppearance.BorderSize = 0;
            this.btnCancelPolygon.FlatAppearance.CheckedBackColor = System.Drawing.Color.Fuchsia;
            this.btnCancelPolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnCancelPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPolygon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelPolygon.Location = new System.Drawing.Point(206, 35);
            this.btnCancelPolygon.Name = "btnCancelPolygon";
            this.btnCancelPolygon.Size = new System.Drawing.Size(77, 33);
            this.btnCancelPolygon.TabIndex = 46;
            this.btnCancelPolygon.Text = "Вiдмiна";
            this.btnCancelPolygon.UseVisualStyleBackColor = false;
            this.btnCancelPolygon.Click += new System.EventHandler(this.btnCancelPolygon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Виберіть назву міста ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Пошук";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbTownSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cbSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1034, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 536);
            this.panel1.TabIndex = 57;
            this.panel1.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearch.Location = new System.Drawing.Point(12, 224);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 75;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Назві",
            "Задачі",
            "Розрахунку",
            "Формулі"});
            this.cbSearch.Location = new System.Drawing.Point(15, 165);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(278, 21);
            this.cbSearch.TabIndex = 74;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Пошук по:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(15, 196);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(278, 20);
            this.tbSearch.TabIndex = 72;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(100, 89);
            this.textBox4.MaxLength = 9;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(72, 20);
            this.textBox4.TabIndex = 66;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 89);
            this.textBox2.MaxLength = 9;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 20);
            this.textBox2.TabIndex = 65;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "довгота";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "широта";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 58;
            this.button6.Text = "Пошук";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(6, 262);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(307, 267);
            this.tabControl1.TabIndex = 57;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))));
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnClearMarker);
            this.tabPage1.Controls.Add(this.btnDeleteMarker);
            this.tabPage1.Controls.Add(this.btnShowExpertsMarkers);
            this.tabPage1.Controls.Add(this.btnShowAllMarkers);
            this.tabPage1.Controls.Add(this.btnCancelMarker);
            this.tabPage1.Controls.Add(this.btnSaveMarker);
            this.tabPage1.Controls.Add(this.btnAddMarker);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(299, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Маркер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 15);
            this.label9.TabIndex = 68;
            this.label9.Text = "Вид економічної діяльності";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 66;
            this.label8.Text = "Форма власності";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Публічне акціонерне товариство",
            "Товариство з додатковою відповідальністю",
            "Приватне акціонерне товариство",
            "Товариство з обмеженою відповідальністю",
            "Комунальна",
            "Державне підприємство",
            "Закрите акціонерне товариство",
            "Дочірнє підприємство закритого акціонерного товариства"});
            this.comboBox1.Location = new System.Drawing.Point(6, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 23);
            this.comboBox1.TabIndex = 65;
            this.comboBox1.ValueMember = "1";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "1";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 23);
            this.comboBox2.TabIndex = 67;
            this.comboBox2.ValueMember = "1";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(223, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 71);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClearMarker
            // 
            this.btnClearMarker.FlatAppearance.BorderSize = 0;
            this.btnClearMarker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClearMarker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnClearMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMarker.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearMarker.Location = new System.Drawing.Point(208, 150);
            this.btnClearMarker.Name = "btnClearMarker";
            this.btnClearMarker.Size = new System.Drawing.Size(75, 23);
            this.btnClearMarker.TabIndex = 64;
            this.btnClearMarker.Text = "Очистити";
            this.btnClearMarker.UseVisualStyleBackColor = true;
            this.btnClearMarker.Click += new System.EventHandler(this.btnClearMarker_Click);
            // 
            // btnDeleteMarker
            // 
            this.btnDeleteMarker.FlatAppearance.BorderSize = 0;
            this.btnDeleteMarker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteMarker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnDeleteMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMarker.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteMarker.Location = new System.Drawing.Point(9, 150);
            this.btnDeleteMarker.Name = "btnDeleteMarker";
            this.btnDeleteMarker.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMarker.TabIndex = 63;
            this.btnDeleteMarker.Text = "Видалити";
            this.btnDeleteMarker.UseVisualStyleBackColor = true;
            this.btnDeleteMarker.Click += new System.EventHandler(this.btnDeleteMarker_Click);
            // 
            // btnShowExpertsMarkers
            // 
            this.btnShowExpertsMarkers.FlatAppearance.BorderSize = 0;
            this.btnShowExpertsMarkers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowExpertsMarkers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnShowExpertsMarkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowExpertsMarkers.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowExpertsMarkers.Location = new System.Drawing.Point(140, 189);
            this.btnShowExpertsMarkers.Name = "btnShowExpertsMarkers";
            this.btnShowExpertsMarkers.Size = new System.Drawing.Size(150, 23);
            this.btnShowExpertsMarkers.TabIndex = 62;
            this.btnShowExpertsMarkers.Text = "Вiдобразити поточний";
            this.btnShowExpertsMarkers.UseVisualStyleBackColor = true;
            this.btnShowExpertsMarkers.Click += new System.EventHandler(this.btnShowExpertsMarkers_Click);
            // 
            // btnShowAllMarkers
            // 
            this.btnShowAllMarkers.FlatAppearance.BorderSize = 0;
            this.btnShowAllMarkers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowAllMarkers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnShowAllMarkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllMarkers.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAllMarkers.Location = new System.Drawing.Point(9, 189);
            this.btnShowAllMarkers.Name = "btnShowAllMarkers";
            this.btnShowAllMarkers.Size = new System.Drawing.Size(103, 23);
            this.btnShowAllMarkers.TabIndex = 61;
            this.btnShowAllMarkers.Text = "Вiдобразити всi";
            this.btnShowAllMarkers.UseVisualStyleBackColor = true;
            this.btnShowAllMarkers.Click += new System.EventHandler(this.btnShowAllMarkers_Click);
            // 
            // btnCancelMarker
            // 
            this.btnCancelMarker.Enabled = false;
            this.btnCancelMarker.FlatAppearance.BorderSize = 0;
            this.btnCancelMarker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelMarker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnCancelMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelMarker.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelMarker.Location = new System.Drawing.Point(215, 103);
            this.btnCancelMarker.Name = "btnCancelMarker";
            this.btnCancelMarker.Size = new System.Drawing.Size(75, 23);
            this.btnCancelMarker.TabIndex = 60;
            this.btnCancelMarker.Text = "Вiдмiна";
            this.btnCancelMarker.UseVisualStyleBackColor = true;
            this.btnCancelMarker.Click += new System.EventHandler(this.btnCancelMarker_Click);
            // 
            // btnSaveMarker
            // 
            this.btnSaveMarker.Enabled = false;
            this.btnSaveMarker.FlatAppearance.BorderSize = 0;
            this.btnSaveMarker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSaveMarker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnSaveMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMarker.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveMarker.Location = new System.Drawing.Point(113, 103);
            this.btnSaveMarker.Name = "btnSaveMarker";
            this.btnSaveMarker.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMarker.TabIndex = 59;
            this.btnSaveMarker.Text = "Зберегти";
            this.btnSaveMarker.UseVisualStyleBackColor = true;
            this.btnSaveMarker.Click += new System.EventHandler(this.btnSaveMarker_Click);
            // 
            // btnAddMarker
            // 
            this.btnAddMarker.FlatAppearance.BorderSize = 0;
            this.btnAddMarker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddMarker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnAddMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMarker.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddMarker.Location = new System.Drawing.Point(9, 103);
            this.btnAddMarker.Name = "btnAddMarker";
            this.btnAddMarker.Size = new System.Drawing.Size(75, 23);
            this.btnAddMarker.TabIndex = 58;
            this.btnAddMarker.Text = "Додати";
            this.btnAddMarker.UseVisualStyleBackColor = true;
            this.btnAddMarker.Click += new System.EventHandler(this.btnAddMarker_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))));
            this.tabPage2.Controls.Add(this.btnDeletePolygon);
            this.tabPage2.Controls.Add(this.btnClearPolygons);
            this.tabPage2.Controls.Add(this.btnShowExpertsPolygons);
            this.tabPage2.Controls.Add(this.btnShowAllPolygons);
            this.tabPage2.Controls.Add(this.btnShowPolygon);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnColorPolygon);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.btnStartPointPolygon);
            this.tabPage2.Controls.Add(this.btnCancelPolygon);
            this.tabPage2.Controls.Add(this.btnSavePolygon);
            this.tabPage2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(299, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Полiгон";
            // 
            // btnDeletePolygon
            // 
            this.btnDeletePolygon.FlatAppearance.BorderSize = 0;
            this.btnDeletePolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeletePolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnDeletePolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePolygon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeletePolygon.Location = new System.Drawing.Point(206, 146);
            this.btnDeletePolygon.Name = "btnDeletePolygon";
            this.btnDeletePolygon.Size = new System.Drawing.Size(77, 33);
            this.btnDeletePolygon.TabIndex = 56;
            this.btnDeletePolygon.Text = "Видалення";
            this.btnDeletePolygon.UseVisualStyleBackColor = true;
            this.btnDeletePolygon.Click += new System.EventHandler(this.btnDeletePolygon_Click);
            // 
            // btnClearPolygons
            // 
            this.btnClearPolygons.FlatAppearance.BorderSize = 0;
            this.btnClearPolygons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClearPolygons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnClearPolygons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPolygons.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearPolygons.Location = new System.Drawing.Point(113, 195);
            this.btnClearPolygons.Name = "btnClearPolygons";
            this.btnClearPolygons.Size = new System.Drawing.Size(77, 33);
            this.btnClearPolygons.TabIndex = 53;
            this.btnClearPolygons.Text = "Очистити";
            this.btnClearPolygons.UseVisualStyleBackColor = true;
            this.btnClearPolygons.Click += new System.EventHandler(this.btnClearPolygons_Click);
            // 
            // btnShowExpertsPolygons
            // 
            this.btnShowExpertsPolygons.FlatAppearance.BorderSize = 0;
            this.btnShowExpertsPolygons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowExpertsPolygons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnShowExpertsPolygons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowExpertsPolygons.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowExpertsPolygons.Location = new System.Drawing.Point(206, 86);
            this.btnShowExpertsPolygons.Name = "btnShowExpertsPolygons";
            this.btnShowExpertsPolygons.Size = new System.Drawing.Size(77, 33);
            this.btnShowExpertsPolygons.TabIndex = 52;
            this.btnShowExpertsPolygons.Text = "Поточний";
            this.btnShowExpertsPolygons.UseVisualStyleBackColor = true;
            this.btnShowExpertsPolygons.Click += new System.EventHandler(this.btnShowExpertsPolygons_Click);
            // 
            // btnShowAllPolygons
            // 
            this.btnShowAllPolygons.FlatAppearance.BorderSize = 0;
            this.btnShowAllPolygons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowAllPolygons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnShowAllPolygons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllPolygons.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAllPolygons.Location = new System.Drawing.Point(113, 86);
            this.btnShowAllPolygons.Name = "btnShowAllPolygons";
            this.btnShowAllPolygons.Size = new System.Drawing.Size(77, 33);
            this.btnShowAllPolygons.TabIndex = 51;
            this.btnShowAllPolygons.Text = "Всi";
            this.btnShowAllPolygons.UseVisualStyleBackColor = true;
            this.btnShowAllPolygons.Click += new System.EventHandler(this.btnAllShowPolygons_Click);
            // 
            // btnShowPolygon
            // 
            this.btnShowPolygon.Enabled = false;
            this.btnShowPolygon.FlatAppearance.BorderSize = 0;
            this.btnShowPolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnShowPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPolygon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowPolygon.Location = new System.Drawing.Point(18, 86);
            this.btnShowPolygon.Name = "btnShowPolygon";
            this.btnShowPolygon.Size = new System.Drawing.Size(77, 33);
            this.btnShowPolygon.TabIndex = 50;
            this.btnShowPolygon.Text = "Зобразити";
            this.btnShowPolygon.UseVisualStyleBackColor = true;
            this.btnShowPolygon.Click += new System.EventHandler(this.btnShowPolygon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(17, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 49;
            this.label5.Text = "Прозорiсть:";
            // 
            // btnColorPolygon
            // 
            this.btnColorPolygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))));
            this.btnColorPolygon.FlatAppearance.BorderSize = 0;
            this.btnColorPolygon.FlatAppearance.CheckedBackColor = System.Drawing.Color.Fuchsia;
            this.btnColorPolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnColorPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnColorPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorPolygon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnColorPolygon.Location = new System.Drawing.Point(113, 146);
            this.btnColorPolygon.Name = "btnColorPolygon";
            this.btnColorPolygon.Size = new System.Drawing.Size(77, 33);
            this.btnColorPolygon.TabIndex = 48;
            this.btnColorPolygon.Text = "Колiр";
            this.btnColorPolygon.UseVisualStyleBackColor = false;
            this.btnColorPolygon.Click += new System.EventHandler(this.btnColorPolygon_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(20, 153);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown1.TabIndex = 47;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))));
            this.tabPage3.Controls.Add(this.btnDeleteTube);
            this.tabPage3.Controls.Add(this.btnClearTube);
            this.tabPage3.Controls.Add(this.btnShowExpertsTubes);
            this.tabPage3.Controls.Add(this.btnShowAllTubes);
            this.tabPage3.Controls.Add(this.btnCancelTube);
            this.tabPage3.Controls.Add(this.btnSaveTube);
            this.tabPage3.Controls.Add(this.btnStartTube);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(299, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Водопровід";
            // 
            // btnDeleteTube
            // 
            this.btnDeleteTube.FlatAppearance.BorderSize = 0;
            this.btnDeleteTube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteTube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnDeleteTube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTube.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTube.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTube.Location = new System.Drawing.Point(106, 167);
            this.btnDeleteTube.Name = "btnDeleteTube";
            this.btnDeleteTube.Size = new System.Drawing.Size(87, 23);
            this.btnDeleteTube.TabIndex = 10;
            this.btnDeleteTube.Text = "Видалити";
            this.btnDeleteTube.UseVisualStyleBackColor = true;
            this.btnDeleteTube.Click += new System.EventHandler(this.btnDeleteTube_Click);
            // 
            // btnClearTube
            // 
            this.btnClearTube.FlatAppearance.BorderSize = 0;
            this.btnClearTube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClearTube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnClearTube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTube.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClearTube.ForeColor = System.Drawing.Color.White;
            this.btnClearTube.Location = new System.Drawing.Point(201, 111);
            this.btnClearTube.Name = "btnClearTube";
            this.btnClearTube.Size = new System.Drawing.Size(75, 23);
            this.btnClearTube.TabIndex = 9;
            this.btnClearTube.Text = "Очистити";
            this.btnClearTube.UseVisualStyleBackColor = true;
            this.btnClearTube.Click += new System.EventHandler(this.btnClearTube_Click);
            // 
            // btnShowExpertsTubes
            // 
            this.btnShowExpertsTubes.FlatAppearance.BorderSize = 0;
            this.btnShowExpertsTubes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowExpertsTubes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnShowExpertsTubes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowExpertsTubes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShowExpertsTubes.ForeColor = System.Drawing.Color.White;
            this.btnShowExpertsTubes.Location = new System.Drawing.Point(106, 111);
            this.btnShowExpertsTubes.Name = "btnShowExpertsTubes";
            this.btnShowExpertsTubes.Size = new System.Drawing.Size(81, 23);
            this.btnShowExpertsTubes.TabIndex = 8;
            this.btnShowExpertsTubes.Text = "Поточний";
            this.btnShowExpertsTubes.UseVisualStyleBackColor = true;
            this.btnShowExpertsTubes.Click += new System.EventHandler(this.btnShowExpertsTubes_Click);
            // 
            // btnShowAllTubes
            // 
            this.btnShowAllTubes.FlatAppearance.BorderSize = 0;
            this.btnShowAllTubes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowAllTubes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnShowAllTubes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllTubes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShowAllTubes.ForeColor = System.Drawing.Color.White;
            this.btnShowAllTubes.Location = new System.Drawing.Point(17, 111);
            this.btnShowAllTubes.Name = "btnShowAllTubes";
            this.btnShowAllTubes.Size = new System.Drawing.Size(75, 23);
            this.btnShowAllTubes.TabIndex = 3;
            this.btnShowAllTubes.Text = "Всі";
            this.btnShowAllTubes.UseVisualStyleBackColor = true;
            this.btnShowAllTubes.Click += new System.EventHandler(this.btnShowAllTubes_Click);
            // 
            // btnCancelTube
            // 
            this.btnCancelTube.Enabled = false;
            this.btnCancelTube.FlatAppearance.BorderSize = 0;
            this.btnCancelTube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelTube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnCancelTube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTube.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelTube.ForeColor = System.Drawing.Color.White;
            this.btnCancelTube.Location = new System.Drawing.Point(201, 47);
            this.btnCancelTube.Name = "btnCancelTube";
            this.btnCancelTube.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTube.TabIndex = 2;
            this.btnCancelTube.Text = "Відміна";
            this.btnCancelTube.UseVisualStyleBackColor = true;
            this.btnCancelTube.Click += new System.EventHandler(this.btnCancelTube_Click);
            // 
            // btnSaveTube
            // 
            this.btnSaveTube.Enabled = false;
            this.btnSaveTube.FlatAppearance.BorderSize = 0;
            this.btnSaveTube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSaveTube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnSaveTube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTube.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveTube.ForeColor = System.Drawing.Color.White;
            this.btnSaveTube.Location = new System.Drawing.Point(106, 47);
            this.btnSaveTube.Name = "btnSaveTube";
            this.btnSaveTube.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTube.TabIndex = 1;
            this.btnSaveTube.Text = "Зберегти";
            this.btnSaveTube.UseVisualStyleBackColor = true;
            this.btnSaveTube.Click += new System.EventHandler(this.btnSaveTube_Click);
            // 
            // btnStartTube
            // 
            this.btnStartTube.FlatAppearance.BorderSize = 0;
            this.btnStartTube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStartTube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.btnStartTube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTube.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStartTube.ForeColor = System.Drawing.Color.White;
            this.btnStartTube.Location = new System.Drawing.Point(17, 47);
            this.btnStartTube.Name = "btnStartTube";
            this.btnStartTube.Size = new System.Drawing.Size(75, 23);
            this.btnStartTube.TabIndex = 0;
            this.btnStartTube.Text = "Почати";
            this.btnStartTube.UseVisualStyleBackColor = true;
            this.btnStartTube.Click += new System.EventHandler(this.btnStartTube_Click);
            // 
            // CollapseButton
            // 
            this.CollapseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CollapseButton.Location = new System.Drawing.Point(1004, 0);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(24, 23);
            this.CollapseButton.TabIndex = 66;
            this.CollapseButton.Text = "_";
            this.CollapseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CollapseButton.UseVisualStyleBackColor = true;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // cbTownSearch
            // 
            this.cbTownSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTownSearch.FormattingEnabled = true;
            this.cbTownSearch.Location = new System.Drawing.Point(12, 19);
            this.cbTownSearch.Name = "cbTownSearch";
            this.cbTownSearch.Size = new System.Drawing.Size(288, 21);
            this.cbTownSearch.TabIndex = 76;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.CollapseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ZoomMinus);
            this.Controls.Add(this.ZoomAdd);
            this.Controls.Add(this.x);
            this.Controls.Add(this.gMapControl);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Map_Load);
            this.SizeChanged += new System.EventHandler(this.Map_SizeChanged);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button btnSavePolygon;
        private System.Windows.Forms.Button ZoomAdd;
        private System.Windows.Forms.Button ZoomMinus;
        private System.Windows.Forms.Button btnStartPointPolygon;
        private System.Windows.Forms.Button btnCancelPolygon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnColorPolygon;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowAllPolygons;
        private System.Windows.Forms.Button btnShowPolygon;
        private System.Windows.Forms.Button btnAddMarker;
        private System.Windows.Forms.Button btnShowAllMarkers;
        private System.Windows.Forms.Button btnCancelMarker;
        private System.Windows.Forms.Button btnSaveMarker;
        private System.Windows.Forms.Button btnShowExpertsMarkers;
        private System.Windows.Forms.Button btnShowExpertsPolygons;
        private System.Windows.Forms.Button btnClearPolygons;
        private System.Windows.Forms.Button btnDeleteMarker;
        private System.Windows.Forms.Button btnClearMarker;
        private System.Windows.Forms.Button btnDeletePolygon;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnShowAllTubes;
        private System.Windows.Forms.Button btnCancelTube;
        private System.Windows.Forms.Button btnSaveTube;
        private System.Windows.Forms.Button btnStartTube;
        private System.Windows.Forms.Button btnClearTube;
        private System.Windows.Forms.Button btnShowExpertsTubes;
        private System.Windows.Forms.Button btnDeleteTube;
        private System.Windows.Forms.Button CollapseButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbTownSearch;
    }
}

