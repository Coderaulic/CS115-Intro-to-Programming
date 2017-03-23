<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFavoriteFilms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFavoriteFilms))
        Me.grpClassmates = New System.Windows.Forms.GroupBox()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.radClearAll = New System.Windows.Forms.RadioButton()
        Me.radRussellB = New System.Windows.Forms.RadioButton()
        Me.radNasirE = New System.Windows.Forms.RadioButton()
        Me.radZhipengLi = New System.Windows.Forms.RadioButton()
        Me.radDanilaY = New System.Windows.Forms.RadioButton()
        Me.radDavidB = New System.Windows.Forms.RadioButton()
        Me.lblWrittenBy = New System.Windows.Forms.Label()
        Me.lblFavoriteFilms = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picFilmPoster = New System.Windows.Forms.PictureBox()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.grpClassmates.SuspendLayout()
        CType(Me.picFilmPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpClassmates
        '
        Me.grpClassmates.BackColor = System.Drawing.Color.Transparent
        Me.grpClassmates.Controls.Add(Me.chkBold)
        Me.grpClassmates.Controls.Add(Me.radClearAll)
        Me.grpClassmates.Controls.Add(Me.radRussellB)
        Me.grpClassmates.Controls.Add(Me.radNasirE)
        Me.grpClassmates.Controls.Add(Me.radZhipengLi)
        Me.grpClassmates.Controls.Add(Me.radDanilaY)
        Me.grpClassmates.Controls.Add(Me.radDavidB)
        Me.grpClassmates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpClassmates.Location = New System.Drawing.Point(95, 36)
        Me.grpClassmates.Name = "grpClassmates"
        Me.grpClassmates.Size = New System.Drawing.Size(158, 240)
        Me.grpClassmates.TabIndex = 0
        Me.grpClassmates.TabStop = False
        Me.grpClassmates.Text = "Classmates:"
        '
        'chkBold
        '
        Me.chkBold.Location = New System.Drawing.Point(15, 211)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(117, 21)
        Me.chkBold.TabIndex = 0
        Me.chkBold.Text = "Bold text"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'radClearAll
        '
        Me.radClearAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.radClearAll.Location = New System.Drawing.Point(15, 185)
        Me.radClearAll.Name = "radClearAll"
        Me.radClearAll.Size = New System.Drawing.Size(129, 17)
        Me.radClearAll.TabIndex = 0
        Me.radClearAll.TabStop = True
        Me.radClearAll.Text = "Clear All"
        Me.radClearAll.UseVisualStyleBackColor = True
        '
        'radRussellB
        '
        Me.radRussellB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.radRussellB.Location = New System.Drawing.Point(15, 139)
        Me.radRussellB.Name = "radRussellB"
        Me.radRussellB.Size = New System.Drawing.Size(129, 24)
        Me.radRussellB.TabIndex = 0
        Me.radRussellB.TabStop = True
        Me.radRussellB.Text = "Russell Brendel"
        Me.radRussellB.UseVisualStyleBackColor = True
        '
        'radNasirE
        '
        Me.radNasirE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.radNasirE.Location = New System.Drawing.Point(15, 113)
        Me.radNasirE.Name = "radNasirE"
        Me.radNasirE.Size = New System.Drawing.Size(129, 20)
        Me.radNasirE.TabIndex = 0
        Me.radNasirE.TabStop = True
        Me.radNasirE.Text = "Nasir Elmi"
        Me.radNasirE.UseVisualStyleBackColor = True
        '
        'radZhipengLi
        '
        Me.radZhipengLi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.radZhipengLi.Location = New System.Drawing.Point(15, 86)
        Me.radZhipengLi.Name = "radZhipengLi"
        Me.radZhipengLi.Size = New System.Drawing.Size(129, 21)
        Me.radZhipengLi.TabIndex = 0
        Me.radZhipengLi.TabStop = True
        Me.radZhipengLi.Text = "Zhipeng Li"
        Me.radZhipengLi.UseVisualStyleBackColor = True
        '
        'radDanilaY
        '
        Me.radDanilaY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.radDanilaY.Location = New System.Drawing.Point(15, 60)
        Me.radDanilaY.Name = "radDanilaY"
        Me.radDanilaY.Size = New System.Drawing.Size(137, 20)
        Me.radDanilaY.TabIndex = 0
        Me.radDanilaY.TabStop = True
        Me.radDanilaY.Text = "Danila Yajimchuk"
        Me.radDanilaY.UseVisualStyleBackColor = True
        '
        'radDavidB
        '
        Me.radDavidB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.radDavidB.Location = New System.Drawing.Point(15, 33)
        Me.radDavidB.Name = "radDavidB"
        Me.radDavidB.Size = New System.Drawing.Size(129, 17)
        Me.radDavidB.TabIndex = 0
        Me.radDavidB.TabStop = True
        Me.radDavidB.Text = "David Bushnell"
        Me.radDavidB.UseVisualStyleBackColor = True
        '
        'lblWrittenBy
        '
        Me.lblWrittenBy.BackColor = System.Drawing.Color.Transparent
        Me.lblWrittenBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrittenBy.Location = New System.Drawing.Point(98, 301)
        Me.lblWrittenBy.Name = "lblWrittenBy"
        Me.lblWrittenBy.Size = New System.Drawing.Size(155, 70)
        Me.lblWrittenBy.TabIndex = 1
        Me.lblWrittenBy.Text = "Written by:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ryu Muthui" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CS115 Section B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "October 25, 2012" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblWrittenBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFavoriteFilms
        '
        Me.lblFavoriteFilms.BackColor = System.Drawing.Color.Transparent
        Me.lblFavoriteFilms.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavoriteFilms.Location = New System.Drawing.Point(177, 18)
        Me.lblFavoriteFilms.Name = "lblFavoriteFilms"
        Me.lblFavoriteFilms.Size = New System.Drawing.Size(269, 23)
        Me.lblFavoriteFilms.TabIndex = 3
        Me.lblFavoriteFilms.Text = "Classmate's Favorite Films:"
        Me.lblFavoriteFilms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(108, 383)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 27)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picFilmPoster
        '
        Me.picFilmPoster.BackColor = System.Drawing.Color.Transparent
        Me.picFilmPoster.BackgroundImage = CType(resources.GetObject("picFilmPoster.BackgroundImage"), System.Drawing.Image)
        Me.picFilmPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFilmPoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picFilmPoster.Location = New System.Drawing.Point(292, 44)
        Me.picFilmPoster.Name = "picFilmPoster"
        Me.picFilmPoster.Size = New System.Drawing.Size(212, 232)
        Me.picFilmPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFilmPoster.TabIndex = 6
        Me.picFilmPoster.TabStop = False
        '
        'lblInformation
        '
        Me.lblInformation.BackColor = System.Drawing.Color.Transparent
        Me.lblInformation.Location = New System.Drawing.Point(233, 279)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(299, 160)
        Me.lblInformation.TabIndex = 7
        '
        'frmFavoriteFilms
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.Favorite_Films.My.Resources.Resources.ImgFilmStrip
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(620, 448)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.picFilmPoster)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblFavoriteFilms)
        Me.Controls.Add(Me.lblWrittenBy)
        Me.Controls.Add(Me.grpClassmates)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmFavoriteFilms"
        Me.Text = "Favorite Films"
        Me.grpClassmates.ResumeLayout(False)
        CType(Me.picFilmPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpClassmates As System.Windows.Forms.GroupBox
    Friend WithEvents lblWrittenBy As System.Windows.Forms.Label
    Friend WithEvents lblFavoriteFilms As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents chkBold As System.Windows.Forms.CheckBox
    Friend WithEvents radClearAll As System.Windows.Forms.RadioButton
    Friend WithEvents radRussellB As System.Windows.Forms.RadioButton
    Friend WithEvents radNasirE As System.Windows.Forms.RadioButton
    Friend WithEvents radZhipengLi As System.Windows.Forms.RadioButton
    Friend WithEvents radDanilaY As System.Windows.Forms.RadioButton
    Friend WithEvents radDavidB As System.Windows.Forms.RadioButton
    Friend WithEvents picFilmPoster As System.Windows.Forms.PictureBox
    Friend WithEvents lblInformation As System.Windows.Forms.Label

End Class
