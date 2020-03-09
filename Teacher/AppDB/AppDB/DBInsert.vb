Imports MySql.Data.MySqlClient
Module DBInsert
    Dim dbCon As MySqlConnection
    Dim strQuery = ""
    Dim SQLCmd As MySqlCommand
    Dim DR As MySqlDataReader
    Friend Sub InsertData()

        If (Form1.txt1.Text = "") Then
            MsgBox("Please fill in the information bellow!")
        End If
        Dim ids = CInt(Form1.txt1.Text)
        Dim names = Form1.txt2.Text
        Dim marks = CDbl(Form1.txt3.Text)
        Dim departs = CInt(Form1.txt4.Text)
        Try
            'PREPARE THE CONNECTION TO DB
            dbCon = New MySqlConnection("Server=127.0.0.1;Database=vbnet;Uid=root;Pwd=''")
            'STATEMENT
            strQuery = "INSERT INTO student (id,name,mark,depart) values(@id_,@name_,@mark_,@depart_)"
            'Open the connection
            dbCon.Open()
            SQLCmd = New MySqlCommand(strQuery, dbCon)
            'OPEN THE DB AND KICKOFF THE QUERY
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.Parameters.AddWithValue("@id_", ids)
            SQLCmd.Parameters.AddWithValue("@name_", names)
            SQLCmd.Parameters.AddWithValue("@mark_", marks)
            SQLCmd.Parameters.AddWithValue("@depart_", departs)
            SQLCmd.ExecuteNonQuery()
            MsgBox("Data sucessfully inserted!")
            dbCon.Close()



        Catch ex As Exception
            MsgBox("Failure to communicate!" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub
End Module
