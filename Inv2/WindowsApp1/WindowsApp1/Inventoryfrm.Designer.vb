<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventoryfrm
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoPipe = New System.Windows.Forms.RadioButton()
        Me.rdoSkunk = New System.Windows.Forms.RadioButton()
        Me.rdoCat = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoAWD = New System.Windows.Forms.RadioButton()
        Me.rdoRWD = New System.Windows.Forms.RadioButton()
        Me.rdoFWD = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdo8 = New System.Windows.Forms.RadioButton()
        Me.rdo6 = New System.Windows.Forms.RadioButton()
        Me.rdo4 = New System.Windows.Forms.RadioButton()
        Me.lstVIN = New System.Windows.Forms.ListBox()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.txtVIN = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picCar = New System.Windows.Forms.PictureBox()
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdoX = New System.Windows.Forms.RadioButton()
        Me.rdoV = New System.Windows.Forms.RadioButton()
        Me.rdoInline = New System.Windows.Forms.RadioButton()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdoPipe)
        Me.GroupBox3.Controls.Add(Me.rdoSkunk)
        Me.GroupBox3.Controls.Add(Me.rdoCat)
        Me.GroupBox3.Location = New System.Drawing.Point(358, 103)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(132, 130)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Exhaust Type"
        '
        'rdoPipe
        '
        Me.rdoPipe.AutoSize = True
        Me.rdoPipe.Location = New System.Drawing.Point(11, 87)
        Me.rdoPipe.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPipe.Name = "rdoPipe"
        Me.rdoPipe.Size = New System.Drawing.Size(126, 24)
        Me.rdoPipe.TabIndex = 2
        Me.rdoPipe.Text = "Straight Pipe"
        Me.rdoPipe.UseVisualStyleBackColor = True
        '
        'rdoSkunk
        '
        Me.rdoSkunk.AutoSize = True
        Me.rdoSkunk.Location = New System.Drawing.Point(11, 59)
        Me.rdoSkunk.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSkunk.Name = "rdoSkunk"
        Me.rdoSkunk.Size = New System.Drawing.Size(75, 24)
        Me.rdoSkunk.TabIndex = 1
        Me.rdoSkunk.Text = "Skunk"
        Me.rdoSkunk.UseVisualStyleBackColor = True
        '
        'rdoCat
        '
        Me.rdoCat.AutoSize = True
        Me.rdoCat.Checked = True
        Me.rdoCat.Location = New System.Drawing.Point(11, 31)
        Me.rdoCat.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoCat.Name = "rdoCat"
        Me.rdoCat.Size = New System.Drawing.Size(94, 24)
        Me.rdoCat.TabIndex = 0
        Me.rdoCat.TabStop = True
        Me.rdoCat.Text = "CatBack"
        Me.rdoCat.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoAWD)
        Me.GroupBox2.Controls.Add(Me.rdoRWD)
        Me.GroupBox2.Controls.Add(Me.rdoFWD)
        Me.GroupBox2.Location = New System.Drawing.Point(358, 241)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(132, 130)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Drive Control"
        '
        'rdoAWD
        '
        Me.rdoAWD.AutoSize = True
        Me.rdoAWD.Location = New System.Drawing.Point(11, 87)
        Me.rdoAWD.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoAWD.Name = "rdoAWD"
        Me.rdoAWD.Size = New System.Drawing.Size(70, 24)
        Me.rdoAWD.TabIndex = 2
        Me.rdoAWD.Text = "AWD"
        Me.rdoAWD.UseVisualStyleBackColor = True
        '
        'rdoRWD
        '
        Me.rdoRWD.AutoSize = True
        Me.rdoRWD.Location = New System.Drawing.Point(11, 59)
        Me.rdoRWD.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoRWD.Name = "rdoRWD"
        Me.rdoRWD.Size = New System.Drawing.Size(71, 24)
        Me.rdoRWD.TabIndex = 1
        Me.rdoRWD.Text = "RWD"
        Me.rdoRWD.UseVisualStyleBackColor = True
        '
        'rdoFWD
        '
        Me.rdoFWD.AutoSize = True
        Me.rdoFWD.Checked = True
        Me.rdoFWD.Location = New System.Drawing.Point(11, 31)
        Me.rdoFWD.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFWD.Name = "rdoFWD"
        Me.rdoFWD.Size = New System.Drawing.Size(69, 24)
        Me.rdoFWD.TabIndex = 0
        Me.rdoFWD.TabStop = True
        Me.rdoFWD.Text = "FWD"
        Me.rdoFWD.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdo8)
        Me.GroupBox1.Controls.Add(Me.rdo6)
        Me.GroupBox1.Controls.Add(Me.rdo4)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 103)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(132, 130)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Engine Size"
        '
        'rdo8
        '
        Me.rdo8.AutoSize = True
        Me.rdo8.Location = New System.Drawing.Point(11, 87)
        Me.rdo8.Margin = New System.Windows.Forms.Padding(4)
        Me.rdo8.Name = "rdo8"
        Me.rdo8.Size = New System.Drawing.Size(105, 24)
        Me.rdo8.TabIndex = 2
        Me.rdo8.Text = "8 Cylinder"
        Me.rdo8.UseVisualStyleBackColor = True
        '
        'rdo6
        '
        Me.rdo6.AutoSize = True
        Me.rdo6.Location = New System.Drawing.Point(11, 59)
        Me.rdo6.Margin = New System.Windows.Forms.Padding(4)
        Me.rdo6.Name = "rdo6"
        Me.rdo6.Size = New System.Drawing.Size(105, 24)
        Me.rdo6.TabIndex = 1
        Me.rdo6.Text = "6 Cylinder"
        Me.rdo6.UseVisualStyleBackColor = True
        '
        'rdo4
        '
        Me.rdo4.AutoSize = True
        Me.rdo4.Checked = True
        Me.rdo4.Location = New System.Drawing.Point(11, 31)
        Me.rdo4.Margin = New System.Windows.Forms.Padding(4)
        Me.rdo4.Name = "rdo4"
        Me.rdo4.Size = New System.Drawing.Size(105, 24)
        Me.rdo4.TabIndex = 0
        Me.rdo4.TabStop = True
        Me.rdo4.Text = "4 Cylinder"
        Me.rdo4.UseVisualStyleBackColor = True
        '
        'lstVIN
        '
        Me.lstVIN.FormattingEnabled = True
        Me.lstVIN.ItemHeight = 20
        Me.lstVIN.Location = New System.Drawing.Point(498, 28)
        Me.lstVIN.Margin = New System.Windows.Forms.Padding(4)
        Me.lstVIN.Name = "lstVIN"
        Me.lstVIN.Size = New System.Drawing.Size(200, 224)
        Me.lstVIN.TabIndex = 11
        '
        'cmbModel
        '
        Me.cmbModel.Enabled = False
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Items.AddRange(New Object() {"2000", "2001", "2002", "2003"})
        Me.cmbModel.Location = New System.Drawing.Point(251, 54)
        Me.cmbModel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(96, 28)
        Me.cmbModel.TabIndex = 10
        '
        'cmbMake
        '
        Me.cmbMake.Enabled = False
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Toyota", "Ford", "Chevrolet"})
        Me.cmbMake.Location = New System.Drawing.Point(147, 54)
        Me.cmbMake.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(96, 28)
        Me.cmbMake.TabIndex = 9
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2000", "2001", "2002", "2003"})
        Me.cmbYear.Location = New System.Drawing.Point(43, 54)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(96, 28)
        Me.cmbYear.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckBox8)
        Me.GroupBox4.Controls.Add(Me.CheckBox7)
        Me.GroupBox4.Controls.Add(Me.CheckBox6)
        Me.GroupBox4.Controls.Add(Me.CheckBox5)
        Me.GroupBox4.Controls.Add(Me.CheckBox4)
        Me.GroupBox4.Controls.Add(Me.CheckBox3)
        Me.GroupBox4.Controls.Add(Me.CheckBox2)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(43, 241)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(294, 140)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Misc..."
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(159, 113)
        Me.CheckBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(121, 24)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "LED Lamps"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(159, 85)
        Me.CheckBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(115, 24)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "Angel Eyes"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(159, 57)
        Me.CheckBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(112, 24)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "Moon Roof"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(159, 28)
        Me.CheckBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(130, 24)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "Fuel Injection"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(8, 113)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(140, 24)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Cold Air Intake"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(8, 85)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(74, 24)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Turbo"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(8, 57)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(111, 24)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Hydraulics"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(8, 28)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(65, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "ABS"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Make"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Model"
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(627, 285)
        Me.cmdCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(132, 42)
        Me.cmdCreate.TabIndex = 19
        Me.cmdCreate.Text = "Create VIN"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'txtVIN
        '
        Me.txtVIN.Location = New System.Drawing.Point(569, 334)
        Me.txtVIN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVIN.Name = "txtVIN"
        Me.txtVIN.ReadOnly = True
        Me.txtVIN.Size = New System.Drawing.Size(255, 26)
        Me.txtVIN.TabIndex = 20
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(627, 364)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(132, 32)
        Me.cmdAdd.TabIndex = 21
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(706, 35)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Car Picture"
        Me.Label4.Visible = False
        '
        'picCar
        '
        Me.picCar.Location = New System.Drawing.Point(705, 54)
        Me.picCar.Name = "picCar"
        Me.picCar.Size = New System.Drawing.Size(283, 145)
        Me.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar.TabIndex = 23
        Me.picCar.TabStop = False
        Me.picCar.Visible = False
        '
        'cmdChange
        '
        Me.cmdChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChange.Location = New System.Drawing.Point(511, 285)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(79, 36)
        Me.cmdChange.TabIndex = 24
        Me.cmdChange.Text = "Replace VIN"
        Me.cmdChange.UseVisualStyleBackColor = True
        Me.cmdChange.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.ForeColor = System.Drawing.Color.Red
        Me.cmdDelete.Location = New System.Drawing.Point(511, 364)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(79, 36)
        Me.cmdDelete.TabIndex = 25
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.Visible = False
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(801, 285)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(89, 42)
        Me.cmdReset.TabIndex = 26
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1093, 28)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsToolStripMenuItem, Me.SaveToolStripMenuItem, Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdoX)
        Me.GroupBox5.Controls.Add(Me.rdoV)
        Me.GroupBox5.Controls.Add(Me.rdoInline)
        Me.GroupBox5.Location = New System.Drawing.Point(202, 103)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(132, 130)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Engine Design"
        '
        'rdoX
        '
        Me.rdoX.AutoSize = True
        Me.rdoX.Location = New System.Drawing.Point(11, 87)
        Me.rdoX.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoX.Name = "rdoX"
        Me.rdoX.Size = New System.Drawing.Size(77, 24)
        Me.rdoX.TabIndex = 2
        Me.rdoX.Text = "X type"
        Me.rdoX.UseVisualStyleBackColor = True
        '
        'rdoV
        '
        Me.rdoV.AutoSize = True
        Me.rdoV.Location = New System.Drawing.Point(11, 59)
        Me.rdoV.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoV.Name = "rdoV"
        Me.rdoV.Size = New System.Drawing.Size(77, 24)
        Me.rdoV.TabIndex = 1
        Me.rdoV.Text = "V type"
        Me.rdoV.UseVisualStyleBackColor = True
        '
        'rdoInline
        '
        Me.rdoInline.AutoSize = True
        Me.rdoInline.Checked = True
        Me.rdoInline.Location = New System.Drawing.Point(11, 31)
        Me.rdoInline.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoInline.Name = "rdoInline"
        Me.rdoInline.Size = New System.Drawing.Size(69, 24)
        Me.rdoInline.TabIndex = 0
        Me.rdoInline.TabStop = True
        Me.rdoInline.Text = "Inline"
        Me.rdoInline.UseVisualStyleBackColor = True
        '
        'cmbColor
        '
        Me.cmbColor.Enabled = False
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Items.AddRange(New Object() {"Black", "Blue", "Green", "Red", "White", "Yellow"})
        Me.cmbColor.Location = New System.Drawing.Point(355, 54)
        Me.cmbColor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(96, 28)
        Me.cmbColor.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(366, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Color"
        '
        'Inventoryfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 428)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbColor)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.picCar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtVIN)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstVIN)
        Me.Controls.Add(Me.cmbModel)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Inventoryfrm"
        Me.Text = "Inventory"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdoPipe As RadioButton
    Friend WithEvents rdoSkunk As RadioButton
    Friend WithEvents rdoCat As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoAWD As RadioButton
    Friend WithEvents rdoRWD As RadioButton
    Private WithEvents rdoFWD As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdo8 As RadioButton
    Friend WithEvents rdo6 As RadioButton
    Friend WithEvents rdo4 As RadioButton
    Friend WithEvents lstVIN As ListBox
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdCreate As Button
    Friend WithEvents txtVIN As TextBox
    Friend WithEvents cmdAdd As Button
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents picCar As PictureBox
    Friend WithEvents cmdChange As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rdoX As RadioButton
    Friend WithEvents rdoV As RadioButton
    Friend WithEvents rdoInline As RadioButton
    Friend WithEvents cmbColor As ComboBox
    Friend WithEvents Label5 As Label
End Class
