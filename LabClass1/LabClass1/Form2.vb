Public Class Form2
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lbltotalcommission.Click, lbltotalVistraANDComputer.Click, lblcomcomputer.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vistra, computer, totalvisandcom, totalcommission, commisvis, commiscom As Double
        vistra = txtvistra.Text
        computer = txtcomputer.Text
        totalvisandcom = vistra + computer
        lbltotalVistraANDComputer.Text = totalvisandcom
        commisvis = vistra * 0.05
        lblcomvistra.Text = commisvis
        commiscom = computer * 0.1
        lblcomcomputer.Text = commiscom
        totalcommission = commisvis + commiscom
        lbltotalcommission.Text = totalcommission



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class