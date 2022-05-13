Public Class Form10

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox5.Text = "") Or (ComboBox1.Text = "") Or (ComboBox2.Text = "") Or (ComboBox3.Text = "") Or (ComboBox4.Text = "") Or (ComboBox5.Text = "") Or (DateTimePicker1.Text = "") Or (DateTimePicker2.Text = "") Then
            MsgBox("enter all the details")
        ElseIf Len(TextBox5.Text) < 10 Then
            MsgBox("number is less than 10")
        Else
            AddBindingSource.EndEdit()
            AddTableAdapter.Update(StudentDataSet.add)
            MsgBox("data updated successfully")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.add' table. You can move, or remove it, as needed.
        Me.AddTableAdapter.Fill(Me.StudentDataSet.add)
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.AddBindingSource.Filter = "regno='" & Me.ComboBox4.Text & "'"
    End Sub
End Class