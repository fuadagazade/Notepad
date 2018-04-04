namespace WF_DZ_05
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUnselect = new System.Windows.Forms.ToolStripMenuItem();
            this.ssBottom = new System.Windows.Forms.StatusStrip();
            this.ssText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssLinesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbTextCount = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenRTF = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveRTF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFontEdit = new System.Windows.Forms.ToolStripButton();
            this.FontSelector = new System.Windows.Forms.ToolStripComboBox();
            this.FontSizeSelector = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnColorEdit = new System.Windows.Forms.ToolStripButton();
            this.btnBgColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.btnStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSmall = new System.Windows.Forms.ToolStripButton();
            this.btnBig = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLower = new System.Windows.Forms.ToolStripButton();
            this.btnUpper = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.btnAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.btnAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbFindText = new System.Windows.Forms.ToolStripTextBox();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            this.ssBottom.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbText.Location = new System.Drawing.Point(9, 68);
            this.rtbText.Margin = new System.Windows.Forms.Padding(0);
            this.rtbText.MaxLength = 5000;
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(966, 469);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            this.rtbText.SelectionChanged += new System.EventHandler(this.rtbText_TextChanged);
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCopy,
            this.btnPaste,
            this.toolStripSeparator2,
            this.btnCut,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnSelectAll,
            this.btnUnselect});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 148);
            // 
            // btnCopy
            // 
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(190, 22);
            this.btnCopy.Text = "Копировать";
            this.btnCopy.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(190, 22);
            this.btnPaste.Text = "Вставить";
            this.btnPaste.Click += new System.EventHandler(this.btn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            this.toolStripSeparator2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCut
            // 
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(190, 22);
            this.btnCut.Text = "Вырезать";
            this.btnCut.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 22);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            this.toolStripSeparator3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(190, 22);
            this.btnSelectAll.Text = "Выделить все";
            this.btnSelectAll.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnUnselect
            // 
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(190, 22);
            this.btnUnselect.Text = "Сбросить выделение";
            this.btnUnselect.Click += new System.EventHandler(this.btn_Click);
            // 
            // ssBottom
            // 
            this.ssBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssText,
            this.toolStripStatusLabel1,
            this.ssLinesCount,
            this.tsLabelCount,
            this.pbTextCount});
            this.ssBottom.Location = new System.Drawing.Point(0, 537);
            this.ssBottom.Name = "ssBottom";
            this.ssBottom.Size = new System.Drawing.Size(984, 22);
            this.ssBottom.TabIndex = 1;
            this.ssBottom.Text = "statusStrip1";
            // 
            // ssText
            // 
            this.ssText.Name = "ssText";
            this.ssText.Size = new System.Drawing.Size(112, 17);
            this.ssText.Text = "Количество строк: ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // ssLinesCount
            // 
            this.ssLinesCount.Name = "ssLinesCount";
            this.ssLinesCount.Size = new System.Drawing.Size(13, 17);
            this.ssLinesCount.Text = "0";
            // 
            // tsLabelCount
            // 
            this.tsLabelCount.Name = "tsLabelCount";
            this.tsLabelCount.Size = new System.Drawing.Size(143, 17);
            this.tsLabelCount.Text = "Заполняемость текстом:";
            // 
            // pbTextCount
            // 
            this.pbTextCount.Maximum = 5000;
            this.pbTextCount.Name = "pbTextCount";
            this.pbTextCount.Size = new System.Drawing.Size(100, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnFile
            // 
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnClose});
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(48, 20);
            this.btnFile.Text = "&Файл";
            // 
            // btnOpen
            // 
            this.btnOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenTXT,
            this.btnOpenRTF});
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpen.Size = new System.Drawing.Size(194, 22);
            this.btnOpen.Text = "&Открыть";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnOpenTXT
            // 
            this.btnOpenTXT.Name = "btnOpenTXT";
            this.btnOpenTXT.Size = new System.Drawing.Size(87, 22);
            this.btnOpenTXT.Text = "txt";
            this.btnOpenTXT.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnOpenRTF
            // 
            this.btnOpenRTF.Name = "btnOpenRTF";
            this.btnOpenRTF.Size = new System.Drawing.Size(87, 22);
            this.btnOpenRTF.Text = "rtf";
            this.btnOpenRTF.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveTXT,
            this.btnSaveRTF});
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSave.Size = new System.Drawing.Size(194, 22);
            this.btnSave.Text = "&Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveTXT
            // 
            this.btnSaveTXT.Name = "btnSaveTXT";
            this.btnSaveTXT.Size = new System.Drawing.Size(87, 22);
            this.btnSaveTXT.Text = "txt";
            this.btnSaveTXT.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveRTF
            // 
            this.btnSaveRTF.Name = "btnSaveRTF";
            this.btnSaveRTF.Size = new System.Drawing.Size(87, 22);
            this.btnSaveRTF.Text = "rtf";
            this.btnSaveRTF.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.btnClose.Size = new System.Drawing.Size(194, 22);
            this.btnClose.Text = "&Закрыть";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.btnAbout.Size = new System.Drawing.Size(94, 20);
            this.btnAbout.Text = "&О программе";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFontEdit,
            this.FontSelector,
            this.FontSizeSelector,
            this.toolStripSeparator9,
            this.btnColorEdit,
            this.btnBgColor,
            this.toolStripSeparator4,
            this.btnBold,
            this.btnItalic,
            this.btnUnderline,
            this.btnStrikeout,
            this.toolStripSeparator8,
            this.btnSmall,
            this.btnBig,
            this.toolStripSeparator5,
            this.btnLower,
            this.btnUpper,
            this.toolStripSeparator6,
            this.btnAlignLeft,
            this.btnAlignCenter,
            this.btnAlignRight,
            this.toolStripSeparator7,
            this.toolStripLabel2,
            this.tbFindText,
            this.btnFind});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 31);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFontEdit
            // 
            this.btnFontEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFontEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnFontEdit.Image")));
            this.btnFontEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFontEdit.Name = "btnFontEdit";
            this.btnFontEdit.Size = new System.Drawing.Size(28, 28);
            this.btnFontEdit.Text = "Редактировать шрифт";
            this.btnFontEdit.Click += new System.EventHandler(this.btnFontEdit_Click);
            // 
            // FontSelector
            // 
            this.FontSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FontSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FontSelector.Name = "FontSelector";
            this.FontSelector.Size = new System.Drawing.Size(121, 31);
            this.FontSelector.SelectedIndexChanged += new System.EventHandler(this.Font_SelectedIndexChanged);
            // 
            // FontSizeSelector
            // 
            this.FontSizeSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FontSizeSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FontSizeSelector.Name = "FontSizeSelector";
            this.FontSizeSelector.Size = new System.Drawing.Size(75, 31);
            this.FontSizeSelector.SelectedIndexChanged += new System.EventHandler(this.Font_SelectedIndexChanged);
            this.FontSizeSelector.TextChanged += new System.EventHandler(this.Font_SelectedIndexChanged);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // btnColorEdit
            // 
            this.btnColorEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColorEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnColorEdit.Image")));
            this.btnColorEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColorEdit.Name = "btnColorEdit";
            this.btnColorEdit.Size = new System.Drawing.Size(28, 28);
            this.btnColorEdit.Text = "Редактировать цвет";
            this.btnColorEdit.Click += new System.EventHandler(this.btnColorEdit_Click);
            // 
            // btnBgColor
            // 
            this.btnBgColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBgColor.Image = ((System.Drawing.Image)(resources.GetObject("btnBgColor.Image")));
            this.btnBgColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBgColor.Name = "btnBgColor";
            this.btnBgColor.Size = new System.Drawing.Size(28, 28);
            this.btnBgColor.Text = "Редактировать фон";
            this.btnBgColor.Click += new System.EventHandler(this.btnBgColor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // btnBold
            // 
            this.btnBold.CheckOnClick = true;
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(28, 28);
            this.btnBold.Text = "Жирный";
            this.btnBold.CheckedChanged += new System.EventHandler(this.btnStyle_CheckedChanged);
            // 
            // btnItalic
            // 
            this.btnItalic.CheckOnClick = true;
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.Image")));
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(28, 28);
            this.btnItalic.Text = "Курсивный";
            this.btnItalic.CheckedChanged += new System.EventHandler(this.btnStyle_CheckedChanged);
            // 
            // btnUnderline
            // 
            this.btnUnderline.CheckOnClick = true;
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(28, 28);
            this.btnUnderline.Text = "Подчеркнутый";
            this.btnUnderline.CheckedChanged += new System.EventHandler(this.btnStyle_CheckedChanged);
            // 
            // btnStrikeout
            // 
            this.btnStrikeout.CheckOnClick = true;
            this.btnStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStrikeout.Image = ((System.Drawing.Image)(resources.GetObject("btnStrikeout.Image")));
            this.btnStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStrikeout.Name = "btnStrikeout";
            this.btnStrikeout.Size = new System.Drawing.Size(28, 28);
            this.btnStrikeout.Text = "Перечеркнутый";
            this.btnStrikeout.CheckedChanged += new System.EventHandler(this.btnStyle_CheckedChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSmall
            // 
            this.btnSmall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSmall.Image = ((System.Drawing.Image)(resources.GetObject("btnSmall.Image")));
            this.btnSmall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(28, 28);
            this.btnSmall.Text = "Шрифт -";
            this.btnSmall.Click += new System.EventHandler(this.btnCase_Click);
            // 
            // btnBig
            // 
            this.btnBig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBig.Image = ((System.Drawing.Image)(resources.GetObject("btnBig.Image")));
            this.btnBig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(28, 28);
            this.btnBig.Text = "Шрифт +";
            this.btnBig.Click += new System.EventHandler(this.btnCase_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // btnLower
            // 
            this.btnLower.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLower.Image = ((System.Drawing.Image)(resources.GetObject("btnLower.Image")));
            this.btnLower.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(28, 28);
            this.btnLower.Text = "Прописные буквы";
            this.btnLower.Click += new System.EventHandler(this.btnCase_Click);
            // 
            // btnUpper
            // 
            this.btnUpper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpper.Image = ((System.Drawing.Image)(resources.GetObject("btnUpper.Image")));
            this.btnUpper.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(28, 28);
            this.btnUpper.Text = "Заглавные буквы";
            this.btnUpper.Click += new System.EventHandler(this.btnCase_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignLeft.Image")));
            this.btnAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(28, 28);
            this.btnAlignLeft.Text = "Левое выравнивание";
            this.btnAlignLeft.Click += new System.EventHandler(this.btnAlign_Click);
            // 
            // btnAlignCenter
            // 
            this.btnAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignCenter.Image")));
            this.btnAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignCenter.Name = "btnAlignCenter";
            this.btnAlignCenter.Size = new System.Drawing.Size(28, 28);
            this.btnAlignCenter.Text = "Центральное выравнивание";
            this.btnAlignCenter.Click += new System.EventHandler(this.btnAlign_Click);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignRight.Image")));
            this.btnAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(28, 28);
            this.btnAlignRight.Text = "Правое выравнивание";
            this.btnAlignRight.Click += new System.EventHandler(this.btnAlign_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 28);
            // 
            // tbFindText
            // 
            this.tbFindText.Name = "tbFindText";
            this.tbFindText.Size = new System.Drawing.Size(110, 31);
            this.tbFindText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 28);
            this.btnFind.Text = "Поиск";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 559);
            this.Controls.Add(this.ssBottom);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rtbText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ssBottom.ResumeLayout(false);
            this.ssBottom.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.StatusStrip ssBottom;
        private System.Windows.Forms.ToolStripStatusLabel ssText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ssLinesCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnOpenTXT;
        private System.Windows.Forms.ToolStripMenuItem btnOpenRTF;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnSaveTXT;
        private System.Windows.Forms.ToolStripMenuItem btnSaveRTF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCopy;
        private System.Windows.Forms.ToolStripMenuItem btnPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnCut;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnSelectAll;
        private System.Windows.Forms.ToolStripMenuItem btnUnselect;
        private System.Windows.Forms.ToolStripButton btnFontEdit;
        private System.Windows.Forms.ToolStripTextBox tbFindText;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnColorEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripButton btnStrikeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnLower;
        private System.Windows.Forms.ToolStripButton btnUpper;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnAlignLeft;
        private System.Windows.Forms.ToolStripButton btnAlignCenter;
        private System.Windows.Forms.ToolStripButton btnAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripComboBox FontSelector;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripComboBox FontSizeSelector;
        private System.Windows.Forms.ToolStripButton btnBgColor;
        private System.Windows.Forms.ToolStripProgressBar pbTextCount;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSmall;
        private System.Windows.Forms.ToolStripButton btnBig;
    }
}

