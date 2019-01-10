<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLAB3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLAB3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUP = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblF_Red = New System.Windows.Forms.Label()
        Me.lblF_Blue = New System.Windows.Forms.Label()
        Me.lblF_Green = New System.Windows.Forms.Label()
        Me.lblF_Ping = New System.Windows.Forms.Label()
        Me.lblF_Black = New System.Windows.Forms.Label()
        Me.lblF_Sky = New System.Windows.Forms.Label()
        Me.lblF_White = New System.Windows.Forms.Label()
        Me.lblF_Brown = New System.Windows.Forms.Label()
        Me.lblF_Yello = New System.Windows.Forms.Label()
        Me.lblF_Orange = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblB_Orange = New System.Windows.Forms.Label()
        Me.lblB_Yello = New System.Windows.Forms.Label()
        Me.lblB_Brown = New System.Windows.Forms.Label()
        Me.lblB_White = New System.Windows.Forms.Label()
        Me.lblB_Sky = New System.Windows.Forms.Label()
        Me.lblB_Black = New System.Windows.Forms.Label()
        Me.lblB_Ping = New System.Windows.Forms.Label()
        Me.lblB_Green = New System.Windows.Forms.Label()
        Me.lblB_Blue = New System.Windows.Forms.Label()
        Me.lblB_Red = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "กำหนดค่า"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(171, 44)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(355, 74)
        Me.txtInput.TabIndex = 1
        '
        'btnUP
        '
        Me.btnUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnUP.Location = New System.Drawing.Point(532, 44)
        Me.btnUP.Name = "btnUP"
        Me.btnUP.Size = New System.Drawing.Size(75, 33)
        Me.btnUP.TabIndex = 2
        Me.btnUP.Text = "+"
        Me.btnUP.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDown.Location = New System.Drawing.Point(532, 83)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 35)
        Me.btnDown.TabIndex = 3
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"10", "12", "14", "18", "22", "24", "28", "32", "36", "40", "44", "48", "52", "56", "60", "74", "66", "70"})
        Me.ComboBox1.Location = New System.Drawing.Point(520, 124)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(87, 21)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "------เลือก------"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.lblF_Orange)
        Me.GroupBox1.Controls.Add(Me.lblF_Yello)
        Me.GroupBox1.Controls.Add(Me.lblF_Brown)
        Me.GroupBox1.Controls.Add(Me.lblF_White)
        Me.GroupBox1.Controls.Add(Me.lblF_Sky)
        Me.GroupBox1.Controls.Add(Me.lblF_Black)
        Me.GroupBox1.Controls.Add(Me.lblF_Ping)
        Me.GroupBox1.Controls.Add(Me.lblF_Green)
        Me.GroupBox1.Controls.Add(Me.lblF_Blue)
        Me.GroupBox1.Controls.Add(Me.lblF_Red)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 181)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForeColor"
        '
        'lblF_Red
        '
        Me.lblF_Red.BackColor = System.Drawing.Color.Red
        Me.lblF_Red.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF_Red.Location = New System.Drawing.Point(20, 26)
        Me.lblF_Red.Name = "lblF_Red"
        Me.lblF_Red.Size = New System.Drawing.Size(49, 46)
        Me.lblF_Red.TabIndex = 0
        '
        'lblF_Blue
        '
        Me.lblF_Blue.BackColor = System.Drawing.Color.Blue
        Me.lblF_Blue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF_Blue.Location = New System.Drawing.Point(75, 26)
        Me.lblF_Blue.Name = "lblF_Blue"
        Me.lblF_Blue.Size = New System.Drawing.Size(49, 46)
        Me.lblF_Blue.TabIndex = 0
        '
        'lblF_Green
        '
        Me.lblF_Green.BackColor = System.Drawing.Color.Lime
        Me.lblF_Green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF_Green.Location = New System.Drawing.Point(130, 26)
        Me.lblF_Green.Name = "lblF_Green"
        Me.lblF_Green.Size = New System.Drawing.Size(49, 46)
        Me.lblF_Green.TabIndex = 0
        '
        'lblF_Ping
        '
        Me.lblF_Ping.BackColor = System.Drawing.Color.Magenta
        Me.lblF_Ping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF_Ping.Location = New System.Drawing.Point(185, 26)
        Me.lblF_Ping.Name = "lblF_Ping"
        Me.lblF_Ping.Size = New System.Drawing.Size(49, 46)
        Me.lblF_Ping.TabIndex = 0
        '
        'lblF_Black
        '
        Me.lblF_Black.BackColor = System.Drawing.Color.Black
        Me.lblF_Black.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF_Black.Location = New System.Drawing.Point(240, 26)
        Me.lblF_Black.Name = "lblF_Black"
        Me.lblF_Black.Size = New System.Drawing.Size(49, 46)
        Me.lblF_Black.TabIndex = 0
        '
        'lblF_Sky
        '
        Me.lblF_Sky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblF_Sky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF_Sky.Location = New System.Drawing.Point(240, 94)
        Me.lblF_Sky.Name = "lblF_Sky"
        Me.lblF_Sky.Size = New System.Drawing.Size(49, 46)
        Me.lblF_Sky.TabIndex = 0
        '
        'lblF_White
        '
        Me.lblF_White.BackColor = System.Drawing.Color.White
        Me.lblF_White.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF_White.Location = New System.Drawing.Point(185, 94)
        Me.lblF_White.Name = "lblF_White"
        Me.lblF_White.Size = New System.Drawing.Size(49, 46)
        Me.lblF_White.TabIndex = 0
        '
        'lblF_Brown
        '
        Me.lblF_Brown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblF_Brown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF_Brown.Location = New System.Drawing.Point(130, 94)
        Me.lblF_Brown.Name = "lblF_Brown"
        Me.lblF_Brown.Size = New System.Drawing.Size(49, 46)
        Me.lblF_Brown.TabIndex = 0
        '
        'lblF_Yello
        '
        Me.lblF_Yello.BackColor = System.Drawing.Color.Yellow
        Me.lblF_Yello.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF_Yello.Location = New System.Drawing.Point(75, 94)
        Me.lblF_Yello.Name = "lblF_Yello"
        Me.lblF_Yello.Size = New System.Drawing.Size(49, 46)
        Me.lblF_Yello.TabIndex = 0
        '
        'lblF_Orange
        '
        Me.lblF_Orange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblF_Orange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF_Orange.Location = New System.Drawing.Point(20, 94)
        Me.lblF_Orange.Name = "lblF_Orange"
        Me.lblF_Orange.Size = New System.Drawing.Size(49, 46)
        Me.lblF_Orange.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Controls.Add(Me.lblB_Orange)
        Me.GroupBox2.Controls.Add(Me.lblB_Yello)
        Me.GroupBox2.Controls.Add(Me.lblB_Brown)
        Me.GroupBox2.Controls.Add(Me.lblB_White)
        Me.GroupBox2.Controls.Add(Me.lblB_Sky)
        Me.GroupBox2.Controls.Add(Me.lblB_Black)
        Me.GroupBox2.Controls.Add(Me.lblB_Ping)
        Me.GroupBox2.Controls.Add(Me.lblB_Green)
        Me.GroupBox2.Controls.Add(Me.lblB_Blue)
        Me.GroupBox2.Controls.Add(Me.lblB_Red)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(457, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 181)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BGColor"
        '
        'lblB_Orange
        '
        Me.lblB_Orange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblB_Orange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblB_Orange.Location = New System.Drawing.Point(20, 94)
        Me.lblB_Orange.Name = "lblB_Orange"
        Me.lblB_Orange.Size = New System.Drawing.Size(49, 46)
        Me.lblB_Orange.TabIndex = 0
        '
        'lblB_Yello
        '
        Me.lblB_Yello.BackColor = System.Drawing.Color.Yellow
        Me.lblB_Yello.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblB_Yello.Location = New System.Drawing.Point(75, 94)
        Me.lblB_Yello.Name = "lblB_Yello"
        Me.lblB_Yello.Size = New System.Drawing.Size(49, 46)
        Me.lblB_Yello.TabIndex = 0
        '
        'lblB_Brown
        '
        Me.lblB_Brown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblB_Brown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblB_Brown.Location = New System.Drawing.Point(130, 94)
        Me.lblB_Brown.Name = "lblB_Brown"
        Me.lblB_Brown.Size = New System.Drawing.Size(49, 46)
        Me.lblB_Brown.TabIndex = 0
        '
        'lblB_White
        '
        Me.lblB_White.BackColor = System.Drawing.Color.White
        Me.lblB_White.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblB_White.Location = New System.Drawing.Point(185, 94)
        Me.lblB_White.Name = "lblB_White"
        Me.lblB_White.Size = New System.Drawing.Size(49, 46)
        Me.lblB_White.TabIndex = 0
        '
        'lblB_Sky
        '
        Me.lblB_Sky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblB_Sky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblB_Sky.Location = New System.Drawing.Point(240, 94)
        Me.lblB_Sky.Name = "lblB_Sky"
        Me.lblB_Sky.Size = New System.Drawing.Size(49, 46)
        Me.lblB_Sky.TabIndex = 0
        '
        'lblB_Black
        '
        Me.lblB_Black.BackColor = System.Drawing.Color.Black
        Me.lblB_Black.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblB_Black.Location = New System.Drawing.Point(240, 26)
        Me.lblB_Black.Name = "lblB_Black"
        Me.lblB_Black.Size = New System.Drawing.Size(49, 46)
        Me.lblB_Black.TabIndex = 0
        '
        'lblB_Ping
        '
        Me.lblB_Ping.BackColor = System.Drawing.Color.Magenta
        Me.lblB_Ping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblB_Ping.Location = New System.Drawing.Point(185, 26)
        Me.lblB_Ping.Name = "lblB_Ping"
        Me.lblB_Ping.Size = New System.Drawing.Size(49, 46)
        Me.lblB_Ping.TabIndex = 0
        '
        'lblB_Green
        '
        Me.lblB_Green.BackColor = System.Drawing.Color.Lime
        Me.lblB_Green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblB_Green.Location = New System.Drawing.Point(130, 26)
        Me.lblB_Green.Name = "lblB_Green"
        Me.lblB_Green.Size = New System.Drawing.Size(49, 46)
        Me.lblB_Green.TabIndex = 0
        '
        'lblB_Blue
        '
        Me.lblB_Blue.BackColor = System.Drawing.Color.Blue
        Me.lblB_Blue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblB_Blue.Location = New System.Drawing.Point(75, 26)
        Me.lblB_Blue.Name = "lblB_Blue"
        Me.lblB_Blue.Size = New System.Drawing.Size(49, 46)
        Me.lblB_Blue.TabIndex = 0
        '
        'lblB_Red
        '
        Me.lblB_Red.BackColor = System.Drawing.Color.Red
        Me.lblB_Red.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblB_Red.Location = New System.Drawing.Point(20, 26)
        Me.lblB_Red.Name = "lblB_Red"
        Me.lblB_Red.Size = New System.Drawing.Size(49, 46)
        Me.lblB_Red.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(417, 124)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 26)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "ขนาดฟอนด์"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(850, 452)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUP)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUP As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblF_Orange As Label
    Friend WithEvents lblF_Yello As Label
    Friend WithEvents lblF_Brown As Label
    Friend WithEvents lblF_White As Label
    Friend WithEvents lblF_Sky As Label
    Friend WithEvents lblF_Black As Label
    Friend WithEvents lblF_Ping As Label
    Friend WithEvents lblF_Green As Label
    Friend WithEvents lblF_Blue As Label
    Friend WithEvents lblF_Red As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblB_Orange As Label
    Friend WithEvents lblB_Yello As Label
    Friend WithEvents lblB_Brown As Label
    Friend WithEvents lblB_White As Label
    Friend WithEvents lblB_Sky As Label
    Friend WithEvents lblB_Black As Label
    Friend WithEvents lblB_Ping As Label
    Friend WithEvents lblB_Green As Label
    Friend WithEvents lblB_Blue As Label
    Friend WithEvents lblB_Red As Label
    Friend WithEvents Label22 As Label
End Class
