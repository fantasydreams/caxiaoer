Imports MySql.Data.MySqlClient

Public Class product

    Private Sub product_load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Catch ex As Exception
            SqliteConn.Close()
            Mysqlconn.Close()
            Me.Close()
            MsgBox(ex.Message)
        End Try
        Try
            SqliteConn1.Open()
        Catch ex As Exception
            SqliteConn1.Close()
            SqliteConn.Close()
            Mysqlconn.Close()
            Me.Close()
        End Try
        Dim data As New DataTable
        Dim sqliteda As SQLite.SQLiteDataAdapter
        Dim sqlcm As New SQLite.SQLiteCommand
        sqlcm.Connection = SqliteConn
        sqlcm.CommandType = CommandType.Text
        sqlcm.CommandText = "select product_id from cx_product_dl"
        sqliteda = New SQLite.SQLiteDataAdapter(sqlcm.CommandText, SqliteConn)
        sqliteda.Fill(data)
        If data.Rows.Count <> 0 Then
            Dim mysqldata As New DataTable
            Dim mysqlda As MySqlDataAdapter
            Dim sqlitecm1 As New SQLite.SQLiteCommand
            sqlitecm1.Connection = SqliteConn1
            sqlitecm1.CommandType = CommandType.Text
            For i = 0 To data.Rows.Count - 1
                mysqldata.Reset()
                mysqlda = New MySqlDataAdapter("select product_id,name,brief,picture,sold_count,surplus_count,price,earn_money,product_sort_id,specification from cx_product where product_id = " & data.Rows.Item(i).Item(0), Mysqlconn)
                mysqlda.Fill(mysqldata)
                If mysqldata.Rows.Count <> 0 Then
                    If mysqldata.Rows.Item(0).Item(3) <> "" Then
                        sqlitecm1.CommandText = "insert into cx_product (product_id,name,brief,picture,sold_count,surplus_count,price,earn_money,product_sort_id,specification) values( " & mysqldata.Rows.Item(0).Item(0) & ",'" & mysqldata.Rows.Item(0).Item(1).ToString & "','" & mysqldata.Rows.Item(0).Item(2) & "','" & mysqldata.Rows.Item(0).Item(3) & "'," & mysqldata.Rows.Item(0).Item(4) & "," & mysqldata.Rows.Item(0).Item(5) & "," & mysqldata.Rows.Item(0).Item(6) & "," & mysqldata.Rows.Item(0).Item(7) & "," & mysqldata.Rows.Item(0).Item(8) & "," & mysqldata.Rows.Item(0).Item(9) & ")"
                    Else
                        sqlitecm1.CommandText = "insert into cx_product (product_id,name,picture,sold_count,surplus_count,price,earn_money,product_sort_id,specification) values( " & mysqldata.Rows.Item(0).Item(0) & ",'" & mysqldata.Rows.Item(0).Item(1).ToString & "','" & mysqldata.Rows.Item(0).Item(3) & "'," & mysqldata.Rows.Item(0).Item(4) & "," & mysqldata.Rows.Item(0).Item(5) & "," & mysqldata.Rows.Item(0).Item(6) & "," & mysqldata.Rows.Item(0).Item(7) & "," & mysqldata.Rows.Item(0).Item(8) & "," & mysqldata.Rows.Item(0).Item(9) & ")"
                    End If
                    sqlitecm1.ExecuteNonQuery()
                    sqlcm.CommandText = "delete from cx_product_dl where product_id = " & mysqldata.Rows.Item(0).Item(0)
                    sqlcm.ExecuteNonQuery()
                End If
            Next
        End If
        SqliteConn1.Close()
        SqliteConn.Close()
        Mysqlconn.Close()
        Me.Close()
    End Sub

    Private Sub HideMe() Handles Me.VisibleChanged
        Me.Visible = False
    End Sub

End Class
