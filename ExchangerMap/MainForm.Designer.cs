namespace ExchangerMap
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gMapControl2 = new GMap.NET.WindowsForms.GMapControl();
            this.tbBestBank = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBestRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RurBuyBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EurBuyBtn = new System.Windows.Forms.Button();
            this.UsdSaleBtn = new System.Windows.Forms.Button();
            this.UsdBuyBtn = new System.Windows.Forms.Button();
            this.RurSaleBtn = new System.Windows.Forms.Button();
            this.EurSaleBtn = new System.Windows.Forms.Button();
            this.btnRouteBank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StartPoint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.tbStartLong = new System.Windows.Forms.TextBox();
            this.tbStartLat = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gMapControl2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbBestBank);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.btnRouteBank);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.StartPoint);
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.btnShowAll);
            this.splitContainer1.Panel2.Controls.Add(this.tbStartLong);
            this.splitContainer1.Panel2.Controls.Add(this.tbStartLat);
            this.splitContainer1.Size = new System.Drawing.Size(1069, 581);
            this.splitContainer1.SplitterDistance = 784;
            this.splitContainer1.TabIndex = 0;
            // 
            // gMapControl2
            // 
            this.gMapControl2.Bearing = 0F;
            this.gMapControl2.CanDragMap = true;
            this.gMapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl2.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl2.GrayScaleMode = false;
            this.gMapControl2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl2.LevelsKeepInMemmory = 5;
            this.gMapControl2.Location = new System.Drawing.Point(0, 24);
            this.gMapControl2.MarkersEnabled = true;
            this.gMapControl2.MaxZoom = 18;
            this.gMapControl2.MinZoom = 2;
            this.gMapControl2.MouseWheelZoomEnabled = true;
            this.gMapControl2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl2.Name = "gMapControl2";
            this.gMapControl2.NegativeMode = false;
            this.gMapControl2.PolygonsEnabled = true;
            this.gMapControl2.RetryLoadTile = 0;
            this.gMapControl2.RoutesEnabled = true;
            this.gMapControl2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl2.ShowTileGridLines = false;
            this.gMapControl2.Size = new System.Drawing.Size(784, 557);
            this.gMapControl2.TabIndex = 0;
            this.gMapControl2.Zoom = 17D;
            // 
            // tbBestBank
            // 
            this.tbBestBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBestBank.Location = new System.Drawing.Point(31, 501);
            this.tbBestBank.Multiline = true;
            this.tbBestBank.Name = "tbBestBank";
            this.tbBestBank.Size = new System.Drawing.Size(223, 68);
            this.tbBestBank.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBestRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RurBuyBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EurBuyBtn);
            this.groupBox1.Controls.Add(this.UsdSaleBtn);
            this.groupBox1.Controls.Add(this.UsdBuyBtn);
            this.groupBox1.Controls.Add(this.RurSaleBtn);
            this.groupBox1.Controls.Add(this.EurSaleBtn);
            this.groupBox1.Location = new System.Drawing.Point(4, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 271);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // tbBestRate
            // 
            this.tbBestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBestRate.Location = new System.Drawing.Point(27, 230);
            this.tbBestRate.Multiline = true;
            this.tbBestRate.Name = "tbBestRate";
            this.tbBestRate.Size = new System.Drawing.Size(223, 28);
            this.tbBestRate.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(164, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Купить";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(86, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Лучший курс";
            // 
            // RurBuyBtn
            // 
            this.RurBuyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RurBuyBtn.Location = new System.Drawing.Point(142, 146);
            this.RurBuyBtn.Name = "RurBuyBtn";
            this.RurBuyBtn.Size = new System.Drawing.Size(117, 30);
            this.RurBuyBtn.TabIndex = 15;
            this.RurBuyBtn.Text = "RUR";
            this.RurBuyBtn.UseVisualStyleBackColor = true;
            this.RurBuyBtn.Click += new System.EventHandler(this.RurBuyBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Продать";
            // 
            // EurBuyBtn
            // 
            this.EurBuyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurBuyBtn.Location = new System.Drawing.Point(142, 93);
            this.EurBuyBtn.Name = "EurBuyBtn";
            this.EurBuyBtn.Size = new System.Drawing.Size(117, 30);
            this.EurBuyBtn.TabIndex = 13;
            this.EurBuyBtn.Text = "EUR";
            this.EurBuyBtn.UseVisualStyleBackColor = true;
            this.EurBuyBtn.Click += new System.EventHandler(this.EurBuyBtn_Click);
            // 
            // UsdSaleBtn
            // 
            this.UsdSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdSaleBtn.Location = new System.Drawing.Point(6, 44);
            this.UsdSaleBtn.Name = "UsdSaleBtn";
            this.UsdSaleBtn.Size = new System.Drawing.Size(117, 30);
            this.UsdSaleBtn.TabIndex = 10;
            this.UsdSaleBtn.Text = "USD";
            this.UsdSaleBtn.UseVisualStyleBackColor = true;
            this.UsdSaleBtn.Click += new System.EventHandler(this.UsdSaleBtn_Click);
            // 
            // UsdBuyBtn
            // 
            this.UsdBuyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdBuyBtn.Location = new System.Drawing.Point(142, 44);
            this.UsdBuyBtn.Name = "UsdBuyBtn";
            this.UsdBuyBtn.Size = new System.Drawing.Size(117, 30);
            this.UsdBuyBtn.TabIndex = 11;
            this.UsdBuyBtn.Text = "USD";
            this.UsdBuyBtn.UseVisualStyleBackColor = true;
            this.UsdBuyBtn.Click += new System.EventHandler(this.UsdBuyBtn_Click);
            // 
            // RurSaleBtn
            // 
            this.RurSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RurSaleBtn.Location = new System.Drawing.Point(6, 146);
            this.RurSaleBtn.Name = "RurSaleBtn";
            this.RurSaleBtn.Size = new System.Drawing.Size(117, 30);
            this.RurSaleBtn.TabIndex = 14;
            this.RurSaleBtn.Text = "RUR";
            this.RurSaleBtn.UseVisualStyleBackColor = true;
            this.RurSaleBtn.Click += new System.EventHandler(this.RurSaleBtn_Click);
            // 
            // EurSaleBtn
            // 
            this.EurSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurSaleBtn.Location = new System.Drawing.Point(6, 93);
            this.EurSaleBtn.Name = "EurSaleBtn";
            this.EurSaleBtn.Size = new System.Drawing.Size(117, 30);
            this.EurSaleBtn.TabIndex = 12;
            this.EurSaleBtn.Text = "EUR";
            this.EurSaleBtn.UseVisualStyleBackColor = true;
            this.EurSaleBtn.Click += new System.EventHandler(this.EurSaleBtn_Click);
            // 
            // btnRouteBank
            // 
            this.btnRouteBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRouteBank.Location = new System.Drawing.Point(53, 465);
            this.btnRouteBank.Name = "btnRouteBank";
            this.btnRouteBank.Size = new System.Drawing.Size(177, 30);
            this.btnRouteBank.TabIndex = 18;
            this.btnRouteBank.Text = "Ближайший";
            this.btnRouteBank.UseVisualStyleBackColor = true;
            this.btnRouteBank.Click += new System.EventHandler(this.btnRouteBank_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Координаты";
            // 
            // StartPoint
            // 
            this.StartPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartPoint.Location = new System.Drawing.Point(13, 347);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(256, 57);
            this.StartPoint.TabIndex = 6;
            this.StartPoint.Text = "Установить мое местоположение";
            this.StartPoint.UseVisualStyleBackColor = true;
            this.StartPoint.Click += new System.EventHandler(this.StartPoint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(152, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 52);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить карту";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAll.Location = new System.Drawing.Point(13, 12);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(117, 52);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Все отделения";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // tbStartLong
            // 
            this.tbStartLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStartLong.Location = new System.Drawing.Point(152, 433);
            this.tbStartLong.Name = "tbStartLong";
            this.tbStartLong.Size = new System.Drawing.Size(117, 26);
            this.tbStartLong.TabIndex = 2;
            // 
            // tbStartLat
            // 
            this.tbStartLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStartLat.Location = new System.Drawing.Point(13, 433);
            this.tbStartLat.Name = "tbStartLat";
            this.tbStartLat.Size = new System.Drawing.Size(117, 26);
            this.tbStartLat.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About Us";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 581);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankExchanger";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbStartLong;
        private GMap.NET.WindowsForms.GMapControl gMapControl2;
        private System.Windows.Forms.Button StartPoint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStartLat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RurBuyBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EurBuyBtn;
        private System.Windows.Forms.Button UsdSaleBtn;
        private System.Windows.Forms.Button UsdBuyBtn;
        private System.Windows.Forms.Button RurSaleBtn;
        private System.Windows.Forms.Button EurSaleBtn;
        private System.Windows.Forms.TextBox tbBestRate;
        private System.Windows.Forms.Button btnRouteBank;
        private System.Windows.Forms.TextBox tbBestBank;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

