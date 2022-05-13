Imports System.Data.OleDb
Public Class Form16
    Dim con As New OleDbConnection
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rakeshmech\Documents\student.accdb")
        con.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("select * from [add] where feepaid='" & TextBox2.Text & "'", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Visible = True
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        a = DataGridView1.Rows.Count - 1
        TextBox1.Text = a
    End Sub
End Class