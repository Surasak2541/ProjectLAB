<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLAB8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLAB8))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstSubject = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lstCredit = New System.Windows.Forms.ListBox()
        Me.lstGrade = New System.Windows.Forms.ListBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClaer = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblOldTotalScore = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9lblOldTotalCredit = New System.Windows.Forms.Label()
        Me.lblOldGPA = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblNewGPA = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณเกรด"
        '
        'lstSubject
        '
        Me.lstSubject.FormattingEnabled = True
        Me.lstSubject.Location = New System.Drawing.Point(56, 83)
        Me.lstSubject.Name = "lstSubject"
        Me.lstSubject.Size = New System.Drawing.Size(120, 199)
        Me.lstSubject.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "วิชา"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "คะแนนสอบ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(316, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "หน่อยกิต"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(445, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "เกรด"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lstScore
        '
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.Location = New System.Drawing.Point(182, 83)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(120, 199)
        Me.lstScore.TabIndex = 5
        '
        'lstCredit
        '
        Me.lstCredit.FormattingEnabled = True
        Me.lstCredit.Location = New System.Drawing.Point(308, 83)
        Me.lstCredit.Name = "lstCredit"
        Me.lstCredit.Size = New System.Drawing.Size(120, 199)
        Me.lstCredit.TabIndex = 4
        '
        'lstGrade
        '
        Me.lstGrade.FormattingEnabled = True
        Me.lstGrade.Location = New System.Drawing.Point(434, 83)
        Me.lstGrade.Name = "lstGrade"
        Me.lstGrade.Size = New System.Drawing.Size(120, 199)
        Me.lstGrade.TabIndex = 3
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(65, 288)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(100, 20)
        Me.txtSubject.TabIndex = 0
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(192, 288)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(100, 20)
        Me.txtScore.TabIndex = 1
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(316, 288)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(100, 20)
        Me.txtCredit.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(443, 288)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(54, 34)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClaer
        '
        Me.btnClaer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClaer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClaer.Location = New System.Drawing.Point(503, 288)
        Me.btnClaer.Name = "btnClaer"
        Me.btnClaer.Size = New System.Drawing.Size(54, 34)
        Me.btnClaer.TabIndex = 4
        Me.btnClaer.Text = "เคลียร์"
        Me.btnClaer.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(53, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "คะแนนสะสมก่อนหน้า"
        '
        'lblOldTotalScore
        '
        Me.lblOldTotalScore.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblOldTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOldTotalScore.Location = New System.Drawing.Point(167, 329)
        Me.lblOldTotalScore.Name = "lblOldTotalScore"
        Me.lblOldTotalScore.Size = New System.Drawing.Size(57, 24)
        Me.lblOldTotalScore.TabIndex = 5
        Me.lblOldTotalScore.Text = "150"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(230, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "หน่วยกิจสะสม"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(397, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "เกรดเฉลี่ยสะสม"
        '
        'Label9lblOldTotalCredit
        '
        Me.Label9lblOldTotalCredit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9lblOldTotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9lblOldTotalCredit.Location = New System.Drawing.Point(316, 329)
        Me.Label9lblOldTotalCredit.Name = "Label9lblOldTotalCredit"
        Me.Label9lblOldTotalCredit.Size = New System.Drawing.Size(57, 24)
        Me.Label9lblOldTotalCredit.TabIndex = 5
        Me.Label9lblOldTotalCredit.Text = "50"
        '
        'lblOldGPA
        '
        Me.lblOldGPA.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblOldGPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOldGPA.Location = New System.Drawing.Point(485, 329)
        Me.lblOldGPA.Name = "lblOldGPA"
        Me.lblOldGPA.Size = New System.Drawing.Size(57, 24)
        Me.lblOldGPA.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(92, 386)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 15)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "เกรดเฉลี่ยสะสมภาคปัจจุบัน"
        '
        'lblNewGPA
        '
        Me.lblNewGPA.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNewGPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNewGPA.Location = New System.Drawing.Point(250, 386)
        Me.lblNewGPA.Name = "lblNewGPA"
        Me.lblNewGPA.Size = New System.Drawing.Size(86, 24)
        Me.lblNewGPA.TabIndex = 5
        '
        'frmLAB8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(615, 430)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblOldGPA)
        Me.Controls.Add(Me.lblNewGPA)
        Me.Controls.Add(Me.Label9lblOldTotalCredit)
        Me.Controls.Add(Me.lblOldTotalScore)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClaer)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstGrade)
        Me.Controls.Add(Me.lstCredit)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.lstSubject)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmLAB8"
        Me.Text = "frmLAB8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstSubject As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstScore As ListBox
    Friend WithEvents lstCredit As ListBox
    Friend WithEvents lstGrade As ListBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClaer As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblOldTotalScore As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9lblOldTotalCredit As Label
    Friend WithEvents lblOldGPA As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblNewGPA As Label
End Class
