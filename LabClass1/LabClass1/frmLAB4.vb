Public Class frmLAB4
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Dim decR_BONUS = 0.2, decR_ALLOW = 0.01, decR_TAX = 0.07

        Dim dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Integer
        Dim salary, yearsale As Integer
        salary = Val(txtSalary.Text)
        yearsale = Val(txtSale.Text)

        dblYearSalary = salary * 12
        lblYearSalary.Text = dblYearSalary
        dblBonus = yearsale * decR_BONUS
        lblBonus.Text = dblBonus
        dblAllIncome = dblYearSalary + dblBonus
        lblAllIncome.Text = dblAllIncome

        dblAllowance = dblAllIncome * decR_ALLOW
        lblAllowance.Text = dblAllowance
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX
        lblTax.Text = dblTax

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged

        lblDate.Text = Date.Now.ToString("dd/MM/yy")
    End Sub

    Private Sub radGenDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = FormatDateTime(Today, DateFormat.GeneralDate)
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = FormatDateTime(Today, DateFormat.LongDate)
    End Sub
End Class