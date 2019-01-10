Public Class frmLAB3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUP.Click
        txtInput.Text = Val(txtInput.Text) + 2

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDown.Click

        txtInput.Text = Val(txtInput.Text) - 2
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim size As Integer
        Integer.TryParse(ComboBox1.Text, size)
        txtInput.Font = New Font(txtInput.Font.Name, size, txtInput.Font.Style, txtInput.Font.Unit)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblF_Red.Click
        txtInput.ForeColor = Color.Red
    End Sub

    Private Sub lblF_Blue_Click(sender As Object, e As EventArgs) Handles lblF_Blue.Click
        txtInput.ForeColor = Color.Blue
    End Sub

    Private Sub lblF_Green_Click(sender As Object, e As EventArgs) Handles lblF_Green.Click
        txtInput.ForeColor = Color.Green
    End Sub

    Private Sub lblF_Ping_Click(sender As Object, e As EventArgs) Handles lblF_Ping.Click
        txtInput.ForeColor = Color.Pink
    End Sub

    Private Sub lblF_Black_Click(sender As Object, e As EventArgs) Handles lblF_Black.Click
        txtInput.ForeColor = Color.Black
    End Sub

    Private Sub lblF_Orange_Click(sender As Object, e As EventArgs) Handles lblF_Orange.Click
        txtInput.ForeColor = Color.Orange
    End Sub

    Private Sub lblF_Yello_Click(sender As Object, e As EventArgs) Handles lblF_Yello.Click
        txtInput.ForeColor = Color.Yellow
    End Sub

    Private Sub lblF_Brown_Click(sender As Object, e As EventArgs) Handles lblF_Brown.Click
        txtInput.ForeColor = Color.Brown
    End Sub

    Private Sub lblF_White_Click(sender As Object, e As EventArgs) Handles lblF_White.Click
        txtInput.ForeColor = Color.White
    End Sub

    Private Sub lblF_Sky_Click(sender As Object, e As EventArgs) Handles lblF_Sky.Click
        txtInput.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblB_Red_Click(sender As Object, e As EventArgs) Handles lblB_Red.Click
        txtInput.BackColor = Color.Red
    End Sub

    Private Sub lblB_Blue_Click(sender As Object, e As EventArgs) Handles lblB_Blue.Click
        txtInput.BackColor = Color.Blue
    End Sub

    Private Sub lblB_Green_Click(sender As Object, e As EventArgs) Handles lblB_Green.Click
        txtInput.BackColor = Color.Green
    End Sub

    Private Sub lblB_Ping_Click(sender As Object, e As EventArgs) Handles lblB_Ping.Click
        txtInput.BackColor = Color.Pink
    End Sub

    Private Sub lblB_Black_Click(sender As Object, e As EventArgs) Handles lblB_Black.Click
        txtInput.BackColor = Color.Black
    End Sub

    Private Sub lblB_Orange_Click(sender As Object, e As EventArgs) Handles lblB_Orange.Click
        txtInput.BackColor = Color.Orange
    End Sub

    Private Sub lblB_Yello_Click(sender As Object, e As EventArgs) Handles lblB_Yello.Click
        txtInput.BackColor = Color.Yellow
    End Sub

    Private Sub lblB_Brown_Click(sender As Object, e As EventArgs) Handles lblB_Brown.Click
        txtInput.BackColor = Color.Brown
    End Sub

    Private Sub lblB_White_Click(sender As Object, e As EventArgs) Handles lblB_White.Click
        txtInput.BackColor = Color.White
    End Sub

    Private Sub lblB_Sky_Click(sender As Object, e As EventArgs) Handles lblB_Sky.Click
        txtInput.BackColor = Color.SkyBlue
    End Sub
End Class