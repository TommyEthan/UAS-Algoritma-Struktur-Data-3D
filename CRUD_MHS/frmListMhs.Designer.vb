<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListMhs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListViewMhs = New System.Windows.Forms.ListView()
        Me.BtnClearForm = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNIM = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtKotaAsal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateLahir = New System.Windows.Forms.DateTimePicker()
        Me.RTBAlamatAsal = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RTBAlamatMalang = New System.Windows.Forms.RichTextBox()
        Me.ComboBoxAgama = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtLulusSMA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxProgKelas = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBoxKelas = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListViewMhs
        '
        Me.ListViewMhs.Location = New System.Drawing.Point(12, 323)
        Me.ListViewMhs.Name = "ListViewMhs"
        Me.ListViewMhs.Size = New System.Drawing.Size(1115, 285)
        Me.ListViewMhs.TabIndex = 0
        Me.ListViewMhs.UseCompatibleStateImageBehavior = False
        '
        'BtnClearForm
        '
        Me.BtnClearForm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnClearForm.Location = New System.Drawing.Point(757, 280)
        Me.BtnClearForm.Name = "BtnClearForm"
        Me.BtnClearForm.Size = New System.Drawing.Size(97, 37)
        Me.BtnClearForm.TabIndex = 3
        Me.BtnClearForm.Text = "Clear Form"
        Me.BtnClearForm.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSave.Location = New System.Drawing.Point(939, 280)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(80, 37)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnRefresh.Location = New System.Drawing.Point(1049, 280)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(78, 37)
        Me.BtnRefresh.TabIndex = 5
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "1. NIM"
        '
        'TxtNIM
        '
        Me.TxtNIM.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNIM.Location = New System.Drawing.Point(172, 17)
        Me.TxtNIM.Name = "TxtNIM"
        Me.TxtNIM.Size = New System.Drawing.Size(195, 27)
        Me.TxtNIM.TabIndex = 7
        '
        'TxtNama
        '
        Me.TxtNama.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNama.Location = New System.Drawing.Point(172, 50)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(390, 27)
        Me.TxtNama.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "2. NAMA LENGKAP"
        '
        'TxtKotaAsal
        '
        Me.TxtKotaAsal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtKotaAsal.Location = New System.Drawing.Point(172, 234)
        Me.TxtKotaAsal.Name = "TxtKotaAsal"
        Me.TxtKotaAsal.Size = New System.Drawing.Size(256, 27)
        Me.TxtKotaAsal.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "3. JENIS KELAMIN"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.AutoCompleteCustomSource.AddRange(New String() {"Laki-laki", "Perempuan"})
        Me.ComboBoxGender.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Location = New System.Drawing.Point(172, 83)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(134, 28)
        Me.ComboBoxGender.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "4. TANGGAL LAHIR"
        '
        'DateLahir
        '
        Me.DateLahir.CalendarFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateLahir.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateLahir.Location = New System.Drawing.Point(172, 119)
        Me.DateLahir.Name = "DateLahir"
        Me.DateLahir.Size = New System.Drawing.Size(256, 27)
        Me.DateLahir.TabIndex = 14
        '
        'RTBAlamatAsal
        '
        Me.RTBAlamatAsal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RTBAlamatAsal.Location = New System.Drawing.Point(172, 152)
        Me.RTBAlamatAsal.Name = "RTBAlamatAsal"
        Me.RTBAlamatAsal.Size = New System.Drawing.Size(390, 63)
        Me.RTBAlamatAsal.TabIndex = 15
        Me.RTBAlamatAsal.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "5. ALAMAT ASAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(12, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "6. KOTA ASAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(597, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "7. ALAMAT MALANG"
        '
        'RTBAlamatMalang
        '
        Me.RTBAlamatMalang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RTBAlamatMalang.Location = New System.Drawing.Point(757, 12)
        Me.RTBAlamatMalang.Name = "RTBAlamatMalang"
        Me.RTBAlamatMalang.Size = New System.Drawing.Size(372, 63)
        Me.RTBAlamatMalang.TabIndex = 18
        Me.RTBAlamatMalang.Text = ""
        '
        'ComboBoxAgama
        '
        Me.ComboBoxAgama.AutoCompleteCustomSource.AddRange(New String() {"Islam", "Kristen", "Katolik", "Hindu", "Budha"})
        Me.ComboBoxAgama.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxAgama.FormattingEnabled = True
        Me.ComboBoxAgama.Location = New System.Drawing.Point(757, 81)
        Me.ComboBoxAgama.Name = "ComboBoxAgama"
        Me.ComboBoxAgama.Size = New System.Drawing.Size(155, 28)
        Me.ComboBoxAgama.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(597, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "8. AGAMA"
        '
        'TxtLulusSMA
        '
        Me.TxtLulusSMA.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtLulusSMA.Location = New System.Drawing.Point(757, 117)
        Me.TxtLulusSMA.Name = "TxtLulusSMA"
        Me.TxtLulusSMA.Size = New System.Drawing.Size(119, 27)
        Me.TxtLulusSMA.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(597, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "9. TAHUN LULUS SMA"
        '
        'ComboBoxProgKelas
        '
        Me.ComboBoxProgKelas.AutoCompleteCustomSource.AddRange(New String() {"AKSELERASI", "REGULER"})
        Me.ComboBoxProgKelas.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxProgKelas.FormattingEnabled = True
        Me.ComboBoxProgKelas.Location = New System.Drawing.Point(757, 150)
        Me.ComboBoxProgKelas.Name = "ComboBoxProgKelas"
        Me.ComboBoxProgKelas.Size = New System.Drawing.Size(168, 28)
        Me.ComboBoxProgKelas.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(597, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "10. PROGRAM KELAS"
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtEmail.Location = New System.Drawing.Point(757, 184)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(300, 27)
        Me.TxtEmail.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(597, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "11. EMAIL"
        '
        'ComboBoxKelas
        '
        Me.ComboBoxKelas.AutoCompleteCustomSource.AddRange(New String() {"3A", "3B", "3C"})
        Me.ComboBoxKelas.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxKelas.FormattingEnabled = True
        Me.ComboBoxKelas.Location = New System.Drawing.Point(757, 217)
        Me.ComboBoxKelas.Name = "ComboBoxKelas"
        Me.ComboBoxKelas.Size = New System.Drawing.Size(119, 28)
        Me.ComboBoxKelas.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(597, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 17)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "10. KELAS"
        '
        'frmListMhs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 620)
        Me.Controls.Add(Me.ComboBoxKelas)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBoxProgKelas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtLulusSMA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBoxAgama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RTBAlamatMalang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RTBAlamatAsal)
        Me.Controls.Add(Me.DateLahir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxGender)
        Me.Controls.Add(Me.TxtKotaAsal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNIM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnClearForm)
        Me.Controls.Add(Me.ListViewMhs)
        Me.Name = "frmListMhs"
        Me.Text = "List Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListViewMhs As ListView
    Friend WithEvents BtnClearForm As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtKotaAsal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateLahir As DateTimePicker
    Friend WithEvents RTBAlamatAsal As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RTBAlamatMalang As RichTextBox
    Friend WithEvents ComboBoxAgama As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtLulusSMA As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBoxProgKelas As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBoxKelas As ComboBox
    Friend WithEvents Label12 As Label
End Class
