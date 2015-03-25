Imports System.Data
Imports MySql.Data.MySqlClient

Imports System
Public Class main
    Public Mysqlconn As MySqlConnection
    Dim SqliteConn As New Data.SQLite.SQLiteConnection '记录同步数据库
    Dim sqliteConn1 As New Data.SQLite.SQLiteConnection 
    Dim all_order As New DataTable
    Dim Order_Max As String = "" '记录订单号的最大值，方便进行同步
    Dim order_status As Integer = 0 '记录是否第一次同步
    Dim fristBoot As Boolean '标记是否是第一次联网退出
    Dim tips As Integer = 0 '记录提示窗口会弹出的次数
    Dim order As New DataTable '用来记录订单,远程订单的状态更改，本地记录的删除记录等
    Dim order_net As Boolean = True '用来记录当期同步的状态是被在断网时发生
    Dim all_order_net As Boolean = True
    Dim all_order_finished As Boolean = True
    Dim order_detail_finished As Boolean = True
    Dim order_status_finished As Boolean = True
    Private Sub dbsynch_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        Me.TopMost = True
        SqliteConn.ConnectionString = "Data Source=" & Application.StartupPath & "\database\update.db"
        sqliteConn1.ConnectionString = "Data Source=" & Application.StartupPath & "\database\xiaoer.db"
        If My.Computer.Network.IsAvailable = True Then
            Try
                SqliteConn.Open() '测试数据库连接
                sqliteConn1.Open()
                ' MsgBox("OK")
                ConnectMySql("root", "caixiao2")
            Catch ex As Exception
                MsgBox("未连接网络或网络断开，请及时修复，否则会影响小二管理系统的正常运行！")
            End Try
        Else
            While (My.Computer.Network.IsAvailable = False)
                System.Threading.Thread.Sleep(1000)
                Try
                    SqliteConn.Open() '测试数据库连接
                    sqliteConn1.Open()
                    ' MsgBox("OK")
                    ConnectMySql("root", "caixiao2")
                Catch ex As Exception
                    MsgBox("未连接网络或网络断开，请及时修复，否则会影响小二管理系统的正常运行！")
                End Try
            End While
        End If
        fristBoot = True
    End Sub

    Private Sub p() Handles Me.VisibleChanged
        Me.Visible = False
    End Sub
    Public Sub ConnectMySql(ByVal UserID As String, Password As String)
        'Dim connStr As String
        If Not Mysqlconn Is Nothing Then Mysqlconn.Close()
        'connStr = String.Format("server={0};user id={1}; password={2}; database=caixiao2; pooling=false;chatset = utf8 ", "123.1.154.169", UserID, Password)
        Try
            Mysqlconn = New MySqlConnection("server=123.1.154.169;user id=root;password=caixiao2;database=caixiao2;charset=utf8")
con:        Mysqlconn.Open()
        Catch ex As MySqlException
            If tips = 0 Then
                tips += 1
                MsgBox("网络未连接或者断开，请及时修复，否则会影响小二管理系统的正常运行！")
            Else
                If tips = 2 Then
                    tips = 0
                Else
                    tips += 1
                End If
            End If
            System.Threading.Thread.Sleep(60000)
            GoTo con
        End Try
    End Sub

    Private Sub updateDate_Tick(sender As Object, e As EventArgs) Handles updateDate.Tick
        If My.Computer.Network.IsAvailable = True And fristBoot = True And all_order_net = True And all_order_finished = True Then
            update_order_all()
        ElseIf tips = 0 And fristBoot = True Then
            tips += 1
            MsgBox("网络断开，请及时修复，否则会影响小二管理系统的正常运行！")
        Else
            If tips = 500 Then
                tips = 0
            Else
                tips += 1
            End If

        End If
    End Sub
    '对订单数据的同步
    Private Sub update_order_all()
        all_order_finished = False
        all_order.Reset()
        Dim int_arrow As Integer
        Dim da As MySqlDataAdapter
        Dim cb As MySqlCommandBuilder
        If order_status = 0 Then
            Dim sqlcmd As New SQLite.SQLiteCommand
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.Connection = SqliteConn
            sqlcmd.CommandText = "select status from cx_frist_update where table_name = 'cx_order'"
            Dim sqlda As SQLite.SQLiteDataAdapter
            sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SqliteConn)
            Dim data As New DataTable
            sqlda.Fill(data)
            If data.Rows.Item(0).Item(0) = 0 Then
                sqlcmd.CommandText = "update cx_frist_update set status = 1 where table_name = 'cx_order'"
                sqlcmd.ExecuteNonQuery()
                order_status = 1
                Try
