Public Class Form1

    Private Sub k_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles k.Click
        If uname.Text = "" And pass.Text = "" Then
            MsgBox("ENTER USERNAME AND PASSWORD")
            uname.Focus()
        ElseIf uname.Text = "" And pass.Text = "BCA" Then
            MsgBox("ENTER USERNAME")
            uname.Focus()
        ElseIf uname.Text = "admin" And pass.Text = "" Then
            MsgBox("ENTER PASSWORD")
            pass.Focus()
        ElseIf uname.Text = "admin" And pass.Text = "BCA" Then
            MsgBox("login successfully")
            Form2.Show()
        Else
            MsgBox("login failed")
            uname.Text = ""
            pass.Text = ""
            uname.Focus()
        End If
    End Sub

    Private Sub ext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ext.Click
        Me.Close()
    End Sub
End Class
