Public Class MyMain
    Private Sub MyMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ลกคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ลกคาToolStripMenuItem.Click
        Dim lab2 As New frmLAB2
        lab2.ShowDialog()
    End Sub

    Private Sub สนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สนคาToolStripMenuItem.Click
        Dim lab1 As New frmLAB1
        lab1.ShowDialog()
    End Sub

    Private Sub สมาชกToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สมาชกToolStripMenuItem.Click
        Dim lab3 As New frmLAB3
        lab3.ShowDialog()
    End Sub

    Private Sub Lab4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab4ToolStripMenuItem.Click
        Dim lab4 As New frmLAB4
        lab4.ShowDialog()
    End Sub

    Private Sub Lab5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab5ToolStripMenuItem.Click
        Dim lab5 As New frmLAB5
        lab5.ShowDialog()
    End Sub

    Private Sub Lab6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab6ToolStripMenuItem.Click
        Dim lab6 As New frmLAB6
        lab6.ShowDialog()
    End Sub

    Private Sub Lab7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab7ToolStripMenuItem.Click
        Dim lab7 As New frmLAB7
        lab7.ShowDialog()
    End Sub

    Private Sub Lab8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lab8ToolStripMenuItem.Click
        Dim lab8 As New frmLAB8
        lab8.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim close As DialogResult
        close = MessageBox.Show("ต้องการออกจากโปรแกรมหรอ", "yousure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If close = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub
End Class