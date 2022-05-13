Imports System.Data.OleDb
Public Class Form14
    Dim con As New OleDbConnection
    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RhariniDataSet1.c' table. You can move, or remove it, as needed.
        Me.CTableAdapter.Fill(Me.RhariniDataSet1.c)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rakeshmech\Documents\rharini.accdb")
            con.Open()
            Using command = New OleDbCommand("select count(courseid) from c", con)
                Dim total = Convert.ToInt32(command.ExecuteScalar)
                TextBox1.Text = total.ToString
            End Using
            con.Close()
        End Using
    End Sub
End Class