point:              If My.Computer.Network.IsAvailable = True Then
                        da = New MySqlDataAdapter("select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type,cart_owner_id from cx_order order by order_time desc", Mysqlconn)
                        cb = New MySqlCommandBuilder(da)
                        da.Fill(all_order)
                        int_arrow = all_order.Rows.Count
                        If int_arrow = 0 Then
                        Else
                            Dim sqlcmd1 As New SQLite.SQLiteCommand
                            sqlcmd1.CommandType = CommandType.Text
                            sqlcmd1.Connection = sqliteConn1
                            For i = 0 To int_arrow - 1
                                If all_order.Rows.Item(i).Item(10).ToString = "" Then
                                    sqlcmd1.CommandText = "insert into cx_order (order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,purchase_type) values ( '" & all_order.Rows.Item(i).Item(0).ToString & "','" & all_order.Rows.Item(i).Item(1).ToString & "','" & all_order.Rows.Item(i).Item(2).ToString & "','" & all_order.Rows.Item(i).Item(3).ToString & "','" & all_order.Rows.Item(i).Item(4).ToString & "','" & all_order.Rows.Item(i).Item(5).ToString & "','" & all_order.Rows.Item(i).Item(6).ToString & "','" & all_order.Rows.Item(i).Item(9).ToString & "')"
                                Else
                                    sqlcmd1.CommandText = "insert into cx_order (order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,purchase_type,cart_owner_id) values ( '" & all_order.Rows.Item(i).Item(0).ToString & "','" & all_order.Rows.Item(i).Item(1).ToString & "','" & all_order.Rows.Item(i).Item(2).ToString & "','" & all_order.Rows.Item(i).Item(3).ToString & "','" & all_order.Rows.Item(i).Item(4).ToString & "','" & all_order.Rows.Item(i).Item(5).ToString & "','" & all_order.Rows.Item(i).Item(6).ToString & "','" & all_order.Rows.Item(i).Item(9).ToString & "','" & all_order.Rows.Item(i).Item(10).ToString & "')"
                                End If
                                sqlcmd1.ExecuteNonQuery()
                                sqlcmd.CommandText = "insert into cx_order_id (order_id) values('" & all_order.Rows.Item(i).Item(0) & "')"
                                sqlcmd.ExecuteNonQuery()
                            Next
                            Order_Max = all_order.Rows.Item(0).Item(2)
                            sqlcmd.CommandText = "update cx_max_record set max_record = '" & Order_Max & "'" & "where table_name = 'cx_order'"
                            sqlcmd.ExecuteNonQuery()
                        End If
                    Else
                        all_order_net = False
                        System.Threading.Thread.Sleep(60000)
                        GoTo point
                    End If
                Catch ex As MySqlException
                    'MessageBox.Show(ex.ToString)
                    MessageBox.Show("程序出现错误！请重启程序，或联系维护人员。", "抱歉")
                End Try
            Else
                order_status = 1
                sqlcmd.CommandText = "select max_record from cx_max_record where table_name = 'cx_order'"
                sqlcmd.CommandType = CommandType.Text
                sqlcmd.Connection = SqliteConn
                data.Reset()
                sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SqliteConn)
                sqlda.Fill(data)
                Order_Max = data.Rows.Item(0).Item(0)
