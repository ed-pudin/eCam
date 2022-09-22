namespace ProcesamientoP
{
    partial class FormImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.histogram3 = new AForge.Controls.Histogram();
            this.histogram2 = new AForge.Controls.Histogram();
            this.histogram1 = new AForge.Controls.Histogram();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.pbImageTaken = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTakeP = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTaken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.histogram3);
            this.panel2.Controls.Add(this.histogram2);
            this.panel2.Controls.Add(this.histogram1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbFilters);
            this.panel2.Controls.Add(this.cbCamera);
            this.panel2.Controls.Add(this.pbImageTaken);
            this.panel2.Controls.Add(this.pbImage);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 613);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // histogram3
            // 
            this.histogram3.BackColor = System.Drawing.Color.White;
            this.histogram3.Color = System.Drawing.Color.Green;
            this.histogram3.Location = new System.Drawing.Point(704, 339);
            this.histogram3.Name = "histogram3";
            this.histogram3.Size = new System.Drawing.Size(203, 129);
            this.histogram3.TabIndex = 9;
            this.histogram3.Text = "histogram3";
            this.histogram3.Values = null;
            // 
            // histogram2
            // 
            this.histogram2.BackColor = System.Drawing.Color.White;
            this.histogram2.Color = System.Drawing.Color.Blue;
            this.histogram2.Location = new System.Drawing.Point(472, 339);
            this.histogram2.Name = "histogram2";
            this.histogram2.Size = new System.Drawing.Size(203, 129);
            this.histogram2.TabIndex = 8;
            this.histogram2.Text = "histogram2";
            this.histogram2.Values = null;
            // 
            // histogram1
            // 
            this.histogram1.BackColor = System.Drawing.Color.White;
            this.histogram1.Color = System.Drawing.Color.Red;
            this.histogram1.Location = new System.Drawing.Point(239, 339);
            this.histogram1.Name = "histogram1";
            this.histogram1.Size = new System.Drawing.Size(203, 129);
            this.histogram1.TabIndex = 7;
            this.histogram1.Text = "histogram1";
            this.histogram1.Values = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Histograma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(489, 20);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(418, 23);
            this.cbFilters.TabIndex = 4;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // cbCamera
            // 
            this.cbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(37, 20);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(418, 23);
            this.cbCamera.TabIndex = 3;
            // 
            // pbImageTaken
            // 
            this.pbImageTaken.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImageTaken.BackgroundImage")));
            this.pbImageTaken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImageTaken.Location = new System.Drawing.Point(489, 63);
            this.pbImageTaken.Name = "pbImageTaken";
            this.pbImageTaken.Size = new System.Drawing.Size(418, 246);
            this.pbImageTaken.TabIndex = 2;
            this.pbImageTaken.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImage.BackgroundImage")));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(37, 63);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(418, 246);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.panel3.Controls.Add(this.btnTakeP);
            this.panel3.Controls.Add(this.btnPowerOff);
            this.panel3.Controls.Add(this.btnAddImg);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnPowerOn);
            this.panel3.Location = new System.Drawing.Point(-2, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 103);
            this.panel3.TabIndex = 0;
            // 
            // btnTakeP
            // 
            this.btnTakeP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTakeP.BackgroundImage")));
            this.btnTakeP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakeP.FlatAppearance.BorderSize = 0;
            this.btnTakeP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.btnTakeP.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTakeP.Location = new System.Drawing.Point(321, 26);
            this.btnTakeP.Name = "btnTakeP";
            this.btnTakeP.Size = new System.Drawing.Size(50, 50);
            this.btnTakeP.TabIndex = 7;
            this.btnTakeP.UseVisualStyleBackColor = true;
            this.btnTakeP.Click += new System.EventHandler(this.btnTakeP_Click);
            this.btnTakeP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTakeP_MouseDown);
            this.btnTakeP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTakeP_MouseUp);
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPowerOff.BackgroundImage")));
            this.btnPowerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPowerOff.FlatAppearance.BorderSize = 0;
            this.btnPowerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.btnPowerOff.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPowerOff.Location = new System.Drawing.Point(547, 26);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(50, 50);
            this.btnPowerOff.TabIndex = 3;
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Visible = false;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnAddImg
            // 
            this.btnAddImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddImg.BackgroundImage")));
            this.btnAddImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddImg.FlatAppearance.BorderSize = 0;
            this.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.btnAddImg.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddImg.Location = new System.Drawing.Point(110, 26);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(50, 50);
            this.btnAddImg.TabIndex = 6;
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            this.btnAddImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAddImg_MouseDown);
            this.btnAddImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAddImg_MouseUp);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.Location = new System.Drawing.Point(756, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseDown);
            this.btnSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseUp);
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPowerOn.BackgroundImage")));
            this.btnPowerOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPowerOn.FlatAppearance.BorderSize = 0;
            this.btnPowerOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.btnPowerOn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPowerOn.Location = new System.Drawing.Point(547, 26);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(50, 50);
            this.btnPowerOn.TabIndex = 4;
            this.btnPowerOn.UseVisualStyleBackColor = true;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // FormImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 613);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImage";
            this.Text = "FormImage";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTaken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Button btnPowerOn;
        private Button btnPowerOff;
        private Button btnTakeP;
        private Button btnAddImg;
        private Button btnSave;
        private ComboBox cbFilters;
        private ComboBox cbCamera;
        private PictureBox pbImageTaken;
        private PictureBox pbImage;
        private Label label1;
        private AForge.Controls.Histogram histogram3;
        private AForge.Controls.Histogram histogram2;
        private AForge.Controls.Histogram histogram1;
    }
}