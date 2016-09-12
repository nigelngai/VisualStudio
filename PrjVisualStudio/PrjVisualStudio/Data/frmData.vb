Imports System.Data.SqlClient
Public Class frmData

    Public strSQLConn As String

    Private Sub frmDatabaseConn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Debug.Print(Environment.MachineName.ToUpper)
        Debug.Print(Environment.OSVersion.ToString)
        Debug.Print(Environment.UserDomainName)
        Debug.Print(Environment.UserName)
        Debug.Print(Environment.CurrentDirectory)
        Debug.Print(Environment.Is64BitOperatingSystem)



    End Sub



    'strSQLConn = "Data Source=ServerName;Initial Catalog=AdventureWorks2014;Persist Security Info=True;User ID=sa;Password=YourSecret"

    'ReadDataFromDB()

    Private Sub ReadDataFromDB()

        Dim sqlConn As New SqlConnection(strSQLConn)

        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim myReader As SqlDataReader

        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "Select itemCode , itemName from  ItemMaster "
        cmd.Connection = sqlConn

        sqlConn.Open()
        myReader = cmd.ExecuteReader()

        While myReader.Read

            dgSample.Rows.Add(myReader.Item("itemCode"), myReader.Item("itemname"))

        End While

        sqlConn.Close()

    End Sub




    Private Sub btnInsertPara_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertPara.Click
        InsertWithPara()
    End Sub

    Private Sub InsertWithPara()

        Dim sqlConn As New SqlConnection(strSQLConn)

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT INTO ItemMaster  ( ItemCode,  ItemName  ,CategoryCode ,Color)  Values ( @itemcode , @itemName, @catecode, @color) "
        cmd.Connection = sqlConn

        Try
            cmd.Parameters.AddWithValue("@itemcode", "60300")
            cmd.Parameters.AddWithValue("@itemName", "AirLine Max")
            cmd.Parameters.AddWithValue("@catecode", 9)
            cmd.Parameters.AddWithValue("@color", "Green")

            'cmd.Parameters.Add("@itemcode", SqlDbType.NVarChar)
            'cmd.Parameters["@itemcode"].Value = textBox1.Text

            sqlConn.Open()
            cmd.ExecuteNonQuery()
            sqlConn.Close()

            MsgBox("Insert Success", MsgBoxStyle.Information)

        Catch ex As Exception
            sqlConn = Nothing
        End Try

    End Sub


    Private Sub BtnInsert_Click(sender As System.Object, e As System.EventArgs) Handles BtnInsert.Click

        Dim sqlConn As New SqlConnection(strSQLConn)

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT INTO ItemMaster  ( ItemCode,  ItemName  ,CategoryCode ,Color)  Values ( '60100' , 'AirLine', 9, 'Red') "
        cmd.Connection = sqlConn

        Try

            sqlConn.Open()
            cmd.ExecuteNonQuery()
            sqlConn.Close()

            MsgBox("Insert Success", MsgBoxStyle.Information)

        Catch ex As Exception
            sqlConn = Nothing
        End Try

    End Sub




End Class