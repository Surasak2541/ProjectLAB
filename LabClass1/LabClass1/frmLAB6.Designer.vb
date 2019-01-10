<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLAB6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkCarForMe = New System.Windows.Forms.CheckBox()
        Me.lblSartPrice = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkItemsAdd1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkItemsAdd2 = New System.Windows.Forms.CheckBox()
        Me.chkItemsAdd3 = New System.Windows.Forms.CheckBox()
        Me.chkItemsAdd4 = New System.Windows.Forms.CheckBox()
        Me.lblItemsPrice1 = New System.Windows.Forms.Label()
        Me.lblItemsPrice2 = New System.Windows.Forms.Label()
        Me.lblItemsPrice3 = New System.Windows.Forms.Label()
        Me.lblItemsPrice4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFree3 = New System.Windows.Forms.Label()
        Me.lblFree2 = New System.Windows.Forms.Label()
        Me.lblFree1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Chkfree3 = New System.Windows.Forms.CheckBox()
        Me.Chkfree2 = New System.Windows.Forms.CheckBox()
        Me.Chkfree1 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPaidPrice = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณราคาขายรถยนต์"
        '
        'chkCarForMe
        '
        Me.chkCarForMe.AutoSize = True
        Me.chkCarForMe.Location = New System.Drawing.Point(50, 97)
        Me.chkCarForMe.Name = "chkCarForMe"
        Me.chkCarForMe.Size = New System.Drawing.Size(92, 17)
        Me.chkCarForMe.TabIndex = 1
        Me.chkCarForMe.Text = "ISUZU MU7X"
        Me.chkCarForMe.UseVisualStyleBackColor = True
        '
        'lblSartPrice
        '
        Me.lblSartPrice.BackColor = System.Drawing.Color.Yellow
        Me.lblSartPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSartPrice.Location = New System.Drawing.Point(391, 97)
        Me.lblSartPrice.Name = "lblSartPrice"
        Me.lblSartPrice.Size = New System.Drawing.Size(160, 30)
        Me.lblSartPrice.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblItemsPrice4)
        Me.GroupBox1.Controls.Add(Me.lblItemsPrice3)
        Me.GroupBox1.Controls.Add(Me.lblItemsPrice2)
        Me.GroupBox1.Controls.Add(Me.lblItemsPrice1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkItemsAdd4)
        Me.GroupBox1.Controls.Add(Me.chkItemsAdd3)
        Me.GroupBox1.Controls.Add(Me.chkItemsAdd2)
        Me.GroupBox1.Controls.Add(Me.chkItemsAdd1)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 195)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "อุปกรณ์เสริม"
        '
        'chkItemsAdd1
        '
        Me.chkItemsAdd1.AutoSize = True
        Me.chkItemsAdd1.Location = New System.Drawing.Point(6, 48)
        Me.chkItemsAdd1.Name = "chkItemsAdd1"
        Me.chkItemsAdd1.Size = New System.Drawing.Size(76, 17)
        Me.chkItemsAdd1.TabIndex = 0
        Me.chkItemsAdd1.Text = "กันชนหน้า"
        Me.chkItemsAdd1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "รายการ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ราคา"
        '
        'chkItemsAdd2
        '
        Me.chkItemsAdd2.AutoSize = True
        Me.chkItemsAdd2.Location = New System.Drawing.Point(6, 85)
        Me.chkItemsAdd2.Name = "chkItemsAdd2"
        Me.chkItemsAdd2.Size = New System.Drawing.Size(80, 17)
        Me.chkItemsAdd2.TabIndex = 0
        Me.chkItemsAdd2.Text = "ชุดเสริมข้าง"
        Me.chkItemsAdd2.UseVisualStyleBackColor = True
        '
        'chkItemsAdd3
        '
        Me.chkItemsAdd3.AutoSize = True
        Me.chkItemsAdd3.Location = New System.Drawing.Point(6, 120)
        Me.chkItemsAdd3.Name = "chkItemsAdd3"
        Me.chkItemsAdd3.Size = New System.Drawing.Size(79, 17)
        Me.chkItemsAdd3.TabIndex = 0
        Me.chkItemsAdd3.Text = "เเล็คหลังคา"
        Me.chkItemsAdd3.UseVisualStyleBackColor = True
        '
        'chkItemsAdd4
        '
        Me.chkItemsAdd4.AutoSize = True
        Me.chkItemsAdd4.Location = New System.Drawing.Point(6, 157)
        Me.chkItemsAdd4.Name = "chkItemsAdd4"
        Me.chkItemsAdd4.Size = New System.Drawing.Size(60, 17)
        Me.chkItemsAdd4.TabIndex = 0
        Me.chkItemsAdd4.Text = "ล้อแม็ก"
        Me.chkItemsAdd4.UseVisualStyleBackColor = True
        '
        'lblItemsPrice1
        '
        Me.lblItemsPrice1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblItemsPrice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemsPrice1.Location = New System.Drawing.Point(114, 48)
        Me.lblItemsPrice1.Name = "lblItemsPrice1"
        Me.lblItemsPrice1.Size = New System.Drawing.Size(100, 23)
        Me.lblItemsPrice1.TabIndex = 2
        Me.lblItemsPrice1.Text = "40000"
        '
        'lblItemsPrice2
        '
        Me.lblItemsPrice2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblItemsPrice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemsPrice2.Location = New System.Drawing.Point(114, 79)
        Me.lblItemsPrice2.Name = "lblItemsPrice2"
        Me.lblItemsPrice2.Size = New System.Drawing.Size(100, 23)
        Me.lblItemsPrice2.TabIndex = 2
        Me.lblItemsPrice2.Text = "50000"
        '
        'lblItemsPrice3
        '
        Me.lblItemsPrice3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblItemsPrice3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemsPrice3.Location = New System.Drawing.Point(114, 114)
        Me.lblItemsPrice3.Name = "lblItemsPrice3"
        Me.lblItemsPrice3.Size = New System.Drawing.Size(100, 23)
        Me.lblItemsPrice3.TabIndex = 2
        Me.lblItemsPrice3.Text = "20000"
        '
        'lblItemsPrice4
        '
        Me.lblItemsPrice4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblItemsPrice4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemsPrice4.Location = New System.Drawing.Point(114, 157)
        Me.lblItemsPrice4.Name = "lblItemsPrice4"
        Me.lblItemsPrice4.Size = New System.Drawing.Size(100, 23)
        Me.lblItemsPrice4.TabIndex = 2
        Me.lblItemsPrice4.Text = "30000"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFree3)
        Me.GroupBox2.Controls.Add(Me.lblFree2)
        Me.GroupBox2.Controls.Add(Me.lblFree1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Chkfree3)
        Me.GroupBox2.Controls.Add(Me.Chkfree2)
        Me.GroupBox2.Controls.Add(Me.Chkfree1)
        Me.GroupBox2.Location = New System.Drawing.Point(350, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 195)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "สิทธพิเศษ"
        '
        'lblFree3
        '
        Me.lblFree3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFree3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFree3.Location = New System.Drawing.Point(130, 114)
        Me.lblFree3.Name = "lblFree3"
        Me.lblFree3.Size = New System.Drawing.Size(100, 23)
        Me.lblFree3.TabIndex = 2
        Me.lblFree3.Text = "35000"
        '
        'lblFree2
        '
        Me.lblFree2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFree2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFree2.Location = New System.Drawing.Point(130, 79)
        Me.lblFree2.Name = "lblFree2"
        Me.lblFree2.Size = New System.Drawing.Size(100, 23)
        Me.lblFree2.TabIndex = 2
        Me.lblFree2.Text = "15000"
        '
        'lblFree1
        '
        Me.lblFree1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFree1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFree1.Location = New System.Drawing.Point(130, 48)
        Me.lblFree1.Name = "lblFree1"
        Me.lblFree1.Size = New System.Drawing.Size(100, 23)
        Me.lblFree1.TabIndex = 2
        Me.lblFree1.Text = "25000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(161, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "ราคา"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "รายการ"
        '
        'Chkfree3
        '
        Me.Chkfree3.AutoSize = True
        Me.Chkfree3.Location = New System.Drawing.Point(6, 120)
        Me.Chkfree3.Name = "Chkfree3"
        Me.Chkfree3.Size = New System.Drawing.Size(78, 17)
        Me.Chkfree3.TabIndex = 0
        Me.Chkfree3.Text = "จดทะเบียน"
        Me.Chkfree3.UseVisualStyleBackColor = True
        '
        'Chkfree2
        '
        Me.Chkfree2.AutoSize = True
        Me.Chkfree2.Location = New System.Drawing.Point(6, 85)
        Me.Chkfree2.Name = "Chkfree2"
        Me.Chkfree2.Size = New System.Drawing.Size(62, 17)
        Me.Chkfree2.TabIndex = 0
        Me.Chkfree2.Text = "ทำ พรบ"
        Me.Chkfree2.UseVisualStyleBackColor = True
        '
        'Chkfree1
        '
        Me.Chkfree1.AutoSize = True
        Me.Chkfree1.Location = New System.Drawing.Point(6, 48)
        Me.Chkfree1.Name = "Chkfree1"
        Me.Chkfree1.Size = New System.Drawing.Size(108, 17)
        Me.Chkfree1.TabIndex = 0
        Me.Chkfree1.Text = "ประกันภัยชั้นหนึ่ง"
        Me.Chkfree1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(161, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 25)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "ราคาสุทธิ"
        '
        'lblPaidPrice
        '
        Me.lblPaidPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPaidPrice.Location = New System.Drawing.Point(288, 381)
        Me.lblPaidPrice.Name = "lblPaidPrice"
        Me.lblPaidPrice.Size = New System.Drawing.Size(263, 41)
        Me.lblPaidPrice.TabIndex = 5
        '
        'frmLAB6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 441)
        Me.Controls.Add(Me.lblPaidPrice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSartPrice)
        Me.Controls.Add(Me.chkCarForMe)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLAB6"
        Me.Text = "frmLAB6"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkCarForMe As CheckBox
    Friend WithEvents lblSartPrice As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblItemsPrice4 As Label
    Friend WithEvents lblItemsPrice3 As Label
    Friend WithEvents lblItemsPrice2 As Label
    Friend WithEvents lblItemsPrice1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkItemsAdd4 As CheckBox
    Friend WithEvents chkItemsAdd3 As CheckBox
    Friend WithEvents chkItemsAdd2 As CheckBox
    Friend WithEvents chkItemsAdd1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblFree3 As Label
    Friend WithEvents lblFree2 As Label
    Friend WithEvents lblFree1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Chkfree3 As CheckBox
    Friend WithEvents Chkfree2 As CheckBox
    Friend WithEvents Chkfree1 As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPaidPrice As Label
End Class
