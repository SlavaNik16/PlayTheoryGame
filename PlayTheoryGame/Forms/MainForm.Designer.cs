namespace PlayTheoryGame
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butName = new MaterialSkin.Controls.MaterialButton();
            this.nameTwoBox = new MaterialSkin.Controls.MaterialTextBox();
            this.nameOneBox = new MaterialSkin.Controls.MaterialTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.butClear = new MaterialSkin.Controls.MaterialButton();
            this.listBox = new MaterialSkin.Controls.MaterialListBox();
            this.butPriceAddList = new MaterialSkin.Controls.MaterialButton();
            this.priceBox = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPlayer2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPlayer1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Game.png");
            this.imageList1.Images.SetKeyName(1, "Settings.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialTabControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(110, 70);
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1914, 1013);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.ImageKey = "Game.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 74);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1906, 935);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Игра";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.318539F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.51633F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.1117F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.483377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.02583F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.49839F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1900, 929);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.butName);
            this.panel1.Controls.Add(this.nameTwoBox);
            this.panel1.Controls.Add(this.nameOneBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(66, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 316);
            this.panel1.TabIndex = 3;
            // 
            // butName
            // 
            this.butName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.butName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butName.Depth = 0;
            this.butName.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butName.HighEmphasis = true;
            this.butName.Icon = null;
            this.butName.Location = new System.Drawing.Point(15, 251);
            this.butName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butName.MouseState = MaterialSkin.MouseState.HOVER;
            this.butName.Name = "butName";
            this.butName.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butName.Size = new System.Drawing.Size(185, 36);
            this.butName.TabIndex = 2;
            this.butName.Text = "Подтвердить имена";
            this.butName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butName.UseAccentColor = false;
            this.butName.UseVisualStyleBackColor = false;
            this.butName.Click += new System.EventHandler(this.butName_Click);
            // 
            // nameTwoBox
            // 
            this.nameTwoBox.AnimateReadOnly = false;
            this.nameTwoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nameTwoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTwoBox.Depth = 0;
            this.nameTwoBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTwoBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameTwoBox.HideSelection = false;
            this.nameTwoBox.Hint = "Игрок 2";
            this.nameTwoBox.LeadingIcon = null;
            this.nameTwoBox.Location = new System.Drawing.Point(15, 130);
            this.nameTwoBox.MaxLength = 50;
            this.nameTwoBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nameTwoBox.Multiline = false;
            this.nameTwoBox.Name = "nameTwoBox";
            this.nameTwoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.nameTwoBox.Size = new System.Drawing.Size(371, 50);
            this.nameTwoBox.TabIndex = 1;
            this.nameTwoBox.Text = "";
            this.nameTwoBox.TrailingIcon = null;
            // 
            // nameOneBox
            // 
            this.nameOneBox.AnimateReadOnly = false;
            this.nameOneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nameOneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOneBox.Depth = 0;
            this.nameOneBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameOneBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameOneBox.HideSelection = false;
            this.nameOneBox.Hint = "Игрок 1";
            this.nameOneBox.LeadingIcon = null;
            this.nameOneBox.Location = new System.Drawing.Point(15, 14);
            this.nameOneBox.MaxLength = 50;
            this.nameOneBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nameOneBox.Multiline = false;
            this.nameOneBox.Name = "nameOneBox";
            this.nameOneBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.nameOneBox.Size = new System.Drawing.Size(371, 50);
            this.nameOneBox.TabIndex = 0;
            this.nameOneBox.Text = "";
            this.nameOneBox.TrailingIcon = null;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel4.Controls.Add(this.butClear);
            this.panel4.Controls.Add(this.listBox);
            this.panel4.Controls.Add(this.butPriceAddList);
            this.panel4.Controls.Add(this.priceBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(66, 434);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 464);
            this.panel4.TabIndex = 4;
            // 
            // butClear
            // 
            this.butClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.butClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butClear.Depth = 0;
            this.butClear.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butClear.HighEmphasis = true;
            this.butClear.Icon = null;
            this.butClear.Location = new System.Drawing.Point(29, 0);
            this.butClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.butClear.Name = "butClear";
            this.butClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butClear.Size = new System.Drawing.Size(99, 36);
            this.butClear.TabIndex = 4;
            this.butClear.Text = "Очистить";
            this.butClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butClear.UseAccentColor = false;
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.listBox.BorderColor = System.Drawing.Color.LightGray;
            this.listBox.Depth = 0;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBox.Location = new System.Drawing.Point(29, 68);
            this.listBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBox.Name = "listBox";
            this.listBox.SelectedIndex = -1;
            this.listBox.SelectedItem = null;
            this.listBox.Size = new System.Drawing.Size(357, 153);
            this.listBox.TabIndex = 3;
            // 
            // butPriceAddList
            // 
            this.butPriceAddList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butPriceAddList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.butPriceAddList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butPriceAddList.Depth = 0;
            this.butPriceAddList.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPriceAddList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butPriceAddList.HighEmphasis = true;
            this.butPriceAddList.Icon = null;
            this.butPriceAddList.Location = new System.Drawing.Point(29, 322);
            this.butPriceAddList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butPriceAddList.MouseState = MaterialSkin.MouseState.HOVER;
            this.butPriceAddList.Name = "butPriceAddList";
            this.butPriceAddList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butPriceAddList.Size = new System.Drawing.Size(217, 36);
            this.butPriceAddList.TabIndex = 2;
            this.butPriceAddList.Text = "Добавить цену на товар";
            this.butPriceAddList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butPriceAddList.UseAccentColor = false;
            this.butPriceAddList.UseVisualStyleBackColor = false;
            this.butPriceAddList.Click += new System.EventHandler(this.butPriceAddList_Click);
            // 
            // priceBox
            // 
            this.priceBox.AnimateReadOnly = false;
            this.priceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceBox.Depth = 0;
            this.priceBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.priceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.priceBox.HideSelection = false;
            this.priceBox.Hint = "Цена";
            this.priceBox.LeadingIcon = null;
            this.priceBox.Location = new System.Drawing.Point(29, 227);
            this.priceBox.MaxLength = 50;
            this.priceBox.MouseState = MaterialSkin.MouseState.OUT;
            this.priceBox.Multiline = false;
            this.priceBox.Name = "priceBox";
            this.priceBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.priceBox.Size = new System.Drawing.Size(357, 50);
            this.priceBox.TabIndex = 0;
            this.priceBox.Text = "";
            this.priceBox.TrailingIcon = null;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.95721F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.04279F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(836, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.77273F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.22727F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(631, 402);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.labelPlayer2);
            this.panel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(110, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 53);
            this.panel2.TabIndex = 0;
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.labelPlayer2.Depth = 0;
            this.labelPlayer2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelPlayer2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPlayer2.Location = new System.Drawing.Point(153, 21);
            this.labelPlayer2.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(135, 24);
            this.labelPlayer2.TabIndex = 0;
            this.labelPlayer2.Text = "materialLabel1";
            this.labelPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.labelPlayer1);
            this.panel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(3, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 337);
            this.panel3.TabIndex = 1;
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.labelPlayer1.Depth = 0;
            this.labelPlayer1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPlayer1.Location = new System.Drawing.Point(3, 146);
            this.labelPlayer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(107, 19);
            this.labelPlayer1.TabIndex = 5;
            this.labelPlayer1.Text = "materialLabel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.Location = new System.Drawing.Point(110, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(518, 337);
            this.dataGridView1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage2.ImageKey = "Settings.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 74);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1906, 935);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1100, 820);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton butName;
        private MaterialSkin.Controls.MaterialTextBox nameTwoBox;
        private MaterialSkin.Controls.MaterialTextBox nameOneBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel labelPlayer2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialListBox listBox;
        private MaterialSkin.Controls.MaterialButton butPriceAddList;
        private MaterialSkin.Controls.MaterialTextBox priceBox;
        private MaterialSkin.Controls.MaterialButton butClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel labelPlayer1;
    }
}

