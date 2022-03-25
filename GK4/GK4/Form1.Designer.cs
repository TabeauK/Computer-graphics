namespace GK4
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
            this.trackBarFOV = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxShowLight = new System.Windows.Forms.CheckBox();
            this.groupBoxCamera = new System.Windows.Forms.GroupBox();
            this.radioButtonCamera3 = new System.Windows.Forms.RadioButton();
            this.radioButtonCamera2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCamera1 = new System.Windows.Forms.RadioButton();
            this.groupBoxObject = new System.Windows.Forms.GroupBox();
            this.checkBoxRotate = new System.Windows.Forms.CheckBox();
            this.checkBoxMoveZ = new System.Windows.Forms.CheckBox();
            this.checkBoxMoveY = new System.Windows.Forms.CheckBox();
            this.checkBoxMoveX = new System.Windows.Forms.CheckBox();
            this.groupBoxShading = new System.Windows.Forms.GroupBox();
            this.radioButtonPhong = new System.Windows.Forms.RadioButton();
            this.radioButtonGouraud = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.MovingLightColorButton = new System.Windows.Forms.Button();
            this.StableLightColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarK = new System.Windows.Forms.TrackBar();
            this.trackBarN = new System.Windows.Forms.TrackBar();
            this.trackBarKa = new System.Windows.Forms.TrackBar();
            this.trackBarKd = new System.Windows.Forms.TrackBar();
            this.trackBarKs = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RotateLightCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonColorPick = new System.Windows.Forms.Button();
            this.timerCamera = new System.Windows.Forms.Timer(this.components);
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFOV)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxCamera.SuspendLayout();
            this.groupBoxObject.SuspendLayout();
            this.groupBoxShading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKs)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBarFOV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonColorPick, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 1325);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 1271);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarFOV
            // 
            this.trackBarFOV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarFOV.Location = new System.Drawing.Point(3, 1277);
            this.trackBarFOV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarFOV.Maximum = 150;
            this.trackBarFOV.Minimum = 10;
            this.trackBarFOV.Name = "trackBarFOV";
            this.trackBarFOV.Size = new System.Drawing.Size(1016, 46);
            this.trackBarFOV.TabIndex = 1;
            this.trackBarFOV.Value = 45;
            this.trackBarFOV.Scroll += new System.EventHandler(this.TrackBarFOV_Scroll);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.checkBoxShowLight, 0, 17);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxCamera, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxObject, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxShading, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.MovingLightColorButton, 0, 15);
            this.tableLayoutPanel2.Controls.Add(this.StableLightColorButton, 0, 14);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.trackBarK, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.trackBarN, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.trackBarKa, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.trackBarKd, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.trackBarKs, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.RotateLightCheckBox, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1025, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 18;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(154, 1271);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // checkBoxShowLight
            // 
            this.checkBoxShowLight.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxShowLight.Location = new System.Drawing.Point(3, 1108);
            this.checkBoxShowLight.Name = "checkBoxShowLight";
            this.checkBoxShowLight.Size = new System.Drawing.Size(148, 30);
            this.checkBoxShowLight.TabIndex = 20;
            this.checkBoxShowLight.Text = "Show Light";
            this.checkBoxShowLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxShowLight.UseVisualStyleBackColor = true;
            this.checkBoxShowLight.Click += new System.EventHandler(this.CheckBoxShowLight_Click);
            // 
            // groupBoxCamera
            // 
            this.groupBoxCamera.AutoSize = true;
            this.groupBoxCamera.Controls.Add(this.radioButtonCamera3);
            this.groupBoxCamera.Controls.Add(this.radioButtonCamera2);
            this.groupBoxCamera.Controls.Add(this.radioButtonCamera1);
            this.groupBoxCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCamera.Location = new System.Drawing.Point(4, 4);
            this.groupBoxCamera.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCamera.Name = "groupBoxCamera";
            this.groupBoxCamera.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCamera.Size = new System.Drawing.Size(146, 143);
            this.groupBoxCamera.TabIndex = 1;
            this.groupBoxCamera.TabStop = false;
            this.groupBoxCamera.Text = "Camera:";
            // 
            // radioButtonCamera3
            // 
            this.radioButtonCamera3.AutoSize = true;
            this.radioButtonCamera3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonCamera3.Enabled = false;
            this.radioButtonCamera3.Location = new System.Drawing.Point(4, 99);
            this.radioButtonCamera3.MinimumSize = new System.Drawing.Size(140, 40);
            this.radioButtonCamera3.Name = "radioButtonCamera3";
            this.radioButtonCamera3.Size = new System.Drawing.Size(140, 40);
            this.radioButtonCamera3.TabIndex = 2;
            this.radioButtonCamera3.Text = "Follow Object";
            this.radioButtonCamera3.UseVisualStyleBackColor = true;
            this.radioButtonCamera3.CheckedChanged += new System.EventHandler(this.RadioButtonCamera3_CheckedChanged);
            // 
            // radioButtonCamera2
            // 
            this.radioButtonCamera2.AutoSize = true;
            this.radioButtonCamera2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonCamera2.Location = new System.Drawing.Point(4, 59);
            this.radioButtonCamera2.MinimumSize = new System.Drawing.Size(140, 40);
            this.radioButtonCamera2.Name = "radioButtonCamera2";
            this.radioButtonCamera2.Size = new System.Drawing.Size(140, 40);
            this.radioButtonCamera2.TabIndex = 1;
            this.radioButtonCamera2.Text = "Rotating";
            this.radioButtonCamera2.UseVisualStyleBackColor = true;
            this.radioButtonCamera2.CheckedChanged += new System.EventHandler(this.RadioButtonCamera2_CheckedChanged);
            // 
            // radioButtonCamera1
            // 
            this.radioButtonCamera1.AutoSize = true;
            this.radioButtonCamera1.Checked = true;
            this.radioButtonCamera1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonCamera1.Location = new System.Drawing.Point(4, 19);
            this.radioButtonCamera1.MinimumSize = new System.Drawing.Size(140, 40);
            this.radioButtonCamera1.Name = "radioButtonCamera1";
            this.radioButtonCamera1.Size = new System.Drawing.Size(140, 40);
            this.radioButtonCamera1.TabIndex = 0;
            this.radioButtonCamera1.TabStop = true;
            this.radioButtonCamera1.Text = "Stable";
            this.radioButtonCamera1.UseVisualStyleBackColor = true;
            // 
            // groupBoxObject
            // 
            this.groupBoxObject.AutoSize = true;
            this.groupBoxObject.Controls.Add(this.checkBoxRotate);
            this.groupBoxObject.Controls.Add(this.checkBoxMoveZ);
            this.groupBoxObject.Controls.Add(this.checkBoxMoveY);
            this.groupBoxObject.Controls.Add(this.checkBoxMoveX);
            this.groupBoxObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxObject.Location = new System.Drawing.Point(3, 154);
            this.groupBoxObject.Name = "groupBoxObject";
            this.groupBoxObject.Size = new System.Drawing.Size(148, 181);
            this.groupBoxObject.TabIndex = 3;
            this.groupBoxObject.TabStop = false;
            this.groupBoxObject.Text = "Object";
            // 
            // checkBoxRotate
            // 
            this.checkBoxRotate.AutoSize = true;
            this.checkBoxRotate.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxRotate.Location = new System.Drawing.Point(3, 138);
            this.checkBoxRotate.MinimumSize = new System.Drawing.Size(140, 40);
            this.checkBoxRotate.Name = "checkBoxRotate";
            this.checkBoxRotate.Size = new System.Drawing.Size(142, 40);
            this.checkBoxRotate.TabIndex = 3;
            this.checkBoxRotate.Text = "Rotate";
            this.checkBoxRotate.UseVisualStyleBackColor = true;
            this.checkBoxRotate.CheckedChanged += new System.EventHandler(this.CheckBoxMove_CheckedChanged);
            // 
            // checkBoxMoveZ
            // 
            this.checkBoxMoveZ.AutoSize = true;
            this.checkBoxMoveZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxMoveZ.Location = new System.Drawing.Point(3, 98);
            this.checkBoxMoveZ.MinimumSize = new System.Drawing.Size(140, 40);
            this.checkBoxMoveZ.Name = "checkBoxMoveZ";
            this.checkBoxMoveZ.Size = new System.Drawing.Size(142, 40);
            this.checkBoxMoveZ.TabIndex = 2;
            this.checkBoxMoveZ.Text = "Move on Z axis";
            this.checkBoxMoveZ.UseVisualStyleBackColor = true;
            this.checkBoxMoveZ.CheckedChanged += new System.EventHandler(this.CheckBoxMove_CheckedChanged);
            // 
            // checkBoxMoveY
            // 
            this.checkBoxMoveY.AutoSize = true;
            this.checkBoxMoveY.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxMoveY.Location = new System.Drawing.Point(3, 58);
            this.checkBoxMoveY.MinimumSize = new System.Drawing.Size(140, 40);
            this.checkBoxMoveY.Name = "checkBoxMoveY";
            this.checkBoxMoveY.Size = new System.Drawing.Size(142, 40);
            this.checkBoxMoveY.TabIndex = 1;
            this.checkBoxMoveY.Text = "Move on Y axis";
            this.checkBoxMoveY.UseVisualStyleBackColor = true;
            this.checkBoxMoveY.CheckedChanged += new System.EventHandler(this.CheckBoxMove_CheckedChanged);
            // 
            // checkBoxMoveX
            // 
            this.checkBoxMoveX.AutoSize = true;
            this.checkBoxMoveX.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxMoveX.Location = new System.Drawing.Point(3, 18);
            this.checkBoxMoveX.MinimumSize = new System.Drawing.Size(140, 40);
            this.checkBoxMoveX.Name = "checkBoxMoveX";
            this.checkBoxMoveX.Size = new System.Drawing.Size(142, 40);
            this.checkBoxMoveX.TabIndex = 0;
            this.checkBoxMoveX.Text = "Move on X axis";
            this.checkBoxMoveX.UseVisualStyleBackColor = true;
            this.checkBoxMoveX.CheckedChanged += new System.EventHandler(this.CheckBoxMove_CheckedChanged);
            // 
            // groupBoxShading
            // 
            this.groupBoxShading.AutoSize = true;
            this.groupBoxShading.Controls.Add(this.radioButtonPhong);
            this.groupBoxShading.Controls.Add(this.radioButtonGouraud);
            this.groupBoxShading.Controls.Add(this.radioButtonNormal);
            this.groupBoxShading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxShading.Location = new System.Drawing.Point(3, 341);
            this.groupBoxShading.Name = "groupBoxShading";
            this.groupBoxShading.Size = new System.Drawing.Size(148, 141);
            this.groupBoxShading.TabIndex = 4;
            this.groupBoxShading.TabStop = false;
            this.groupBoxShading.Text = "Shading";
            // 
            // radioButtonPhong
            // 
            this.radioButtonPhong.AutoSize = true;
            this.radioButtonPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonPhong.Location = new System.Drawing.Point(3, 98);
            this.radioButtonPhong.MinimumSize = new System.Drawing.Size(140, 40);
            this.radioButtonPhong.Name = "radioButtonPhong";
            this.radioButtonPhong.Size = new System.Drawing.Size(142, 40);
            this.radioButtonPhong.TabIndex = 2;
            this.radioButtonPhong.TabStop = true;
            this.radioButtonPhong.Text = "Phong\'s";
            this.radioButtonPhong.UseVisualStyleBackColor = true;
            this.radioButtonPhong.Click += new System.EventHandler(this.RadioButtonPhong_Click);
            // 
            // radioButtonGouraud
            // 
            this.radioButtonGouraud.AutoSize = true;
            this.radioButtonGouraud.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonGouraud.Location = new System.Drawing.Point(3, 58);
            this.radioButtonGouraud.MinimumSize = new System.Drawing.Size(140, 40);
            this.radioButtonGouraud.Name = "radioButtonGouraud";
            this.radioButtonGouraud.Size = new System.Drawing.Size(142, 40);
            this.radioButtonGouraud.TabIndex = 1;
            this.radioButtonGouraud.Text = "Gouraud\'s";
            this.radioButtonGouraud.UseVisualStyleBackColor = true;
            this.radioButtonGouraud.Click += new System.EventHandler(this.RadioButtonGouraud_Click);
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Checked = true;
            this.radioButtonNormal.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonNormal.Location = new System.Drawing.Point(3, 18);
            this.radioButtonNormal.MinimumSize = new System.Drawing.Size(140, 40);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(142, 40);
            this.radioButtonNormal.TabIndex = 0;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.Click += new System.EventHandler(this.RadioButtonNormal_Click);
            // 
            // MovingLightColorButton
            // 
            this.MovingLightColorButton.BackColor = System.Drawing.Color.White;
            this.MovingLightColorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovingLightColorButton.ForeColor = System.Drawing.Color.Black;
            this.MovingLightColorButton.Location = new System.Drawing.Point(3, 1038);
            this.MovingLightColorButton.Name = "MovingLightColorButton";
            this.MovingLightColorButton.Size = new System.Drawing.Size(148, 44);
            this.MovingLightColorButton.TabIndex = 5;
            this.MovingLightColorButton.Text = "Pick Moving Light Color";
            this.MovingLightColorButton.UseVisualStyleBackColor = false;
            this.MovingLightColorButton.Click += new System.EventHandler(this.MovingLightColorButton_Click);
            // 
            // StableLightColorButton
            // 
            this.StableLightColorButton.BackColor = System.Drawing.Color.White;
            this.StableLightColorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StableLightColorButton.ForeColor = System.Drawing.Color.Black;
            this.StableLightColorButton.Location = new System.Drawing.Point(3, 988);
            this.StableLightColorButton.Name = "StableLightColorButton";
            this.StableLightColorButton.Size = new System.Drawing.Size(148, 44);
            this.StableLightColorButton.TabIndex = 6;
            this.StableLightColorButton.Text = "Pick Static Light Color";
            this.StableLightColorButton.UseVisualStyleBackColor = false;
            this.StableLightColorButton.Click += new System.EventHandler(this.StableLightColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 889);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sphere Interpolation Level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarK
            // 
            this.trackBarK.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarK.Location = new System.Drawing.Point(3, 926);
            this.trackBarK.Minimum = 1;
            this.trackBarK.Name = "trackBarK";
            this.trackBarK.Size = new System.Drawing.Size(148, 56);
            this.trackBarK.TabIndex = 9;
            this.trackBarK.Value = 3;
            this.trackBarK.Scroll += new System.EventHandler(this.TrackBarK_Scroll);
            // 
            // trackBarN
            // 
            this.trackBarN.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarN.Location = new System.Drawing.Point(3, 830);
            this.trackBarN.Name = "trackBarN";
            this.trackBarN.Size = new System.Drawing.Size(148, 56);
            this.trackBarN.TabIndex = 10;
            this.trackBarN.Value = 1;
            this.trackBarN.Scroll += new System.EventHandler(this.TrackBarN_Scroll);
            // 
            // trackBarKa
            // 
            this.trackBarKa.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarKa.Location = new System.Drawing.Point(3, 738);
            this.trackBarKa.Name = "trackBarKa";
            this.trackBarKa.Size = new System.Drawing.Size(148, 56);
            this.trackBarKa.TabIndex = 11;
            this.trackBarKa.Value = 5;
            this.trackBarKa.Scroll += new System.EventHandler(this.TrackBarKa_Scroll);
            // 
            // trackBarKd
            // 
            this.trackBarKd.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarKd.Location = new System.Drawing.Point(3, 646);
            this.trackBarKd.Name = "trackBarKd";
            this.trackBarKd.Size = new System.Drawing.Size(148, 56);
            this.trackBarKd.TabIndex = 12;
            this.trackBarKd.Value = 5;
            this.trackBarKd.Scroll += new System.EventHandler(this.TrackBarKd_Scroll);
            // 
            // trackBarKs
            // 
            this.trackBarKs.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarKs.Location = new System.Drawing.Point(3, 554);
            this.trackBarKs.Name = "trackBarKs";
            this.trackBarKs.Size = new System.Drawing.Size(148, 56);
            this.trackBarKs.TabIndex = 13;
            this.trackBarKs.Value = 5;
            this.trackBarKs.Scroll += new System.EventHandler(this.TrackBarKs_Scroll);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 797);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "N";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 705);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ka";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kd";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ks";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RotateLightCheckBox
            // 
            this.RotateLightCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RotateLightCheckBox.Enabled = false;
            this.RotateLightCheckBox.Location = new System.Drawing.Point(3, 488);
            this.RotateLightCheckBox.Name = "RotateLightCheckBox";
            this.RotateLightCheckBox.Size = new System.Drawing.Size(148, 30);
            this.RotateLightCheckBox.TabIndex = 18;
            this.RotateLightCheckBox.Text = "Rotate Light";
            this.RotateLightCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RotateLightCheckBox.UseVisualStyleBackColor = true;
            this.RotateLightCheckBox.Click += new System.EventHandler(this.RotateLightCheckBox_Click);
            // 
            // buttonColorPick
            // 
            this.buttonColorPick.AutoSize = true;
            this.buttonColorPick.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonColorPick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonColorPick.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonColorPick.Location = new System.Drawing.Point(1025, 1278);
            this.buttonColorPick.Name = "buttonColorPick";
            this.buttonColorPick.Size = new System.Drawing.Size(154, 44);
            this.buttonColorPick.TabIndex = 3;
            this.buttonColorPick.Text = "Pick background color";
            this.buttonColorPick.UseVisualStyleBackColor = false;
            this.buttonColorPick.Click += new System.EventHandler(this.ButtonColorPick_Click);
            // 
            // timerCamera
            // 
            this.timerCamera.Interval = 17;
            this.timerCamera.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timerMove
            // 
            this.timerMove.Interval = 20;
            this.timerMove.Tick += new System.EventHandler(this.TimerMove1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1325);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFOV)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxCamera.ResumeLayout(false);
            this.groupBoxCamera.PerformLayout();
            this.groupBoxObject.ResumeLayout(false);
            this.groupBoxObject.PerformLayout();
            this.groupBoxShading.ResumeLayout(false);
            this.groupBoxShading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarFOV;
        private System.Windows.Forms.Timer timerCamera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxCamera;
        private System.Windows.Forms.RadioButton radioButtonCamera3;
        private System.Windows.Forms.RadioButton radioButtonCamera2;
        private System.Windows.Forms.RadioButton radioButtonCamera1;
        private System.Windows.Forms.Button buttonColorPick;
        private System.Windows.Forms.GroupBox groupBoxObject;
        private System.Windows.Forms.CheckBox checkBoxMoveZ;
        private System.Windows.Forms.CheckBox checkBoxMoveY;
        private System.Windows.Forms.CheckBox checkBoxMoveX;
        private System.Windows.Forms.GroupBox groupBoxShading;
        private System.Windows.Forms.RadioButton radioButtonPhong;
        private System.Windows.Forms.RadioButton radioButtonGouraud;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.CheckBox checkBoxRotate;
        private System.Windows.Forms.Button MovingLightColorButton;
        private System.Windows.Forms.Button StableLightColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarK;
        private System.Windows.Forms.TrackBar trackBarN;
        private System.Windows.Forms.TrackBar trackBarKa;
        private System.Windows.Forms.TrackBar trackBarKd;
        private System.Windows.Forms.TrackBar trackBarKs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox RotateLightCheckBox;
        private System.Windows.Forms.CheckBox checkBoxShowLight;
    }
}

