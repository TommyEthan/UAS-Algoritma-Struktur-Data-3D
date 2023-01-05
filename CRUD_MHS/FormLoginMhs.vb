'Option Strict On
'Option Explicit On
Imports MySql.Data.MySqlClient
Imports CRUD_MHS.DB
Imports System.Net
Imports System.Windows.Input
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class FormLoginMhs
    Sub Authenthicate()
        Call MyDNS()
        Try
            conn.Open()
        Catch ex As MySqlException
            conn.Close()
            conn.Dispose()
            MsgBox(ex.ToString)
        End Try

        dataAdapter = New MySqlDataAdapter
        Dim SQLQuery = "SELECT * FROM tmahasiswa WHERE NIM='" & txtUsername.Text & "' AND " & "pwdlogin='" & txtPassword.Text & "'"
        cmd = New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = SQLQuery

        dataAdapter.SelectCommand = cmd
        reader = cmd.ExecuteReader()
        If reader.HasRows = False Then
            MsgBox("Username atau Password Salah!! ",
            MsgBoxStyle.Exclamation, "Error Login")
            conn.Close()
            conn.Dispose()
        Else
            MsgBox("Login berhasil, Selamat datang " & txtUsername.Text & "!", MsgBoxStyle.Information, "Successfull Login")
            conn.Close()
            conn.Dispose()
            Dim listViewMhs = New frmListMhs
            Me.Hide()
            listViewMhs.Show()
        End If

    End Sub
    Private Sub FormLoginMhs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ConnectionChecking()

    End Sub

    Private Sub btnConnectionTest_Click(sender As Object, e As EventArgs) Handles btnConnectionTest.Click
        Call ConnectionChecking()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Authenthicate()
    End Sub
End Class