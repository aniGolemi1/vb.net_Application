Imports MySql.Data.MySqlClient
Module delete
    Dim dbCon As MySqlConnection
    Dim strQuery = ""
    Dim SQLCmd As MySqlCommand
    Dim DR As MySqlDataReader


    Friend Sub DeleteTable()
        Try
            Dim ID As Integer
            Dim Name As String
            Dim Mark As Double
            Dim Depart As Integer

            Dim ids = CInt(Form1.TextBox5.Text)
            dbCon = New MySqlConnection("Server=127.0.0.1;Database=vbnet;Uid=root;Pwd=''")
            strQuery = "SELECT * from student where id = " & ids
            SQLCmd = New MySqlCommand(strQuery, dbCon)
            dbCon.Open()
            DR = SQLCmd.ExecuteReader


            While DR.Read
                ID = DR.Item("ID")
                Name = DR.Item("Name")
                Mark = DR.Item("Mark")
                Depart = DR.Item("Depart")
            End While

            dbCon.Close()

            strQuery = "INSERT INTO studentDelete (id,name,mark,depart,DT) values(@id_,@name_,@mark_,@depart_,NOW())"
            dbCon.Open()
            SQLCmd = New MySqlCommand(strQuery, dbCon)
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.Parameters.AddWithValue("@id_", ID)
            SQLCmd.Parameters.AddWithValue("@name_", Name)
            SQLCmd.Parameters.AddWithValue("@mark_", Mark)
            SQLCmd.Parameters.AddWithValue("@depart_", Depart)
            SQLCmd.ExecuteNonQuery()
            MsgBox("Record inserted into studentDelete!")
            dbCon.Close()
            strQuery = "DELETE from student where id = " & ids
            SQLCmd = New MySqlCommand(strQuery, dbCon)
            dbCon.Open()
            SQLCmd.ExecuteReader()
            MsgBox("student succesfully deleted!")
            dbCon.Close()



        Catch ex As Exception
            MsgBox("Cannot Connect!" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub

End Module
