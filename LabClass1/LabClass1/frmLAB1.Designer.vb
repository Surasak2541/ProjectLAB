<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLAB1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTex = New System.Windows.Forms.Label()
        Me.lblNetSalary = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblSalaryperyear = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เครื่องคิดคำนวณหารายได้สุทธิ"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เงินเดือนทั้งปี"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ภาษีที่ต้องชำระ"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "เงินเดือนสุทธิ"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(263, 89)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtSalary.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(112, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "เงินเดือน"
        '
        'lblTex
        '
        Me.lblTex.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTex.Location = New System.Drawing.Point(260, 179)
        Me.lblTex.Name = "lblTex"
        Me.lblTex.Size = New System.Drawing.Size(103, 23)
        Me.lblTex.TabIndex = 1
        '
        'lblNetSalary
        '
        Me.lblNetSalary.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNetSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetSalary.Location = New System.Drawing.Point(260, 219)
        Me.lblNetSalary.Name = "lblNetSalary"
        Me.lblNetSalary.Size = New System.Drawing.Size(103, 22)
        Me.lblNetSalary.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(232, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(375, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 59)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "ปิด"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblSalaryperyear
        '
        Me.lblSalaryperyear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSalaryperyear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalaryperyear.Location = New System.Drawing.Point(263, 137)
        Me.lblSalaryperyear.Name = "lblSalaryperyear"
        Me.lblSalaryperyear.Size = New System.Drawing.Size(100, 23)
        Me.lblSalaryperyear.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(601, 399)
        Me.Controls.Add(Me.lblSalaryperyear)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTex)
        Me.Controls.Add(Me.lblNetSalary)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTex As Label
    Friend WithEvents lblNetSalary As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblSalaryperyear As Label
End Class
