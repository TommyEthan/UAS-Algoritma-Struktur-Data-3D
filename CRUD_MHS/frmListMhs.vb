Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports CRUD_MHS.DB
Imports System.Runtime.Intrinsics
Imports System.Windows.Input
Imports Org.BouncyCastle.Math.EC.ECCurve

Public Class frmListMhs
    Public isiList As ListView
    Dim row As Integer


    Sub GetDataMhs()
        Call MyDNS()
        Try
            conn.Open()
            dataTable = New DataTable
            query = "SELECT * FROM tmahasiswa"
            dataAdapter = New MySqlDataAdapter(query, conn)
            dataAdapter.Fill(dataTable)
            row = 1
            For i As Integer = 0 To dataTable.Rows.Count - 1
                With ListViewMhs
                    .Items.Add(row)
                    With .Items(.Items.Count - 1).SubItems
                        .Add(dataTable.Rows(i)("NIM"))
                        .Add(IIf(IsDBNull(dataTable.Rows(i)("NamaLengkap")), "", dataTable.Rows(i)("NamaLengkap")))
                        .Add(IIf(IsDBNull(dataTable.Rows(i)("JenisKelamin")), "", dataTable.Rows(i)("JenisKelamin")))
                        .Add(IIf(IsDBNull(dataTable.Rows(i)("TglLahir")), "", dataTable.Rows(i)("TglLahir")))
                        .Add(IIf(IsDBNull(dataTable.Rows(i)("AlamatAsal")), "", dataTable.Rows(i)("AlamatAsal")))
                        .Add(IIf(IsDBNull(dataTable.Rows(i)("KotaAsal")), "", dataTable.Rows(i)("KotaAsal")))
                        .Add(IIf(IsDBNull(dataTable.Rows(i)("AlamatMalang")), "", dataTable.Rows(i)("AlamatMalang")))
                        .Add(IIf(IsDBNull(dataTable.Rows(i)("Agama")), "", dataTable.Rows(i)("Agama")))
                        .Add(IIf(IsDBNull(dataTable.Rows(i)("TahunLulusSMA")), "", dataTable.Rows(i)("TahunLulusSMA")))
                        .Add(IIf(IsDBNull(dataTable.Rows(i)("KELAS")), "", dataTable.Rows(i)("KELAS")))
                        .Add(IIf(IsDBNull(dataTable.Rows(i)("ProgramKelas")), "", dataTable.Rows(i)("ProgramKelas")))
                    End With
                End With
                row += 1
            Next
            conn.Close()
            conn.Dispose()
        Catch ex As MySqlException
            conn.Close()
            conn.Dispose()
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Connection Error!")
        End Try
    End Sub
    Private Sub frmListMhs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ListViewMhs
            .View = View.Details 'tipe tampilan
            .GridLines = True
            .FullRowSelect = True
            .Scrollable = True
        End With

        With ListViewMhs.Columns
            .Add("No", 40)
            .Add("NIM", 40)   'Judul,Lebar
            .Add("Nama", 250)
            .Add("J.Kelamin", 100)
            .Add("Tgl Lahir", 80)
            .Add("Alamat Asal", 90)
            .Add("Kota Asal", 100)
            .Add("Alamat Malang", 100)
            .Add("Agama", 100)
            .Add("Th. LULUS SMA", 100)
            .Add("KELAS", 100)
            .Add("PROG. KELAS", 100)
        End With
        GetDataMhs()

        With ComboBoxAgama
            .Items.Add("Islam")
            .Items.Add("Kristen")
            .Items.Add("Katolik")
            .Items.Add("Hindu")
            .Items.Add("Budha")
        End With

        With ComboBoxGender
            .Items.Add("Laki-Laki")
            .Items.Add("Perempuan")
        End With

        With ComboBoxKelas
            .Items.Add("3A")
            .Items.Add("3B")
            .Items.Add("3C")
        End With

        With ComboBoxProgKelas
            .Items.Add("AKSELERASI")
            .Items.Add("REGULER")
        End With

    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ClearDataListview()
        GetDataMhs()
    End Sub

    Sub ClearDataListview()
        ListViewMhs.Items.Clear()
    End Sub

    Private Sub BtnClearForm_Click(sender As Object, e As EventArgs) Handles BtnClearForm.Click
        Call EmptyForm()
    End Sub

    Sub EmptyForm()
        TxtEmail.Text = ""
        TxtKotaAsal.Text = ""
        TxtLulusSMA.Text = ""
        TxtNama.Text = ""
        TxtNIM.Text = ""
        ComboBoxGender.Text = ""
        ComboBoxAgama.Text = ""
        ComboBoxKelas.Text = ""
        ComboBoxProgKelas.Text = ""
        RTBAlamatAsal.Text = ""
        RTBAlamatMalang.Text = ""
    End Sub

    Sub Store()
        Dim nim, nama, jenisKelamin, tglLahir, alamatAsal, kotaAsal, alamatMlg As String
        Dim agama, programkelas, email, kelas, password As String
        Dim tahunLulus As String

        nim = TxtNIM.Text
        nama = TxtNama.Text
        jenisKelamin = ComboBoxGender.Text
        tglLahir = Format(DateLahir.Value, "yyyy-MM-dd")
        alamatAsal = RTBAlamatAsal.Text
        kotaAsal = TxtKotaAsal.Text
        alamatMlg = RTBAlamatMalang.Text
        agama = ComboBoxAgama.Text
        tahunLulus = Val(TxtLulusSMA.Text)
        programkelas = ComboBoxProgKelas.Text
        email = TxtEmail.Text
        kelas = ComboBoxKelas.Text
        password = nim

        'Insert Into Query
        Dim SQLQuery As String
        SQLQuery = "INSERT INTO tmahasiswa (NIM, NamaLengkap, JenisKelamin, TglLahir, AlamatAsal, KotaAsal, AlamatMalang, Agama, TahunLulusSMA, ProgramKelas, email, KELAS, pwdlogin) VALUES ('" & nim & "','" &
        nama & "','" &
        jenisKelamin & "','" &
        tglLahir & "','" &
        alamatAsal & "','" &
        kotaAsal & "','" &
        alamatMlg & "','" &
        agama & "'," &
        tahunLulus & ",'" &
        programkelas & "','" &
        email & "','" &
        kelas & "','" &
        password & "')"

        Call MyDNS()
        'CONFIG
        Dim server As String = "127.0.0.1"
        Dim port As String = "3306"
        Dim username As String = "root"
        Dim pwd As String = ""
        Dim database As String = "dbmahasiswa"
        conn = New MySqlConnection
        conn.ConnectionString = "server=" & server & ";port=" & port & ";userid=" & username & ";password=" & pwd & ";database=" & database
        'cmd.Connection = conn
        Try
            conn.Open()
            'dataAdapter = New MySqlDataAdapter
            'cmd = New MySqlCommand
            'cmd.CommandText = SQLQuery
            cmd = New MySqlCommand(SQLQuery, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Saved", MsgBoxStyle.Information, "Status")
        Catch ex As MySqlException
            conn.Close()
            conn.Dispose()
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Store()
        ClearDataListview()
        GetDataMhs()
    End Sub
End Class