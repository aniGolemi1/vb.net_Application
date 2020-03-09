Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InsertData()


    End Sub

    Private Sub displayStudentTxt_Click(sender As Object, e As EventArgs) Handles displayStudentTxt.Click
        getData2()
    End Sub

    Private Sub studentTxtBox_TextChanged(sender As Object, e As EventArgs) Handles studentTxtBox.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        searchById()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Update1()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DeleteTable()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GetDataDelete()
    End Sub

    Private Sub upid_TextChanged(sender As Object, e As EventArgs) Handles upid.TextChanged

    End Sub

    Private Sub upname_TextChanged(sender As Object, e As EventArgs) Handles upname.TextChanged

    End Sub

    Private Sub upmark_TextChanged(sender As Object, e As EventArgs) Handles upmark.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GetDataUpdate()
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub RichTextBox3_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox3.TextChanged

    End Sub
End Class
