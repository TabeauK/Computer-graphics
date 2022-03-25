namespace GK1
{
    partial class GK1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GK1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStripV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.movePolygonToolStripMenuItemV = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePolygonToolStripMenuItemV = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVericleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripE = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.movePolygonToolStripMenuItemE = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePolygonToolStripMenuItemE = new System.Windows.Forms.ToolStripMenuItem();
            this.addVerticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRelationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.equalEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perpendicularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRelationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarE = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarV = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Save = new System.Windows.Forms.Button();
            this.LoadPolygons = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.contextMenuStripV.SuspendLayout();
            this.contextMenuStripE.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarE)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(3, 3);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(1055, 555);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.SizeChanged += new System.EventHandler(this.MainPictureBox_SizeChanged);
            this.mainPictureBox.Click += new System.EventHandler(this.MainPictureBox_Click);
            this.mainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseDown);
            this.mainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseMove);
            this.mainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseUp);
            // 
            // contextMenuStripV
            // 
            this.contextMenuStripV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movePolygonToolStripMenuItemV,
            this.deletePolygonToolStripMenuItemV,
            this.deleteVericleToolStripMenuItem});
            this.contextMenuStripV.Name = "contextMenuStrip";
            this.contextMenuStripV.Size = new System.Drawing.Size(182, 76);
            // 
            // movePolygonToolStripMenuItemV
            // 
            this.movePolygonToolStripMenuItemV.Name = "movePolygonToolStripMenuItemV";
            this.movePolygonToolStripMenuItemV.Size = new System.Drawing.Size(181, 24);
            this.movePolygonToolStripMenuItemV.Text = "Move polygon";
            this.movePolygonToolStripMenuItemV.Click += new System.EventHandler(this.MovePolygonToolStripMenuItemV_Click);
            // 
            // deletePolygonToolStripMenuItemV
            // 
            this.deletePolygonToolStripMenuItemV.Name = "deletePolygonToolStripMenuItemV";
            this.deletePolygonToolStripMenuItemV.Size = new System.Drawing.Size(181, 24);
            this.deletePolygonToolStripMenuItemV.Text = "Delete polygon";
            this.deletePolygonToolStripMenuItemV.Click += new System.EventHandler(this.DeletePolygonToolStripMenuItem_Click);
            // 
            // deleteVericleToolStripMenuItem
            // 
            this.deleteVericleToolStripMenuItem.Name = "deleteVericleToolStripMenuItem";
            this.deleteVericleToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.deleteVericleToolStripMenuItem.Text = "Delete Vertex";
            this.deleteVericleToolStripMenuItem.Click += new System.EventHandler(this.DeleteVericleToolStripMenuItem_Click);
            // 
            // contextMenuStripE
            // 
            this.contextMenuStripE.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movePolygonToolStripMenuItemE,
            this.deletePolygonToolStripMenuItemE,
            this.addVerticleToolStripMenuItem,
            this.addRelationToolStripMenuItem1,
            this.deleteRelationToolStripMenuItem});
            this.contextMenuStripE.Name = "contextMenuStrip1";
            this.contextMenuStripE.Size = new System.Drawing.Size(182, 124);
            this.contextMenuStripE.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripE_Opening);
            // 
            // movePolygonToolStripMenuItemE
            // 
            this.movePolygonToolStripMenuItemE.Name = "movePolygonToolStripMenuItemE";
            this.movePolygonToolStripMenuItemE.Size = new System.Drawing.Size(181, 24);
            this.movePolygonToolStripMenuItemE.Text = "Move polygon";
            this.movePolygonToolStripMenuItemE.Click += new System.EventHandler(this.MovePolygonToolStripMenuItemV_Click);
            // 
            // deletePolygonToolStripMenuItemE
            // 
            this.deletePolygonToolStripMenuItemE.Name = "deletePolygonToolStripMenuItemE";
            this.deletePolygonToolStripMenuItemE.Size = new System.Drawing.Size(181, 24);
            this.deletePolygonToolStripMenuItemE.Text = "Delete polygon";
            this.deletePolygonToolStripMenuItemE.Click += new System.EventHandler(this.DeletePolygonToolStripMenuItem_Click);
            // 
            // addVerticleToolStripMenuItem
            // 
            this.addVerticleToolStripMenuItem.Name = "addVerticleToolStripMenuItem";
            this.addVerticleToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.addVerticleToolStripMenuItem.Text = "Add verticle";
            this.addVerticleToolStripMenuItem.Click += new System.EventHandler(this.AddVerticleToolStripMenuItem_Click);
            // 
            // addRelationToolStripMenuItem1
            // 
            this.addRelationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equalEdgesToolStripMenuItem,
            this.perpendicularToolStripMenuItem});
            this.addRelationToolStripMenuItem1.Name = "addRelationToolStripMenuItem1";
            this.addRelationToolStripMenuItem1.Size = new System.Drawing.Size(181, 24);
            this.addRelationToolStripMenuItem1.Text = "Add relation";
            // 
            // equalEdgesToolStripMenuItem
            // 
            this.equalEdgesToolStripMenuItem.Name = "equalEdgesToolStripMenuItem";
            this.equalEdgesToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.equalEdgesToolStripMenuItem.Text = "Equal edges";
            this.equalEdgesToolStripMenuItem.Click += new System.EventHandler(this.EqualEdgesToolStripMenuItem_Click);
            // 
            // perpendicularToolStripMenuItem
            // 
            this.perpendicularToolStripMenuItem.Name = "perpendicularToolStripMenuItem";
            this.perpendicularToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.perpendicularToolStripMenuItem.Text = "Perpendicular";
            this.perpendicularToolStripMenuItem.Click += new System.EventHandler(this.PerpendicularToolStripMenuItem_Click);
            // 
            // deleteRelationToolStripMenuItem
            // 
            this.deleteRelationToolStripMenuItem.Name = "deleteRelationToolStripMenuItem";
            this.deleteRelationToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.deleteRelationToolStripMenuItem.Text = "Delete relation";
            this.deleteRelationToolStripMenuItem.Click += new System.EventHandler(this.DeleteRelationToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1061, 621);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 564);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1055, 54);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.trackBarE, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(354, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(345, 48);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size of edges: 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarE
            // 
            this.trackBarE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarE.Location = new System.Drawing.Point(175, 3);
            this.trackBarE.Name = "trackBarE";
            this.trackBarE.Size = new System.Drawing.Size(167, 42);
            this.trackBarE.TabIndex = 2;
            this.trackBarE.Value = 1;
            this.trackBarE.Scroll += new System.EventHandler(this.TrackBarE_Scroll);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.trackBarV, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(345, 48);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // trackBarV
            // 
            this.trackBarV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarV.Location = new System.Drawing.Point(175, 3);
            this.trackBarV.Name = "trackBarV";
            this.trackBarV.Size = new System.Drawing.Size(167, 42);
            this.trackBarV.TabIndex = 3;
            this.trackBarV.Value = 1;
            this.trackBarV.Scroll += new System.EventHandler(this.TrackBarV_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size of verticles: 4";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.Save, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.LoadPolygons, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(705, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(347, 48);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save.Location = new System.Drawing.Point(3, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(167, 42);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.LoadPolygons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadPolygons.Location = new System.Drawing.Point(176, 3);
            this.LoadPolygons.Name = "Load";
            this.LoadPolygons.Size = new System.Drawing.Size(168, 42);
            this.LoadPolygons.TabIndex = 1;
            this.LoadPolygons.Text = "Load";
            this.LoadPolygons.UseVisualStyleBackColor = true;
            this.LoadPolygons.Click += new System.EventHandler(this.Load_Click);
            // 
            // GK1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 621);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GK1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polygons creator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.contextMenuStripV.ResumeLayout(false);
            this.contextMenuStripE.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarE)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripV;
        private System.Windows.Forms.ToolStripMenuItem movePolygonToolStripMenuItemV;
        private System.Windows.Forms.ToolStripMenuItem deletePolygonToolStripMenuItemV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripE;
        private System.Windows.Forms.ToolStripMenuItem deleteVericleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movePolygonToolStripMenuItemE;
        private System.Windows.Forms.ToolStripMenuItem deletePolygonToolStripMenuItemE;
        private System.Windows.Forms.ToolStripMenuItem addVerticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRelationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem equalEdgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perpendicularToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarV;
        private System.Windows.Forms.ToolStripMenuItem deleteRelationToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button LoadPolygons;
    }
}

