<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLAB5
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radMember = New System.Windows.Forms.RadioButton()
        Me.gpbPaid = New System.Windows.Forms.GroupBox()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.radPaid = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gpbPaid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณการขาย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ราคาขาย"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "สินค้า"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "จำนวนซื้อ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เป็นเงิน"
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(189, 71)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(213, 20)
        Me.txtProduct.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(189, 112)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(213, 20)
        Me.txtPrice.TabIndex = 2
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(189, 153)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(213, 20)
        Me.txtUnit.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radOther)
        Me.GroupBox1.Controls.Add(Me.radMember)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 234)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 70)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทลูกค้า"
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(113, 32)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(76, 17)
        Me.radOther.TabIndex = 1
        Me.radOther.TabStop = True
        Me.radOther.Text = "ลูกค่าทั่วไป"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radMember
        '
        Me.radMember.AutoSize = True
        Me.radMember.Location = New System.Drawing.Point(16, 32)
        Me.radMember.Name = "radMember"
        Me.radMember.Size = New System.Drawing.Size(57, 17)
        Me.radMember.TabIndex = 0
        Me.radMember.TabStop = True
        Me.radMember.Text = "สมาชิก"
        Me.radMember.UseVisualStyleBackColor = True
        '
        'gpbPaid
        '
        Me.gpbPaid.Controls.Add(Me.radCredit)
        Me.gpbPaid.Controls.Add(Me.radPaid)
        Me.gpbPaid.Location = New System.Drawing.Point(292, 234)
        Me.gpbPaid.Name = "gpbPaid"
        Me.gpbPaid.Size = New System.Drawing.Size(200, 70)
        Me.gpbPaid.TabIndex = 5
        Me.gpbPaid.TabStop = False
        Me.gpbPaid.Text = "การชำระเงิน"
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Location = New System.Drawing.Point(104, 32)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(43, 17)
        Me.radCredit.TabIndex = 1
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "เชื่อ"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'radPaid
        '
        Me.radPaid.AutoSize = True
        Me.radPaid.Location = New System.Drawing.Point(7, 32)
        Me.radPaid.Name = "radPaid"
        Me.radPaid.Size = New System.Drawing.Size(38, 17)
        Me.radPaid.TabIndex = 0
        Me.radPaid.TabStop = True
        Me.radPaid.Text = "สด"
        Me.radPaid.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ส่วนลด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "จำนวนเงินต้องชำระ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 397)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ยอดค้างชำระ"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(189, 426)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(213, 47)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotal.Location = New System.Drawing.Point(189, 196)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(213, 23)
        Me.lblTotal.TabIndex = 7
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDiscount.Location = New System.Drawing.Point(189, 322)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(213, 23)
        Me.lblDiscount.TabIndex = 7
        '
        'lblPaid
        '
        Me.lblPaid.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPaid.Location = New System.Drawing.Point(189, 355)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(213, 23)
        Me.lblPaid.TabIndex = 7
        '
        'lblCredit
        '
        Me.lblCredit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCredit.Location = New System.Drawing.Point(189, 387)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(213, 23)
        Me.lblCredit.TabIndex = 7
        '
        'frmLAB5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 500)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gpbPaid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLAB5"
        Me.Text = "Form5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbPaid.ResumeLayout(False)
        Me.gpbPaid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radOther As RadioButton
    Friend WithEvents radMember As RadioButton
    Friend WithEvents gpbPaid As GroupBox
    Friend WithEvents radCredit As RadioButton
    Friend WithEvents radPaid As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents lblCredit As Label
End Class
