Public Class Form11

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddBindingSource.RemoveCurrent()
        AddBindingSource.EndEdit()
        AddTableAdapter.Update(StudentDataSet.add)
        MsgBox("data deleted successfully")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.AddBindingSource.Filter = "regno='" & Me.ComboBox1.Text & "'"
    End Sub

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.add' table. You can move, or remove it, as needed.
        Me.AddTableAdapter.Fill(Me.StudentDataSet.add)
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        TextBox6.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub
End Class