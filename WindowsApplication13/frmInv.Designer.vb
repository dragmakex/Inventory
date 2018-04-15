Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInv
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nosel() Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Function Nosel() As IContainer
        Throw New NotImplementedException()
    End Function

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbArtist = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbStrokes = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdOrange = New System.Windows.Forms.RadioButton()
        Me.rdYellow = New System.Windows.Forms.RadioButton()
        Me.rdRed = New System.Windows.Forms.RadioButton()
        Me.rdBlue = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdPlastic = New System.Windows.Forms.RadioButton()
        Me.rdWood = New System.Windows.Forms.RadioButton()
        Me.rdGold = New System.Windows.Forms.RadioButton()
        Me.rdSteel = New System.Windows.Forms.RadioButton()
        Me.chbFam = New System.Windows.Forms.CheckBox()
        Me.chbRat = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdCub = New System.Windows.Forms.RadioButton()
        Me.rdExp = New System.Windows.Forms.RadioButton()
        Me.rdImp = New System.Windows.Forms.RadioButton()
        Me.rdReal = New System.Windows.Forms.RadioButton()
        Me.rdNat = New System.Windows.Forms.RadioButton()
        Me.rdRenn = New System.Windows.Forms.RadioButton()
        Me.chbIn = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chbRuss = New System.Windows.Forms.CheckBox()
        Me.chbGer = New System.Windows.Forms.CheckBox()
        Me.chbIta = New System.Windows.Forms.CheckBox()
        Me.chbFrench = New System.Windows.Forms.CheckBox()
        Me.chbStolen = New System.Windows.Forms.CheckBox()
        Me.chbNap = New System.Windows.Forms.CheckBox()
        Me.chbRec = New System.Windows.Forms.CheckBox()
        Me.chbSq = New System.Windows.Forms.CheckBox()
        Me.chbDam = New System.Windows.Forms.CheckBox()
        Me.chbOut = New System.Windows.Forms.CheckBox()
        Me.chbPainter = New System.Windows.Forms.CheckBox()
        Me.chbFake = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lstpin = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbYear
        '
        Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(295, 124)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(180, 33)
        Me.cmbYear.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Year"
        '
        'cmbArtist
        '
        Me.cmbArtist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbArtist.FormattingEnabled = True
        Me.cmbArtist.Items.AddRange(New Object() {"Van Gogh", "Monet", "Rembrandt", "Picasso", "Michelangelo", "Raphael", "Manet", "Courbet"})
        Me.cmbArtist.Location = New System.Drawing.Point(70, 124)
        Me.cmbArtist.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbArtist.Name = "cmbArtist"
        Me.cmbArtist.Size = New System.Drawing.Size(180, 33)
        Me.cmbArtist.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Artist"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(574, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Strokes"
        '
        'cmbStrokes
        '
        Me.cmbStrokes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStrokes.FormattingEnabled = True
        Me.cmbStrokes.Items.AddRange(New Object() {"Soft", "Medium", "Harsh"})
        Me.cmbStrokes.Location = New System.Drawing.Point(525, 124)
        Me.cmbStrokes.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStrokes.Name = "cmbStrokes"
        Me.cmbStrokes.Size = New System.Drawing.Size(180, 33)
        Me.cmbStrokes.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdOrange)
        Me.GroupBox1.Controls.Add(Me.rdYellow)
        Me.GroupBox1.Controls.Add(Me.rdRed)
        Me.GroupBox1.Controls.Add(Me.rdBlue)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 199)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(157, 218)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color"
        '
        'rdOrange
        '
        Me.rdOrange.AutoSize = True
        Me.rdOrange.Location = New System.Drawing.Point(23, 180)
        Me.rdOrange.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdOrange.Name = "rdOrange"
        Me.rdOrange.Size = New System.Drawing.Size(91, 24)
        Me.rdOrange.TabIndex = 3
        Me.rdOrange.TabStop = True
        Me.rdOrange.Text = "Orange"
        Me.rdOrange.UseVisualStyleBackColor = True
        '
        'rdYellow
        '
        Me.rdYellow.AutoSize = True
        Me.rdYellow.Location = New System.Drawing.Point(23, 126)
        Me.rdYellow.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdYellow.Name = "rdYellow"
        Me.rdYellow.Size = New System.Drawing.Size(84, 24)
        Me.rdYellow.TabIndex = 2
        Me.rdYellow.TabStop = True
        Me.rdYellow.Text = "Yellow"
        Me.rdYellow.UseVisualStyleBackColor = True
        '
        'rdRed
        '
        Me.rdRed.AutoSize = True
        Me.rdRed.Location = New System.Drawing.Point(23, 74)
        Me.rdRed.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdRed.Name = "rdRed"
        Me.rdRed.Size = New System.Drawing.Size(63, 24)
        Me.rdRed.TabIndex = 1
        Me.rdRed.TabStop = True
        Me.rdRed.Text = "Red"
        Me.rdRed.UseVisualStyleBackColor = True
        '
        'rdBlue
        '
        Me.rdBlue.AutoSize = True
        Me.rdBlue.Location = New System.Drawing.Point(23, 29)
        Me.rdBlue.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdBlue.Name = "rdBlue"
        Me.rdBlue.Size = New System.Drawing.Size(68, 24)
        Me.rdBlue.TabIndex = 0
        Me.rdBlue.TabStop = True
        Me.rdBlue.Text = "Blue"
        Me.rdBlue.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(340, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Paintings"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdPlastic)
        Me.GroupBox2.Controls.Add(Me.rdWood)
        Me.GroupBox2.Controls.Add(Me.rdGold)
        Me.GroupBox2.Controls.Add(Me.rdSteel)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 199)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(200, 218)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Frame"
        '
        'rdPlastic
        '
        Me.rdPlastic.AutoSize = True
        Me.rdPlastic.Location = New System.Drawing.Point(16, 180)
        Me.rdPlastic.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdPlastic.Name = "rdPlastic"
        Me.rdPlastic.Size = New System.Drawing.Size(88, 24)
        Me.rdPlastic.TabIndex = 9
        Me.rdPlastic.TabStop = True
        Me.rdPlastic.Text = "Plastic"
        Me.rdPlastic.UseVisualStyleBackColor = True
        '
        'rdWood
        '
        Me.rdWood.AutoSize = True
        Me.rdWood.Location = New System.Drawing.Point(16, 126)
        Me.rdWood.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdWood.Name = "rdWood"
        Me.rdWood.Size = New System.Drawing.Size(77, 24)
        Me.rdWood.TabIndex = 2
        Me.rdWood.TabStop = True
        Me.rdWood.Text = "Wood"
        Me.rdWood.UseVisualStyleBackColor = True
        '
        'rdGold
        '
        Me.rdGold.AutoSize = True
        Me.rdGold.Location = New System.Drawing.Point(16, 75)
        Me.rdGold.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdGold.Name = "rdGold"
        Me.rdGold.Size = New System.Drawing.Size(69, 24)
        Me.rdGold.TabIndex = 1
        Me.rdGold.TabStop = True
        Me.rdGold.Text = "Gold"
        Me.rdGold.UseVisualStyleBackColor = True
        '
        'rdSteel
        '
        Me.rdSteel.AutoSize = True
        Me.rdSteel.Location = New System.Drawing.Point(16, 29)
        Me.rdSteel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdSteel.Name = "rdSteel"
        Me.rdSteel.Size = New System.Drawing.Size(73, 24)
        Me.rdSteel.TabIndex = 0
        Me.rdSteel.TabStop = True
        Me.rdSteel.Text = "Steel"
        Me.rdSteel.UseVisualStyleBackColor = True
        '
        'chbFam
        '
        Me.chbFam.AutoSize = True
        Me.chbFam.Location = New System.Drawing.Point(14, 23)
        Me.chbFam.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chbFam.Name = "chbFam"
        Me.chbFam.Size = New System.Drawing.Size(97, 24)
        Me.chbFam.TabIndex = 9
        Me.chbFam.Text = "Famous"
        Me.chbFam.UseVisualStyleBackColor = True
        '
        'chbRat
        '
        Me.chbRat.AutoSize = True
        Me.chbRat.Location = New System.Drawing.Point(14, 49)
        Me.chbRat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chbRat.Name = "chbRat"
        Me.chbRat.Size = New System.Drawing.Size(129, 24)
        Me.chbRat.TabIndex = 10
        Me.chbRat.Text = "Good rating"
        Me.chbRat.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdCub)
        Me.GroupBox3.Controls.Add(Me.rdExp)
        Me.GroupBox3.Controls.Add(Me.rdImp)
        Me.GroupBox3.Controls.Add(Me.rdReal)
        Me.GroupBox3.Controls.Add(Me.rdNat)
        Me.GroupBox3.Controls.Add(Me.rdRenn)
        Me.GroupBox3.Location = New System.Drawing.Point(70, 456)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(200, 273)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Era"
        '
        'rdCub
        '
        Me.rdCub.AutoSize = True
        Me.rdCub.Location = New System.Drawing.Point(16, 229)
        Me.rdCub.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdCub.Name = "rdCub"
        Me.rdCub.Size = New System.Drawing.Size(93, 24)
        Me.rdCub.TabIndex = 5
        Me.rdCub.TabStop = True
        Me.rdCub.Text = "Cubism"
        Me.rdCub.UseVisualStyleBackColor = True
        '
        'rdExp
        '
        Me.rdExp.AutoSize = True
        Me.rdExp.Location = New System.Drawing.Point(16, 187)
        Me.rdExp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdExp.Name = "rdExp"
        Me.rdExp.Size = New System.Drawing.Size(153, 24)
        Me.rdExp.TabIndex = 4
        Me.rdExp.TabStop = True
        Me.rdExp.Text = "Expressionism"
        Me.rdExp.UseVisualStyleBackColor = True
        '
        'rdImp
        '
        Me.rdImp.AutoSize = True
        Me.rdImp.Location = New System.Drawing.Point(16, 147)
        Me.rdImp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdImp.Name = "rdImp"
        Me.rdImp.Size = New System.Drawing.Size(152, 24)
        Me.rdImp.TabIndex = 3
        Me.rdImp.TabStop = True
        Me.rdImp.Text = "Impressionism"
        Me.rdImp.UseVisualStyleBackColor = True
        '
        'rdReal
        '
        Me.rdReal.AutoSize = True
        Me.rdReal.Location = New System.Drawing.Point(16, 110)
        Me.rdReal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdReal.Name = "rdReal"
        Me.rdReal.Size = New System.Drawing.Size(98, 24)
        Me.rdReal.TabIndex = 2
        Me.rdReal.TabStop = True
        Me.rdReal.Text = "Realism"
        Me.rdReal.UseVisualStyleBackColor = True
        '
        'rdNat
        '
        Me.rdNat.AutoSize = True
        Me.rdNat.Location = New System.Drawing.Point(16, 70)
        Me.rdNat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdNat.Name = "rdNat"
        Me.rdNat.Size = New System.Drawing.Size(121, 24)
        Me.rdNat.TabIndex = 1
        Me.rdNat.TabStop = True
        Me.rdNat.Text = "Naturalism"
        Me.rdNat.UseVisualStyleBackColor = True
        '
        'rdRenn
        '
        Me.rdRenn.AutoSize = True
        Me.rdRenn.Location = New System.Drawing.Point(16, 32)
        Me.rdRenn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdRenn.Name = "rdRenn"
        Me.rdRenn.Size = New System.Drawing.Size(148, 24)
        Me.rdRenn.TabIndex = 0
        Me.rdRenn.TabStop = True
        Me.rdRenn.Text = "Rennaissance"
        Me.rdRenn.UseVisualStyleBackColor = True
        '
        'chbIn
        '
        Me.chbIn.AutoSize = True
        Me.chbIn.Location = New System.Drawing.Point(14, 75)
        Me.chbIn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chbIn.Name = "chbIn"
        Me.chbIn.Size = New System.Drawing.Size(124, 24)
        Me.chbIn.TabIndex = 12
        Me.chbIn.Text = "In a gallery"
        Me.chbIn.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chbRuss)
        Me.GroupBox4.Controls.Add(Me.chbGer)
        Me.GroupBox4.Controls.Add(Me.chbIta)
        Me.GroupBox4.Controls.Add(Me.chbFrench)
        Me.GroupBox4.Controls.Add(Me.chbStolen)
        Me.GroupBox4.Controls.Add(Me.chbNap)
        Me.GroupBox4.Controls.Add(Me.chbRec)
        Me.GroupBox4.Controls.Add(Me.chbSq)
        Me.GroupBox4.Controls.Add(Me.chbDam)
        Me.GroupBox4.Controls.Add(Me.chbOut)
        Me.GroupBox4.Controls.Add(Me.chbPainter)
        Me.GroupBox4.Controls.Add(Me.chbFake)
        Me.GroupBox4.Controls.Add(Me.chbIn)
        Me.GroupBox4.Controls.Add(Me.chbRat)
        Me.GroupBox4.Controls.Add(Me.chbFam)
        Me.GroupBox4.Location = New System.Drawing.Point(301, 456)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(231, 422)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Options"
        '
        'chbRuss
        '
        Me.chbRuss.AutoSize = True
        Me.chbRuss.Location = New System.Drawing.Point(16, 398)
        Me.chbRuss.Name = "chbRuss"
        Me.chbRuss.Size = New System.Drawing.Size(99, 24)
        Me.chbRuss.TabIndex = 24
        Me.chbRuss.Text = "Russian"
        Me.chbRuss.UseVisualStyleBackColor = True
        '
        'chbGer
        '
        Me.chbGer.AutoSize = True
        Me.chbGer.Location = New System.Drawing.Point(16, 372)
        Me.chbGer.Name = "chbGer"
        Me.chbGer.Size = New System.Drawing.Size(97, 24)
        Me.chbGer.TabIndex = 23
        Me.chbGer.Text = "German"
        Me.chbGer.UseVisualStyleBackColor = True
        '
        'chbIta
        '
        Me.chbIta.AutoSize = True
        Me.chbIta.Location = New System.Drawing.Point(16, 342)
        Me.chbIta.Name = "chbIta"
        Me.chbIta.Size = New System.Drawing.Size(82, 24)
        Me.chbIta.TabIndex = 22
        Me.chbIta.Text = "Italian"
        Me.chbIta.UseVisualStyleBackColor = True
        '
        'chbFrench
        '
        Me.chbFrench.AutoSize = True
        Me.chbFrench.Location = New System.Drawing.Point(16, 312)
        Me.chbFrench.Name = "chbFrench"
        Me.chbFrench.Size = New System.Drawing.Size(89, 24)
        Me.chbFrench.TabIndex = 21
        Me.chbFrench.Text = "French"
        Me.chbFrench.UseVisualStyleBackColor = True
        '
        'chbStolen
        '
        Me.chbStolen.AutoSize = True
        Me.chbStolen.Location = New System.Drawing.Point(16, 287)
        Me.chbStolen.Name = "chbStolen"
        Me.chbStolen.Size = New System.Drawing.Size(84, 24)
        Me.chbStolen.TabIndex = 20
        Me.chbStolen.Text = "Stolen"
        Me.chbStolen.UseVisualStyleBackColor = True
        '
        'chbNap
        '
        Me.chbNap.AutoSize = True
        Me.chbNap.Location = New System.Drawing.Point(14, 257)
        Me.chbNap.Name = "chbNap"
        Me.chbNap.Size = New System.Drawing.Size(211, 24)
        Me.chbNap.TabIndex = 19
        Me.chbNap.Text = "Touched by Napoleon"
        Me.chbNap.UseVisualStyleBackColor = True
        '
        'chbRec
        '
        Me.chbRec.AutoSize = True
        Me.chbRec.Location = New System.Drawing.Point(14, 231)
        Me.chbRec.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chbRec.Name = "chbRec"
        Me.chbRec.Size = New System.Drawing.Size(115, 24)
        Me.chbRec.TabIndex = 18
        Me.chbRec.Text = "Rectangle"
        Me.chbRec.UseVisualStyleBackColor = True
        '
        'chbSq
        '
        Me.chbSq.AutoSize = True
        Me.chbSq.Location = New System.Drawing.Point(14, 205)
        Me.chbSq.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chbSq.Name = "chbSq"
        Me.chbSq.Size = New System.Drawing.Size(90, 24)
        Me.chbSq.TabIndex = 17
        Me.chbSq.Text = "Square"
        Me.chbSq.UseVisualStyleBackColor = True
        '
        'chbDam
        '
        Me.chbDam.AutoSize = True
        Me.chbDam.Location = New System.Drawing.Point(14, 179)
        Me.chbDam.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chbDam.Name = "chbDam"
        Me.chbDam.Size = New System.Drawing.Size(110, 24)
        Me.chbDam.TabIndex = 16
        Me.chbDam.Text = "Damaged"
        Me.chbDam.UseVisualStyleBackColor = True
        '
        'chbOut
        '
        Me.chbOut.AutoSize = True
        Me.chbOut.Location = New System.Drawing.Point(14, 153)
        Me.chbOut.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chbOut.Name = "chbOut"
        Me.chbOut.Size = New System.Drawing.Size(131, 24)
        Me.chbOut.TabIndex = 15
        Me.chbOut.Text = "Out for sale"
        Me.chbOut.UseVisualStyleBackColor = True
        '
        'chbPainter
        '
        Me.chbPainter.AutoSize = True
        Me.chbPainter.Location = New System.Drawing.Point(14, 127)
        Me.chbPainter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chbPainter.Name = "chbPainter"
        Me.chbPainter.Size = New System.Drawing.Size(177, 24)
        Me.chbPainter.TabIndex = 14
        Me.chbPainter.Text = "Painter deceased"
        Me.chbPainter.UseVisualStyleBackColor = True
        '
        'chbFake
        '
        Me.chbFake.AutoSize = True
        Me.chbFake.Location = New System.Drawing.Point(14, 101)
        Me.chbFake.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chbFake.Name = "chbFake"
        Me.chbFake.Size = New System.Drawing.Size(71, 24)
        Me.chbFake.TabIndex = 13
        Me.chbFake.Text = "Fake"
        Me.chbFake.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(567, 704)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 40)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(567, 661)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 32)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lstpin
        '
        Me.lstpin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstpin.FormattingEnabled = True
        Me.lstpin.ItemHeight = 20
        Me.lstpin.Location = New System.Drawing.Point(788, 385)
        Me.lstpin.Name = "lstpin"
        Me.lstpin.Size = New System.Drawing.Size(400, 324)
        Me.lstpin.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(567, 552)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(165, 90)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "PIN"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Pic1
        '
        Me.Pic1.Location = New System.Drawing.Point(788, 95)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(372, 252)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic1.TabIndex = 18
        Me.Pic1.TabStop = False
        Me.Pic1.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.OpenToolStripMenuItem1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 24)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(120, 26)
        Me.OpenToolStripMenuItem1.Text = "Open"
        '
        'FillToolStripMenuItem
        '
        Me.FillToolStripMenuItem.Name = "FillToolStripMenuItem"
        Me.FillToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.FillToolStripMenuItem.Text = "Decrypt"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.FillToolStripMenuItem, Me.ChangeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1283, 28)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ChangeToolStripMenuItem.Text = "Change"
        '
        'frmInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1283, 944)
        Me.Controls.Add(Me.Pic1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lstpin)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbStrokes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbArtist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbArtist As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbStrokes As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdOrange As RadioButton
    Friend WithEvents rdYellow As RadioButton
    Friend WithEvents rdRed As RadioButton
    Friend WithEvents rdBlue As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdPlastic As RadioButton
    Friend WithEvents rdWood As RadioButton
    Friend WithEvents rdGold As RadioButton
    Friend WithEvents rdSteel As RadioButton
    Friend WithEvents chbFam As CheckBox
    Friend WithEvents chbRat As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdCub As RadioButton
    Friend WithEvents rdExp As RadioButton
    Friend WithEvents rdImp As RadioButton
    Friend WithEvents rdReal As RadioButton
    Friend WithEvents rdNat As RadioButton
    Friend WithEvents rdRenn As RadioButton
    Friend WithEvents chbIn As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chbSq As CheckBox
    Friend WithEvents chbDam As CheckBox
    Friend WithEvents chbOut As CheckBox
    Friend WithEvents chbPainter As CheckBox
    Friend WithEvents chbFake As CheckBox
    Friend WithEvents chbRec As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lstpin As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents chbRuss As CheckBox
    Friend WithEvents chbGer As CheckBox
    Friend WithEvents chbIta As CheckBox
    Friend WithEvents chbFrench As CheckBox
    Friend WithEvents chbStolen As CheckBox
    Friend WithEvents chbNap As CheckBox
    Friend WithEvents Pic1 As PictureBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FillToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ChangeToolStripMenuItem As ToolStripMenuItem
End Class
