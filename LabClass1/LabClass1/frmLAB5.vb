Public Class frmLAB5
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click, Label8.Click, Label7.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decTotal, decDiscount, decNet, decCredit As Integer
        decTotal = lblTotal.Text

        If txtProduct.Text = "" Or txtPrice.Text = "" Or txtUnit.Text = "" Then
            MessageBox.Show("ป้อนขอ้มูลไม่สมบูรณ์")





        End If
        If radMember.Checked = True And radPaid.Checked = True Then

            If lblTotal.Text < 1000 Then
                decDiscount = 0

                lblDiscount.Text = decDiscount



            ElseIf lblTotal.Text < 5000 Then
                decDiscount = decTotal * 0.05
                decNet = lblTotal.Text - decDiscount
                lblDiscount.Text = decDiscount
                lblPaid.Text = decNet

            ElseIf lblTotal.Text < 10000 Then

                decDiscount = decTotal * 0.1
                decNet = lblTotal.Text - decDiscount
                lblDiscount.Text = decDiscount
                lblPaid.Text = decNet


            Else

                decDiscount = decTotal * 0.15
                decNet = lblTotal.Text - decDiscount
                lblDiscount.Text = decDiscount
                lblPaid.Text = decNet
                lblCredit.Text = 0









            End If

        End If
        If radMember.Checked = True And radCredit.Checked = True Then
            lblPaid.Text = lblTotal.Text
            lblCredit.Text = lblTotal.Text
            lblDiscount.Text = 0

        End If
        If radOther.Checked = True Then
            lblPaid.Text = lblTotal.Text
        End If











    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        If radMember.Checked = True Then
            gpbPaid.Enabled = True
            lblDiscount.Text = ""
            lblPaid.Text = ""
            lblCredit.Text = ""

        End If
    End Sub

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        If radOther.Checked = True Then
            gpbPaid.Enabled = False
            radPaid.Select()
            lblDiscount.Text = ""
            lblPaid.Text = ""
            lblCredit.Text = ""

        End If
    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)
    End Sub

    Private Sub radPaid_CheckedChanged(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radCredit_CheckedChanged(sender As Object, e As EventArgs) Handles radCredit.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub txtProduct_TextChanged(sender As Object, e As EventArgs) Handles txtProduct.TextChanged

    End Sub
End Class