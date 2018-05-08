Public Class Inventoryfrm
    Dim ArrChk(7) As CheckBox
    Dim ArrVIN(100) As String
    Dim Path As String
    Dim VIN As String
    Dim I As Integer
    Dim J As Integer

    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        cmbMake.Enabled = True
    End Sub

    Private Sub Inventoryfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        J = -1
        ArrChk(0) = CheckBox1
        ArrChk(1) = CheckBox2
        ArrChk(2) = CheckBox3
        ArrChk(3) = CheckBox4
        ArrChk(4) = CheckBox5
        ArrChk(5) = CheckBox6
        ArrChk(6) = CheckBox7
        ArrChk(7) = CheckBox8
    End Sub

    Private Sub cmbMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMake.SelectedIndexChanged
        cmbModel.ResetText()
        Label4.Visible = False
        picCar.Visible = False
        cmbModel.Items.Clear()
        If cmbMake.SelectedItem = "Toyota" Then
            cmbModel.Items.Add("Celica")
            cmbModel.Items.Add("Supra")
            cmbModel.Items.Add("Sienna")
        ElseIf cmbMake.SelectedItem = "Ford" Then
            cmbModel.Items.Add("Mustang")
            cmbModel.Items.Add("Fusion")
            cmbModel.Items.Add("Shelby")
        ElseIf cmbMake.SelectedItem = "Chevrolet" Then
            cmbModel.Items.Add("Camero")
            cmbModel.Items.Add("Malibu")
            cmbModel.Items.Add("Corvette")
        End If
        cmbModel.Enabled = True
    End Sub

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        VIN = ""
        VIN = VIN + cmbYear.SelectedItem


        If cmbMake.SelectedItem = "Toyota" Then
            VIN = VIN + "T"
        ElseIf cmbMake.SelectedItem = "Ford" Then
            VIN = VIN + "F"
        ElseIf cmbMake.SelectedItem = "Chevrolet" Then
            VIN = VIN + "C"
        End If

        If cmbModel.SelectedItem = "Celica" Then    'Toyota
            VIN = VIN + "CE"
        ElseIf cmbModel.SelectedItem = "Supra" Then
            VIN = VIN + "SU"
        ElseIf cmbModel.SelectedItem = "Sienna" Then
            VIN = VIN + "SI"
        ElseIf cmbModel.SelectedItem = "Mustang" Then   'Ford
            VIN = VIN + "MU"
        ElseIf cmbModel.SelectedItem = "Fusion" Then
            VIN = VIN + "FU"
        ElseIf cmbModel.SelectedItem = "Shelby" Then
            VIN = VIN + "SH"
        ElseIf cmbModel.SelectedItem = "Camero" Then    'Chevy
            VIN = VIN + "CA"
        ElseIf cmbModel.SelectedItem = "Malibu" Then
            VIN = VIN + "MA"
        ElseIf cmbModel.SelectedItem = "Corvette" Then
            VIN = VIN + "CO"
        End If

        If cmbColor.SelectedItem = "Black" Then
            VIN = VIN + "BK"
        ElseIf cmbColor.SelectedItem = "Blue" Then
            VIN = VIN + "BE"
        ElseIf cmbColor.SelectedItem = "Green" Then
            VIN = VIN + "GN"
        ElseIf cmbColor.SelectedItem = "Red" Then
            VIN = VIN + "RD"
        ElseIf cmbColor.SelectedItem = "White" Then
            VIN = VIN + "WE"
        ElseIf cmbColor.SelectedItem = "Yellow" Then
            VIN = VIN + "YW"
        End If

        If rdo4.Checked = True Then
            VIN = VIN + "4"
        ElseIf rdo6.Checked = True Then
            VIN = VIN + "6"
        ElseIf rdo8.checked = True Then
            VIN = VIN + "8"
        End If

        If rdoInline.Checked = True Then
            VIN = VIN + "I"
        ElseIf rdoV.Checked = True Then
            VIN = VIN + "V"
        ElseIf rdoX.Checked = True Then
            VIN = VIN + "X"
        End If

        If rdoFWD.Checked = True Then
            VIN = VIN + "F"
        ElseIf rdoRWD.Checked = True Then
            VIN = VIN + "R"
        ElseIf rdoAWD.Checked = True Then
            VIN = VIN + "A"
        End If

        If rdoCat.Checked = True Then
            VIN = VIN + "C"
        ElseIf rdoSkunk.Checked = True Then
            VIN = VIN + "S"
        ElseIf rdoPipe.Checked = True Then
            VIN = VIN + "P"
        End If

        For I = 0 To 7
            If ArrChk(I).Checked = True Then
                VIN = VIN + "1"
            Else
                VIN = VIN + "0"
            End If
        Next I
        txtVIN.Text = VIN
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If txtVIN.Text <> "" Then
            lstVIN.SelectedIndex = -1
            cmdChange.Visible = False
            cmdDelete.Visible = False
            J = J + 1
            ArrVIN(J) = Trim(txtVIN.Text)
            lstVIN.Items.Add(ArrVIN(J))
        End If
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        cmdChange.Visible = False
        cmdDelete.Visible = False
        For I = 0 To J
            ArrVIN(J) = ""
        Next I

        J = -1
        lstVIN.Items.Clear()
        rdo4.Checked = True
        rdoV.Checked = True
        rdoFWD.Checked = True
        rdoCat.Checked = True

        cmbYear.ResetText()
        cmbModel.ResetText()
        Label4.Visible = False
        picCar.Visible = False
        cmbModel.Enabled = False
        cmbMake.ResetText()
        cmbMake.Enabled = False
        cmbColor.ResetText()
        cmbColor.Enabled = False

        For I = 0 To 7
            ArrChk(I).Checked = False
        Next
    End Sub
    Sub Save()
        If My.Computer.FileSystem.FileExists(Path) = True Then
            Kill(Path)
        End If

        FileOpen(1, Path, OpenMode.Output)
        For I = 0 To J
            If Trim(ArrVIN(I)) <> "" Then
                PrintLine(1, ArrVIN(I))
            End If
        Next I
        FileClose(1)
        SaveToolStripMenuItem.Enabled = True
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Save()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim Result As DialogResult = OpenFileDialog1.ShowDialog
        cmdReset_Click(sender, e)

        If Result = Windows.Forms.DialogResult.OK Then
            Path = OpenFileDialog1.FileName
            I = 0

            FileOpen(1, Path, OpenMode.Input)
            Do While Not EOF(1)
                ArrVIN(I) = LineInput(1)
                lstVIN.Items.Add(ArrVIN(I))
                I = I + 1
            Loop
            FileClose(1)
            J = lstVIN.Items.Count
            J = J - 1
            SaveToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName <> "" Then
            Path = SaveFileDialog1.FileName
            Save()
        End If
    End Sub

    Private Sub cmdChange_Click(sender As Object, e As EventArgs) Handles cmdChange.Click
        ArrVIN(lstVIN.SelectedIndex) = Trim(txtVIN.Text)
        lstVIN.Items.Item(lstVIN.SelectedIndex) = ArrVIN(lstVIN.SelectedIndex)
    End Sub

    Private Sub lstVIN_Click(sender As Object, e As EventArgs) Handles lstVIN.Click
        If lstVIN.SelectedIndex <= J Then
            VIN = ArrVIN(lstVIN.SelectedIndex)
            cmbYear.SelectedItem = Mid(VIN, 1, 4)
            cmdChange.Visible = True
            cmdDelete.Visible = True
            txtVIN.Text = VIN

            If Mid(VIN, 5, 1) = "T" Then
                cmbMake.SelectedItem = "Toyota"
            ElseIf Mid(VIN, 5, 1) = "F" Then
                cmbMake.SelectedItem = "Ford"
            ElseIf Mid(VIN, 5, 1) = "C" Then
                cmbMake.SelectedItem = "Chevrolet"
            End If

            If Mid(VIN, 6, 2) = "CE" Then
                cmbModel.SelectedItem = "Celica"
            ElseIf Mid(VIN, 6, 2) = "SU" Then

                cmbModel.SelectedItem = "Supra"
            ElseIf Mid(VIN, 6, 2) = "SI" Then
                cmbModel.SelectedItem = "Sienna"
            ElseIf Mid(VIN, 6, 2) = "MU" Then
                cmbModel.SelectedItem = "Mustang"
            ElseIf Mid(VIN, 6, 2) = "FU" Then
                cmbModel.SelectedItem = "Fusion"
            ElseIf Mid(VIN, 6, 2) = "SH" Then
                cmbModel.SelectedItem = "Shelby"
            ElseIf Mid(VIN, 6, 2) = "CA" Then
                cmbModel.SelectedItem = "Camero"
            ElseIf Mid(VIN, 6, 2) = "MA" Then
                cmbModel.SelectedItem = "Malibu"
            ElseIf Mid(VIN, 6, 2) = "CO" Then
                cmbModel.SelectedItem = "Corvette"
            End If

            If Mid(VIN, 8, 2) = "BK" Then
                cmbColor.SelectedItem = "Black"
            ElseIf Mid(VIN, 8, 2) = "BE" Then
                cmbColor.SelectedItem = "Blue"
            ElseIf Mid(VIN, 8, 2) = "GN" Then
                cmbColor.SelectedItem = "Green"
            ElseIf Mid(VIN, 8, 2) = "RD" Then
                cmbColor.SelectedItem = "Red"
            ElseIf Mid(VIN, 8, 2) = "WE" Then
                cmbColor.SelectedItem = "White"
            ElseIf Mid(VIN, 8, 2) = "YW" Then
                cmbColor.SelectedItem = "Yellow"
            End If

            If Mid(VIN, 10, 1) = "4" Then
                rdo4.Checked = True
            ElseIf Mid(VIN, 10, 1) = "6" Then
                rdo6.Checked = True
            ElseIf Mid(VIN, 10, 1) = "8" Then
                rdo8.Checked = True
            End If

            If Mid(VIN, 11, 1) = "I" Then
                rdoInline.Checked = True
            ElseIf Mid(VIN, 11, 1) = "V" Then
                rdoV.Checked = True
            ElseIf Mid(VIN, 11, 1) = "X" Then
                rdoX.Checked = True
            End If

            If Mid(VIN, 12, 1) = "F" Then
                rdoFWD.Checked = True
            ElseIf Mid(VIN, 12, 1) = "R" Then
                rdoRWD.Checked = True
            ElseIf Mid(VIN, 12, 1) = "A" Then
                rdoAWD.Checked = True
            End If

            If Mid(VIN, 13, 1) = "C" Then
                rdoCat.Checked = True
            ElseIf Mid(VIN, 13, 1) = "S" Then
                rdoSkunk.Checked = True
            ElseIf Mid(VIN, 13, 1) = "P" Then
                rdoPipe.Checked = True
            End If

            For I = 0 To 7
                If Mid(VIN, (14 + I), 1) = 1 Then
                    ArrChk(I).Checked = True
                Else
                    ArrChk(I).Checked = False
                End If
            Next I
        End If
    End Sub

    Private Sub cmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged
        cmbColor.Enabled = True

        If cmbModel.SelectedItem <> "" Then
            Label4.Visible = True
            picCar.Visible = True
        Else
            Label4.Visible = False
            picCar.Visible = False
        End If

        If cmbModel.SelectedItem = "Celica" Then    'Toyota
            picCar.Image = Image.FromFile("E:\Computer Programming II\VBNET\Inventory\Celica.png")
        ElseIf cmbModel.SelectedItem = "Supra" Then
            picCar.Image = Image.FromFile("E:\Computer Programming II\VBNET\Inventory\Supra.jpg")
        ElseIf cmbModel.SelectedItem = "Sienna" Then
            picCar.Image = Image.FromFile("E:\Computer Programming II\VBNET\Inventory\Sienna.png")
        ElseIf cmbModel.SelectedItem = "Mustang" Then   'Ford
            picCar.Image = Image.FromFile("E:\Computer Programming II\VBNET\Inventory\Mustang.jpg")
        ElseIf cmbModel.SelectedItem = "Fusion" Then
            picCar.Image = Image.FromFile("E:\Computer Programming II\VBNET\Inventory\Fusion.png")
        ElseIf cmbModel.SelectedItem = "Shelby" Then
            picCar.Image = Image.FromFile("E:\Computer Programming II\VBNET\Inventory\Shelby.jpg")
        ElseIf cmbModel.SelectedItem = "Camero" Then    'Chevy
            picCar.Image = Image.FromFile("E:\Computer Programming II\VBNET\Inventory\Camero.jpg")
        ElseIf cmbModel.SelectedItem = "Malibu" Then
            picCar.Image = Image.FromFile("E:\Computer Programming II\VBNET\Inventory\Malibu.png")
        ElseIf cmbModel.SelectedItem = "Corvette" Then
            picCar.Image = Image.FromFile("E:\Computer Programming II\VBNET\Inventory\Corvette.jpg")
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim Pos As Integer
        Dim Ans As String

        Ans = MsgBox("Are you sure you want to delete this Vehicle?", vbYesNo, "Are you sure?")

        If Ans = vbYes Then
            Pos = lstVIN.SelectedIndex
            lstVIN.Items.RemoveAt(Pos)
            J = J - 1

            For I = Pos To J
                ArrVIN(I) = ArrVIN(I + 1)
            Next I

            If Pos >= J Then
                Pos = J
            End If

            lstVIN.SelectedIndex = Pos
            lstVIN_Click(sender, e)

        ElseIf Ans = vbNo Then
            Exit Sub
        End If
    End Sub
End Class