Public Class Form12

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'RhariniDataSet.c' table. You can move, or remove it, as needed.
        Me.CTableAdapter.Fill(Me.RhariniDataSet.c)

    End Sub
End Class