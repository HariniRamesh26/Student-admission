Imports System.Data.OleDb
Public Class Form9
    Dim cn As New OleDbConnection
    Dim str As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim icount As String
    Dim a, b, c, d As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox5.Text = "") Or (ComboBox1.Text = "") Or (ComboBox2.Text = "") Or (ComboBox3.Text = "") Or (ComboBox4.Text = "") Or (DateTimePicker1.Text = "") Or (DateTimePicker2.Text = "") Then
            MsgBox("enter all the details")
        ElseIf Len(TextBox5.Text) < 10 Then
            MsgBox("number is less than 10")
        Else
            AddBindingSource.EndEdit()
            AddTableAdapter.Update(StudentDataSet.add)
            MsgBox("data saved successfully")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.add' table. You can move, or remove it, as needed.
        Me.AddTableAdapter.Fill(Me.StudentDataSet.add)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AddBindingSource.AddNew()
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rakeshmech\Documents\student.accdb")
        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = cn
        cmd.CommandText = "Select Max (regno) from [add]"
        cn.Open()
        Dim a As Integer = cmd.ExecuteScalar
        cn.Close()
        TextBox1.Text = a + 1
        If TextBox1.Text = "" Then

        End If
    End Sub
End Class