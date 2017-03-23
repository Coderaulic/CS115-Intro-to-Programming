'========================================================================================
'Project:           Lab 0
'Title:             Favorite Films Project
'File Name:         FavoriteFilms.vb
'Date completed:    October 25, 2012.
'Author:            Ryu Muthui
'Class:             CS 115 Section B
'Description:       This program is a project that displays classmate's favorite films.
'                   This program includes on a form, 3 labels, 6 radio buttons, 1 check
'                   box, a picture box and a button. The user can select through the 
'                   radio buttons to view each class mate's favorite film; displayed with
'                   a film poster and description text. Selecting the Check box will 
'                   display the text in bold font. Selecting the Clear All clears the 
'                   selections. The user can exit the program via the Exit button.
'========================================================================================
Option Explicit On
Option Strict On

Public Class frmFavoriteFilms

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnExit.Click
        '--------------------------------------------------------------------------------
        'Description: Click to end the program.
        '--------------------------------------------------------------------------------

        Me.Close()

    End Sub

    Private Sub radDavidB_Click(sender As System.Object, _e As System.EventArgs) _
        Handles radDavidB.Click
        '--------------------------------------------------------------------------------
        'Description: Displays the movie poster in the picture box. It will also display
        '             the movie synopsis and the reason why it's their favorite film.
        '--------------------------------------------------------------------------------

        picFilmPoster.Image = My.Resources.ImgBraveheart

        lblInformation.Text = ("Braveheart:" & Chr(13) & "William Wallace, a commoner," _
            & " unites the 13th Century Scots in their battle to overthrow English " _
            & "rule." & Chr(13) & Chr(13) & "David like this movie for its great " _
            & "medieval warfare elements. The fact that it is based on true story of a" _
            & " historical struggle. It is also a very moving film and he believes " _
            & "that a great film shouldleave the viewer with something to remember.")

    End Sub

    Private Sub radDanilaY_Click(sender As System.Object, _e As System.EventArgs) _
        Handles radDanilaY.Click
        '--------------------------------------------------------------------------------

        'Description: Displays the movie poster in the picture box. It will also display
        '             the movie synopsis and the reason why it's their favorite film.
        '--------------------------------------------------------------------------------

        picFilmPoster.Image = My.Resources.ImgThe_Matrix
    
        lblInformation.Text = ("The Matrix:" & Chr(13) & "The film revolves around a " _
            & "computer hacker who learns from mysterious rebels about the true nature" _
            & " of his reality and his role in the war against its controllers." _
            & Chr(13) & Chr(13) & "This is Danila's favorite film because of its " _
            & "ground breaking special effects, the great idea behind the war between " _
            & "humans vs. machines, and the cast includes his favorite actor, " _
            & "Laurence Fishburne.")

    End Sub

    Private Sub radZhipengLi_Click(sender As System.Object, e As System.EventArgs) _
        Handles radZhipengLi.Click
        '--------------------------------------------------------------------------------
        'Description: Displays the movie poster in the picture box. It will also display
        '             the movie synopsis and the reason why it's their favorite film.
        '--------------------------------------------------------------------------------

        picFilmPoster.Image = My.Resources.ImgThe_Dictator
   
        lblInformation.Text = ("The Dictator:" & Chr(13) & "The Republic of Wadiya is " _
            & "ruled by an eccentric and oppressive leader named Hafez Aladeen. " _
            & "Aladeen is summoned to New York to a UN assembly to address concerns " _
            & "about his country's nuclear weapons program, but the trip goes awry." _
            & Chr(13) & Chr(13) & "The wide range of comedic situations depicted " _
            & "throughout the film makes it Zhipeng's favorite film.")

    End Sub

    Private Sub radNasirE_Click(sender As System.Object, e As System.EventArgs) _
        Handles radNasirE.Click
        '--------------------------------------------------------------------------------
        'Description: Displays the movie poster in the picture box. It will also display
        '             the movie synopsis and the reason why it's their favorite film.
        '--------------------------------------------------------------------------------

        picFilmPoster.Image = My.Resources.ImgMission_Impossible_4
       
        lblInformation.Text = ("Mission Impossible 4:" & Chr(13) & "The IMF is shut " _
            & "down when it's implicated in the bombing of the Kremlin, causing Ethan" _
            & " Hunt and his new team to go rogue to clear their organization's name." _
            & Chr(13) & Chr(13) & "This is Nasir's favorite film as it features very " _
            & "advanced high-tech devices and gizmo elements. Not to mention the many " _
            & "ground breaking crazy stunts and action sequences. The cast also " _
            & "includes his favorite actor, Tom Cruise.")

    End Sub

    Private Sub radRussellB_Click(sender As System.Object, e As System.EventArgs) _
        Handles radRussellB.Click
        '--------------------------------------------------------------------------------
        'Description: Displays the movie poster in the picture box. It will also display
        '             the movie synopsis and the reason why it's their favorite film.
        '--------------------------------------------------------------------------------

        picFilmPoster.Image = My.Resources.ImgThank_You_For_Smoking
     
        lblInformation.Text = ("Thank You For Smoking:" & Chr(13) & "Satirical comedy " _
            & "follows the machinations of Big Tobacco's chief spokesman, Nick Naylor," _
            & " who spins on behalf of cigarettes while trying to remain a role model " _
            & "for his twelve-year-old son." & Chr(13) & Chr(13) & "This is Russell's " _
            & "favorite film as he claims it's the best film done very well for its " _
            & "dry comedy.")

    End Sub

    Private Sub radClearAll_Click(sender As Object, e As System.EventArgs) _
        Handles radClearAll.Click
        '--------------------------------------------------------------------------------
        'Description: This option will clear all selections in the class mate list.
        '--------------------------------------------------------------------------------

        lblInformation.Text = ("")

        picFilmPoster.Image = BackgroundImage

    End Sub

    Private Sub chkBold_Click(sender As Object, e As System.EventArgs) _
        Handles chkBold.Click
        '--------------------------------------------------------------------------------
        'Description: When checked, it will make the film information text bold font. 
        '             If unchecked, the text will display as regular font.
        '--------------------------------------------------------------------------------

        If lblInformation.Font.Bold Then

            lblInformation.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)

        Else

            lblInformation.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)

        End If

    End Sub

End Class
