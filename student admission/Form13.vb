Public Class Form13

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'TODO: This line of code loads data into the 'StudentDataSet.add' table. You can move, or remove it, as needed.
        Me.AddTableAdapter.Fill(Me.StudentDataSet.add)
        

    End Sub
End Class