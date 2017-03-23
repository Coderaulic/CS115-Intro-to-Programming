<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHolidayMoviesAndMusicStore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHolidayMoviesAndMusicStore))
        Me.btnCalcTotal = New System.Windows.Forms.Button()
        Me.btnCountry = New System.Windows.Forms.Button()
        Me.btnRB = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnJazz = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnClassical = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblCurrentBGinfo = New System.Windows.Forms.Label()
        Me.btnChgBckgrnd = New System.Windows.Forms.Button()
        Me.grpShoppingCart = New System.Windows.Forms.GroupBox()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.lstPrices = New System.Windows.Forms.ListBox()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblSubTotalDisplay = New System.Windows.Forms.Label()
        Me.lblTotalCostDisplay = New System.Windows.Forms.Label()
        Me.lblStoreBanner = New System.Windows.Forms.Label()
        Me.lblBckgrndNum = New System.Windows.Forms.Label()
        Me.lblPromotionBanner1 = New System.Windows.Forms.Label()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.lblPriceDisplay = New System.Windows.Forms.Label()
        Me.rtfDetails = New System.Windows.Forms.RichTextBox()
        Me.lblMediaType = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblEnterAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnAddtoCart = New System.Windows.Forms.Button()
        Me.picDetails = New System.Windows.Forms.PictureBox()
        Me.pnlContainAll = New System.Windows.Forms.Panel()
        Me.btnFullScreen = New System.Windows.Forms.Button()
        Me.grpMusic = New System.Windows.Forms.GroupBox()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpMovie = New System.Windows.Forms.GroupBox()
        Me.btnSciFi = New System.Windows.Forms.Button()
        Me.btnRomantic = New System.Windows.Forms.Button()
        Me.btnActionAdventure = New System.Windows.Forms.Button()
        Me.btnFamilyKids = New System.Windows.Forms.Button()
        Me.btnComedy = New System.Windows.Forms.Button()
        Me.btnAnimated = New System.Windows.Forms.Button()
        Me.lstProductsForSale = New System.Windows.Forms.ListBox()
        Me.tmrPromotionBanner1 = New System.Windows.Forms.Timer(Me.components)
        Me.grpShoppingCart.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        CType(Me.picDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContainAll.SuspendLayout()
        Me.grpMusic.SuspendLayout()
        Me.grpMovie.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalcTotal
        '
        Me.btnCalcTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalcTotal.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcTotal.Location = New System.Drawing.Point(299, 165)
        Me.btnCalcTotal.Name = "btnCalcTotal"
        Me.btnCalcTotal.Size = New System.Drawing.Size(147, 40)
        Me.btnCalcTotal.TabIndex = 23
        Me.btnCalcTotal.Text = "Check Out"
        Me.btnCalcTotal.UseVisualStyleBackColor = True
        '
        'btnCountry
        '
        Me.btnCountry.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCountry.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCountry.ForeColor = System.Drawing.Color.Transparent
        Me.btnCountry.Location = New System.Drawing.Point(130, 19)
        Me.btnCountry.Name = "btnCountry"
        Me.btnCountry.Size = New System.Drawing.Size(120, 30)
        Me.btnCountry.TabIndex = 6
        Me.btnCountry.Text = "Country"
        Me.btnCountry.UseVisualStyleBackColor = True
        '
        'btnRB
        '
        Me.btnRB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRB.Font = New System.Drawing.Font("Segoe Print", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRB.ForeColor = System.Drawing.Color.Transparent
        Me.btnRB.Location = New System.Drawing.Point(508, 19)
        Me.btnRB.Name = "btnRB"
        Me.btnRB.Size = New System.Drawing.Size(120, 30)
        Me.btnRB.TabIndex = 10
        Me.btnRB.Text = "R && B"
        Me.btnRB.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(299, 78)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(147, 40)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear Shopping Cart"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnJazz
        '
        Me.btnJazz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnJazz.Font = New System.Drawing.Font("Segoe Print", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJazz.ForeColor = System.Drawing.Color.Transparent
        Me.btnJazz.Location = New System.Drawing.Point(256, 19)
        Me.btnJazz.Name = "btnJazz"
        Me.btnJazz.Size = New System.Drawing.Size(120, 30)
        Me.btnJazz.TabIndex = 7
        Me.btnJazz.Text = "Jazz"
        Me.btnJazz.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(750, 115)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(190, 25)
        Me.txtSearch.TabIndex = 33
        '
        'btnClassical
        '
        Me.btnClassical.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClassical.Font = New System.Drawing.Font("Segoe Print", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassical.ForeColor = System.Drawing.Color.Transparent
        Me.btnClassical.Location = New System.Drawing.Point(6, 19)
        Me.btnClassical.Name = "btnClassical"
        Me.btnClassical.Size = New System.Drawing.Size(120, 30)
        Me.btnClassical.TabIndex = 9
        Me.btnClassical.Text = "Classical"
        Me.btnClassical.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Transparent
        Me.btnSearch.Location = New System.Drawing.Point(818, 143)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 26)
        Me.btnSearch.TabIndex = 34
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblCurrentBGinfo
        '
        Me.lblCurrentBGinfo.ForeColor = System.Drawing.Color.White
        Me.lblCurrentBGinfo.Location = New System.Drawing.Point(107, 694)
        Me.lblCurrentBGinfo.Name = "lblCurrentBGinfo"
        Me.lblCurrentBGinfo.Size = New System.Drawing.Size(206, 20)
        Me.lblCurrentBGinfo.TabIndex = 37
        Me.lblCurrentBGinfo.Text = "Currently showing Background #"
        '
        'btnChgBckgrnd
        '
        Me.btnChgBckgrnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChgBckgrnd.Font = New System.Drawing.Font("Segoe Script", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChgBckgrnd.ForeColor = System.Drawing.Color.Transparent
        Me.btnChgBckgrnd.Location = New System.Drawing.Point(468, 690)
        Me.btnChgBckgrnd.Name = "btnChgBckgrnd"
        Me.btnChgBckgrnd.Size = New System.Drawing.Size(171, 30)
        Me.btnChgBckgrnd.TabIndex = 36
        Me.btnChgBckgrnd.Text = "Change Bac&kground"
        Me.btnChgBckgrnd.UseVisualStyleBackColor = True
        '
        'grpShoppingCart
        '
        Me.grpShoppingCart.Controls.Add(Me.lstShoppingCart)
        Me.grpShoppingCart.Controls.Add(Me.lstPrices)
        Me.grpShoppingCart.Controls.Add(Me.btnRemoveItem)
        Me.grpShoppingCart.Controls.Add(Me.btnCalcTotal)
        Me.grpShoppingCart.Controls.Add(Me.btnClear)
        Me.grpShoppingCart.Controls.Add(Me.lblSubTotal)
        Me.grpShoppingCart.Controls.Add(Me.lblTotalPrice)
        Me.grpShoppingCart.Controls.Add(Me.lblSubTotalDisplay)
        Me.grpShoppingCart.Controls.Add(Me.lblTotalCostDisplay)
        Me.grpShoppingCart.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpShoppingCart.ForeColor = System.Drawing.Color.White
        Me.grpShoppingCart.Location = New System.Drawing.Point(488, 411)
        Me.grpShoppingCart.Name = "grpShoppingCart"
        Me.grpShoppingCart.Size = New System.Drawing.Size(452, 216)
        Me.grpShoppingCart.TabIndex = 33
        Me.grpShoppingCart.TabStop = False
        Me.grpShoppingCart.Text = "Shoppnig Cart"
        '
        'lstShoppingCart
        '
        Me.lstShoppingCart.BackColor = System.Drawing.Color.DarkRed
        Me.lstShoppingCart.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShoppingCart.ForeColor = System.Drawing.Color.Transparent
        Me.lstShoppingCart.FormattingEnabled = True
        Me.lstShoppingCart.ItemHeight = 19
        Me.lstShoppingCart.Location = New System.Drawing.Point(6, 22)
        Me.lstShoppingCart.Name = "lstShoppingCart"
        Me.lstShoppingCart.Size = New System.Drawing.Size(214, 118)
        Me.lstShoppingCart.TabIndex = 19
        '
        'lstPrices
        '
        Me.lstPrices.BackColor = System.Drawing.Color.DarkRed
        Me.lstPrices.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrices.ForeColor = System.Drawing.Color.Transparent
        Me.lstPrices.FormattingEnabled = True
        Me.lstPrices.ItemHeight = 19
        Me.lstPrices.Location = New System.Drawing.Point(226, 22)
        Me.lstPrices.Name = "lstPrices"
        Me.lstPrices.Size = New System.Drawing.Size(67, 118)
        Me.lstPrices.TabIndex = 20
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemoveItem.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.Location = New System.Drawing.Point(299, 22)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(147, 50)
        Me.btnRemoveItem.TabIndex = 21
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Location = New System.Drawing.Point(145, 165)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(75, 19)
        Me.lblSubTotal.TabIndex = 28
        Me.lblSubTotal.Text = "SubTotal"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Location = New System.Drawing.Point(173, 186)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(47, 21)
        Me.lblTotalPrice.TabIndex = 29
        Me.lblTotalPrice.Text = "Total Cost"
        '
        'lblSubTotalDisplay
        '
        Me.lblSubTotalDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotalDisplay.Location = New System.Drawing.Point(226, 165)
        Me.lblSubTotalDisplay.Name = "lblSubTotalDisplay"
        Me.lblSubTotalDisplay.Size = New System.Drawing.Size(67, 20)
        Me.lblSubTotalDisplay.TabIndex = 24
        '
        'lblTotalCostDisplay
        '
        Me.lblTotalCostDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCostDisplay.Location = New System.Drawing.Point(226, 187)
        Me.lblTotalCostDisplay.Name = "lblTotalCostDisplay"
        Me.lblTotalCostDisplay.Size = New System.Drawing.Size(67, 20)
        Me.lblTotalCostDisplay.TabIndex = 25
        '
        'lblStoreBanner
        '
        Me.lblStoreBanner.Font = New System.Drawing.Font("Segoe Print", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoreBanner.ForeColor = System.Drawing.Color.White
        Me.lblStoreBanner.Location = New System.Drawing.Point(230, 13)
        Me.lblStoreBanner.Name = "lblStoreBanner"
        Me.lblStoreBanner.Size = New System.Drawing.Size(534, 42)
        Me.lblStoreBanner.TabIndex = 32
        Me.lblStoreBanner.Text = "Welcome to the Holiday Movies and Music Store!"
        Me.lblStoreBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBckgrndNum
        '
        Me.lblBckgrndNum.ForeColor = System.Drawing.Color.White
        Me.lblBckgrndNum.Location = New System.Drawing.Point(364, 694)
        Me.lblBckgrndNum.Name = "lblBckgrndNum"
        Me.lblBckgrndNum.Size = New System.Drawing.Size(56, 18)
        Me.lblBckgrndNum.TabIndex = 35
        Me.lblBckgrndNum.Text = "Default"
        '
        'lblPromotionBanner1
        '
        Me.lblPromotionBanner1.BackColor = System.Drawing.Color.Transparent
        Me.lblPromotionBanner1.Font = New System.Drawing.Font("Segoe Script", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromotionBanner1.ForeColor = System.Drawing.Color.Lime
        Me.lblPromotionBanner1.Location = New System.Drawing.Point(970, 645)
        Me.lblPromotionBanner1.Name = "lblPromotionBanner1"
        Me.lblPromotionBanner1.Size = New System.Drawing.Size(468, 28)
        Me.lblPromotionBanner1.TabIndex = 0
        Me.lblPromotionBanner1.Text = "Free Express Shipping During This Holiday Season !!!"
        Me.lblPromotionBanner1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlDetails
        '
        Me.pnlDetails.AutoScroll = True
        Me.pnlDetails.BackColor = System.Drawing.Color.Transparent
        Me.pnlDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDetails.Controls.Add(Me.lblPriceDisplay)
        Me.pnlDetails.Controls.Add(Me.rtfDetails)
        Me.pnlDetails.Controls.Add(Me.lblMediaType)
        Me.pnlDetails.Controls.Add(Me.lblPrice)
        Me.pnlDetails.Controls.Add(Me.lblItemName)
        Me.pnlDetails.Controls.Add(Me.lblEnterAmount)
        Me.pnlDetails.Controls.Add(Me.txtAmount)
        Me.pnlDetails.Controls.Add(Me.btnAddtoCart)
        Me.pnlDetails.Controls.Add(Me.picDetails)
        Me.pnlDetails.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDetails.ForeColor = System.Drawing.Color.White
        Me.pnlDetails.Location = New System.Drawing.Point(107, 170)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(833, 240)
        Me.pnlDetails.TabIndex = 13
        '
        'lblPriceDisplay
        '
        Me.lblPriceDisplay.Location = New System.Drawing.Point(179, 113)
        Me.lblPriceDisplay.Name = "lblPriceDisplay"
        Me.lblPriceDisplay.Size = New System.Drawing.Size(61, 26)
        Me.lblPriceDisplay.TabIndex = 33
        Me.lblPriceDisplay.Text = "Price:  "
        Me.lblPriceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtfDetails
        '
        Me.rtfDetails.BackColor = System.Drawing.Color.DarkRed
        Me.rtfDetails.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfDetails.ForeColor = System.Drawing.Color.Transparent
        Me.rtfDetails.Location = New System.Drawing.Point(356, 3)
        Me.rtfDetails.Name = "rtfDetails"
        Me.rtfDetails.ReadOnly = True
        Me.rtfDetails.Size = New System.Drawing.Size(470, 229)
        Me.rtfDetails.TabIndex = 32
        Me.rtfDetails.Text = ""
        '
        'lblMediaType
        '
        Me.lblMediaType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMediaType.ForeColor = System.Drawing.Color.Transparent
        Me.lblMediaType.Location = New System.Drawing.Point(179, 67)
        Me.lblMediaType.Name = "lblMediaType"
        Me.lblMediaType.Size = New System.Drawing.Size(171, 28)
        Me.lblMediaType.TabIndex = 32
        Me.lblMediaType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.ForeColor = System.Drawing.Color.Transparent
        Me.lblPrice.Location = New System.Drawing.Point(246, 112)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(103, 27)
        Me.lblPrice.TabIndex = 7
        '
        'lblItemName
        '
        Me.lblItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemName.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.Transparent
        Me.lblItemName.Location = New System.Drawing.Point(6, 4)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(344, 23)
        Me.lblItemName.TabIndex = 6
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnterAmount
        '
        Me.lblEnterAmount.Location = New System.Drawing.Point(174, 157)
        Me.lblEnterAmount.Name = "lblEnterAmount"
        Me.lblEnterAmount.Size = New System.Drawing.Size(106, 23)
        Me.lblEnterAmount.TabIndex = 4
        Me.lblEnterAmount.Text = "Enter Amount"
        Me.lblEnterAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(286, 158)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(53, 30)
        Me.txtAmount.TabIndex = 3
        '
        'btnAddtoCart
        '
        Me.btnAddtoCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddtoCart.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddtoCart.Location = New System.Drawing.Point(178, 194)
        Me.btnAddtoCart.Name = "btnAddtoCart"
        Me.btnAddtoCart.Size = New System.Drawing.Size(171, 36)
        Me.btnAddtoCart.TabIndex = 2
        Me.btnAddtoCart.Text = "Add Item to Cart"
        Me.btnAddtoCart.UseVisualStyleBackColor = True
        '
        'picDetails
        '
        Me.picDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDetails.Location = New System.Drawing.Point(6, 30)
        Me.picDetails.Name = "picDetails"
        Me.picDetails.Size = New System.Drawing.Size(167, 200)
        Me.picDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDetails.TabIndex = 0
        Me.picDetails.TabStop = False
        '
        'pnlContainAll
        '
        Me.pnlContainAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlContainAll.BackColor = System.Drawing.Color.Transparent
        Me.pnlContainAll.Controls.Add(Me.txtSearch)
        Me.pnlContainAll.Controls.Add(Me.btnSearch)
        Me.pnlContainAll.Controls.Add(Me.lblCurrentBGinfo)
        Me.pnlContainAll.Controls.Add(Me.btnChgBckgrnd)
        Me.pnlContainAll.Controls.Add(Me.lblBckgrndNum)
        Me.pnlContainAll.Controls.Add(Me.lblPromotionBanner1)
        Me.pnlContainAll.Controls.Add(Me.grpShoppingCart)
        Me.pnlContainAll.Controls.Add(Me.lblStoreBanner)
        Me.pnlContainAll.Controls.Add(Me.pnlDetails)
        Me.pnlContainAll.Controls.Add(Me.btnFullScreen)
        Me.pnlContainAll.Controls.Add(Me.grpMusic)
        Me.pnlContainAll.Controls.Add(Me.btnExit)
        Me.pnlContainAll.Controls.Add(Me.grpMovie)
        Me.pnlContainAll.Controls.Add(Me.lstProductsForSale)
        Me.pnlContainAll.Font = New System.Drawing.Font("Segoe Script", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlContainAll.Location = New System.Drawing.Point(-8, 0)
        Me.pnlContainAll.Name = "pnlContainAll"
        Me.pnlContainAll.Size = New System.Drawing.Size(1024, 730)
        Me.pnlContainAll.TabIndex = 33
        '
        'btnFullScreen
        '
        Me.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFullScreen.Font = New System.Drawing.Font("Segoe Script", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullScreen.ForeColor = System.Drawing.Color.Transparent
        Me.btnFullScreen.Location = New System.Drawing.Point(644, 690)
        Me.btnFullScreen.Name = "btnFullScreen"
        Me.btnFullScreen.Size = New System.Drawing.Size(170, 30)
        Me.btnFullScreen.TabIndex = 31
        Me.btnFullScreen.Text = "Full Screen"
        Me.btnFullScreen.UseVisualStyleBackColor = True
        '
        'grpMusic
        '
        Me.grpMusic.Controls.Add(Me.btnCountry)
        Me.grpMusic.Controls.Add(Me.btnRB)
        Me.grpMusic.Controls.Add(Me.btnJazz)
        Me.grpMusic.Controls.Add(Me.btnClassical)
        Me.grpMusic.Controls.Add(Me.btnRock)
        Me.grpMusic.ForeColor = System.Drawing.Color.White
        Me.grpMusic.Location = New System.Drawing.Point(107, 109)
        Me.grpMusic.Name = "grpMusic"
        Me.grpMusic.Size = New System.Drawing.Size(637, 57)
        Me.grpMusic.TabIndex = 0
        Me.grpMusic.TabStop = False
        Me.grpMusic.Text = "Music CD"
        '
        'btnRock
        '
        Me.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRock.Font = New System.Drawing.Font("Segoe Print", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRock.ForeColor = System.Drawing.Color.Transparent
        Me.btnRock.Location = New System.Drawing.Point(382, 19)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(120, 30)
        Me.btnRock.TabIndex = 8
        Me.btnRock.Text = "Rock"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Segoe Script", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Transparent
        Me.btnExit.Location = New System.Drawing.Point(820, 690)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 30)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "E&xit Store"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpMovie
        '
        Me.grpMovie.Controls.Add(Me.btnSciFi)
        Me.grpMovie.Controls.Add(Me.btnRomantic)
        Me.grpMovie.Controls.Add(Me.btnActionAdventure)
        Me.grpMovie.Controls.Add(Me.btnFamilyKids)
        Me.grpMovie.Controls.Add(Me.btnComedy)
        Me.grpMovie.Controls.Add(Me.btnAnimated)
        Me.grpMovie.ForeColor = System.Drawing.Color.White
        Me.grpMovie.Location = New System.Drawing.Point(107, 58)
        Me.grpMovie.Name = "grpMovie"
        Me.grpMovie.Size = New System.Drawing.Size(833, 51)
        Me.grpMovie.TabIndex = 8
        Me.grpMovie.TabStop = False
        Me.grpMovie.Text = "Movie DVD"
        '
        'btnSciFi
        '
        Me.btnSciFi.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSciFi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSciFi.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSciFi.ForeColor = System.Drawing.Color.Transparent
        Me.btnSciFi.Location = New System.Drawing.Point(664, 15)
        Me.btnSciFi.Name = "btnSciFi"
        Me.btnSciFi.Size = New System.Drawing.Size(108, 30)
        Me.btnSciFi.TabIndex = 5
        Me.btnSciFi.Text = "Sci Fi"
        Me.btnSciFi.UseVisualStyleBackColor = True
        '
        'btnRomantic
        '
        Me.btnRomantic.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnRomantic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRomantic.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRomantic.ForeColor = System.Drawing.Color.Transparent
        Me.btnRomantic.Location = New System.Drawing.Point(538, 15)
        Me.btnRomantic.Name = "btnRomantic"
        Me.btnRomantic.Size = New System.Drawing.Size(120, 30)
        Me.btnRomantic.TabIndex = 4
        Me.btnRomantic.Text = "Romantic"
        Me.btnRomantic.UseVisualStyleBackColor = True
        '
        'btnActionAdventure
        '
        Me.btnActionAdventure.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnActionAdventure.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActionAdventure.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActionAdventure.ForeColor = System.Drawing.Color.Transparent
        Me.btnActionAdventure.Location = New System.Drawing.Point(256, 15)
        Me.btnActionAdventure.Name = "btnActionAdventure"
        Me.btnActionAdventure.Size = New System.Drawing.Size(150, 30)
        Me.btnActionAdventure.TabIndex = 3
        Me.btnActionAdventure.Text = "Action / Adventure"
        Me.btnActionAdventure.UseVisualStyleBackColor = True
        '
        'btnFamilyKids
        '
        Me.btnFamilyKids.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnFamilyKids.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFamilyKids.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamilyKids.ForeColor = System.Drawing.Color.Transparent
        Me.btnFamilyKids.Location = New System.Drawing.Point(412, 15)
        Me.btnFamilyKids.Name = "btnFamilyKids"
        Me.btnFamilyKids.Size = New System.Drawing.Size(120, 30)
        Me.btnFamilyKids.TabIndex = 2
        Me.btnFamilyKids.Text = "Family / Kids"
        Me.btnFamilyKids.UseVisualStyleBackColor = True
        '
        'btnComedy
        '
        Me.btnComedy.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnComedy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComedy.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComedy.ForeColor = System.Drawing.Color.Transparent
        Me.btnComedy.Location = New System.Drawing.Point(130, 15)
        Me.btnComedy.Name = "btnComedy"
        Me.btnComedy.Size = New System.Drawing.Size(120, 30)
        Me.btnComedy.TabIndex = 1
        Me.btnComedy.Text = "Comedy"
        Me.btnComedy.UseVisualStyleBackColor = True
        '
        'btnAnimated
        '
        Me.btnAnimated.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnAnimated.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnimated.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnimated.ForeColor = System.Drawing.Color.Transparent
        Me.btnAnimated.Location = New System.Drawing.Point(4, 15)
        Me.btnAnimated.Name = "btnAnimated"
        Me.btnAnimated.Size = New System.Drawing.Size(120, 30)
        Me.btnAnimated.TabIndex = 0
        Me.btnAnimated.Text = "Animated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAnimated.UseVisualStyleBackColor = True
        '
        'lstProductsForSale
        '
        Me.lstProductsForSale.BackColor = System.Drawing.Color.DarkRed
        Me.lstProductsForSale.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProductsForSale.ForeColor = System.Drawing.Color.Transparent
        Me.lstProductsForSale.FormattingEnabled = True
        Me.lstProductsForSale.ItemHeight = 21
        Me.lstProductsForSale.Location = New System.Drawing.Point(107, 420)
        Me.lstProductsForSale.Name = "lstProductsForSale"
        Me.lstProductsForSale.Size = New System.Drawing.Size(375, 193)
        Me.lstProductsForSale.Sorted = True
        Me.lstProductsForSale.TabIndex = 14
        '
        'tmrPromotionBanner1
        '
        Me.tmrPromotionBanner1.Enabled = True
        '
        'frmHolidayMoviesAndMusicStore
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.pnlContainAll)
        Me.Name = "frmHolidayMoviesAndMusicStore"
        Me.Text = "Holiday Movies and Music Store"
        Me.grpShoppingCart.ResumeLayout(False)
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        CType(Me.picDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContainAll.ResumeLayout(False)
        Me.pnlContainAll.PerformLayout()
        Me.grpMusic.ResumeLayout(False)
        Me.grpMovie.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCalcTotal As System.Windows.Forms.Button
    Friend WithEvents btnCountry As System.Windows.Forms.Button
    Friend WithEvents btnRB As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnJazz As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnClassical As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblCurrentBGinfo As System.Windows.Forms.Label
    Friend WithEvents btnChgBckgrnd As System.Windows.Forms.Button
    Friend WithEvents grpShoppingCart As System.Windows.Forms.GroupBox
    Friend WithEvents lstShoppingCart As System.Windows.Forms.ListBox
    Friend WithEvents lstPrices As System.Windows.Forms.ListBox
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalDisplay As System.Windows.Forms.Label
    Friend WithEvents lblTotalCostDisplay As System.Windows.Forms.Label
    Friend WithEvents lblStoreBanner As System.Windows.Forms.Label
    Friend WithEvents lblBckgrndNum As System.Windows.Forms.Label
    Friend WithEvents lblPromotionBanner1 As System.Windows.Forms.Label
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents lblPriceDisplay As System.Windows.Forms.Label
    Friend WithEvents rtfDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents lblMediaType As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents lblEnterAmount As System.Windows.Forms.Label
    Private WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnAddtoCart As System.Windows.Forms.Button
    Friend WithEvents picDetails As System.Windows.Forms.PictureBox
    Friend WithEvents pnlContainAll As System.Windows.Forms.Panel
    Friend WithEvents btnFullScreen As System.Windows.Forms.Button
    Friend WithEvents grpMusic As System.Windows.Forms.GroupBox
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grpMovie As System.Windows.Forms.GroupBox
    Friend WithEvents btnSciFi As System.Windows.Forms.Button
    Friend WithEvents btnRomantic As System.Windows.Forms.Button
    Friend WithEvents btnActionAdventure As System.Windows.Forms.Button
    Friend WithEvents btnFamilyKids As System.Windows.Forms.Button
    Friend WithEvents btnComedy As System.Windows.Forms.Button
    Friend WithEvents btnAnimated As System.Windows.Forms.Button
    Friend WithEvents lstProductsForSale As System.Windows.Forms.ListBox
    Friend WithEvents tmrPromotionBanner1 As System.Windows.Forms.Timer

End Class