point1:         If My.Computer.Network.IsAvailable = True Then
                    da = New MySqlDataAdapter("select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type,cart_owner_id from cx_order where order_time > '" & Order_Max & "' order by order_time desc", Mysqlconn)
                    cb = New MySqlCommandBuilder(da)
                    all_order.Reset()
                    Try
                        da.Fill(all_order)
                    Catch ex As Exception
                        MsgBox("网络状况不佳，请为管理系统留足够的宽带供其正常运行！")
                        System.Threading.Thread.Sleep(30000)
                        GoTo point1
                    End Try
                    int_arrow = all_order.Rows.Count
                    If int_arrow = 0 Then
                    Else
                        Dim sqlcmd1 As New SQLite.SQLiteCommand
                        sqlcmd1.CommandType = CommandType.Text
                        sqlcmd1.Connection = sqliteConn1
                        For i = 0 To int_arrow - 1
                            If all_order.Rows.Item(i).Item(10).ToString = "" Then
                                sqlcmd1.CommandText = "insert into cx_order (order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,purchase_type) values ( '" & all_order.Rows.Item(i).Item(0).ToString & "','" & all_order.Rows.Item(i).Item(1).ToString & "','" & all_order.Rows.Item(i).Item(2).ToString & "','" & all_order.Rows.Item(i).Item(3).ToString & "','" & all_order.Rows.Item(i).Item(4).ToString & "','" & all_order.Rows.Item(i).Item(5).ToString & "','" & all_order.Rows.Item(i).Item(6).ToString & "','" & all_order.Rows.Item(i).Item(9).ToString & "')"
                            Else
                                sqlcmd1.CommandText = "insert into cx_order (order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,purchase_type,cart_owner_id) values ( '" & all_order.Rows.Item(i).Item(0).ToString & "','" & all_order.Rows.Item(i).Item(1).ToString & "','" & all_order.Rows.Item(i).Item(2).ToString & "','" & all_order.Rows.Item(i).Item(3).ToString & "','" & all_order.Rows.Item(i).Item(4).ToString & "','" & all_order.Rows.Item(i).Item(5).ToString & "','" & all_order.Rows.Item(i).Item(6).ToString & "','" & all_order.Rows.Item(i).Item(9).ToString & "','" & all_order.Rows.Item(i).Item(10).ToString & "')"
                            End If
                            sqlcmd1.ExecuteNonQuery()
                            sqlcmd.CommandText = "insert into cx_order_id (order_id) values('" & all_order.Rows.Item(i).Item(0) & "')"
                            sqlcmd.ExecuteNonQuery()
                        Next
                        Order_Max = all_order.Rows.Item(0).Item(2)
                        sqlcmd.CommandText = "update cx_max_record set max_record = '" & Order_Max & "'" & "where table_name = 'cx_order'"
                        sqlcmd.ExecuteNonQuery()
                    End If
                Else
                    all_order_net = False
                    System.Threading.Thread.Sleep(60000)
                    GoTo point1
                End If
            End If
        Else
