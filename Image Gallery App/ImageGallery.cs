using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using C1.Win.C1Tile;
using C1.C1Pdf;


namespace Image_Gallery_App
{
    public partial class ImageGallery : Form
    {
        //constructor
        public ImageGallery()
        {
            InitializeComponent();
        }
        //property declarations
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox _searchBox;
        private Panel panel2;
        private PictureBox _search;
       
        private C1PdfDocument imagePdfDocument;
        
        DataFetcher datafetch = new DataFetcher();
        List<ImageItem> imagesList;
        int checkedItems = 0;
        private void AddTiles(List<ImageItem> imageList)
        {
            _imgTileControl.Groups[0].Tiles.Clear();
            foreach (var imageitem in imageList)
            {
                Tile tile = new Tile();
                tile.HorizontalSize = 2;
                tile.VerticalSize = 2;
                _imgTileControl.Groups[0].Tiles.Add(tile);
                Image img = Image.FromStream(new
               MemoryStream(imageitem.Base64));
                Template tl = new Template();
                ImageElement ie = new ImageElement();
                ie.ImageLayout = ForeImageLayout.Stretch;
                tl.Elements.Add(ie);
                tile.Template = tl;
                tile.Image = img;
            }
        }

        private void OnTileChecked(object sender, TileEventArgs e)
        {
            Console.Write("CHECKED");
            checkedItems++;
            _exportImage.Visible = true;
            if (checkedItems > 0)
            {
                _exportImage.Show();
            }
        }
        private void OnTileUnchecked(object sender, TileEventArgs e)
        {
            checkedItems--;
            _exportImage.Visible = checkedItems > 0;
           
        }

        private async void OnSearchClick(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            imagesList = await
           datafetch.GetImageData(_searchBox.Text);
            AddTiles(imagesList);
            statusStrip1.Visible = false;
        }
        private void ImageGallery_Load(object sender, EventArgs e)
        {
             imagePdfDocument = new C1PdfDocument();
        }

        private PictureBox _exportImage;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private C1TileControl _imgTileControl;
        private Group group1;
        private Tile tile1;
        private Tile tile2;
        private Tile tile3;
    
        private void ConvertToPdf(List<Image> images)
        {
            try
            {
                RectangleF rect = imagePdfDocument.PageRectangle;
                bool firstPage = true;
                foreach (var selectedimg in images)
                {
                    if (!firstPage)
                    {
                        imagePdfDocument.NewPage();
                    }
                    firstPage = false;
                    rect.Inflate(-72, -72);
                    imagePdfDocument.DrawImage(selectedimg, rect);
                }
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void OnExportClick(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            foreach (Tile tile in _imgTileControl.Groups[0].Tiles)
            {
                if (tile.Checked)
                {
                    images.Add(tile.Image);
                }
            }
            ConvertToPdf(images);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "pdf";
            saveFile.Filter = "PDF files (*.pdf)|*.pdf*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                imagePdfDocument.Save(saveFile.FileName);
            }
        }
        private void OnSearchPanelPaint(object sender, PaintEventArgs e)

        {
            Rectangle r = _searchBox.Bounds;
            r.Inflate(3, 3);
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
        }

        private void OnExportImagePaint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(_exportImage.Location.X,
           _exportImage.Location.Y, _exportImage.Width, _exportImage.Height);
         r.X -= 29;
            r.Y -= 3;
            r.Width--;
            r.Height--;
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
            e.Graphics.DrawLine(p, new Point(0, 43), new
           Point(this.Width, 43));
        }

        private void OnTileControlPaint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawLine(p, 0, 43, 800, 43);
        } 
    }
}

