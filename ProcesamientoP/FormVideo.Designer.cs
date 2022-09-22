namespace ProcesamientoP
{
    partial class FormVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideo));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPlayVid = new System.Windows.Forms.Button();
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnAddVid = new System.Windows.Forms.Button();
            this.btnStopVid = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.panel3.Controls.Add(this.btnPlayVid);
            this.panel3.Controls.Add(this.btnPowerOn);
            this.panel3.Controls.Add(this.btnPowerOff);
            this.panel3.Controls.Add(this.btnAddVid);
            this.panel3.Controls.Add(this.btnStopVid);
            this.panel3.Location = new System.Drawing.Point(-2, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 103);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnPlayVid
            // 
            this.btnPlayVid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayVid.BackgroundImage")));
            this.btnPlayVid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayVid.FlatAppearance.BorderSize = 0;
            this.btnPlayVid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayVid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.btnPlayVid.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPlayVid.Location = new System.Drawing.Point(558, 27);
            this.btnPlayVid.Name = "btnPlayVid";
            this.btnPlayVid.Size = new System.Drawing.Size(50, 50);
            this.btnPlayVid.TabIndex = 5;
            this.btnPlayVid.UseVisualStyleBackColor = true;
            this.btnPlayVid.Click += new System.EventHandler(this.btnPlayVid_Click);
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPowerOn.BackgroundImage")));
            this.btnPowerOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPowerOn.FlatAppearance.BorderSize = 0;
            this.btnPowerOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.btnPowerOn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPowerOn.Location = new System.Drawing.Point(695, 27);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(50, 50);
            this.btnPowerOn.TabIndex = 4;
            this.btnPowerOn.UseVisualStyleBackColor = true;
            this.btnPowerOn.Visible = false;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPowerOff.BackgroundImage")));
            this.btnPowerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPowerOff.FlatAppearance.BorderSize = 0;
            this.btnPowerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.btnPowerOff.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPowerOff.Location = new System.Drawing.Point(695, 26);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(50, 50);
            this.btnPowerOff.TabIndex = 3;
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Visible = false;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnAddVid
            // 
            this.btnAddVid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddVid.BackgroundImage")));
            this.btnAddVid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddVid.FlatAppearance.BorderSize = 0;
            this.btnAddVid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.btnAddVid.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddVid.Location = new System.Drawing.Point(327, 25);
            this.btnAddVid.Name = "btnAddVid";
            this.btnAddVid.Size = new System.Drawing.Size(50, 50);
            this.btnAddVid.TabIndex = 2;
            this.btnAddVid.UseVisualStyleBackColor = true;
            this.btnAddVid.Click += new System.EventHandler(this.btnAddVid_Click);
            this.btnAddVid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAddVid_MouseDown);
            this.btnAddVid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAddVid_MouseUp);
            // 
            // btnStopVid
            // 
            this.btnStopVid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopVid.BackgroundImage")));
            this.btnStopVid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStopVid.FlatAppearance.BorderSize = 0;
            this.btnStopVid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopVid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.btnStopVid.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStopVid.Location = new System.Drawing.Point(558, 25);
            this.btnStopVid.Name = "btnStopVid";
            this.btnStopVid.Size = new System.Drawing.Size(50, 50);
            this.btnStopVid.TabIndex = 1;
            this.btnStopVid.UseVisualStyleBackColor = true;
            this.btnStopVid.Click += new System.EventHandler(this.btnStopVid_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.pbVideo);
            this.panel2.Controls.Add(this.cbFilters);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 614);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pbVideo
            // 
            this.pbVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbVideo.BackgroundImage")));
            this.pbVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbVideo.InitialImage = null;
            this.pbVideo.Location = new System.Drawing.Point(150, 67);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(640, 360);
            this.pbVideo.TabIndex = 5;
            this.pbVideo.TabStop = false;
            this.pbVideo.Click += new System.EventHandler(this.pbVideo_Click);
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(184, 24);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(559, 23);
            this.cbFilters.TabIndex = 4;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbCamera_SelectedIndexChanged);
            // 
            // FormVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 613);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVideo";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel3;
        private Panel panel2;
        private Button btnPowerOn;
        private Button btnPowerOff;
        private Button btnAddVid;
        private Button btnStopVid;
        private Button btnPlayVid;
        private ComboBox cbFilters;
        private PictureBox pbVideo;
    }
}