point2:     If My.Computer.Network.IsAvailable = True Then
                da = New MySqlDataAdapter("select order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,operator_id,operator_type,purchase_type,cart_owner_id from cx_order where order_time > '" & Order_Max & "' order by order_time desc", Mysqlconn)
                cb = New MySqlCommandBuilder(da)
                all_order.Reset()
                Try
                    da.Fill(all_order)
                Catch ex As Exception
                    MsgBox("网络状况不佳，请为管理系统留足够的宽带供其正常运行！")
                    System.Threading.Thread.Sleep(30000)
                    GoTo point2
                End Try
                int_arrow = all_order.Rows.Count
                Dim sqlcmd As New SQLite.SQLiteCommand
                sqlcmd.CommandType = CommandType.Text
                sqlcmd.Connection = SqliteConn
                If int_arrow = 0 Then
                Else
                    Dim sqlcmd1 As New SQLite.SQLiteCommand
                    sqlcmd1.CommandType = CommandType.Text
                    sqlcmd1.Connection = sqliteConn1
                    For i = 0 To int_arrow - 1
                        If all_order.Rows.Item(i).Item(10).ToString = "" Then
                            sqlcmd1.CommandText = "insert into cx_order (order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,purchase_type) values ( '" & all_order.Rows.Item(i).Item(0).ToString & "','" & all_order.Rows.Item(i).Item(1).ToString & "','" & all_order.Rows.Item(i).Item(2).ToString & "','" & all_order.Rows.Item(i).Item(3).ToString & "','" & all_order.Rows.Item(i).Item(4).ToString & "','" & all_order.Rows.Item(i).Item(5).ToString & "','" & all_order.Rows.Item(i).Item(6).ToString & "','" & all_order.Rows.Item(i).Item(9).ToString & "')"
                        Else
                            sqlcmd1.CommandText = "insert into cx_order (order_count,order_status,order_time,order_money,receiver_name,receiver_phone,receiver_address,purchase_type,cart_owner_id) values ( '" & all_order.Rows.Item(i).Item(0).ToString & "','" & all_order.Rows.Item(i).Item(1).ToString & "','" & all_order.Rows.Item(i).Item(2).ToString & "','" & all_order.Rows.Item(i).Item(3).ToString & "','" & all_order.Rows.Item(i).Item(4).ToString & "','" & all_order.Rows.Item(i).Item(5).ToString & "','" & all_order.Rows.Item(i).Item(6).ToString & "','" & all_order.Rows.Item(i).Item(9).ToString & "','" & all_order.Rows.Item(i).Item(10).ToString & "')"
                        End If
                        sqlcmd1.ExecuteNonQuery()
                        sqlcmd.CommandText = "insert into cx_order_id (order_id) values('" & all_order.Rows.Item(i).Item(0) & "')"
                        sqlcmd.ExecuteNonQuery()
                    Next
                    Order_Max = all_order.Rows.Item(0).Item(2)
                    sqlcmd.CommandText = "update cx_max_record set max_record = '" & Order_Max & "'" & "where table_name = 'cx_order'"
                    sqlcmd.ExecuteNonQuery()
                End If
            Else
                all_order_net = False
                System.Threading.Thread.Sleep(60000)
                GoTo point2
            End If
        End If
        all_order_finished = True
    End Sub

    Private Sub order_status_upload_Tick(sender As Object, e As EventArgs) Handles order_status_upload.Tick
        If My.Computer.Network.IsAvailable = True And fristBoot = True And order_net = True And order_status_finished = True Then
            LD_order_status()
        ElseIf tips = 0 And fristBoot = True Then
            tips += 1
            MsgBox("网络断开，请及时修复，否则会影响小二管理系统的正常运行！")
        Else
            If tips = 500 Then
                tips = 0
            Else
                tips += 1
            End If
        End If
    End Sub
    '更改远程数据订单的状态
    Private Sub LD_order_status()
        order_status_finished = False
        order.Reset()
        Dim sqlcmd As New SQLite.SQLiteCommand
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = SqliteConn
        sqlcmd.CommandText = "select order_id,order_status from cx_order_status"
        Dim sqlda As SQLite.SQLiteDataAdapter
        Dim cm As MySqlCommand
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SqliteConn)
        sqlda.Fill(order)
        'Dim da As MySqlDataAdapter
        For i = 0 To order.Rows.Count - 1
            Try
