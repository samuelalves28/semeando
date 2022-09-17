Imports MySql.Data.MySqlClient

Public Module ConexoesDAL

    Dim MyConStringNew As String = "Server=127.0.0.1;Database=siteecommecer;Uid=root;Pwd=123456;POOLING=TRUE;convert zero datetime=True"

    Public Function Insert(comando As String)
        Dim retorno
        Using con = New MySqlConnection(MyConStringNew)
            con.Open()
            Using cmd = New MySqlCommand(comando, con)
                cmd.ExecuteNonQuery()
                retorno = Convert.ToInt32(cmd.LastInsertedId)
            End Using
            con.Close()
        End Using
        Return retorno
    End Function

    Public Function Update(comando As String)
        Dim retorno
        Using con = New MySqlConnection(MyConStringNew)
            con.Open()
            Using cmd = New MySqlCommand(comando, con)
                retorno = cmd.ExecuteNonQuery()
            End Using
            con.Close()
        End Using
        Return retorno
    End Function

    Public Function Delete(comando As String)
        Dim retorno
        Using con = New MySqlConnection(MyConStringNew)
            con.Open()
            Using cmd = New MySqlCommand(comando, con)
                retorno = cmd.ExecuteNonQuery()
            End Using
            con.Close()
        End Using
        Return retorno
    End Function

    Public Function Select_(comando As String) As DataTable
        Dim dataTable As New DataTable
        Using con = New MySqlConnection(MyConStringNew)
            con.Open()
            Using cmd = New MySqlCommand(comando, con)
                Using sda As New MySqlDataAdapter(cmd)
                    sda.Fill(dataTable)
                End Using
            End Using
            con.Close()
        End Using
        Return dataTable
    End Function

    Public Function SelectScalar(comando As String) As String
        Dim retorno As String
        Using con = New MySqlConnection(MyConStringNew)
            con.Open()
            Using cmd = New MySqlCommand(comando, con)
                retorno = IIf(IsDBNull(cmd.ExecuteScalar()), Nothing, cmd.ExecuteScalar())
            End Using
            con.Close()
        End Using
        Return retorno
    End Function

End Module

