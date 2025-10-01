namespace BasicImageProcessing
{
    partial class MainForm
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
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addImageToolStripMenuItem = new ToolStripMenuItem();
            captureCameraPhotoToolStripMenuItem = new ToolStripMenuItem();
            saveProcessedImageToolStripMenuItem = new ToolStripMenuItem();
            clearImagePlaceholdersToolStripMenuItem = new ToolStripMenuItem();
            advancedImageProcessingToolStripMenuItem = new ToolStripMenuItem();
            imageSubtractionToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            pictureBoxOriginalImage = new PictureBox();
            labelControls = new Label();
            panel1 = new Panel();
            groupBoxContrast = new GroupBox();
            trackBarContrast = new TrackBar();
            groupBoxBrightness = new GroupBox();
            trackBarBrightness = new TrackBar();
            groupBoxBasicImageProcessing = new GroupBox();
            buttonEmbossLaplacianVer = new Button();
            buttonEmbossLaplacianHor = new Button();
            buttonEmbossLaplacianLossy = new Button();
            buttonEmbossLaplacianAllDir = new Button();
            buttonEmbossLaplacianHV = new Button();
            buttonEmbossLaplacian = new Button();
            buttonMeanRemoval = new Button();
            buttonSharpen = new Button();
            buttonGaussianBlur = new Button();
            buttonSmooth = new Button();
            buttonSepia = new Button();
            buttonHistogram = new Button();
            buttonColorInversion = new Button();
            buttonGreyscale = new Button();
            buttonCopyImage = new Button();
            pictureBoxProcessedImage = new PictureBox();
            labelImageA = new Label();
            labelImageB = new Label();
            saveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalImage).BeginInit();
            panel1.SuspendLayout();
            groupBoxContrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarContrast).BeginInit();
            groupBoxBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).BeginInit();
            groupBoxBasicImageProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcessedImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, advancedImageProcessingToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(1029, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addImageToolStripMenuItem, captureCameraPhotoToolStripMenuItem, saveProcessedImageToolStripMenuItem, clearImagePlaceholdersToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(75, 24);
            fileToolStripMenuItem.Text = "Options";
            // 
            // addImageToolStripMenuItem
            // 
            addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            addImageToolStripMenuItem.Size = new Size(260, 26);
            addImageToolStripMenuItem.Text = "Add Image";
            addImageToolStripMenuItem.Click += addImageToolStripMenuItem_Click;
            // 
            // captureCameraPhotoToolStripMenuItem
            // 
            captureCameraPhotoToolStripMenuItem.Name = "captureCameraPhotoToolStripMenuItem";
            captureCameraPhotoToolStripMenuItem.Size = new Size(260, 26);
            captureCameraPhotoToolStripMenuItem.Text = "Add Image - Use Camera";
            captureCameraPhotoToolStripMenuItem.Click += captureCameraPhotoToolStripMenuItem_Click;
            // 
            // saveProcessedImageToolStripMenuItem
            // 
            saveProcessedImageToolStripMenuItem.Name = "saveProcessedImageToolStripMenuItem";
            saveProcessedImageToolStripMenuItem.Size = new Size(260, 26);
            saveProcessedImageToolStripMenuItem.Text = "Save Processed Image";
            saveProcessedImageToolStripMenuItem.Click += saveProcessedImageToolStripMenuItem_Click;
            // 
            // clearImagePlaceholdersToolStripMenuItem
            // 
            clearImagePlaceholdersToolStripMenuItem.Name = "clearImagePlaceholdersToolStripMenuItem";
            clearImagePlaceholdersToolStripMenuItem.Size = new Size(260, 26);
            clearImagePlaceholdersToolStripMenuItem.Text = "Clear Image Placeholders";
            clearImagePlaceholdersToolStripMenuItem.Click += clearImagePlaceholdersToolStripMenuItem_Click;
            // 
            // advancedImageProcessingToolStripMenuItem
            // 
            advancedImageProcessingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageSubtractionToolStripMenuItem });
            advancedImageProcessingToolStripMenuItem.Name = "advancedImageProcessingToolStripMenuItem";
            advancedImageProcessingToolStripMenuItem.Size = new Size(209, 24);
            advancedImageProcessingToolStripMenuItem.Text = "Advanced Image Processing";
            // 
            // imageSubtractionToolStripMenuItem
            // 
            imageSubtractionToolStripMenuItem.Name = "imageSubtractionToolStripMenuItem";
            imageSubtractionToolStripMenuItem.Size = new Size(214, 26);
            imageSubtractionToolStripMenuItem.Text = "Image Subtraction";
            imageSubtractionToolStripMenuItem.Click += imageSubtractionToolStripMenuItem_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // pictureBoxOriginalImage
            // 
            pictureBoxOriginalImage.BackColor = SystemColors.ActiveCaption;
            pictureBoxOriginalImage.Location = new Point(0, 68);
            pictureBoxOriginalImage.Margin = new Padding(3, 4, 3, 4);
            pictureBoxOriginalImage.Name = "pictureBoxOriginalImage";
            pictureBoxOriginalImage.Size = new Size(469, 576);
            pictureBoxOriginalImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOriginalImage.TabIndex = 1;
            pictureBoxOriginalImage.TabStop = false;
            // 
            // labelControls
            // 
            labelControls.Location = new Point(0, 0);
            labelControls.Name = "labelControls";
            labelControls.Size = new Size(114, 31);
            labelControls.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(groupBoxContrast);
            panel1.Controls.Add(groupBoxBrightness);
            panel1.Controls.Add(groupBoxBasicImageProcessing);
            panel1.Controls.Add(labelControls);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 679);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 479);
            panel1.TabIndex = 3;
            // 
            // groupBoxContrast
            // 
            groupBoxContrast.Controls.Add(trackBarContrast);
            groupBoxContrast.Location = new Point(642, 160);
            groupBoxContrast.Margin = new Padding(3, 4, 3, 4);
            groupBoxContrast.Name = "groupBoxContrast";
            groupBoxContrast.Padding = new Padding(3, 4, 3, 4);
            groupBoxContrast.Size = new Size(343, 109);
            groupBoxContrast.TabIndex = 7;
            groupBoxContrast.TabStop = false;
            groupBoxContrast.Text = "Contrast";
            // 
            // trackBarContrast
            // 
            trackBarContrast.Location = new Point(7, 29);
            trackBarContrast.Margin = new Padding(3, 4, 3, 4);
            trackBarContrast.Maximum = 50;
            trackBarContrast.Minimum = -50;
            trackBarContrast.Name = "trackBarContrast";
            trackBarContrast.Size = new Size(329, 56);
            trackBarContrast.TabIndex = 0;
            trackBarContrast.Scroll += trackBarContrast_Scroll;
            // 
            // groupBoxBrightness
            // 
            groupBoxBrightness.Controls.Add(trackBarBrightness);
            groupBoxBrightness.Location = new Point(642, 35);
            groupBoxBrightness.Margin = new Padding(3, 4, 3, 4);
            groupBoxBrightness.Name = "groupBoxBrightness";
            groupBoxBrightness.Padding = new Padding(3, 4, 3, 4);
            groupBoxBrightness.Size = new Size(343, 99);
            groupBoxBrightness.TabIndex = 6;
            groupBoxBrightness.TabStop = false;
            groupBoxBrightness.Text = "Brightness";
            // 
            // trackBarBrightness
            // 
            trackBarBrightness.Location = new Point(7, 29);
            trackBarBrightness.Margin = new Padding(3, 4, 3, 4);
            trackBarBrightness.Maximum = 100;
            trackBarBrightness.Name = "trackBarBrightness";
            trackBarBrightness.Size = new Size(329, 56);
            trackBarBrightness.TabIndex = 5;
            trackBarBrightness.Value = 100;
            trackBarBrightness.Scroll += trackBarBrightness_Scroll;
            // 
            // groupBoxBasicImageProcessing
            // 
            groupBoxBasicImageProcessing.Controls.Add(buttonEmbossLaplacianVer);
            groupBoxBasicImageProcessing.Controls.Add(buttonEmbossLaplacianHor);
            groupBoxBasicImageProcessing.Controls.Add(buttonEmbossLaplacianLossy);
            groupBoxBasicImageProcessing.Controls.Add(buttonEmbossLaplacianAllDir);
            groupBoxBasicImageProcessing.Controls.Add(buttonEmbossLaplacianHV);
            groupBoxBasicImageProcessing.Controls.Add(buttonEmbossLaplacian);
            groupBoxBasicImageProcessing.Controls.Add(buttonMeanRemoval);
            groupBoxBasicImageProcessing.Controls.Add(buttonSharpen);
            groupBoxBasicImageProcessing.Controls.Add(buttonGaussianBlur);
            groupBoxBasicImageProcessing.Controls.Add(buttonSmooth);
            groupBoxBasicImageProcessing.Controls.Add(buttonSepia);
            groupBoxBasicImageProcessing.Controls.Add(buttonHistogram);
            groupBoxBasicImageProcessing.Controls.Add(buttonColorInversion);
            groupBoxBasicImageProcessing.Controls.Add(buttonGreyscale);
            groupBoxBasicImageProcessing.Controls.Add(buttonCopyImage);
            groupBoxBasicImageProcessing.Location = new Point(36, 35);
            groupBoxBasicImageProcessing.Margin = new Padding(3, 4, 3, 4);
            groupBoxBasicImageProcessing.Name = "groupBoxBasicImageProcessing";
            groupBoxBasicImageProcessing.Padding = new Padding(3, 4, 3, 4);
            groupBoxBasicImageProcessing.Size = new Size(507, 362);
            groupBoxBasicImageProcessing.TabIndex = 4;
            groupBoxBasicImageProcessing.TabStop = false;
            groupBoxBasicImageProcessing.Text = "Image Processing";
            groupBoxBasicImageProcessing.Enter += groupBoxBasicImageProcessing_Enter;
            // 
            // buttonEmbossLaplacianVer
            // 
            buttonEmbossLaplacianVer.Location = new Point(234, 262);
            buttonEmbossLaplacianVer.Margin = new Padding(3, 4, 3, 4);
            buttonEmbossLaplacianVer.Name = "buttonEmbossLaplacianVer";
            buttonEmbossLaplacianVer.Size = new Size(199, 31);
            buttonEmbossLaplacianVer.TabIndex = 13;
            buttonEmbossLaplacianVer.Text = "Emboss Laplacian Ver";
            buttonEmbossLaplacianVer.UseVisualStyleBackColor = true;
            buttonEmbossLaplacianVer.Click += buttonEmbossLaplacianVer_Click;
            // 
            // buttonEmbossLaplacianHor
            // 
            buttonEmbossLaplacianHor.Location = new Point(234, 223);
            buttonEmbossLaplacianHor.Margin = new Padding(3, 4, 3, 4);
            buttonEmbossLaplacianHor.Name = "buttonEmbossLaplacianHor";
            buttonEmbossLaplacianHor.Size = new Size(199, 31);
            buttonEmbossLaplacianHor.TabIndex = 12;
            buttonEmbossLaplacianHor.Text = "Emboss Laplacian Hor";
            buttonEmbossLaplacianHor.UseVisualStyleBackColor = true;
            buttonEmbossLaplacianHor.Click += buttonEmbossLaplacianHor_Click;
            // 
            // buttonEmbossLaplacianLossy
            // 
            buttonEmbossLaplacianLossy.Location = new Point(234, 184);
            buttonEmbossLaplacianLossy.Margin = new Padding(3, 4, 3, 4);
            buttonEmbossLaplacianLossy.Name = "buttonEmbossLaplacianLossy";
            buttonEmbossLaplacianLossy.Size = new Size(199, 31);
            buttonEmbossLaplacianLossy.TabIndex = 11;
            buttonEmbossLaplacianLossy.Text = "Emboss Laplacian Lossy";
            buttonEmbossLaplacianLossy.UseVisualStyleBackColor = true;
            buttonEmbossLaplacianLossy.Click += buttonEmbossLaplacianLossy_Click;
            // 
            // buttonEmbossLaplacianAllDir
            // 
            buttonEmbossLaplacianAllDir.Location = new Point(234, 146);
            buttonEmbossLaplacianAllDir.Margin = new Padding(3, 4, 3, 4);
            buttonEmbossLaplacianAllDir.Name = "buttonEmbossLaplacianAllDir";
            buttonEmbossLaplacianAllDir.Size = new Size(199, 31);
            buttonEmbossLaplacianAllDir.TabIndex = 10;
            buttonEmbossLaplacianAllDir.Text = "Emboss Laplacian All Dir";
            buttonEmbossLaplacianAllDir.UseVisualStyleBackColor = true;
            buttonEmbossLaplacianAllDir.Click += buttonEmbossLaplacianAllDir_Click;
            // 
            // buttonEmbossLaplacianHV
            // 
            buttonEmbossLaplacianHV.Location = new Point(234, 107);
            buttonEmbossLaplacianHV.Margin = new Padding(3, 4, 3, 4);
            buttonEmbossLaplacianHV.Name = "buttonEmbossLaplacianHV";
            buttonEmbossLaplacianHV.Size = new Size(199, 31);
            buttonEmbossLaplacianHV.TabIndex = 9;
            buttonEmbossLaplacianHV.Text = "Emboss Laplacian HV";
            buttonEmbossLaplacianHV.UseVisualStyleBackColor = true;
            buttonEmbossLaplacianHV.Click += buttonEmbossLaplacianHV_Click;
            // 
            // buttonEmbossLaplacian
            // 
            buttonEmbossLaplacian.Location = new Point(234, 68);
            buttonEmbossLaplacian.Margin = new Padding(3, 4, 3, 4);
            buttonEmbossLaplacian.Name = "buttonEmbossLaplacian";
            buttonEmbossLaplacian.Size = new Size(199, 31);
            buttonEmbossLaplacian.TabIndex = 8;
            buttonEmbossLaplacian.Text = "Emboss Laplacian";
            buttonEmbossLaplacian.UseVisualStyleBackColor = true;
            buttonEmbossLaplacian.Click += buttonEmbossLaplacian_Click;
            // 
            // buttonMeanRemoval
            // 
            buttonMeanRemoval.Location = new Point(234, 29);
            buttonMeanRemoval.Margin = new Padding(3, 4, 3, 4);
            buttonMeanRemoval.Name = "buttonMeanRemoval";
            buttonMeanRemoval.Size = new Size(199, 31);
            buttonMeanRemoval.TabIndex = 7;
            buttonMeanRemoval.Text = "Mean Removal";
            buttonMeanRemoval.UseVisualStyleBackColor = true;
            buttonMeanRemoval.Click += buttonMeanRemoval_Click;
            // 
            // buttonSharpen
            // 
            buttonSharpen.Location = new Point(7, 301);
            buttonSharpen.Margin = new Padding(3, 4, 3, 4);
            buttonSharpen.Name = "buttonSharpen";
            buttonSharpen.Size = new Size(199, 31);
            buttonSharpen.TabIndex = 6;
            buttonSharpen.Text = "Sharpen";
            buttonSharpen.UseVisualStyleBackColor = true;
            buttonSharpen.Click += buttonSharpen_Click;
            // 
            // buttonGaussianBlur
            // 
            buttonGaussianBlur.Location = new Point(7, 262);
            buttonGaussianBlur.Margin = new Padding(3, 4, 3, 4);
            buttonGaussianBlur.Name = "buttonGaussianBlur";
            buttonGaussianBlur.Size = new Size(199, 31);
            buttonGaussianBlur.TabIndex = 5;
            buttonGaussianBlur.Text = "Gaussian Blur";
            buttonGaussianBlur.UseVisualStyleBackColor = true;
            buttonGaussianBlur.Click += buttonGaussianBlur_Click;
            // 
            // buttonSmooth
            // 
            buttonSmooth.Location = new Point(7, 223);
            buttonSmooth.Margin = new Padding(3, 4, 3, 4);
            buttonSmooth.Name = "buttonSmooth";
            buttonSmooth.Size = new Size(199, 31);
            buttonSmooth.TabIndex = 4;
            buttonSmooth.Text = "Smooth";
            buttonSmooth.UseVisualStyleBackColor = true;
            buttonSmooth.Click += buttonSmooth_Click;
            // 
            // buttonSepia
            // 
            buttonSepia.Location = new Point(7, 184);
            buttonSepia.Margin = new Padding(3, 4, 3, 4);
            buttonSepia.Name = "buttonSepia";
            buttonSepia.Size = new Size(199, 31);
            buttonSepia.TabIndex = 3;
            buttonSepia.Text = "Sepia";
            buttonSepia.UseVisualStyleBackColor = true;
            buttonSepia.Click += buttonSepia_Click;
            // 
            // buttonHistogram
            // 
            buttonHistogram.Location = new Point(7, 145);
            buttonHistogram.Margin = new Padding(3, 4, 3, 4);
            buttonHistogram.Name = "buttonHistogram";
            buttonHistogram.Size = new Size(199, 31);
            buttonHistogram.TabIndex = 2;
            buttonHistogram.Text = "Histogram";
            buttonHistogram.UseVisualStyleBackColor = true;
            buttonHistogram.Click += buttonHistogram_Click;
            // 
            // buttonColorInversion
            // 
            buttonColorInversion.Location = new Point(7, 107);
            buttonColorInversion.Margin = new Padding(3, 4, 3, 4);
            buttonColorInversion.Name = "buttonColorInversion";
            buttonColorInversion.Size = new Size(199, 31);
            buttonColorInversion.TabIndex = 1;
            buttonColorInversion.Text = "Invert Colors";
            buttonColorInversion.UseVisualStyleBackColor = true;
            buttonColorInversion.Click += buttonColorInversion_Click;
            // 
            // buttonGreyscale
            // 
            buttonGreyscale.Location = new Point(7, 68);
            buttonGreyscale.Margin = new Padding(3, 4, 3, 4);
            buttonGreyscale.Name = "buttonGreyscale";
            buttonGreyscale.Size = new Size(199, 31);
            buttonGreyscale.TabIndex = 0;
            buttonGreyscale.Text = "Greyscale";
            buttonGreyscale.UseVisualStyleBackColor = true;
            buttonGreyscale.Click += buttonGreyscale_Click;
            // 
            // buttonCopyImage
            // 
            buttonCopyImage.Location = new Point(7, 29);
            buttonCopyImage.Margin = new Padding(3, 4, 3, 4);
            buttonCopyImage.Name = "buttonCopyImage";
            buttonCopyImage.Size = new Size(199, 31);
            buttonCopyImage.TabIndex = 0;
            buttonCopyImage.Text = "Copy Image";
            buttonCopyImage.UseVisualStyleBackColor = true;
            buttonCopyImage.Click += buttonCopyImage_Click;
            // 
            // pictureBoxProcessedImage
            // 
            pictureBoxProcessedImage.BackColor = SystemColors.ActiveBorder;
            pictureBoxProcessedImage.Location = new Point(560, 68);
            pictureBoxProcessedImage.Margin = new Padding(3, 4, 3, 4);
            pictureBoxProcessedImage.Name = "pictureBoxProcessedImage";
            pictureBoxProcessedImage.Size = new Size(469, 576);
            pictureBoxProcessedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProcessedImage.TabIndex = 4;
            pictureBoxProcessedImage.TabStop = false;
            // 
            // labelImageA
            // 
            labelImageA.AutoSize = true;
            labelImageA.Location = new Point(0, 44);
            labelImageA.Name = "labelImageA";
            labelImageA.Size = new Size(65, 20);
            labelImageA.TabIndex = 5;
            labelImageA.Text = "Image A";
            // 
            // labelImageB
            // 
            labelImageB.AutoSize = true;
            labelImageB.Location = new Point(560, 44);
            labelImageB.Name = "labelImageB";
            labelImageB.Size = new Size(64, 20);
            labelImageB.TabIndex = 6;
            labelImageB.Text = "Image B";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 1158);
            Controls.Add(labelImageB);
            Controls.Add(labelImageA);
            Controls.Add(pictureBoxProcessedImage);
            Controls.Add(panel1);
            Controls.Add(pictureBoxOriginalImage);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Basic Image Processing by Gil Florenz Sastre";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalImage).EndInit();
            panel1.ResumeLayout(false);
            groupBoxContrast.ResumeLayout(false);
            groupBoxContrast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarContrast).EndInit();
            groupBoxBrightness.ResumeLayout(false);
            groupBoxBrightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).EndInit();
            groupBoxBasicImageProcessing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcessedImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addImageToolStripMenuItem;
        private ToolStripMenuItem saveProcessedImageToolStripMenuItem;
        private ToolStripMenuItem imageProcessingToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem invertColorsToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private PictureBox pictureBoxOriginalImage;
        private Label labelControls;
        private Panel panel1;
        private GroupBox groupBoxBasicImageProcessing;
        private Button buttonCopyImage;
        private PictureBox pictureBoxProcessedImage;
        private Label labelImageA;
        private Label labelImageB;
        private Button buttonGreyscale;
        private Button buttonSepia;
        private Button buttonHistogram;
        private Button buttonColorInversion;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem clearImagePlaceholdersToolStripMenuItem;
        private GroupBox groupBoxBrightness;
        private TrackBar trackBarBrightness;
        private GroupBox groupBoxContrast;
        private TrackBar trackBarContrast;
        private ToolStripMenuItem advancedImageProcessingToolStripMenuItem;
        private ToolStripMenuItem imageSubtractionToolStripMenuItem;
        private ToolStripMenuItem captureCameraPhotoToolStripMenuItem;
        private Button buttonSmooth;
        private Button buttonGaussianBlur;
        private Button buttonEmbossLaplacianVer;
        private Button buttonEmbossLaplacianHor;
        private Button buttonEmbossLaplacianLossy;
        private Button buttonEmbossLaplacianAllDir;
        private Button buttonEmbossLaplacianHV;
        private Button buttonEmbossLaplacian;
        private Button buttonMeanRemoval;
        private Button buttonSharpen;
    }
}
