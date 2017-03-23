'========================================================================================
'Project:           Lab 2
'Title:             Movie and Music Project
'File Name:         Movie and Music Store.vb
'Date completed:    December 07, 2012.
'Authors:           Ryu Muthui, Nasir Elmi, Jan Kruschewski, Gil Chavez.
'Class:             CS 115 Section B
'
'Description:       This program is a virtual shopping program that the user can 
'                   select various holiday themed media items to buy. On a form
'                   there is a panel that will contain all control objects for a full 
'                   screen feature. The user can begin by selecting from either the Music
'                   or Movie category. Selecting a category will display the available 
'                   items in the lstProductsForSale list box to choose from. Once an item
'                   has been selected, it's item details will be displayed in the
'                   pnlDetails with all available item informatiom (Item Name, Price,
'                   Item Picture, Description, and Media type). From the Details Panel
'                   they can enter the amount they wish to purchase. This will add the
'                   selected item and its quantity to the Shopping Cart/Price list boxes
'                   to keep track. In the Shopping Cart, they can see their selected
'                   items with the price and subtotal price. They can remove any specific
'                   item(s) and or clear the entire shopping cart. When they choose to
'                   checkout, the total cost is displayed. Other side features include a 
'                   Search Bar function that can search for specific items by key words.
'                   There is a full screen feature that centers the contain all panel to
'                   the center of the screen. They can cycle through various backgrounds
'                   with the change background feature. There is also a scrolling
'                   banner feature to inform the store's special deals.
'========================================================================================
Option Strict On
Option Explicit On

