Imports System.Data.OleDb
Public Class Form6
    Dim cn As New OleDbConnection
    Dim str As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim icount As String
    Dim a, b, c, d As String

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CBindingSource.AddNew()
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rakeshmech\Documents\rharini.accdb")
        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = cn
        cmd.CommandText = "Select Max (Courseid) from [c]"
        cn.Open()
        Dim a As Integer = cmd.ExecuteScalar
        cn.Close()
        TextBox1.Text = a + 1
        If TextBox1.Text = "" Then

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (ComboBox1.Text = "") Or (c1.Text = "") Or (c2.Text = "") Or (c3.Text = "") Or (c4.Text = "") Or (c5.Text = "") Or (c6.Text = "") Or (c7.Text = "") Or (c8.Text = "") Then
            MsgBox("enter all the details")
        Else
            CBindingSource.EndEdit()
            CTableAdapter.Update(RhariniDataSet.c)
            MsgBox("COURSE DATA SAVED SUCCESSFULLY")
        End If
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RhariniDataSet.c' table. You can move, or remove it, as needed.
        Me.CTableAdapter.Fill(Me.RhariniDataSet.c)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = Val(c1.Text) + Val(c2.Text) + Val(c3.Text) + Val(c4.Text) + Val(c5.Text) + Val(c6.Text) + Val(c7.Text) + Val(c8.Text)
    End Sub
End Class