
'========================================================================================
'Project:           Lab 1
'Title:             Halloween Picture Project
'File Name:         HalloweenPics.vb
'Date completed:    November 16, 2012.
'Authors:           Ryu Muthui and Nasir Elmi
'Class:             CS 115 Section B
'Description:       This project is a manual Halloween Graphics program for use at 
'                   parties to project a different image for the person currently singing
'                   karaoke. The program includes on a form, 3 buttons, 4 labels, 4 check
'                   boxes, 2 panels, a group box, 11 picture boxes, and 12 radio buttons.
'                   The user can select each of the radio buttons to display the
'                   corresponding graphics on the panel. Selecting the No picture clears
'                   the graphics from the panel. They can choose to run the program in
'                   full screen or default window size. Selecting the check boxes will
'                   change the radio button font styles as well as the color. Selecting
'                   the Change Background button will cycle through various background
'                   images, to be paired freely with the chosen graphics. The audience
'                   will only see what’s displayed in the panel but the user can see all
'                   of the objects on the form. The user can exit the program via the
'                   Shut Down button.
'========================================================================================

Option Explicit On
Option Strict On


Public Class frmHalloweenPics

    '------------------------------------------------------------------------------------
    'Description: These are declared class wide Boolean variables to be used in checkbox
    '             combinations for new font style options, so that each combination of 
    '             checkboxes when checked/unchecked can work at the same time. There is 
    '             also a declared integer variable to be used in change background image 
    '             button.
    '------------------------------------------------------------------------------------


    Dim cblnBold As Boolean = False
    Dim cblnUnderline As Boolean = False
    Dim cblnLargeFont As Boolean = False

    Dim cintBackground As Integer


    Private Sub btnShutDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnShutDown.Click
        '--------------------------------------------------------------------------------
        'Description: Click to end the program.
        '--------------------------------------------------------------------------------

        Me.Close()

    End Sub

    Private Sub btnFullScreen_Click(ByVal sender As Object, ByVal e As  _
        System.EventArgs) Handles btnFullScreen.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will make the form's window size to full screen 
        '             and back to normal. When in full screen, it will center all objects
        '             on the form to the center of screen then back to normal. The form's
        '             border style is hidden to prevent the user from encountering a
        '             potential issue. The button's text is also changed accordingly.
        '--------------------------------------------------------------------------------

        If WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Maximized

            btnFullScreen.Text = "E&xit Full Screen"

            pnlContainAll.Left = CInt((Me.Width - pnlContainAll.Width) / 2)
            pnlContainAll.Top = CInt((Me.Height - pnlContainAll.Height) / 2)

            FormBorderStyle = Windows.Forms.FormBorderStyle.None

        Else

            Me.WindowState = FormWindowState.Normal

            btnFullScreen.Text = "Full Sc&reen"

            Dim x As Integer = 0
            Dim y As Integer = 0
            pnlContainAll.Location = New Point(x, y)

            FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

        End If

    End Sub

    Private Sub btnChgBckgrnd_Click(ByVal sender As Object, ByVal e As System. _
        EventArgs) Handles btnChgBckgrnd.Click
        '--------------------------------------------------------------------------------
        'Description: When the button is clicked each time, it will change the background
        '             images on pnlGraphics. It will cycle through 6 different background
        '             images then back to no image.
        '--------------------------------------------------------------------------------

        If cintBackground >= 7 Then

            cintBackground = 0

        Else

            cintBackground += 1

            Select Case cintBackground

                Case 1

                    lblBckgrndNum.Text = "1"
                    pnlGraphics.BackgroundImage = My.Resources.Background1

                Case 2

                    lblBckgrndNum.Text = "2"
                    pnlGraphics.BackgroundImage = My.Resources.Background2


                Case 3

                    lblBckgrndNum.Text = "3"
                    pnlGraphics.BackgroundImage = My.Resources.Background3

                Case 4

                    lblBckgrndNum.Text = "4"
                    pnlGraphics.BackgroundImage = My.Resources.Background4

                Case 5

                    lblBckgrndNum.Text = "5"
                    pnlGraphics.BackgroundImage = My.Resources.Background5

                Case 6

                    lblBckgrndNum.Text = "6"
                    pnlGraphics.BackgroundImage = My.Resources.Background6

                Case Else

                    lblBckgrndNum.Text() = "Nothing"
                    pnlGraphics.BackgroundImage = Nothing

            End Select

        End If

    End Sub

    Private Sub chkBold_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles chkBold.Click
        '--------------------------------------------------------------------------------
        'Description: When checkbox Bold is checked, it will change the Font Style of all
        '             the radio button texts to be bold. It also checks for all other
        '             possible combinations of checkboxes checked so that they can all
        '             work at the same time.
        '--------------------------------------------------------------------------------

        If chkBold.Checked Then

            cblnBold = True

            If cblnLargeFont And cblnUnderline = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Bold Or FontStyle.Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold Or _
                    FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold Or _
                    FontStyle.Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Bold Or FontStyle.Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)

            ElseIf cblnLargeFont = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Bold)

            ElseIf cblnUnderline = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold Or _
                    FontStyle.Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold Or _
                    FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold Or _
                    FontStyle.Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold Or _
                    FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold Or _
                    FontStyle.Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold Or _
                    FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold Or _
                    FontStyle.Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Bold Or FontStyle.Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)

            Else

                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Bold)

            End If

        Else

            cblnBold = False

            If cblnLargeFont And cblnUnderline = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular Or FontStyle.Underline)
                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular Or FontStyle.Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular Or FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular _
                    Or FontStyle.Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular Or FontStyle.Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular _
                    Or FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular _
                    Or FontStyle.Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular Or FontStyle.Underline)
                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular _
                    Or FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular Or _
                    FontStyle.Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular Or FontStyle.Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular Or FontStyle.Underline)

            ElseIf cblnLargeFont = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)

            ElseIf cblnUnderline = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular _
                    Or FontStyle.Underline)
                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular _
                    Or FontStyle.Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular _
                    Or FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular _
                    Or FontStyle.Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular Or FontStyle.Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular _
                    Or FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular _
                    Or FontStyle.Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular Or FontStyle.Underline)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular _
                    Or FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular _
                    Or FontStyle.Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular Or FontStyle.Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular Or FontStyle.Underline)

            Else

                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular)

            End If

        End If

    End Sub


    Private Sub chkLargeFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles chkLargeFont.Click
        '--------------------------------------------------------------------------------
        'Description: When checkbox Large Font is checked, it will change the Font Style 
        '             of all the radio button texts to be a larger font. It also checks 
        '             for all other possible combinations of checkboxes checked so that 
        '             they can all work at the same time.
        '--------------------------------------------------------------------------------

        If chkLargeFont.Checked Then

            cblnLargeFont = True

            If cblnUnderline And cblnBold = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Bold Or FontStyle.Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)

            ElseIf cblnBold = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Bold)

            ElseIf cblnUnderline = True Then

                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Underline)
                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)

            Else

                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)

            End If

        Else

            cblnLargeFont = False

            If cblnUnderline And cblnBold = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Bold Or FontStyle.Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)

            ElseIf cblnUnderline = True Then

                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)
                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)

            ElseIf cblnBold = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Bold)

            Else

                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular)

            End If

        End If

    End Sub

    Private Sub chkUnderline_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles chkUnderline.Click
        '--------------------------------------------------------------------------------
        'Description: When checkbox underline is checked, it will change the Font Style 
        '             of all the radio button texts to be underlined. It also checks 
        '             for all other possible combinations of checkboxes checked so that 
        '             they can all work at the same time.
        '--------------------------------------------------------------------------------

        If chkUnderline.Checked Then

            cblnUnderline = True

            If cblnLargeFont And cblnBold = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Bold Or FontStyle.Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold _
                    Or FontStyle.Underline)

            ElseIf cblnBold = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Bold Or FontStyle.Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold _
                    Or FontStyle.Underline)

            ElseIf cblnLargeFont = True Then

                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Underline)
                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Underline)
                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Underline)

            Else

                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Underline)

            End If

        Else

            cblnUnderline = False

            If cblnLargeFont And cblnBold = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Bold)

            ElseIf cblnLargeFont = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radGhost.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radVampire.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radWitch.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radPirate.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radDevil.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radMummy.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radBat.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 10, FontStyle. _
                    Regular)

            ElseIf cblnBold = True Then

                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Bold)

            Else

                radPumpkin.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radGhost.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radVampire.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radWitch.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radPirate.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radDevil.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radBlackCat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radMummy.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radBat.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                radFrankenstein.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular)
                radNoPicture.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular)
                radScareCrow.Font = New Font("Microsoft Sans Serif", 8, FontStyle. _
                    Regular)
            End If

        End If

    End Sub


    Private Sub chkColorCoord_Click(ByVal sender As Object, ByVal e As System. _
        EventArgs) Handles chkColorCoord.Click
        '--------------------------------------------------------------------------------
        'Description: When Change Color is checked, it will change the Back Color of the  
        '             form to Nothing and the radio button texts to Orange for more 
        '             visibility. When unchecked, the form background image is restored 
        '             the text is reverted to default state.
        '--------------------------------------------------------------------------------

        If chkColorCoord.Checked = True Then

            radPumpkin.ForeColor = Color.DarkOrange
            radGhost.ForeColor = Color.DarkOrange
            radVampire.ForeColor = Color.DarkOrange
            radWitch.ForeColor = Color.DarkOrange
            radScareCrow.ForeColor = Color.DarkOrange
            radPirate.ForeColor = Color.DarkOrange
            radDevil.ForeColor = Color.DarkOrange
            radBlackCat.ForeColor = Color.DarkOrange
            radMummy.ForeColor = Color.DarkOrange
            radBat.ForeColor = Color.DarkOrange
            radFrankenstein.ForeColor = Color.DarkOrange
            radNoPicture.ForeColor = Color.DarkOrange

            Me.BackgroundImage = Nothing

        Else

            radPumpkin.ForeColor = Color.White
            radGhost.ForeColor = Color.White
            radVampire.ForeColor = Color.White
            radWitch.ForeColor = Color.White
            radScareCrow.ForeColor = Color.White
            radPirate.ForeColor = Color.White
            radDevil.ForeColor = Color.White
            radBlackCat.ForeColor = Color.White
            radMummy.ForeColor = Color.White
            radBat.ForeColor = Color.White
            radFrankenstein.ForeColor = Color.White
            radNoPicture.ForeColor = Color.White

            Me.BackgroundImage = Image.FromFile("..\Graphics\DefaultBackGround.jpg")

        End If

    End Sub

    Private Sub radPumpkin_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles radPumpkin.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will display the image of the Pumpkin and set the
        '             location of where it will be dispalyed on the panel. All other
        '             images are set to not display.
        '--------------------------------------------------------------------------------

        Dim x As Integer = 429
        Dim y As Integer = 334
        picPumpkin.Location = New Point(x, y)

        picPumpkin.Visible = True
        picGhost.Visible = False
        picVampire.Visible = False
        picWitch.Visible = False
        picScareCrow.Visible = False
        picPirate.Visible = False
        picDevil.Visible = False
        picBlackCat.Visible = False
        picMummy.Visible = False
        picBat.Visible = False
        picFrankenstein.Visible = False

    End Sub


    Private Sub radGhost_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
 Handles radGhost.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will display the image of the Ghost and set the
        '             location of where it will be dispalyed on the panel. All other
        '             images are set to not display.
        '--------------------------------------------------------------------------------
        Dim x As Integer = 30
        Dim y As Integer = 335
        picGhost.Location = New Point(x, y)

        picPumpkin.Visible = False
        picGhost.Visible = True
        picVampire.Visible = False
        picWitch.Visible = False
        picScareCrow.Visible = False
        picPirate.Visible = False
        picDevil.Visible = False
        picBlackCat.Visible = False
        picMummy.Visible = False
        picBat.Visible = False
        picFrankenstein.Visible = False

    End Sub

    Private Sub radVampire_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles radVampire.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will display the image of the Vampire and set the
        '             location of where it will be dispalyed on the panel. All other
        '             images are set to not display.
        '--------------------------------------------------------------------------------
        Dim x As Integer = 387
        Dim y As Integer = 328
        picVampire.Location = New Point(x, y)

        picPumpkin.Visible = False
        picGhost.Visible = False
        picVampire.Visible = True
        picWitch.Visible = False
        picScareCrow.Visible = False
        picPirate.Visible = False
        picDevil.Visible = False
        picBlackCat.Visible = False
        picMummy.Visible = False
        picBat.Visible = False
        picFrankenstein.Visible = False

    End Sub

    Private Sub radWitch_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles radWitch.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will display the image of the Witch and set the
        '             location of where it will be dispalyed on the panel. All other
        '             images are set to not display.
        '--------------------------------------------------------------------------------
        Dim x As Integer = 76
        Dim y As Integer = 268
        picWitch.Location = New Point(x, y)

        picPumpkin.Visible = False
        picGhost.Visible = False
        picVampire.Visible = False
        picWitch.Visible = True
        picScareCrow.Visible = False
        picPirate.Visible = False
        picDevil.Visible = False
        picBlackCat.Visible = False
        picMummy.Visible = False
        picBat.Visible = False
        picFrankenstein.Visible = False

    End Sub

    Private Sub radScareCrow_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles radScareCrow.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will display the image of the Scare Crow and set 
        '             the location of where it will be dispalyed on the panel. All other
        '             images are set to not display.
        '--------------------------------------------------------------------------------
        Dim x As Integer = 76
        Dim y As Integer = 268
        picScareCrow.Location = New Point(x, y)

        picPumpkin.Visible = False
        picGhost.Visible = False
        picVampire.Visible = False
        picWitch.Visible = False
        picScareCrow.Visible = True
        picPirate.Visible = False
        picDevil.Visible = False
        picBlackCat.Visible = False
        picMummy.Visible = False
        picBat.Visible = False
        picFrankenstein.Visible = False

    End Sub

    Private Sub radPirate_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles radPirate.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will display the image of the Pirate and set the
        '             location of where it will be dispalyed on the panel. All other
        '             images are set to not display.
        '--------------------------------------------------------------------------------
        Dim x As Integer = 76
        Dim y As Integer = 268
        picPirate.Location = New Point(x, y)

        picPumpkin.Visible = False
        picGhost.Visible = False
        picVampire.Visible = False
        picWitch.Visible = False
        picScareCrow.Visible = False
        picPirate.Visible = True
        picDevil.Visible = False
        picBlackCat.Visible = False
        picMummy.Visible = False
        picBat.Visible = False
        picFrankenstein.Visible = False

    End Sub

    Private Sub radDevil_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles radDevil.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will display the image of the Devil and set the
        '             location of where it will be dispalyed on the panel. All other
        '             images are set to not display.
        '--------------------------------------------------------------------------------
        Dim x As Integer = 76
        Dim y As Integer = 268
        picDevil.Location = New Point(x, y)

        picPumpkin.Visible = False
        picGhost.Visible = False
        picVampire.Visible = False
        picWitch.Visible = False
        picScareCrow.Visible = False
        picPirate.Visible = False
        picDevil.Visible = True
        picBlackCat.Visible = False
        picMummy.Visible = False
        picBat.Visible = False
        picFrankenstein.Visible = False

    End Sub

    Private Sub radBlackCat_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles radBlackCat.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will display the image of the Black Cat and set 
        '             the location of where it will be dispalyed on the panel. All other
        '             images are set to not display.
        '--------------------------------------------------------------------------------
        Dim x As Integer = 47
        Dim y As Integer = 228
        picBlackCat.Location = New Point(x, y)

        picPumpkin.Visible = False
        picGhost.Visible = False
        picVampire.Visible = False
        picWitch.Visible = False
        picScareCrow.Visible = False
        picPirate.Visible = False
        picDevil.Visible = False
        picBlackCat.Visible = True
        picMummy.Visible = False
        picBat.Visible = False
        picFrankenstein.Visible = False

    End Sub

    Private Sub radMummy_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles radMummy.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will display the image of the Mummy and set the
        '             location of where it will be dispalyed on the panel. All other
        '             images are set to not display.
        '--------------------------------------------------------------------------------
        Dim x As Integer = 180
        Dim y As Integer = 330
        picMummy.Location = New Point(x, y)

        picPumpkin.Visible = False
        picGhost.Visible = False
        picVampire.Visible = False
        picWitch.Visible = False
        picScareCrow.Visible = False
        picPirate.Visible = False
        picDevil.Visible = False
        picBlackCat.Visible = False
        picMummy.Visible = True
        picBat.Visible = False
        picFrankenstein.Visible = False

    End Sub

    Private Sub radBat_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles radBat.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will display the image of the Bat and set the
        '             location of where it will be dispalyed on the panel. All other
        '             images are set to not display.
        '--------------------------------------------------------------------------------
        Dim x As Integer = 110
        Dim y As Integer = 4
        picBat.Location = New Point(x, y)

        picPumpkin.Visible = False
        picGhost.Visible = False
        picVampire.Visible = False
        picWitch.Visible = False
        picScareCrow.Visible = False
        picPirate.Visible = False
        picDevil.Visible = False
        picBlackCat.Visible = False
        picMummy.Visible = False
        picBat.Visible = True
        picFrankenstein.Visible = False

    End Sub

    Private Sub radFrankenstein_Click(ByVal sender As Object, ByVal e As  _
        System.EventArgs) Handles radFrankenstein.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will display the image of the Frankenstein and set
        '             the location of where it will be dispalyed on the panel. All other
        '             images are set to not display.
        '--------------------------------------------------------------------------------
        Dim x As Integer = 29
        Dim y As Integer = 334
        picFrankenstein.Location = New Point(x, y)

        picPumpkin.Visible = False
        picGhost.Visible = False
        picVampire.Visible = False
        picWitch.Visible = False
        picScareCrow.Visible = False
        picPirate.Visible = False
        picDevil.Visible = False
        picBlackCat.Visible = False
        picMummy.Visible = False
        picBat.Visible = False
        picFrankenstein.Visible = True

    End Sub

    Private Sub radNoPicture_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles radNoPicture.Click
        '--------------------------------------------------------------------------------
        'Description: When clicked, it will set all images to not display.
        '--------------------------------------------------------------------------------

        picPumpkin.Visible = False
        picGhost.Visible = False
        picVampire.Visible = False
        picWitch.Visible = False
        picScareCrow.Visible = False
        picPirate.Visible = False
        picDevil.Visible = False
        picBlackCat.Visible = False
        picMummy.Visible = False
        picBat.Visible = False
        picFrankenstein.Visible = False

    End Sub


End Class
