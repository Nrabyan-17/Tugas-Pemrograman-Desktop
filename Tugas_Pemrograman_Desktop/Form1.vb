
Imports System.Data.Odbc
Public Class Form1

    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader

    'Untuk menghubungkan Database ke Aplikasi Desktop'
    Sub Koneksi()

        conn = New OdbcConnection("dsn=database_latihan")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MsgBox("Koneksi Berhasil...", MsgBoxStyle.Exclamation, "Informasi")
            End If
        Catch ex As Exception
            MessageBox.Show("Mohon maaf koneksi database gagal " & ex.Message)
        End Try

    End Sub

    'Untuk Menampilkan data pada grid'
    Sub Tampil_Data()
        Call koneksi()
        cmd = New OdbcCommand("SELECT * FROM mahasiswa", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()

        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
        Loop
    End Sub

    Sub bersihkan()
        npm1.Clear()
        nama1.Clear()
        alamat1.Clear()
    End Sub

    'Untuk Menambahkan data'
    Sub Tambah_Data()

        Try
            Call Koneksi()
            Dim npm As String = npm1.Text
            Dim nama_mahasiswa As String = nama1.Text
            Dim jenis_kelamin As String = jenisKelamin1.Text
            Dim alamat As String = alamat1.Text
            Dim query As String = "INSERT INTO mahasiswa (npm, nama_mahasiswa, jenis_kelamin, alamat) VALUES ('" + npm + "', '" + nama_mahasiswa + "', '" + jenis_kelamin + "', '" + alamat + "')"

            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("npm1", npm)
            cmd.Parameters.AddWithValue("nama1", nama_mahasiswa)
            cmd.Parameters.AddWithValue("jenisKelamin1", jenis_kelamin)
            cmd.Parameters.AddWithValue("alamat1", alamat)
            cmd.ExecuteNonQuery()
            MessageBox.Show("data berhasil disimpan ke dalam Database")
            Tampil_Data()
            bersihkan()
        Catch ex As Exception
            MessageBox.Show("terjadi kesalahan: " & ex.Message)
        Finally

        End Try

    End Sub

    'Method untuk menghapus Data yang telah diinput'
    Sub hapusdata()
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim ID As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            Dim sql As String = "DELETE FROM mahasiswa WHERE id = @id"

            If MsgBox("Yakin ingin menghapus data?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
                Try
                    Call Koneksi()
                    Dim cmd As New OdbcCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", ID)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Data berhasil dihapus.")
                    Tampil_Data()
                    bersihkan()
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            Else
                MessageBox.Show("Penghapusan data dibatalkan", "Notifikasi")
            End If
        Else
            MessageBox.Show("Pilih baris yang ingin dihapus terlebih dahulu")
        End If
    End Sub


    'Method untuk Menambahkan dua opsi pada comboBox Jenis Kelamin'
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Untuk mengosongkan list item ketika baru buka GUI-nya'
        jenisKelamin1.Items.Add("Laki-laki")
        jenisKelamin1.Items.Add("Perempuan")
        'Menambahkan opsi laki-laki dan perempuan dalam Combobox'
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        npm1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        nama1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        alamat1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        jenisKelamin1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Call Koneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Tambah_Data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call hapusdata()
    End Sub

    Private Sub jenisKelamin1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jenisKelamin1.SelectedIndexChanged

    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim npm As String = npm1.Text
            Dim nama_mahasiswa As String = nama1.Text
            Dim jenis_kelamin As String = jenisKelamin1.Text
            Dim alamat As String = alamat1.Text
            Dim sql As String = "UPDATE mahasiswa SET npm = '" + npm + "', nama_mahasiswa = '" + nama_mahasiswa + "', jenis_kelamin = '" + jenis_kelamin + "', alamat = '" + alamat + "' WHERE npm = '" + npm + "' "

            Try
                Call Koneksi()
                Dim cmd As New OdbcCommand(sql, conn)
                cmd.Parameters.AddWithValue("@npm", npm)
                cmd.Parameters.AddWithValue("@nama", nama_mahasiswa)
                cmd.Parameters.AddWithValue("@alamat", alamat)
                cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil diupdate")
                Tampil_Data()
                bersihkan()
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Pilih baris yang ingin diupdate terlebih dahulu")
        End If

    End Sub

End Class