Public Class frmHolidayMoviesAndMusicStore
    '--------------------------------------------------------------------------------
    'Description:   These are class wide declared variables that will be used through
    '               out the program.              
    '--------------------------------------------------------------------------------

    Const cintMaxArray As Integer = 150
    Const cstrPATH As String = "..\DataFiles\"
    Dim cstrFileItemsName(cintMaxArray) As String
    Dim cintAnimated(cintMaxArray) As Integer
    Dim cstrFileNames(cintMaxArray) As String
    Dim cintLineCount(cintMaxArray) As Integer
    Dim cstrMediaType(cintMaxArray) As String
    Dim cstrCategory(cintMaxArray) As String
    Dim cstrDvdCd(cintMaxArray) As String
    Dim cstrDescription(cintMaxArray) As String
    Dim csngPrice(cintMaxArray) As String
    Dim cstrPictureFile(cintMaxArray) As String
    Dim csngSubTotal As Single
    Dim csngTotal As Single
    Dim csngTax As Single = 1.095
    Dim i As Integer
    Dim cintTotalFiles As Integer
    Dim cintBackground As Integer
    Dim cintSearch(cintMaxArray) As Integer

    Private Sub frmHolidayMoviesAndMusicStore_Load(ByVal sender As Object, ByVal e As  _
        System.EventArgs) Handles MyBase.Load
        '--------------------------------------------------------------------------------
        'Description:   This load sub is used to number all the .mmf files using the
        '               list.mmf. The files will be opened and their contents are
        '               then saved to a corresponding array depending on the data's use.
        '               It will then set the SubTotal and Total texts to 0 and add text
        '               to the lstProductsForSale list box.
        '--------------------------------------------------------------------------------

        Dim strTemp As String = ""
        Dim i As Integer
        Dim j As Integer

        FileOpen(1, cstrPATH & "list.mmf", OpenMode.Input)
        Input(1, strTemp)
        cintTotalFiles = CInt(strTemp) - 1
        Do Until EOF(1) = True
            Input(1, cstrFileNames(i))
            i += 1

        Loop
        FileClose(1)

        For i = 0 To cintTotalFiles - 1
            FileOpen(1, cstrPATH & cstrFileNames(i), OpenMode.Input)
            Input(1, strTemp)

            cintLineCount(i) = CInt(strTemp)
            Input(1, strTemp)

            cstrMediaType(i) = strTemp
            Input(1, strTemp)

            cstrCategory(i) = strTemp
            cstrFileItemsName(i) = LineInput(1)
            Input(1, strTemp)
            Input(1, strTemp)

            cstrDvdCd(i) = strTemp
            Input(1, strTemp)

            For j = 7 To cintLineCount(i) - 4
                cstrDescription(i) &= LineInput(1)
            Next j
            Input(1, strTemp)

            Input(1, strTemp)
            csngPrice(i) = CStr(CSng(strTemp))
            Input(1, strTemp)
            cstrPictureFile(i) = strTemp
            FileClose(1)

        Next i

        lstProductsForSale.Items.Add("Please select a category to browse from.")
        lblSubTotalDisplay.Text = "0"
        lblTotalCostDisplay.Text = "0"

    End Sub

    Private Sub lstProductsForSale_Click(ByVal sender As Object, ByVal e As System. _
        EventArgs) Handles lstProductsForSale.Click
        '--------------------------------------------------------------------------------
        'Description:   It will clear the Rich text box of any descreption text, and set
        '               the txtbox for amount to display "1" as the default count. If the
        '               user does not select an item from the shopping list, it will show
        '               a message box. It will then Displays product info of description,
        '               price, picture, item name, and media type on the details panel. 
        '--------------------------------------------------------------------------------

        Dim strIndex As String
        Dim i As Integer

        rtfDetails.Clear()
        txtAmount.Text = "1"

        If lstProductsForSale.SelectedIndex = -1 Then

            lstProductsForSale.SelectedIndex = 0
            MessageBox.Show("Please select a category to browse from.")

        End If

        strIndex = lstProductsForSale.SelectedItem.ToString

        For i = 0 To cintTotalFiles - 1
            If strIndex = cstrFileItemsName(i) Then
                rtfDetails.Text = cstrDescription(i)
                picDetails.Image = Image.FromFile(cstrPATH & cstrPictureFile(i))
                lblPrice.Text = FormatCurrency(csngPrice(i))
                lblItemName.Text = cstrFileItemsName(i)
                lblMediaType.Text = "Media Type: " & cstrDvdCd(i)
            End If
        Next

    End Sub

    Private Sub btnFullScreen_Click(ByVal sender As Object, ByVal e As System. _
        EventArgs) Handles btnFullScreen.Click
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

    Private Sub btnAnimated_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnAnimated.Click
        '--------------------------------------------------------------------------------
        'Description:   When the user clicks, it will clear the text box for the search
        '               bar. It also clears the lstProductsForSale of any items so that
        '               the current set of items can be displayed. It will then run a For
        '               loop to check against the cstrFileNames array for all files that
        '               are in the Animated category and display them in the
        '               lstProductsForSale list box.              
        '--------------------------------------------------------------------------------

        txtSearch.Text = Nothing
        lstProductsForSale.Items.Clear()

        For i = 0 To cstrFileNames.Length - 1
            If cstrCategory(i) = "Animated" Then
                lstProductsForSale.Items.Add(cstrFileItemsName(i))
            End If
        Next i

    End Sub

    Private Sub btnComedy_Click(ByVal sender As System.Object, ByVal e As System. _
        EventArgs) Handles btnComedy.Click
        '--------------------------------------------------------------------------------
        'Description:   When the user clicks, it will clear the text box for the search
        '               bar. It also clears the lstProductsForSale of any items so that
        '               the current set of items can be displayed. It will then run a For
        '               loop to check against the cstrFileNames array for all files that
        '               are in the Comedy category and display them in the
        '               lstProductsForSale list box.              
        '--------------------------------------------------------------------------------

        txtSearch.Text = Nothing
        lstProductsForSale.Items.Clear()

        For i = 0 To cstrFileNames.Length - 1
            If cstrCategory(i) = "Comedy" Then
                lstProductsForSale.Items.Add(cstrFileItemsName(i))
            End If
        Next i

    End Sub

    Private Sub btnFamilyKids_Click(ByVal sender As System.Object, ByVal e As System. _
        EventArgs) Handles btnFamilyKids.Click
        '--------------------------------------------------------------------------------
        'Description:   When the user clicks, it will clear the text box for the search
        '               bar. It also clears the lstProductsForSale of any items so that
        '               the current set of items can be displayed. It will then run a For
        '               loop to check against the cstrFileNames array for all files that
        '               are in the Family/Kids category and display them in the
        '               lstProductsForSale list box.              
        '--------------------------------------------------------------------------------

        txtSearch.Text = Nothing
        lstProductsForSale.Items.Clear()

        For i = 0 To cstrFileNames.Length - 1
            If cstrCategory(i) = "Family / Kids" Then
                lstProductsForSale.Items.Add(cstrFileItemsName(i))
            End If
        Next i

    End Sub

    Private Sub btnActionAdventure_Click(ByVal sender As System.Object, ByVal e As  _
        System.EventArgs) Handles btnActionAdventure.Click
        '--------------------------------------------------------------------------------
        'Description:   When the user clicks, it will clear the text box for the search
        '               bar. It also clears the lstProductsForSale of any items so that
        '               the current set of items can be displayed. It will then run a For
        '               loop to check against the cstrFileNames array for all files that
        '               are in the Action/Adventure category and display them in the
        '               lstProductsForSale list box.              
        '--------------------------------------------------------------------------------

        txtSearch.Text = Nothing
        lstProductsForSale.Items.Clear()

        For i = 0 To cstrFileNames.Length - 1
            If cstrCategory(i) = "Action/Adventure" Then
                lstProductsForSale.Items.Add(cstrFileItemsName(i))
            End If
        Next i

    End Sub

    Private Sub btnRomantic_Click(ByVal sender As System.Object, ByVal e As System. _
        EventArgs) Handles btnRomantic.Click
        '--------------------------------------------------------------------------------
        'Description:   When the user clicks, it will clear the text box for the search
        '               bar. It also clears the lstProductsForSale of any items so that
        '               the current set of items can be displayed. It will then run a For
        '               loop to check against the cstrFileNames array for all files that
        '               are in the Romatic category and display them in the
        '               lstProductsForSale list box.              
        '--------------------------------------------------------------------------------

        txtSearch.Text = Nothing
        lstProductsForSale.Items.Clear()

        For i = 0 To cstrFileNames.Length - 1
            If cstrCategory(i) = "Romantic" Then
                lstProductsForSale.Items.Add(cstrFileItemsName(i))
            End If
        Next i

    End Sub

    Private Sub btnSciFi_Click(ByVal sender As System.Object, ByVal e As System. _
        EventArgs) Handles btnSciFi.Click
        '--------------------------------------------------------------------------------
        'Description:   When the user clicks, it will clear the text box for the search
        '               bar. It also clears the lstProductsForSale of any items so that
        '               the current set of items can be displayed. It will then run a For
        '               loop to check against the cstrFileNames array for all files that
        '               are in the Sci-Fi category and display them in the
        '               lstProductsForSale list box.              
        '--------------------------------------------------------------------------------

        txtSearch.Text = Nothing
        lstProductsForSale.Items.Clear()

        For i = 0 To cstrFileNames.Length - 1
            If cstrCategory(i) = "Sci Fi" Then
                lstProductsForSale.Items.Add(cstrFileItemsName(i))
            End If
        Next i

    End Sub

    Private Sub btnCountry_Click(ByVal sender As System.Object, ByVal e As System. _
        EventArgs) Handles btnCountry.Click
        '--------------------------------------------------------------------------------
        'Description:   When the user clicks, it will clear the text box for the search
        '               bar. It also clears the lstProductsForSale of any items so that
        '               the current set of items can be displayed. It will then run a For
        '               loop to check against the cstrFileNames array for all files that
        '               are in the Country category and display them in the
        '               lstProductsForSale list box.              
        '--------------------------------------------------------------------------------

        txtSearch.Text = Nothing
        lstProductsForSale.Items.Clear()

        For i = 0 To cstrFileNames.Length - 1
            If cstrCategory(i) = "Country" Then
                lstProductsForSale.Items.Add(cstrFileItemsName(i))
            End If
        Next i

    End Sub

    Private Sub btnJazz_Click(ByVal sender As System.Object, ByVal e As System. _
        EventArgs) Handles btnJazz.Click
        '--------------------------------------------------------------------------------
        'Description:   When the user clicks, it will clear the text box for the search
        '               bar. It also clears the lstProductsForSale of any items so that
        '               the current set of items can be displayed. It will then run a For
        '               loop to check against the cstrFileNames array for all files that
        '               are in the Jazz category and display them in the
        '               lstProductsForSale list box.              
        '--------------------------------------------------------------------------------

        txtSearch.Text = Nothing
        lstProductsForSale.Items.Clear()

        For i = 0 To cstrFileNames.Length - 1
            If cstrCategory(i) = "Jazz" Then
                lstProductsForSale.Items.Add(cstrFileItemsName(i))
            End If
        Next i

    End Sub

    Private Sub btnRock_Click(ByVal sender As System.Object, ByVal e As System. _
        EventArgs) Handles btnRock.Click
        '--------------------------------------------------------------------------------
        'Description:   When the user clicks, it will clear the text box for the search
        '               bar. It also clears the lstProductsForSale of any items so that
        '               the current set of items can be displayed. It will then run a For
        '               loop to check against the cstrFileNames array for all files that
        '               are in the Rock category and display them in the
        '               lstProductsForSale list box.              
        '--------------------------------------------------------------------------------

        txtSearch.Text = Nothing
        lstProductsForSale.Items.Clear()

        For i = 0 To cstrFileNames.Length - 1
            If cstrCategory(i) = "Rock" Then
                lstProductsForSale.Items.Add(cstrFileItemsName(i))
            End If
        Next i

    End Sub

    Private Sub btnClassical_Click(ByVal sender As System.Object, ByVal e As System. _
        EventArgs) Handles btnClassical.Click
        '--------------------------------------------------------------------------------
        'Description:   When the user clicks, it will clear the text box for the search
        '               bar. It also clears the lstProductsForSale of any items so that
        '               the current set of items can be displayed. It will then run a For
        '               loop to check against the cstrFileNames array for all files that
        '               are in the Classical category and display them in the
        '               lstProductsForSale list box.              
        '--------------------------------------------------------------------------------

        txtSearch.Text = Nothing
        lstProductsForSale.Items.Clear()

        For i = 0 To cstrFileNames.Length - 1
            If cstrCategory(i) = "Classical" Then
                lstProductsForSale.Items.Add(cstrFileItemsName(i))
            End If
        Next i

    End Sub

    Private Sub btnRB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnRB.Click
        '--------------------------------------------------------------------------------
        'Description:   When the user clicks, it will clear the text box for the search
        '               bar. It also clears the lstProductsForSale of any items so that
        '               the current set of items can be displayed. It will then run a For
        '               loop to check against the cstrFileNames array for all files that
        '               are in the R & B category and display them in the
        '               lstProductsForSale list box.              
        '--------------------------------------------------------------------------------

        txtSearch.Text = Nothing
        lstProductsForSale.Items.Clear()

        For i = 0 To cstrFileNames.Length - 1
            If cstrCategory(i) = "R&B" Then
                lstProductsForSale.Items.Add(cstrFileItemsName(i))
            End If
        Next i

    End Sub

    Private Sub btnRemoveItem_Click(ByVal sender As Object, ByVal e As System. _
        EventArgs) Handles btnRemoveItem.Click
        '--------------------------------------------------------------------------------
        'Description:   When clicked, it will allow the user to remove the selected item
        '               in the lstShoppingCart. It will subtrack the price of the item
        '               removed and calculate the subtotal price. If the user doesn't
        '               make valid selections, it will show a message box with the error.
        '--------------------------------------------------------------------------------

        If lstShoppingCart.SelectedIndex <> -1 Then

            lstPrices.SelectedIndex = lstShoppingCart.SelectedIndex

            lstShoppingCart.Items.RemoveAt(lstShoppingCart.SelectedIndex)
            lstPrices.Items.RemoveAt(lstPrices.SelectedIndex)
            lblSubTotalDisplay.Text = "0"
            csngSubTotal = 0

            For i = 0 To lstPrices.Items.Count - 1
                csngSubTotal += CSng(lstPrices.Items(i))
                lblSubTotalDisplay.Text = FormatCurrency(csngSubTotal)
                lblTotalCostDisplay.Text = "0"
            Next i

        ElseIf lstShoppingCart.SelectedIndex = -1 Then

            MessageBox.Show("Please select an item to remove from the shopping cart.")

        End If

    End Sub

    Function fPricing(ByVal csngSubTotal As Single) As Single
        '--------------------------------------------------------------------------------
        'Description:   This function calculates the subtotal with the tax rate applied.
        'Called by:     btnCalcTotal_Click
        '--------------------------------------------------------------------------------

        csngTotal = csngSubTotal * csngTax
        Return csngTotal

    End Function

    Private Sub btnAddtoCart_Click(ByVal sender As System.Object, ByVal e As System. _
        EventArgs) Handles btnAddtoCart.Click
        '--------------------------------------------------------------------------------
        'Description:   This sub will add the selected item from lstProductsForSale and
        '               add it to the ShoppingCart/Price lists. It uses the pricing
        '               Loop to keep tally of a subtotal cost and display the subtolal on
        '               the lblSubTotalDisplay. It also handles user input errors.            
        '--------------------------------------------------------------------------------

        Dim strIndex As String

        If CInt(txtAmount.Text) >= 1 Then

            Dim dblAmount As Double = CDbl(txtAmount.Text)

            If lstProductsForSale.SelectedIndex = -1 Then

                MessageBox.Show("Please select an item from the Movie or Music list.")

            Else

                lstShoppingCart.Items.Add(lstProductsForSale.SelectedItem.ToString & _
                ": @" & txtAmount.Text & " Item")

                strIndex = lstProductsForSale.SelectedItem.ToString()

                For i = 0 To cstrFileNames.Length - 1
                    If cstrFileItemsName(i) = strIndex Then
                        csngTotal = CSng(CDbl(csngPrice(i)) * CSng(txtAmount.Text))
                    End If
                Next

            End If

        Else

            MessageBox.Show("Please use a valid number for the amount.")

        End If

        lstPrices.Items.Add(FormatCurrency(csngTotal))
        csngSubTotal += csngTotal
        lblSubTotalDisplay.Text = FormatCurrency(csngSubTotal.ToString)

    End Sub

    Private Sub btnCalcTotal_Click(ByVal sender As System.Object, ByVal e As System. _
        EventArgs) Handles btnCalcTotal.Click
        '--------------------------------------------------------------------------------
        'Description:   This sub calculates the total cost by calling the fPricing
        '               function and display the total cost to the user.
        '    
        'Calls:         fPricing
        '--------------------------------------------------------------------------------

        fPricing(csngSubTotal)

        lblTotalCostDisplay.Text = FormatCurrency(csngTotal)

        MessageBox.Show("Thank you for shopping with us. Your total cost is " & _
            (FormatCurrency(csngTotal)).ToString)

    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnClear.Click
        '--------------------------------------------------------------------------------
        'Description:   This clears the Shopping Cart and Price List boxes when selected
        '               and set the Total/Subtoal cost's displays to 0.
        '--------------------------------------------------------------------------------

        lstShoppingCart.Items.Clear()
        lstPrices.Items.Clear()
        csngSubTotal = 0
        csngTotal = 0
        lblSubTotalDisplay.Text = "0"
        lblTotalCostDisplay.Text = "0"

    End Sub

    Private Sub tmrPromotionBaneer1_Tick(ByVal sender As Object, ByVal e As System. _
               EventArgs) Handles tmrPromotionBanner1.Tick
        '--------------------------------------------------------------------------------
        'Description:   This sub uses timer to shift the promotional banner to the left 
        '               -5 units with each tick to give the effect of moving. When it
        '               reaches off screen to the left it will reset to default location
        '               and repeat the process.
        '--------------------------------------------------------------------------------

        If lblPromotionBanner1.Left = -550 Then

            Dim x As Integer = 970
            Dim y As Integer = 645
            lblPromotionBanner1.Location = New Point(x, y)

        Else
            lblPromotionBanner1.Left -= 5

        End If

    End Sub

    Private Sub btnChgBckgrnd_Click(ByVal sender As Object, ByVal e As System. _
        EventArgs) Handles btnChgBckgrnd.Click
        '--------------------------------------------------------------------------------
        'Description:   When the button is clicked each time, it will cycle through and
        '               change the background images of the form. It will also display
        '               the appropriate number of the background in the lblBckgrndNum. It
        '               will then set all the backcolor of the rich text box and all the
        '               list boxes on the form to the matching color of the background
        '               image.
        '--------------------------------------------------------------------------------

        If cintBackground >= 7 Then

            cintBackground = 0

        Else

            cintBackground += 1

            Select Case cintBackground

                Case 1

                    lblBckgrndNum.Text = "1"

                    Me.BackgroundImage = My.Resources.Background1

                    lstProductsForSale.BackColor = Color.Brown
                    lstPrices.BackColor = Color.Brown
                    lstShoppingCart.BackColor = Color.Brown
                    rtfDetails.BackColor = Color.Brown

                Case 2

                    lblBckgrndNum.Text = "2"
                    Me.BackgroundImage = My.Resources.Background2

                    lstProductsForSale.BackColor = Color.DarkOrange
                    lstPrices.BackColor = Color.DarkOrange
                    lstShoppingCart.BackColor = Color.DarkOrange
                    rtfDetails.BackColor = Color.DarkOrange

                Case 3

                    lblBckgrndNum.Text = "3"

                    Me.BackgroundImage = My.Resources.Background3

                    lstProductsForSale.BackColor = Color.DodgerBlue
                    lstPrices.BackColor = Color.DodgerBlue
                    lstShoppingCart.BackColor = Color.DodgerBlue
                    rtfDetails.BackColor = Color.DodgerBlue
                Case 4

                    lblBckgrndNum.Text = "4"

                    Me.BackgroundImage = My.Resources.Background4

                    lstProductsForSale.BackColor = Color.Navy
                    lstPrices.BackColor = Color.Navy
                    lstShoppingCart.BackColor = Color.Navy
                    rtfDetails.BackColor = Color.Navy

                Case 5

                    lblBckgrndNum.Text = "5"

                    Me.BackgroundImage = My.Resources.Background5
                    lstProductsForSale.BackColor = Color.DarkRed
                    lstPrices.BackColor = Color.DarkRed
                    lstShoppingCart.BackColor = Color.DarkRed
                    rtfDetails.BackColor = Color.DarkRed

                Case 6

                    lblBckgrndNum.Text = "6"

                    Me.BackgroundImage = My.Resources.Background6

                    lstProductsForSale.BackColor = Color.Black
                    lstPrices.BackColor = Color.Black
                    lstShoppingCart.BackColor = Color.Black
                    rtfDetails.BackColor = Color.Black

                Case Else

                    lblBckgrndNum.Text() = "Default"

                    Me.BackgroundImage = My.Resources.DefaultBG

                    lstProductsForSale.BackColor = Color.DarkRed
                    lstPrices.BackColor = Color.DarkRed
                    lstShoppingCart.BackColor = Color.DarkRed
                    rtfDetails.BackColor = Color.DarkRed

            End Select

        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnSearch.Click
        '--------------------------------------------------------------------------------
        'Description:   This sub clears the lstProductsForSale and loops through the
        '               fsearch function and find matching search entries and displays it
        '               back to the lstProductsForSale list box. If no matches are found
        '               it will display a message box to the user that no matches found.
        '               
        'Call:          fSearch
        '--------------------------------------------------------------------------------

        Dim j As Integer
        Dim strInput As String = ""

        strInput = txtSearch.Text

        lstProductsForSale.Items.Clear()

        For i = 0 To cintSearch.Length - 1
            cintSearch(i) = 0
        Next

        For i = 0 To cstrFileNames.Length - 1
            If fSearch(cstrPATH, cstrFileNames(i), strInput) = True Then
                cintSearch(j) = i
                j += 1

            End If

        Next i

        For i = 0 To j - 1
            lstProductsForSale.Items.Add(cstrFileItemsName(cintSearch(i)))
        Next i

        If lstProductsForSale.Items.Count = 0 Then
            MessageBox.Show("No matching results found.")
        End If

    End Sub

    Private Function fSearch(ByVal strPath As String, ByVal strFileName As String, _
        ByVal strSearchString As String) As Boolean
        '--------------------------------------------------------------------------------
        'Description:   This function will populate the strfileName array with data
        '               containing the files item's name and descreption from the
        '               list.mmf file. and store it.
        '               
        'Called by:     btnSearch.Click
        '--------------------------------------------------------------------------------

        Dim strTemp As String = ""
        Dim i As Integer
        Dim intLines As Integer
        Dim blnSearch As Boolean = False

        FileOpen(2, strPath & strFileName, OpenMode.Input)

        Input(2, strTemp)
        intLines = CInt(strTemp)
        For i = 1 To 3
            strTemp = LineInput(2)
        Next i

        If strTemp.Contains(strSearchString) = True Then
            blnSearch = True
        End If

        For i = 5 To 7
            strTemp = LineInput(2)
        Next i

        strTemp = ""

        For i = 8 To intLines - 3
            strTemp &= LineInput(2)
        Next i

        FileClose(2)

        If strTemp.Contains(strSearchString) = True Then
            blnSearch = True
        End If

        Return blnSearch

    End Function

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnExit.Click
        '--------------------------------------------------------------------------------
        'Description:   This will display the "Thank you for shopping with us" message 
        '               box and closes the program when clicked.           
        '--------------------------------------------------------------------------------

        MessageBox.Show("Thank you for shopping with us! We hope to see you soon :)")

        Me.Close()

    End Sub

End Class
