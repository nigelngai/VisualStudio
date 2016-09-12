
Imports OpenNETCF.Desktop.Communication


Public Class frmDevice


    Private WithEvents _rapi As RAPI = Nothing


    Private Sub frmDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Public Sub connect_Device()
        Try
            If Not Me._rapi.DevicePresent Then
                Throw New Exception("Cannot Connect Device")
            End If
            If Not Me._rapi.Connected Then
                Me._rapi.Connect()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub disconnect_Device()
        Try
            If Me._rapi.Connected Then
                Me._rapi.Disconnect()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Public Sub copy_FileToDevice(ByVal LocalFileName As String, ByVal RemoteFileName As String, ByVal Overwrite As Boolean)

        Me._rapi = New RAPI()

        If Not Me._rapi.Connected Then
            Me.connect_Device()
        End If


        Me._rapi.CopyFileToDevice(LocalFileName, RemoteFileName, Overwrite)

        Me.disconnect_Device()

    End Sub

    Public Sub copy_FromDevice(ByVal device_file_name As String, ByVal pc_file_name As String, ByVal overwrite As Boolean)

        Try

            Me._rapi = New RAPI()

            If Not Me._rapi.Connected Then
                Me.connect_Device()
            End If

            Me._rapi.CopyFileFromDevice(pc_file_name, device_file_name, overwrite)

            Me.disconnect_Device()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub



End Class