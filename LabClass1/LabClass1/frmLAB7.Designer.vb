<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLAB7
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
        Me.btnMove = New System.Windows.Forms.Button()
        Me.lstadd = New System.Windows.Forms.ListBox()
        Me.btnMoveAll = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBackAll = New System.Windows.Forms.Button()
        Me.Cbooutput = New System.Windows.Forms.ComboBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.lblout = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(241, 71)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(75, 39)
        Me.btnMove.TabIndex = 0
        Me.btnMove.Text = ">"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'lstadd
        '
        Me.lstadd.FormattingEnabled = True
        Me.lstadd.Location = New System.Drawing.Point(65, 61)
        Me.lstadd.Name = "lstadd"
        Me.lstadd.Size = New System.Drawing.Size(152, 225)
        Me.lstadd.TabIndex = 1
        '
        'btnMoveAll
        '
        Me.btnMoveAll.Location = New System.Drawing.Point(241, 125)
        Me.btnMoveAll.Name = "btnMoveAll"
        Me.btnMoveAll.Size = New System.Drawing.Size(75, 39)
        Me.btnMoveAll.TabIndex = 0
        Me.btnMoveAll.Text = ">>"
        Me.btnMoveAll.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(241, 179)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 39)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnBackAll
        '
        Me.btnBackAll.Location = New System.Drawing.Point(241, 233)
        Me.btnBackAll.Name = "btnBackAll"
        Me.btnBackAll.Size = New System.Drawing.Size(75, 39)
        Me.btnBackAll.TabIndex = 0
        Me.btnBackAll.Text = "<<"
        Me.btnBackAll.UseVisualStyleBackColor = True
        '
        'Cbooutput
        '
        Me.Cbooutput.FormattingEnabled = True
        Me.Cbooutput.Location = New System.Drawing.Point(397, 61)
        Me.Cbooutput.Name = "Cbooutput"
        Me.Cbooutput.Size = New System.Drawing.Size(121, 21)
        Me.Cbooutput.TabIndex = 2
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(99, 292)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 39)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "เพิ่ม"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(434, 292)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 39)
        Me.btnclear.TabIndex = 0
        Me.btnclear.Text = "เคลียร์"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(65, 355)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(131, 26)
        Me.txtadd.TabIndex = 3
        '
        'lblout
        '
        Me.lblout.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblout.Location = New System.Drawing.Point(431, 358)
        Me.lblout.Name = "lblout"
        Me.lblout.Size = New System.Drawing.Size(113, 41)
        Me.lblout.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(241, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "ปิด"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmLAB7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 454)
        Me.Controls.Add(Me.lblout)
        Me.Controls.Add(Me.txtadd)
        Me.Controls.Add(Me.Cbooutput)
        Me.Controls.Add(Me.lstadd)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnBackAll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMoveAll)
        Me.Controls.Add(Me.btnMove)
        Me.Name = "frmLAB7"
        Me.Text = "frmLAB7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMove As Button
    Friend WithEvents lstadd As ListBox
    Friend WithEvents btnMoveAll As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnBackAll As Button
    Friend WithEvents Cbooutput As ComboBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents txtadd As TextBox
    Friend WithEvents lblout As Label
    Friend WithEvents btnExit As Button
End Class
