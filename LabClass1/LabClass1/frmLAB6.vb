Public Class frmLAB6
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblItemsPrice4.Click

    End Sub

    Private Sub chkCarForMe_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarForMe.CheckedChanged


    End Sub

    Private Sub lblItemsPrice1_Click(sender As Object, e As EventArgs) Handles lblItemsPrice1.Click

    End Sub

    Private Sub Chkfree1_CheckedChanged(sender As Object, e As EventArgs) Handles Chkfree1.CheckedChanged
        If Chkfree1.Checked = False Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree1.Text)
        End If
    End Sub

    Private Sub Chkfree2_CheckedChanged(sender As Object, e As EventArgs) Handles Chkfree2.CheckedChanged
        If Chkfree2.Checked = False Then


            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree2.Text)
        End If



    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice1.Text)
        End If
    End Sub

    Private Sub Chkfree3_CheckedChanged(sender As Object, e As EventArgs) Handles Chkfree3.CheckedChanged
        If Chkfree3.Checked = False Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree3.Text)
        End If
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked = True Then


            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice2.Text)
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked = True Then


            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice3.Text)
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked = True Then


            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice4.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice4.Text)
        End If
    End Sub

    Private Sub lblPaidPrice_Click(sender As Object, e As EventArgs) Handles lblPaidPrice.Click

    End Sub

    Private Sub chkCarForMe_Click(sender As Object, e As EventArgs) Handles chkCarForMe.Click
        If chkCarForMe.Checked = True Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            '  Chkfree1.Checked = True
            ' Chkfree2.Checked = True
            ' Chkfree3.Checked = True
            lblSartPrice.Text = 1250000
            lblPaidPrice.Text = Val(lblSartPrice.Text) + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)


        Else


            Dim result As DialogResult

            result = MessageBox.Show("ตอ้งการยกเลิกการซ้ือรถ", "Hide", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Chkfree1.Checked = False
                Chkfree2.Checked = False
                Chkfree3.Checked = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                lblPaidPrice.Text = ""
                lblSartPrice.Text = ""
            Else
                chkCarForMe.Checked = True




            End If

        End If


    End Sub
End Class