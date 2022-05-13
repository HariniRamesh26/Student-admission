Imports System.Data.OleDb
Public Class Form15
    Dim con As New OleDbConnection
    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet1.add' table. You can move, or remove it, as needed.
        Me.AddTableAdapter.Fill(Me.StudentDataSet1.add)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rakeshmech\Documents\student.accdb")
            con.Open()
            Using command = New OleDbCommand("select count(regno) from [add]", con)
                Dim total = Convert.ToInt32(command.ExecuteScalar)
                TextBox1.Text = total.ToString
            End Using
            con.Close()
        End Using
    End Sub
End Class