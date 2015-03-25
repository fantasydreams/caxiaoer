Imports MySql.Data.MySqlClient
Public Class main

    Private Sub mian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        Dim SqliteConn As New SQLite.SQLiteConnection
        SqliteConn.ConnectionString = "Data Source=" & Application.StartupPath & "\database\update.db"
        Dim SqliteConn1 As New SQLite.SQLiteConnection
        SqliteConn1.ConnectionString = "Data Source=" & Application.StartupPath & "\database\xiaoer.db"
        Dim Mysqlconn As New MySqlConnection
        If Not Mysqlconn Is Nothing Then Mysqlconn.Close()
        'connStr = String.Format("server={0};user id={1}; password={2}; database=caixiao2; pooling=false;chatset = utf8 ", "123.1.154.169", UserID, Password)
        Try
            Mysqlconn = New MySqlConnection("server=123.1.154.169;user id=root;password=caixiao2;database=caixiao2;charset=utf8")
            Mysqlconn.Open()
        Catch ex As MySqlException
            Me.Close()
        End Try
        Try
            SqliteConn.Open()
            SqliteConn1.Open()
        Catch ex As Exception
            Me.Close()
        End Try
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.CommandText = "select product_id,operate from cx_product"
        sqlcmd.Connection = SqliteConn
        Dim temp As New DataTable
        Dim sqlda As SQLite.SQLiteDataAdapter
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SqliteConn)
        sqlda.Fill(temp)
        If temp.Rows.Count <> 0 Then
            Dim sqlcmd1 As New SQLite.SQLiteCommand
            sqlcmd1.Connection = SqliteConn1
            sqlcmd1.CommandType = CommandType.Text
            Dim mysqlcom As MySqlCommand
            For i = 0 To temp.Rows.Count - 1
                If temp.Rows.Item(i).Item(1) <> 0 Then
                    sqlcmd1.CommandText = "select product_id,name,brief,picture,sold_count,surplus_count,price,earn_money,product_sort_id,specification from cx_product where product_id = " & temp.Rows.Item(i).Item(0)
                    Dim data As New DataTable
                    Dim sqlda1 As SQLite.SQLiteDataAdapter
                    sqlda1 = New SQLite.SQLiteDataAdapter(sqlcmd1.CommandText, SqliteConn1)
                    sqlda1.Fill(data)
                    If data.Rows.Item(0).Item(2).ToString <> "" Then
                        If data.Rows.Item(0).Item(3).ToString <> "" Then
                            mysqlcom = New MySqlCommand("insert into cx_product (product_id,name,brief,picture,sold_count,surplus_count,price,earn_money,product_sort_id,specification )values (" & data.Rows.Item(0).Item(0) & ",'" & data.Rows.Item(0).Item(1) & "','" & data.Rows.Item(0).Item(2) & "','" & data.Rows.Item(0).Item(3) & "'," & data.Rows.Item(0).Item(4) & "," & data.Rows.Item(0).Item(5) & "," & data.Rows.Item(0).Item(6) & "," & data.Rows.Item(0).Item(7) & "," & data.Rows.Item(0).Item(8) & "," & data.Rows.Item(0).Item(9) & ")", Mysqlconn)
                        Else
                            mysqlcom = New MySqlCommand("insert into cx_product (product_id,name,brief,sold_count,surplus_count,price,earn_money,product_sort_id,specification )values (" & data.Rows.Item(0).Item(0) & ",'" & data.Rows.Item(0).Item(1) & "','" & data.Rows.Item(0).Item(2) & "'," & data.Rows.Item(0).Item(4) & "," & data.Rows.Item(0).Item(5) & "," & data.Rows.Item(0).Item(6) & "," & data.Rows.Item(0).Item(7) & "," & data.Rows.Item(0).Item(8) & "," & data.Rows.Item(0).Item(9) & ")", Mysqlconn)
                        End If
                        Try
                            mysqlcom.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            'Me.Close()
                        End Try
                    Else
                        If data.Rows.Item(0).Item(3).ToString <> "" Then
                            mysqlcom = New MySqlCommand("insert into cx_product (product_id,name,picture,sold_count,surplus_count,price,earn_money,product_sort_id,specification )values (" & data.Rows.Item(0).Item(0) & ",'" & data.Rows.Item(0).Item(1) & "','" & data.Rows.Item(0).Item(3) & "'," & data.Rows.Item(0).Item(4) & "," & data.Rows.Item(0).Item(5) & "," & data.Rows.Item(0).Item(6) & "," & data.Rows.Item(0).Item(7) & "," & data.Rows.Item(0).Item(8) & "," & data.Rows.Item(0).Item(9) & ")", Mysqlconn)
                        Else
                            mysqlcom = New MySqlCommand("insert into cx_product (product_id,name,sold_count,surplus_count,price,earn_money,product_sort_id,specification )values (" & data.Rows.Item(0).Item(0) & ",'" & data.Rows.Item(0).Item(1) & "'," & data.Rows.Item(0).Item(4) & "," & data.Rows.Item(0).Item(5) & "," & data.Rows.Item(0).Item(6) & "," & data.Rows.Item(0).Item(7) & "," & data.Rows.Item(0).Item(8) & "," & data.Rows.Item(0).Item(9) & ")", Mysqlconn)
                        End If
                        Try
                            mysqlcom.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            'Me.Close()
                        End Try
                    End If
                    sqlcmd.CommandText = "delete from cx_product where product_id = " & temp.Rows.Item(i).Item(0)
                    sqlcmd.ExecuteNonQuery()
                Else
                    mysqlcom = New MySqlCommand("delete from cx_product where product_id = " & temp.Rows.Item(i).Item(0), Mysqlconn)
                    Try
                        mysqlcom.ExecuteNonQuery()
                    Catch ex As Exception
                        Me.Close()
                    End Try
                    sqlcmd.CommandText = "delete from cx_product where product_id = " & temp.Rows.Item(i).Item(0)
                    sqlcmd.ExecuteNonQuery()
                End If

            Next
        Else
            Me.Close()
        End If
        Me.Close()

    End Sub

    Private Sub hide_mian() Handles Me.VisibleChanged
        Me.Visible = False
    End Sub

End Class
