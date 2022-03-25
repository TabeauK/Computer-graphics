namespace GK2
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxBackground = new System.Windows.Forms.GroupBox();
            this.buttonPickFile = new System.Windows.Forms.Button();
            this.radioButtonPickFile = new System.Windows.Forms.RadioButton();
            this.buttonPickColor = new System.Windows.Forms.Button();
            this.radioButtonPickColor = new System.Windows.Forms.RadioButton();
            this.groupBoxNVector = new System.Windows.Forms.GroupBox();
            this.buttonNormalMap = new System.Windows.Forms.Button();
            this.radioButtonNormalMap = new System.Windows.Forms.RadioButton();
            this.radioButtonConst = new System.Windows.Forms.RadioButton();
            this.groupBoxFilling = new System.Windows.Forms.GroupBox();
            this.radioButtonHybrid = new System.Windows.Forms.RadioButton();
            this.radioButtonInterpol = new System.Windows.Forms.RadioButton();
            this.radioButtonFullFilling = new System.Windows.Forms.RadioButton();
            this.groupBoxFactors = new System.Windows.Forms.GroupBox();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.trackBarM = new System.Windows.Forms.TrackBar();
            this.labelM = new System.Windows.Forms.Label();
            this.trackBarKs = new System.Windows.Forms.TrackBar();
            this.labelKs = new System.Windows.Forms.Label();
            this.trackBarKd = new System.Windows.Forms.TrackBar();
            this.labelKd = new System.Windows.Forms.Label();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.groupBoxLight = new System.Windows.Forms.GroupBox();
            this.radioButtonLightAnimate = new System.Windows.Forms.RadioButton();
            this.radioButtonLightVector = new System.Windows.Forms.RadioButton();
            this.buttonLightColor = new System.Windows.Forms.Button();
            this.groupBoxExtra = new System.Windows.Forms.GroupBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxNet = new System.Windows.Forms.CheckBox();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.errorProviderX = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderY = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxBackground.SuspendLayout();
            this.groupBoxNVector.SuspendLayout();
            this.groupBoxFilling.SuspendLayout();
            this.groupBoxFactors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKd)).BeginInit();
            this.groupBoxLight.SuspendLayout();
            this.groupBoxExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderY)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1782, 1055);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(50, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1382, 955);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.PictureBox1_SizeChanged);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxBackground, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxNVector, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxFilling, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxFactors, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxLight, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxExtra, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1485, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 1049);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBoxBackground
            // 
            this.groupBoxBackground.AutoSize = true;
            this.groupBoxBackground.Controls.Add(this.buttonPickFile);
            this.groupBoxBackground.Controls.Add(this.radioButtonPickFile);
            this.groupBoxBackground.Controls.Add(this.buttonPickColor);
            this.groupBoxBackground.Controls.Add(this.radioButtonPickColor);
            this.groupBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBackground.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBackground.Name = "groupBoxBackground";
            this.groupBoxBackground.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxBackground.Size = new System.Drawing.Size(288, 195);
            this.groupBoxBackground.TabIndex = 0;
            this.groupBoxBackground.TabStop = false;
            this.groupBoxBackground.Text = "Background:";
            // 
            // buttonPickFile
            // 
            this.buttonPickFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPickFile.Enabled = false;
            this.buttonPickFile.Location = new System.Drawing.Point(10, 145);
            this.buttonPickFile.Name = "buttonPickFile";
            this.buttonPickFile.Size = new System.Drawing.Size(268, 40);
            this.buttonPickFile.TabIndex = 4;
            this.buttonPickFile.Text = "Pick";
            this.buttonPickFile.UseVisualStyleBackColor = true;
            this.buttonPickFile.Click += new System.EventHandler(this.ButtonPickFile_Click);
            // 
            // radioButtonPickFile
            // 
            this.radioButtonPickFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonPickFile.Location = new System.Drawing.Point(10, 105);
            this.radioButtonPickFile.Name = "radioButtonPickFile";
            this.radioButtonPickFile.Size = new System.Drawing.Size(268, 40);
            this.radioButtonPickFile.TabIndex = 3;
            this.radioButtonPickFile.Text = "Pick from file";
            this.radioButtonPickFile.UseVisualStyleBackColor = true;
            this.radioButtonPickFile.CheckedChanged += new System.EventHandler(this.RadioButtonPickFile_CheckedChanged);
            // 
            // buttonPickColor
            // 
            this.buttonPickColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPickColor.Location = new System.Drawing.Point(10, 65);
            this.buttonPickColor.Name = "buttonPickColor";
            this.buttonPickColor.Size = new System.Drawing.Size(268, 40);
            this.buttonPickColor.TabIndex = 1;
            this.buttonPickColor.Text = "Pick";
            this.buttonPickColor.UseVisualStyleBackColor = true;
            this.buttonPickColor.Click += new System.EventHandler(this.ButtonPickColor_Click);
            // 
            // radioButtonPickColor
            // 
            this.radioButtonPickColor.Checked = true;
            this.radioButtonPickColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonPickColor.Location = new System.Drawing.Point(10, 25);
            this.radioButtonPickColor.Margin = new System.Windows.Forms.Padding(10);
            this.radioButtonPickColor.Name = "radioButtonPickColor";
            this.radioButtonPickColor.Size = new System.Drawing.Size(268, 40);
            this.radioButtonPickColor.TabIndex = 0;
            this.radioButtonPickColor.TabStop = true;
            this.radioButtonPickColor.Text = "Pick color";
            this.radioButtonPickColor.UseVisualStyleBackColor = true;
            this.radioButtonPickColor.CheckedChanged += new System.EventHandler(this.RadioButtonPickColor_CheckedChanged);
            // 
            // groupBoxNVector
            // 
            this.groupBoxNVector.AutoSize = true;
            this.groupBoxNVector.Controls.Add(this.buttonNormalMap);
            this.groupBoxNVector.Controls.Add(this.radioButtonNormalMap);
            this.groupBoxNVector.Controls.Add(this.radioButtonConst);
            this.groupBoxNVector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNVector.Location = new System.Drawing.Point(3, 204);
            this.groupBoxNVector.Name = "groupBoxNVector";
            this.groupBoxNVector.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxNVector.Size = new System.Drawing.Size(288, 155);
            this.groupBoxNVector.TabIndex = 1;
            this.groupBoxNVector.TabStop = false;
            this.groupBoxNVector.Text = "N Vector:";
            // 
            // buttonNormalMap
            // 
            this.buttonNormalMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNormalMap.Enabled = false;
            this.buttonNormalMap.Location = new System.Drawing.Point(10, 105);
            this.buttonNormalMap.Name = "buttonNormalMap";
            this.buttonNormalMap.Size = new System.Drawing.Size(268, 40);
            this.buttonNormalMap.TabIndex = 2;
            this.buttonNormalMap.Text = "Pick";
            this.buttonNormalMap.UseVisualStyleBackColor = true;
            this.buttonNormalMap.Click += new System.EventHandler(this.ButtonNormalMap_Click);
            // 
            // radioButtonNormalMap
            // 
            this.radioButtonNormalMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonNormalMap.Location = new System.Drawing.Point(10, 65);
            this.radioButtonNormalMap.Name = "radioButtonNormalMap";
            this.radioButtonNormalMap.Size = new System.Drawing.Size(268, 40);
            this.radioButtonNormalMap.TabIndex = 1;
            this.radioButtonNormalMap.Text = "Normal Map";
            this.radioButtonNormalMap.UseVisualStyleBackColor = true;
            this.radioButtonNormalMap.CheckedChanged += new System.EventHandler(this.RadioButtonNormalMap_CheckedChanged);
            // 
            // radioButtonConst
            // 
            this.radioButtonConst.Checked = true;
            this.radioButtonConst.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonConst.Location = new System.Drawing.Point(10, 25);
            this.radioButtonConst.Name = "radioButtonConst";
            this.radioButtonConst.Size = new System.Drawing.Size(268, 40);
            this.radioButtonConst.TabIndex = 0;
            this.radioButtonConst.TabStop = true;
            this.radioButtonConst.Text = "[0,0,1]";
            this.radioButtonConst.UseVisualStyleBackColor = true;
            this.radioButtonConst.CheckedChanged += new System.EventHandler(this.RadioButtonConst_CheckedChanged);
            // 
            // groupBoxFilling
            // 
            this.groupBoxFilling.AutoSize = true;
            this.groupBoxFilling.Controls.Add(this.radioButtonHybrid);
            this.groupBoxFilling.Controls.Add(this.radioButtonInterpol);
            this.groupBoxFilling.Controls.Add(this.radioButtonFullFilling);
            this.groupBoxFilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilling.Location = new System.Drawing.Point(3, 365);
            this.groupBoxFilling.Name = "groupBoxFilling";
            this.groupBoxFilling.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxFilling.Size = new System.Drawing.Size(288, 155);
            this.groupBoxFilling.TabIndex = 2;
            this.groupBoxFilling.TabStop = false;
            this.groupBoxFilling.Text = "Filling:";
            // 
            // radioButtonHybrid
            // 
            this.radioButtonHybrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonHybrid.Location = new System.Drawing.Point(10, 105);
            this.radioButtonHybrid.Name = "radioButtonHybrid";
            this.radioButtonHybrid.Size = new System.Drawing.Size(268, 40);
            this.radioButtonHybrid.TabIndex = 2;
            this.radioButtonHybrid.TabStop = true;
            this.radioButtonHybrid.Text = "Fast";
            this.radioButtonHybrid.UseVisualStyleBackColor = true;
            this.radioButtonHybrid.CheckedChanged += new System.EventHandler(this.RadioButtonHybrid_CheckedChanged);
            // 
            // radioButtonInterpol
            // 
            this.radioButtonInterpol.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonInterpol.Location = new System.Drawing.Point(10, 65);
            this.radioButtonInterpol.Name = "radioButtonInterpol";
            this.radioButtonInterpol.Size = new System.Drawing.Size(268, 40);
            this.radioButtonInterpol.TabIndex = 1;
            this.radioButtonInterpol.TabStop = true;
            this.radioButtonInterpol.Text = "Sonic Fast";
            this.radioButtonInterpol.UseVisualStyleBackColor = true;
            this.radioButtonInterpol.CheckedChanged += new System.EventHandler(this.RadioButtonInterpol_CheckedChanged);
            // 
            // radioButtonFullFilling
            // 
            this.radioButtonFullFilling.Checked = true;
            this.radioButtonFullFilling.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonFullFilling.Location = new System.Drawing.Point(10, 25);
            this.radioButtonFullFilling.Name = "radioButtonFullFilling";
            this.radioButtonFullFilling.Size = new System.Drawing.Size(268, 40);
            this.radioButtonFullFilling.TabIndex = 0;
            this.radioButtonFullFilling.TabStop = true;
            this.radioButtonFullFilling.Text = "Slow";
            this.radioButtonFullFilling.UseVisualStyleBackColor = true;
            this.radioButtonFullFilling.CheckedChanged += new System.EventHandler(this.RadioButtonFullFilling_CheckedChanged);
            // 
            // groupBoxFactors
            // 
            this.groupBoxFactors.AutoSize = true;
            this.groupBoxFactors.Controls.Add(this.radioButtonRandom);
            this.groupBoxFactors.Controls.Add(this.trackBarM);
            this.groupBoxFactors.Controls.Add(this.labelM);
            this.groupBoxFactors.Controls.Add(this.trackBarKs);
            this.groupBoxFactors.Controls.Add(this.labelKs);
            this.groupBoxFactors.Controls.Add(this.trackBarKd);
            this.groupBoxFactors.Controls.Add(this.labelKd);
            this.groupBoxFactors.Controls.Add(this.radioButtonCustom);
            this.groupBoxFactors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFactors.Location = new System.Drawing.Point(3, 526);
            this.groupBoxFactors.Name = "groupBoxFactors";
            this.groupBoxFactors.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxFactors.Size = new System.Drawing.Size(288, 337);
            this.groupBoxFactors.TabIndex = 3;
            this.groupBoxFactors.TabStop = false;
            this.groupBoxFactors.Text = "Factors:";
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonRandom.Location = new System.Drawing.Point(10, 287);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(268, 40);
            this.radioButtonRandom.TabIndex = 11;
            this.radioButtonRandom.Text = "Random";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            this.radioButtonRandom.CheckedChanged += new System.EventHandler(this.RadioButtonRandom_CheckedChanged);
            // 
            // trackBarM
            // 
            this.trackBarM.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarM.Location = new System.Drawing.Point(10, 231);
            this.trackBarM.Maximum = 100;
            this.trackBarM.Name = "trackBarM";
            this.trackBarM.Size = new System.Drawing.Size(268, 56);
            this.trackBarM.TabIndex = 10;
            this.trackBarM.Value = 50;
            this.trackBarM.Scroll += new System.EventHandler(this.TrackBarM_Scroll);
            // 
            // labelM
            // 
            this.labelM.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelM.Location = new System.Drawing.Point(10, 214);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(268, 17);
            this.labelM.TabIndex = 9;
            this.labelM.Text = "M";
            this.labelM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarKs
            // 
            this.trackBarKs.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarKs.Location = new System.Drawing.Point(10, 158);
            this.trackBarKs.Maximum = 100;
            this.trackBarKs.Name = "trackBarKs";
            this.trackBarKs.Size = new System.Drawing.Size(268, 56);
            this.trackBarKs.TabIndex = 8;
            this.trackBarKs.Value = 50;
            this.trackBarKs.Scroll += new System.EventHandler(this.TrackBarKss_Scroll);
            // 
            // labelKs
            // 
            this.labelKs.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelKs.Location = new System.Drawing.Point(10, 141);
            this.labelKs.Name = "labelKs";
            this.labelKs.Size = new System.Drawing.Size(268, 17);
            this.labelKs.TabIndex = 7;
            this.labelKs.Text = "Ks";
            this.labelKs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarKd
            // 
            this.trackBarKd.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarKd.Location = new System.Drawing.Point(10, 85);
            this.trackBarKd.Maximum = 100;
            this.trackBarKd.Name = "trackBarKd";
            this.trackBarKd.Size = new System.Drawing.Size(268, 56);
            this.trackBarKd.TabIndex = 6;
            this.trackBarKd.Value = 50;
            this.trackBarKd.Scroll += new System.EventHandler(this.TrackBarKd_Scroll);
            // 
            // labelKd
            // 
            this.labelKd.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelKd.Location = new System.Drawing.Point(10, 65);
            this.labelKd.Name = "labelKd";
            this.labelKd.Size = new System.Drawing.Size(268, 20);
            this.labelKd.TabIndex = 5;
            this.labelKd.Text = "Kd";
            this.labelKd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.Checked = true;
            this.radioButtonCustom.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonCustom.Location = new System.Drawing.Point(10, 25);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(268, 40);
            this.radioButtonCustom.TabIndex = 0;
            this.radioButtonCustom.TabStop = true;
            this.radioButtonCustom.Text = "Custom";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            this.radioButtonCustom.CheckedChanged += new System.EventHandler(this.RadioButtonCustom_CheckedChanged);
            // 
            // groupBoxLight
            // 
            this.groupBoxLight.AutoSize = true;
            this.groupBoxLight.Controls.Add(this.radioButtonLightAnimate);
            this.groupBoxLight.Controls.Add(this.radioButtonLightVector);
            this.groupBoxLight.Controls.Add(this.buttonLightColor);
            this.groupBoxLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLight.Location = new System.Drawing.Point(3, 869);
            this.groupBoxLight.Name = "groupBoxLight";
            this.groupBoxLight.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxLight.Size = new System.Drawing.Size(288, 155);
            this.groupBoxLight.TabIndex = 4;
            this.groupBoxLight.TabStop = false;
            this.groupBoxLight.Text = "Light:";
            // 
            // radioButtonLightAnimate
            // 
            this.radioButtonLightAnimate.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonLightAnimate.Location = new System.Drawing.Point(10, 105);
            this.radioButtonLightAnimate.Name = "radioButtonLightAnimate";
            this.radioButtonLightAnimate.Size = new System.Drawing.Size(268, 40);
            this.radioButtonLightAnimate.TabIndex = 2;
            this.radioButtonLightAnimate.TabStop = true;
            this.radioButtonLightAnimate.Text = "Animated Light";
            this.radioButtonLightAnimate.UseVisualStyleBackColor = true;
            this.radioButtonLightAnimate.CheckedChanged += new System.EventHandler(this.RadioButtonLightAnimate_CheckedChanged);
            // 
            // radioButtonLightVector
            // 
            this.radioButtonLightVector.Checked = true;
            this.radioButtonLightVector.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonLightVector.Location = new System.Drawing.Point(10, 65);
            this.radioButtonLightVector.Name = "radioButtonLightVector";
            this.radioButtonLightVector.Size = new System.Drawing.Size(268, 40);
            this.radioButtonLightVector.TabIndex = 1;
            this.radioButtonLightVector.TabStop = true;
            this.radioButtonLightVector.Text = "[0,0,1]";
            this.radioButtonLightVector.UseVisualStyleBackColor = true;
            this.radioButtonLightVector.CheckedChanged += new System.EventHandler(this.RadioButtonLightVector_CheckedChanged);
            // 
            // buttonLightColor
            // 
            this.buttonLightColor.BackColor = System.Drawing.Color.White;
            this.buttonLightColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLightColor.Location = new System.Drawing.Point(10, 25);
            this.buttonLightColor.Name = "buttonLightColor";
            this.buttonLightColor.Size = new System.Drawing.Size(268, 40);
            this.buttonLightColor.TabIndex = 0;
            this.buttonLightColor.Text = "Pick Light Color";
            this.buttonLightColor.UseVisualStyleBackColor = false;
            this.buttonLightColor.Click += new System.EventHandler(this.ButtonLightColor_Click);
            // 
            // groupBoxExtra
            // 
            this.groupBoxExtra.AutoSize = true;
            this.groupBoxExtra.Controls.Add(this.textBoxY);
            this.groupBoxExtra.Controls.Add(this.label2);
            this.groupBoxExtra.Controls.Add(this.textBoxX);
            this.groupBoxExtra.Controls.Add(this.label1);
            this.groupBoxExtra.Controls.Add(this.checkBoxNet);
            this.groupBoxExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxExtra.Location = new System.Drawing.Point(3, 1030);
            this.groupBoxExtra.Name = "groupBoxExtra";
            this.groupBoxExtra.Size = new System.Drawing.Size(288, 151);
            this.groupBoxExtra.TabIndex = 5;
            this.groupBoxExtra.TabStop = false;
            this.groupBoxExtra.Text = "Extra:";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(140, 108);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 22);
            this.textBoxY.TabIndex = 4;
            this.textBoxY.Text = "10";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxY.TextChanged += new System.EventHandler(this.TextBoxY_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Points on Y-axis:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(140, 70);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 22);
            this.textBoxX.TabIndex = 2;
            this.textBoxX.Text = "10";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX.TextChanged += new System.EventHandler(this.TextBoxX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Points on X-axis:";
            // 
            // checkBoxNet
            // 
            this.checkBoxNet.AutoSize = true;
            this.checkBoxNet.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxNet.Location = new System.Drawing.Point(3, 18);
            this.checkBoxNet.Name = "checkBoxNet";
            this.checkBoxNet.Padding = new System.Windows.Forms.Padding(10);
            this.checkBoxNet.Size = new System.Drawing.Size(282, 41);
            this.checkBoxNet.TabIndex = 0;
            this.checkBoxNet.Text = "Disable Editing Net";
            this.checkBoxNet.UseVisualStyleBackColor = true;
            this.checkBoxNet.CheckedChanged += new System.EventHandler(this.CheckBoxNet_CheckedChanged);
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 30;
            this.timerAnimation.Tick += new System.EventHandler(this.TimerAnimation_Tick);
            // 
            // errorProviderX
            // 
            this.errorProviderX.ContainerControl = this;
            // 
            // errorProviderY
            // 
            this.errorProviderY.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1782, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxBackground.ResumeLayout(false);
            this.groupBoxNVector.ResumeLayout(false);
            this.groupBoxFilling.ResumeLayout(false);
            this.groupBoxFactors.ResumeLayout(false);
            this.groupBoxFactors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKd)).EndInit();
            this.groupBoxLight.ResumeLayout(false);
            this.groupBoxExtra.ResumeLayout(false);
            this.groupBoxExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxBackground;
        private System.Windows.Forms.RadioButton radioButtonPickColor;
        private System.Windows.Forms.GroupBox groupBoxNVector;
        private System.Windows.Forms.RadioButton radioButtonNormalMap;
        private System.Windows.Forms.RadioButton radioButtonConst;
        private System.Windows.Forms.GroupBox groupBoxFilling;
        private System.Windows.Forms.RadioButton radioButtonHybrid;
        private System.Windows.Forms.RadioButton radioButtonInterpol;
        private System.Windows.Forms.RadioButton radioButtonFullFilling;
        private System.Windows.Forms.GroupBox groupBoxFactors;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.Label labelKd;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.TrackBar trackBarM;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.TrackBar trackBarKs;
        private System.Windows.Forms.Label labelKs;
        private System.Windows.Forms.TrackBar trackBarKd;
        private System.Windows.Forms.RadioButton radioButtonPickFile;
        private System.Windows.Forms.Button buttonPickColor;
        private System.Windows.Forms.Button buttonPickFile;
        private System.Windows.Forms.Button buttonNormalMap;
        private System.Windows.Forms.GroupBox groupBoxLight;
        private System.Windows.Forms.RadioButton radioButtonLightAnimate;
        private System.Windows.Forms.RadioButton radioButtonLightVector;
        private System.Windows.Forms.Button buttonLightColor;
        private System.Windows.Forms.GroupBox groupBoxExtra;
        private System.Windows.Forms.CheckBox checkBoxNet;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderX;
        private System.Windows.Forms.ErrorProvider errorProviderY;
    }
}

