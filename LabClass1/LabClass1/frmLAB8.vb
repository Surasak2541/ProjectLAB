Public Class frmLAB8
    Dim sumscore, sumcredit As Integer

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lblNewGPA.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        Dim gpa As String

        txtCredit.Text = txtCredit.Text.Trim
        If txtCredit.Text = "" Or txtScore.Text = "" Or txtSubject.Text = "" Then
            MessageBox.Show("กรุณาใส่ข้อมูลให้ครบ")
        Else
            gpa = haha(txtScore.Text)
            lstGrade.Items.Add(gpa)



            lstSubject.Items.Add(txtSubject.Text)
            lstScore.Items.Add(txtScore.Text)
            lstCredit.Items.Add(txtCredit.Text)

            Call cal()

            lstSubject.SelectedIndex = lstSubject.Items.Count - 1
            lstScore.SelectedIndex = lstScore.Items.Count - 1
            lstGrade.SelectedIndex = lstGrade.Items.Count - 1
            lstCredit.SelectedIndex = lstCredit.Items.Count - 1

            txtCredit.Text = ""
            txtScore.Text = ""
            txtSubject.Text = ""

            txtSubject.Select()

        End If




    End Sub

    Private Function haha(ByVal score As Decimal) As String
        Dim grade As String
        If txtScore.Text >= 80 Then
            grade = "A"
        ElseIf txtScore.Text >= 75 And txtScore.Text <= 79 Then
            grade = "B+"
        ElseIf txtScore.Text >= 70 And txtScore.Text <= 74 Then
            grade = "B"
        ElseIf txtScore.Text >= 65 And txtScore.Text <= 69 Then
            grade = "C+"
        ElseIf txtScore.Text >= 60 And txtScore.Text <= 64 Then
            grade = "C"
        ElseIf txtScore.Text >= 55 And txtScore.Text <= 59 Then
            grade = "D+"
        ElseIf txtScore.Text >= 50 And txtScore.Text <= 54 Then
            grade = "D"
        Else

            grade = "F"
        End If
        Return grade
    End Function
    Private Sub cal()
        Dim G, gad, credit As Double

        sumscore = Val(lblOldTotalScore.Text)
        sumcredit = Val(Label9lblOldTotalCredit.Text)

        For i = 0 To lstCredit.Items.Count - 1

            credit = lstCredit.Items(i)
            If lstGrade.Items(i) = "A" Then
                gad = 4
            ElseIf lstGrade.Items(i) = "B+" Then
                gad = 3.5
            ElseIf lstGrade.Items(i) = "B" Then
                gad = 3
            ElseIf lstGrade.Items(i) = "C+" Then
                gad = 2.5
            ElseIf lstGrade.Items(i) = "C" Then
                gad = 2
            ElseIf lstGrade.Items(i) = "D+" Then
                gad = 1.5
            ElseIf lstGrade.Items(i) = "D" Then
                gad = 1
            ElseIf lstGrade.Items(i) = "F" Then
                gad = 0
            End If

            sumscore += gad * credit
            sumcredit += credit

        Next

        G = sumscore / sumcredit
        lblNewGPA.Text = G.ToString("n")











    End Sub
    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And (Not e.KeyChar = ".") Then
            e.Handled = True

            MessageBox.Show("กรุณาใส่ตัวเลข")
        End If
    End Sub

    Private Sub txtCredit_TextChanged(sender As Object, e As EventArgs) Handles txtCredit.TextChanged

    End Sub

    Private Sub txtCredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredit.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And (Not e.KeyChar = ".") Then
            e.Handled = True

            MessageBox.Show("กรุณาใส่ตัวเลข")
        End If
    End Sub

    Private Sub lstSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubject.SelectedIndexChanged
        lstScore.SelectedIndex = lstSubject.SelectedIndex
        lstCredit.SelectedIndex = lstSubject.SelectedIndex
        lstGrade.SelectedIndex = lstSubject.SelectedIndex

    End Sub

    Private Sub lstScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstScore.SelectedIndexChanged
        lstSubject.SelectedIndex = lstScore.SelectedIndex

    End Sub

    Private Sub frmLAB8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim gpa As Double

        gpa = Val(lblOldTotalScore.Text) / Val(Label9lblOldTotalCredit.Text)
        lblOldGPA.Text = gpa.ToString("n")
    End Sub

    Private Sub btnClaer_Click(sender As Object, e As EventArgs) Handles btnClaer.Click
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()
        lstScore.Items.Clear()
        lstSubject.Items.Clear()
        txtCredit.Clear()
        txtScore.Clear()
        txtSubject.Clear()
        lblNewGPA.Text = ""

    End Sub

    Private Sub lblOldGPA_Click(sender As Object, e As EventArgs) Handles lblOldGPA.Click

    End Sub

    Private Sub lstGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrade.SelectedIndexChanged
        lstSubject.SelectedIndex = lstGrade.SelectedIndex
    End Sub

    Private Sub lstCredit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCredit.SelectedIndexChanged
        lstSubject.SelectedIndex = lstCredit.SelectedIndex


    End Sub
End Class