Point:          'da = New MySqlDataAdapter("update cx_order set order_status = '" & order.Rows.Item(i).Item(1) & "' where order_count = '" & order.Rows.Item(i).Item(0) & "'", Mysqlconn)
                'da.UpdateCommand = "update cx_order set order_status = '" & order.Rows.Item(i).Item(1) & "' where order_count = '" & order.Rows.Item(i).Item(0) & "'"
                cm = New MySqlCommand("update cx_order set order_status = '" & order.Rows.Item(i).Item(1) & "' where order_count = '" & order.Rows.Item(i).Item(0) & "'", Mysqlconn)
                cm.ExecuteNonQuery()
                sqlcmd.CommandText = "delete from cx_order_status where order_id = '" & order.Rows.Item(i).Item(0) & "'"
                sqlcmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                If My.Computer.Network.IsAvailable = True Then
                    System.Threading.Thread.Sleep(60000)
                    GoTo Point
                Else
                    MsgBox("当前网络状况不佳，请为管理系统预留足够的宽带便其正常运行！")
                    System.Threading.Thread.Sleep(30000)
                    GoTo Point
                End If
            End Try
        Next
        order_status_finished = True
    End Sub

    Private Sub update_order_detail_Tick(sender As Object, e As EventArgs) Handles update_order_detail.Tick
        If My.Computer.Network.IsAvailable = True And fristBoot = True And order_net = True And order_detail_finished = True Then
            synch_order_detail()
        ElseIf tips = 0 And fristBoot = True Then
            tips += 1
            MsgBox("网络断开，请及时修复，否则会影响小二管理系统的正常运行！")
        Else
            If tips = 500 Then
                tips = 0
            Else
                tips += 1
            End If
        End If
    End Sub
    '同步订单详情
    Private Sub synch_order_detail()
        order_detail_finished = False
        Dim sqlcmd As New SQLite.SQLiteCommand
        Dim sqlcmd1 As New SQLite.SQLiteCommand
        sqlcmd.Connection = SqliteConn
        sqlcmd1.Connection = sqliteConn1
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.CommandText = "select order_id from cx_order_id"
        Dim sqlda As SQLite.SQLiteDataAdapter
        sqlda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SqliteConn)
        Dim temp As New DataTable
        sqlda.Fill(temp)
        Dim data As New DataTable
        If temp.Rows.Count > 0 Then
            Dim da As MySqlDataAdapter
            Dim cb As MySqlCommandBuilder
            For i = 0 To temp.Rows.Count - 1
                data.Reset()
                da = New MySqlDataAdapter("select order_count,product_id,product_name,product_count,product_price,product_picture from cx_order_product where order_count = '" & temp.Rows.Item(i).Item(0) & "'", Mysqlconn)
                cb = New MySqlCommandBuilder(da)
                da.Fill(data)
                For j = 0 To data.Rows.Count - 1
                    If data.Rows.Item(j).Item(5).ToString <> "" Then
                        sqlcmd1.CommandText = "insert into cx_order_product (order_count,product_id,product_name,product_count,product_price,product_picture) values ('" & data.Rows.Item(j).Item(0) & "'," & data.Rows.Item(j).Item(1) & ",'" & data.Rows.Item(j).Item(2) & "'," & data.Rows.Item(j).Item(3) & "," & data.Rows.Item(j).Item(4) & ",'" & data.Rows.Item(j).Item(5) & "')"
                        sqlcmd1.ExecuteNonQuery()
                    Else
                        sqlcmd1.CommandText = "insert into cx_order_product (order_count,product_id,product_name,product_count,product_price) values ('" & data.Rows.Item(j).Item(0) & "'," & data.Rows.Item(j).Item(1) & ",'" & data.Rows.Item(j).Item(2) & "'," & data.Rows.Item(j).Item(3) & "," & data.Rows.Item(j).Item(4) & ")"
                        sqlcmd1.ExecuteNonQuery()
                    End If
                Next
                sqlcmd.CommandText = "delete from cx_order_id where order_id = '" & temp.Rows.Item(i).Item(0) & "'"
                sqlcmd.ExecuteNonQuery()
            Next
        End If
        order_detail_finished = True
    End Sub
End Class
