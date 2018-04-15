Public Class frmInv
    Dim pin As String
    Dim arrpin(5000) As String
    Dim numitems As Integer
    Dim path As String
    Dim pathsave As String
    Dim fname As String
    Dim ans As String
    Dim index As Integer
    Dim sel As String



    Private Sub frmInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numitems = 1
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStrokes.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmbYear.Items.Clear()
        cmbYear.Text = ""
        cmbArtist.Text = ""
        cmbStrokes.Text = ""

        chbRat.Checked = False
        chbIta.Checked = False
        chbFrench.Checked = False
        chbRuss.Checked = False
        chbGer.Checked = False
        chbNap.Checked = False
        chbOut.Checked = False
        chbIn.Checked = False
        chbFake.Checked = False
        chbDam.Checked = False
        chbPainter.Checked = False
        chbSq.Checked = False
        chbRec.Checked = False
        chbStolen.Checked = False
        chbFam.Checked = False
        Pic1.Visible = False
    End Sub

    Private Sub cmdArtist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArtist.SelectedIndexChanged
        If cmbArtist.SelectedItem = "Picasso" Then
            cmbYear.Items.Clear()
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Picasso.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
            cmbYear.Items.Add("19th")
            cmbYear.Items.Add("20th")
        End If

        If cmbArtist.SelectedItem = "Rembrandt" Then
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Rem.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
            cmbYear.Items.Clear()
            cmbYear.Items.Add("17th")
            cmbYear.Items.Add("18th")
        End If

        If cmbArtist.SelectedItem = "Van Gogh" Then
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\StarryNight.jpeg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
            cmbYear.Items.Clear()
            cmbYear.Items.Add("18th")
            cmbYear.Items.Add("19th")
        End If

        If cmbArtist.SelectedItem = "Monet" Then
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Monet.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
            cmbYear.Items.Clear()
            cmbYear.Items.Add("19th")
            cmbYear.Items.Add("20th")
        End If

        If cmbArtist.SelectedItem = "Michelangelo" Then
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Mich.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
            cmbYear.Items.Clear()
            cmbYear.Items.Add("15th")
            cmbYear.Items.Add("16th")
        End If

        If cmbArtist.SelectedItem = "Raphael" Then
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\School.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
            cmbYear.Items.Clear()
            cmbYear.Items.Add("15th")
            cmbYear.Items.Add("16th")
        End If

        If cmbArtist.SelectedItem = "Manet" Then
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Manet.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
            cmbYear.Items.Clear()
            cmbYear.Items.Add("19th")
        End If

        If cmbArtist.SelectedItem = "Courbet" Then
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Courbet.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
            cmbYear.Items.Clear()
            cmbYear.Items.Add("19th")
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pin = ""

        If cmbArtist.SelectedItem = "Van Gogh" Then
            pin = pin + "V"
        ElseIf cmbArtist.SelectedItem = "Monet" Then
            pin = pin + "O"
        ElseIf cmbArtist.SelectedItem = "Manet" Then
            pin = pin + "A"
        ElseIf cmbArtist.SelectedItem = "Michelangelo" Then
            pin = pin + "G"
        ElseIf cmbArtist.SelectedItem = "Rembrandt" Then
            pin = pin + "R"
        ElseIf cmbArtist.SelectedItem = "Courbet" Then
            pin = pin + "C"
        ElseIf cmbArtist.SelectedItem = "Raphael" Then
            pin = pin + "H"
        ElseIf cmbArtist.SelectedItem = "Picasso" Then
            pin = pin + "P"
        End If

        If cmbYear.SelectedItem = "15th" Then
            pin = pin + "5"
        ElseIf cmbYear.SelectedItem = "16th" Then
            pin = pin + "6"
        ElseIf cmbYear.SelectedItem = "17th" Then
            pin = pin + "7"
        ElseIf cmbYear.SelectedItem = "18th" Then
            pin = pin + "8"
        ElseIf cmbYear.SelectedItem = "19th" Then
            pin = pin + "9"
        ElseIf cmbYear.SelectedItem = "20th" Then
            pin = pin + "0"
        End If

        If cmbStrokes.SelectedItem = "Soft" Then
            pin = pin + "S"
        ElseIf cmbStrokes.SelectedItem = "Medium" Then
            pin = pin + "M"
        ElseIf cmbStrokes.SelectedItem = "Harsh" Then
            pin = pin + "H"
        End If

        If rdBlue.Checked Then
            pin = pin + "B"
        ElseIf rdRed.Checked Then
            pin = pin + "R"
        ElseIf rdYellow.Checked Then
            pin = pin + "Y"
        ElseIf rdOrange.Checked Then
            pin = pin + "O"
        End If

        If rdSteel.Checked Then
            pin = pin + "S"
        ElseIf rdWood.Checked Then
            pin = pin + "W"
        ElseIf rdPlastic.Checked Then
            pin = pin + "P"
        ElseIf rdGold.Checked Then
            pin = pin + "G"
        End If

        If rdRenn.Checked Then
            pin = pin + "A"
        ElseIf rdNat.Checked Then
            pin = pin + "N"
        ElseIf rdReal.Checked Then
            pin = pin + "R"
        ElseIf rdImp.Checked Then
            pin = pin + "I"
        ElseIf rdExp.Checked Then
            pin = pin + "E"
        ElseIf rdCub.Checked Then
            pin = pin + "C"
        End If

        If chbFam.Checked = True Then
            pin = pin + "1"
        ElseIf chbFam.Checked = False Then
            pin = pin + "0"
        End If

        If chbRat.Checked = True Then
            pin = pin + "1"
        ElseIf chbRat.Checked = False Then
            pin = pin + "0"
        End If

        If chbIn.Checked = True Then
            pin = pin + "1"
        ElseIf chbIn.Checked = False Then
            pin = pin + "0"
        End If

        If chbFake.Checked = True Then
            pin = pin + "1"
        ElseIf chbFake.Checked = False Then
            pin = pin + "0"
        End If

        If chbPainter.Checked = True Then
            pin = pin + "1"
        ElseIf chbPainter.Checked = False Then
            pin = pin + "0"
        End If

        If chbOut.Checked = True Then
            pin = pin + "1"
        ElseIf chbOut.Checked = False Then
            pin = pin + "0"
        End If

        If chbDam.Checked = True Then
            pin = pin + "1"
        ElseIf chbDam.Checked = False Then
            pin = pin + "0"
        End If

        If chbSq.Checked = True Then
            pin = pin + "1"
        ElseIf chbSq.Checked = False Then
            pin = pin + "0"
        End If

        If chbRec.Checked = True Then
            pin = pin + "1"
        ElseIf chbRec.Checked = False Then
            pin = pin + "0"
        End If

        If chbNap.Checked = True Then
            pin = pin + "1"
        ElseIf chbNap.Checked = False Then
            pin = pin + "0"
        End If

        If chbStolen.Checked = True Then
            pin = pin + "1"
        ElseIf chbStolen.Checked = False Then
            pin = pin + "0"
        End If

        If chbFrench.Checked = True Then
            pin = pin + "1"
        ElseIf chbFrench.Checked = False Then
            pin = pin + "0"
        End If

        If chbIta.Checked = True Then
            pin = pin + "1"
        ElseIf chbIta.Checked = False Then
            pin = pin + "0"
        End If

        If chbGer.Checked = True Then
            pin = pin + "1"
        ElseIf chbGer.Checked = False Then
            pin = pin + "0"
        End If

        If chbRuss.Checked = True Then
            pin = pin + "1"
        ElseIf chbRuss.Checked = False Then
            pin = pin + "0"
        End If

        numitems = numitems + 1
        arrpin(numitems) = pin
        lstpin.Items.Add(arrpin(numitems))



    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Open
        Dim i As Integer


        fname = Trim(UCase(InputBox("Enter filename", "Filename", "file")))
        pathsave = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\" + fname + ".dat"
        ans = MsgBox(pathsave, vbYesNo, "Is this the path brodda?")
        If ans = vbYes Then
            pathsave = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\" + fname + ".dat"
            FileOpen(1, pathsave, OpenMode.Output)
            For i = 0 To (arrpin.Length - 1)
                If arrpin(i) <> "" Then
                    PrintLine(1, arrpin(i))
                End If
            Next i
            FileClose(1)
        End If


    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        'Open
        Dim i As Long

        fname = Trim(UCase(InputBox("Enter filename", "Filename", "file")))
        pathsave = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\" + fname + ".dat"
        ans = MsgBox(pathsave, vbYesNo, "Is this the path brodda?")
        If ans = vbYes Then
            FileOpen(1, pathsave, OpenMode.Input)

            Do While Not EOF(1)

                arrpin(i) = LineInput(1)

                i = i + 1
            Loop
            FileClose(1)
        End If


        For i = 0 To arrpin.Length - 1
            If arrpin(i) <> "" Then
                lstpin.Items.Add(arrpin(i))
            End If
        Next i


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FillToolStripMenuItem.Click
        sel = lstpin.SelectedItem
        index = lstpin.SelectedIndex

        'artist and year
        If Mid(sel, 1, 1) = "P" And Mid(sel, 2, 1) = 9 Then
            cmbArtist.Text = "Picasso"
            cmbYear.Text = "19th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Picasso.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        ElseIf Mid(sel, 1, 1) = "P" And Mid(sel, 2, 1) = 0 Then
            cmbArtist.Text = "Picasso"
            cmbYear.Text = "20th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Picasso.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        End If

        If Mid(sel, 1, 1) = "R" And Mid(sel, 2, 1) = 7 Then
            cmbArtist.Text = "Rembrandt"
            cmbYear.Text = "17th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Rem.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        ElseIf Mid(sel, 1, 1) = "R" And Mid(sel, 2, 1) = 8 Then
            cmbArtist.Text = "Rembrandt"
            cmbYear.Text = "18th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Rem.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        End If

        If Mid(sel, 1, 1) = "V" And Mid(sel, 2, 1) = 8 Then
            cmbArtist.Text = "Van Gogh"
            cmbYear.Text = "18th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\StarryNight.jpeg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        ElseIf Mid(sel, 1, 1) = "V" And Mid(sel, 2, 1) = 9 Then
            cmbArtist.Text = "Van Gogh"
            cmbYear.Text = "19th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\StarryNight.jpeg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        End If

        If Mid(sel, 1, 1) = "A" And Mid(sel, 2, 1) = 9 Then
            cmbArtist.Text = "Manet"
            cmbYear.Text = "19th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Manet.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        End If

        If Mid(sel, 1, 1) = "C" And Mid(sel, 2, 1) = 9 Then
            cmbArtist.Text = "Courbet"
            cmbYear.Text = "19th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Courbet.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        End If

        If Mid(sel, 1, 1) = "G" And Mid(sel, 2, 1) = 5 Then
            cmbArtist.Text = "Michelangelo"
            cmbYear.Text = "15th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Mich.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        ElseIf Mid(sel, 1, 1) = "G" And Mid(sel, 2, 1) = 6 Then
            cmbArtist.Text = "Michelangelo"
            cmbYear.Text = "16th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Mich.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        End If

        If Mid(sel, 1, 1) = "O" And Mid(sel, 2, 1) = 9 Then
            cmbArtist.Text = "Monet"
            cmbYear.Text = "19th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Monet.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        ElseIf Mid(sel, 1, 1) = "O" And Mid(sel, 2, 1) = 0 Then
            cmbArtist.Text = "Monet"
            cmbYear.Text = "20th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\Monet.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        End If

        If Mid(sel, 1, 1) = "H" And Mid(sel, 2, 1) = 5 Then
            cmbArtist.Text = "Raphael"
            cmbYear.Text = "15th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\School.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        ElseIf Mid(sel, 1, 1) = "H" And Mid(sel, 2, 1) = 6 Then
            cmbArtist.Text = "Raphael"
            cmbYear.Text = "16th"
            path = "D:\Locker\Files\Projects\CP II\VB.NET\Inventory\School.jpg"
            Pic1.Image = Image.FromFile(path)
            Pic1.Visible = True
        End If


        'Strokes
        If Mid(sel, 3, 1) = "S" Then
            cmbStrokes.Text = "Soft"
        End If

        If Mid(sel, 3, 1) = "M" Then
            cmbStrokes.Text = "Medium"
        End If

        If Mid(sel, 3, 1) = "H" Then
            cmbStrokes.Text = "Harsh"
        End If

        'color
        If Mid(sel, 4, 1) = "B" Then
            rdBlue.Select()
        End If

        If Mid(sel, 4, 1) = "Y" Then
            rdYellow.Select()
        End If

        If Mid(sel, 4, 1) = "O" Then
            rdOrange.Select()
        End If

        If Mid(sel, 4, 1) = "R" Then
            rdRed.Select()
        End If

        'frame
        If Mid(sel, 5, 1) = "S" Then
            rdSteel.Select()
        End If

        If Mid(sel, 5, 1) = "G" Then
            rdGold.Select()
        End If

        If Mid(sel, 5, 1) = "P" Then
            rdPlastic.Select()
        End If

        If Mid(sel, 5, 1) = "W" Then
            rdWood.Select()
        End If

        'era
        If Mid(sel, 6, 1) = "A" Then
            rdRenn.Select()
        End If

        If Mid(sel, 6, 1) = "N" Then
            rdNat.Select()
        End If

        If Mid(sel, 6, 1) = "R" Then
            rdReal.Select()
        End If

        If Mid(sel, 6, 1) = "C" Then
            rdCub.Select()
        End If

        If Mid(sel, 6, 1) = "E" Then
            rdExp.Select()
        End If

        If Mid(sel, 6, 1) = "I" Then
            rdImp.Select()
        End If

        'options

        If Mid(sel, 7, 1) = 1 Then
            chbFam.Checked = True
        ElseIf Mid(sel, 7, 1) = 0 Then
            chbFam.Checked = False
        End If

        If Mid(sel, 8, 1) = 1 Then
            chbRat.Checked = True
        ElseIf Mid(sel, 8, 1) = 0 Then
            chbRat.Checked = False
        End If

        If Mid(sel, 9, 1) = 1 Then
            chbIn.Checked = True
        ElseIf Mid(sel, 9, 1) = 0 Then
            chbIn.Checked = False
        End If

        If Mid(sel, 10, 1) = 1 Then
            chbFake.Checked = True
        ElseIf Mid(sel, 10, 1) = 0 Then
            chbFake.Checked = False
        End If

        If Mid(sel, 11, 1) = 1 Then
            chbPainter.Checked = True
        ElseIf Mid(sel, 11, 1) = 0 Then
            chbPainter.Checked = False
        End If

        If Mid(sel, 12, 1) = 1 Then
            chbOut.Checked = True
        ElseIf Mid(sel, 12, 1) = 0 Then
            chbOut.Checked = False
        End If

        If Mid(sel, 13, 1) = 1 Then
            chbDam.Checked = True
        ElseIf Mid(sel, 13, 1) = 0 Then
            chbDam.Checked = False
        End If

        If Mid(sel, 14, 1) = 1 Then
            chbSq.Checked = True
        ElseIf Mid(sel, 14, 1) = 0 Then
            chbSq.Checked = False
        End If

        If Mid(sel, 15, 1) = 1 Then
            chbRec.Checked = True
        ElseIf Mid(sel, 15, 1) = 0 Then
            chbRec.Checked = False
        End If

        If Mid(sel, 16, 1) = 1 Then
            chbNap.Checked = True
        ElseIf Mid(sel, 16, 1) = 0 Then
            chbNap.Checked = False
        End If

        If Mid(sel, 17, 1) = 1 Then
            chbStolen.Checked = True
        ElseIf Mid(sel, 17, 1) = 0 Then
            chbStolen.Checked = False
        End If

        If Mid(sel, 18, 1) = 1 Then
            chbFrench.Checked = True
        ElseIf Mid(sel, 18, 1) = 0 Then
            chbFrench.Checked = False
        End If

        If Mid(sel, 19, 1) = 1 Then
            chbIta.Checked = True
        ElseIf Mid(sel, 19, 1) = 0 Then
            chbIta.Checked = False
        End If

        If Mid(sel, 20, 1) = 1 Then
            chbGer.Checked = True
        ElseIf Mid(sel, 20, 1) = 0 Then
            chbGer.Checked = False
        End If

        If Mid(sel, 21, 1) = 1 Then
            chbRuss.Checked = True
        ElseIf Mid(sel, 21, 1) = 0 Then
            chbRuss.Checked = False
        End If

    End Sub

    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeToolStripMenuItem.Click
        Dim c As Integer
        Dim change As String
        Dim place As Integer
        place = lstpin.SelectedIndex

        change = arrpin(place)


        If arrpin(c) <> "" Then
                pin = ""

                If cmbArtist.SelectedItem = "Van Gogh" Then
                    pin = pin + "V"
                ElseIf cmbArtist.SelectedItem = "Monet" Then
                    pin = pin + "O"
                ElseIf cmbArtist.SelectedItem = "Manet" Then
                    pin = pin + "A"
                ElseIf cmbArtist.SelectedItem = "Michelangelo" Then
                    pin = pin + "G"
                ElseIf cmbArtist.SelectedItem = "Rembrandt" Then
                    pin = pin + "R"
                ElseIf cmbArtist.SelectedItem = "Courbet" Then
                    pin = pin + "C"
                ElseIf cmbArtist.SelectedItem = "Raphael" Then
                    pin = pin + "H"
                ElseIf cmbArtist.SelectedItem = "Picasso" Then
                    pin = pin + "P"
                End If

                If cmbYear.SelectedItem = "15th" Then
                    pin = pin + "5"
                ElseIf cmbYear.SelectedItem = "16th" Then
                    pin = pin + "6"
                ElseIf cmbYear.SelectedItem = "17th" Then
                    pin = pin + "7"
                ElseIf cmbYear.SelectedItem = "18th" Then
                    pin = pin + "8"
                ElseIf cmbYear.SelectedItem = "19th" Then
                    pin = pin + "9"
                ElseIf cmbYear.SelectedItem = "20th" Then
                    pin = pin + "0"
                End If

                If cmbStrokes.SelectedItem = "Soft" Then
                    pin = pin + "S"
                ElseIf cmbStrokes.SelectedItem = "Medium" Then
                    pin = pin + "M"
                ElseIf cmbStrokes.SelectedItem = "Harsh" Then
                    pin = pin + "H"
                End If

                If rdBlue.Checked Then
                    pin = pin + "B"
                ElseIf rdRed.Checked Then
                    pin = pin + "R"
                ElseIf rdYellow.Checked Then
                    pin = pin + "Y"
                ElseIf rdOrange.Checked Then
                    pin = pin + "O"
                End If

                If rdSteel.Checked Then
                    pin = pin + "S"
                ElseIf rdWood.Checked Then
                    pin = pin + "W"
                ElseIf rdPlastic.Checked Then
                    pin = pin + "P"
                ElseIf rdGold.Checked Then
                    pin = pin + "G"
                End If

                If rdRenn.Checked Then
                    pin = pin + "A"
                ElseIf rdNat.Checked Then
                    pin = pin + "N"
                ElseIf rdReal.Checked Then
                    pin = pin + "R"
                ElseIf rdImp.Checked Then
                    pin = pin + "I"
                ElseIf rdExp.Checked Then
                    pin = pin + "E"
                ElseIf rdCub.Checked Then
                    pin = pin + "C"
                End If

                If chbFam.Checked = True Then
                    pin = pin + "1"
                ElseIf chbFam.Checked = False Then
                    pin = pin + "0"
                End If

                If chbRat.Checked = True Then
                    pin = pin + "1"
                ElseIf chbRat.Checked = False Then
                    pin = pin + "0"
                End If

                If chbIn.Checked = True Then
                    pin = pin + "1"
                ElseIf chbIn.Checked = False Then
                    pin = pin + "0"
                End If

                If chbFake.Checked = True Then
                    pin = pin + "1"
                ElseIf chbFake.Checked = False Then
                    pin = pin + "0"
                End If

                If chbPainter.Checked = True Then
                    pin = pin + "1"
                ElseIf chbPainter.Checked = False Then
                    pin = pin + "0"
                End If

                If chbOut.Checked = True Then
                    pin = pin + "1"
                ElseIf chbOut.Checked = False Then
                    pin = pin + "0"
                End If

                If chbDam.Checked = True Then
                    pin = pin + "1"
                ElseIf chbDam.Checked = False Then
                    pin = pin + "0"
                End If

                If chbSq.Checked = True Then
                    pin = pin + "1"
                ElseIf chbSq.Checked = False Then
                    pin = pin + "0"
                End If

                If chbRec.Checked = True Then
                    pin = pin + "1"
                ElseIf chbRec.Checked = False Then
                    pin = pin + "0"
                End If

                If chbNap.Checked = True Then
                    pin = pin + "1"
                ElseIf chbNap.Checked = False Then
                    pin = pin + "0"
                End If

                If chbStolen.Checked = True Then
                    pin = pin + "1"
                ElseIf chbStolen.Checked = False Then
                    pin = pin + "0"
                End If

                If chbFrench.Checked = True Then
                    pin = pin + "1"
                ElseIf chbFrench.Checked = False Then
                    pin = pin + "0"
                End If

                If chbIta.Checked = True Then
                    pin = pin + "1"
                ElseIf chbIta.Checked = False Then
                    pin = pin + "0"
                End If

                If chbGer.Checked = True Then
                    pin = pin + "1"
                ElseIf chbGer.Checked = False Then
                    pin = pin + "0"
                End If

                If chbRuss.Checked = True Then
                    pin = pin + "1"
                ElseIf chbRuss.Checked = False Then
                    pin = pin + "0"
                End If

            lstpin.Items.Clear()
            lstpin.Items.Item(lstpin.SelectedIndex) = arrpin(lstpin.SelectedIndex)

            arrpin(c) = pin
            lstpin.Items.Add(arrpin(c))

            End If


    End Sub
End Class
