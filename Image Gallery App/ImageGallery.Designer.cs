
namespace Image_Gallery_App
{
    partial class ImageGallery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageGallery));
            C1.Win.C1Tile.PanelElement panelElement3 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement3 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement3 = new C1.Win.C1Tile.TextElement();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._searchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._search = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this._imgTileControl = new C1.Win.C1Tile.C1TileControl();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tile1 = new C1.Win.C1Tile.Tile();
            this.tile2 = new C1.Win.C1Tile.Tile();
            this.tile3 = new C1.Win.C1Tile.Tile();
            this.tile4 = new C1.Win.C1Tile.Tile();
            this.tile5 = new C1.Win.C1Tile.Tile();
            this.tile6 = new C1.Win.C1Tile.Tile();
            this.tile7 = new C1.Win.C1Tile.Tile();
            this._exportImage = new System.Windows.Forms.PictureBox();
            this.c1PdfDocument1 = new C1.C1Pdf.C1PdfDocument();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._search)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this._imgTileControl);
            this.splitContainer1.Panel2.Controls.Add(this._exportImage);
            this.splitContainer1.Size = new System.Drawing.Size(572, 612);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(145, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 36);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // _searchBox
            // 
            this._searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._searchBox.BackColor = System.Drawing.Color.White;
            this._searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._searchBox.Location = new System.Drawing.Point(8, 8);
            this._searchBox.Margin = new System.Windows.Forms.Padding(2);
            this._searchBox.Name = "_searchBox";
            this._searchBox.Size = new System.Drawing.Size(200, 20);
            this._searchBox.TabIndex = 0;
            this._searchBox.Text = "Search Image";
            this._searchBox.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._search);
            this.panel2.Location = new System.Drawing.Point(359, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 10, 34, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 13);
            this.panel2.TabIndex = 1;
            this.panel2.UseWaitCursor = true;
            // 
            // _search
            // 
            this._search.Dock = System.Windows.Forms.DockStyle.Fill;
            this._search.Image = ((System.Drawing.Image)(resources.GetObject("_search.Image")));
            this._search.Location = new System.Drawing.Point(0, 0);
            this._search.Margin = new System.Windows.Forms.Padding(0);
            this._search.MinimumSize = new System.Drawing.Size(30, 13);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(30, 13);
            this._search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._search.TabIndex = 0;
            this._search.TabStop = false;
            this._search.UseWaitCursor = true;
            this._search.Click += new System.EventHandler(this.OnSearchClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(572, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.UseWaitCursor = true;
            this.statusStrip1.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(75, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // _imgTileControl
            // 
            this._imgTileControl.AllowChecking = true;
            this._imgTileControl.AllowRearranging = true;
            this._imgTileControl.CellHeight = 61;
            this._imgTileControl.CellSpacing = 9;
            this._imgTileControl.CellWidth = 61;
            // 
            // 
            // 
            panelElement3.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            panelElement3.Children.Add(imageElement3);
            panelElement3.Children.Add(textElement3);
            panelElement3.ChildSpacing = 4;
            panelElement3.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this._imgTileControl.DefaultTemplate.Elements.Add(panelElement3);
            this._imgTileControl.GroupPadding = new System.Windows.Forms.Padding(16, 31, 16, 16);
            this._imgTileControl.Groups.Add(this.group1);
            this._imgTileControl.GroupTextX = 16;
            this._imgTileControl.GroupTextY = 4;
            this._imgTileControl.Location = new System.Drawing.Point(22, 61);
            this._imgTileControl.Margin = new System.Windows.Forms.Padding(2);
            this._imgTileControl.Name = "_imgTileControl";
            this._imgTileControl.Padding = new System.Windows.Forms.Padding(0, 47, 0, 0);
            this._imgTileControl.Size = new System.Drawing.Size(462, 244);
            this._imgTileControl.SurfacePadding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this._imgTileControl.SwipeDistance = 16;
            this._imgTileControl.SwipeRearrangeDistance = 77;
            this._imgTileControl.TabIndex = 1;
            this._imgTileControl.TextX = 27;
            this._imgTileControl.TextY = 12;
            this._imgTileControl.TileChecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this.OnTileChecked);
            this._imgTileControl.TileUnchecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this.OnTileUnchecked);
            this._imgTileControl.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTileControlPaint);
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            this.group1.Tiles.Add(this.tile4);
            this.group1.Tiles.Add(this.tile5);
            this.group1.Tiles.Add(this.tile6);
            this.group1.Tiles.Add(this.tile7);
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.Transparent;
            this.tile1.Name = "tile1";
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.Transparent;
            this.tile2.Name = "tile2";
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.Transparent;
            this.tile3.Name = "tile3";
            // 
            // tile4
            // 
            this.tile4.BackColor = System.Drawing.Color.Transparent;
            this.tile4.Name = "tile4";
            // 
            // tile5
            // 
            this.tile5.BackColor = System.Drawing.Color.Transparent;
            this.tile5.Name = "tile5";
            // 
            // tile6
            // 
            this.tile6.BackColor = System.Drawing.Color.Transparent;
            this.tile6.Name = "tile6";
            // 
            // tile7
            // 
            this.tile7.BackColor = System.Drawing.Color.Transparent;
            this.tile7.Name = "tile7";
            // 
            // _exportImage
            // 
            this._exportImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._exportImage.Image = ((System.Drawing.Image)(resources.GetObject("_exportImage.Image")));
            this._exportImage.Location = new System.Drawing.Point(22, 2);
            this._exportImage.Margin = new System.Windows.Forms.Padding(2);
            this._exportImage.Name = "_exportImage";
            this._exportImage.Size = new System.Drawing.Size(68, 44);
            this._exportImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._exportImage.TabIndex = 0;
            this._exportImage.TabStop = false;
            this._exportImage.UseWaitCursor = true;
            this._exportImage.Visible = false;
            this._exportImage.Click += new System.EventHandler(this.OnExportClick);
            this._exportImage.Paint += new System.Windows.Forms.PaintEventHandler(this.OnExportImagePaint);
            // 
            // c1PdfDocument1
            // 
            this.c1PdfDocument1.DocumentInfo.Author = "";
            this.c1PdfDocument1.DocumentInfo.CreationDate = new System.DateTime(((long)(0)));
            this.c1PdfDocument1.DocumentInfo.Creator = "";
            this.c1PdfDocument1.DocumentInfo.Keywords = "";
            this.c1PdfDocument1.DocumentInfo.Producer = "ComponentOne C1Pdf";
            this.c1PdfDocument1.DocumentInfo.Subject = "";
            this.c1PdfDocument1.DocumentInfo.Title = "";
            this.c1PdfDocument1.MaxHeaderBookmarkLevel = 0;
            this.c1PdfDocument1.PdfVersion = "1.3";
            this.c1PdfDocument1.RefDC = null;
            this.c1PdfDocument1.RotateAngle = 0F;
            this.c1PdfDocument1.UseFastTextOut = true;
            this.c1PdfDocument1.UseFontShaping = true;
            // 
            // ImageGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 612);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(612, 665);
            this.Name = "ImageGallery";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Gallery";
            this.Load += new System.EventHandler(this.ImageGallery_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._search)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).EndInit();
            this.ResumeLayout(false);

            }

        private C1.C1Pdf.C1PdfDocument c1PdfDocument1;
        private C1.Win.C1Tile.Tile tile4;
        private C1.Win.C1Tile.Tile tile5;
        private C1.Win.C1Tile.Tile tile6;
        private C1.Win.C1Tile.Tile tile7;
    }

        #endregion
    }

