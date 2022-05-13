Public Class Form7

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (ComboBox1.Text = "") Or (ComboBox2.Text = "") Or (ComboBox3.Text = "") Or (ComboBox4.Text = "") Or (ComboBox5.Text = "") Or (ComboBox6.Text = "") Or (ComboBox7.Text = "") Or (ComboBox8.Text = "") Or (ComboBox9.Text = "") Or (ComboBox10.Text = "") Then
            MsgBox("enter all the details")
        Else
            CBindingSource.EndEdit()
            CTableAdapter.Update(RhariniDataSet.c)
            MsgBox("updated successfully")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.CBindingSource.Filter = "Courseid='" & Me.ComboBox1.Text & "'"

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RhariniDataSet.c' table. You can move, or remove it, as needed.
        Me.CTableAdapter.Fill(Me.RhariniDataSet.c)
        ComboBox1.Focus()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        ComboBox9.Text = ""
        ComboBox10.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = Val(ComboBox3.Text) + Val(ComboBox4.Text) + Val(ComboBox5.Text) + Val(ComboBox6.Text) + Val(ComboBox7.Text) + Val(ComboBox8.Text) + Val(ComboBox9.Text) + Val(ComboBox10.Text)
    End Sub

End Class