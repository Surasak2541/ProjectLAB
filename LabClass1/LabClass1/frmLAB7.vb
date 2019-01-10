Public Class frmLAB7
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        lstadd.Items.Add(txtadd.Text)
        txtadd.Text = ""
        lstadd.SelectedIndex = lstadd.Items.Count - 1
    End Sub

    Private Sub lab_7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnadd.Enabled = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtadd.TextChanged

        If txtadd.Text = "" Then
            btnadd.Enabled = False
        Else
            btnadd.Enabled = True

        End If
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim a As Integer
        If lstadd.SelectedIndex < 0 Then
            MessageBox.Show("กรุณาเลือกไอเทม", ",มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning
                            )
        Else
            Cbooutput.Items.Add(lstadd.SelectedItem)
            a = lstadd.SelectedIndex
            If lstadd.SelectedIndex = lstadd.Items.Count - 1 Then
                lstadd.Items.RemoveAt(lstadd.SelectedIndex)
                lstadd.SelectedIndex = lstadd.Items.Count - 1
            Else
                lstadd.Items.RemoveAt(lstadd.SelectedIndex)
                lstadd.SelectedIndex = a
            End If
            Cbooutput.SelectedIndex = Cbooutput.Items.Count - 1

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        If Cbooutput.SelectedIndex < 0 Then
            MessageBox.Show("กรุณาเลือกไอเทม", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Cbooutput.Text = ""
            lstadd.Items.Add(Cbooutput.SelectedItem)
            lstadd.SelectedIndex = lstadd.Items.Count - 1
            Cbooutput.Items.Remove(lstadd.SelectedItem)
            lblout.Text = ""
            Cbooutput.SelectedIndex = Cbooutput.Items.Count - 1
        End If


    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        If lstadd.SelectedIndex < 0 Then
            MessageBox.Show("กรุณาเลือกไอเทม", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            For Each item In lstadd.Items
                Cbooutput.Items.Add(item)
                Cbooutput.SelectedIndex = Cbooutput.Items.Count - 1

            Next
            lstadd.Items.Clear()
        End If

    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click

        If Cbooutput.SelectedIndex < 0 Then
            MessageBox.Show("กรุณาเลือกไอเทม", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            For Each item In Cbooutput.Items
                lstadd.Items.Add(item)
                lstadd.SelectedIndex = lstadd.Items.Count - 1
                Cbooutput.SelectedIndex = Cbooutput.Items.Count - 1
            Next
            Cbooutput.Text = ""
            Cbooutput.Items.Clear()
            lblOut.Text = ""
        End If

    End Sub

    Private Sub lblOut_Click(sender As Object, e As EventArgs) Handles lblOut.Click

    End Sub

    Private Sub cbooutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbooutput.SelectedIndexChanged
        lblOut.Text = Cbooutput.Text


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        Cbooutput.Text = ""
        lblOut.Text = ""
        lstadd.Items.Clear()
        Cbooutput.Items.Clear()




    End Sub

    Private Sub lstadd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstadd.SelectedIndexChanged

    End Sub
End Class