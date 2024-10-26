<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        npm1 = New TextBox()
        alamat1 = New TextBox()
        nama1 = New TextBox()
        jenisKelamin1 = New ComboBox()
        Button1 = New Button()
        Edit = New Button()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(183, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 0
        Label1.Text = "NPM:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(183, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(183, 121)
        Label3.Name = "Label3"
        Label3.RightToLeft = RightToLeft.No
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 2
        Label3.Text = "Alamat:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(183, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 15)
        Label4.TabIndex = 3
        Label4.Text = "Jenis Kelamin:"
        ' 
        ' npm1
        ' 
        npm1.Location = New Point(284, 22)
        npm1.Name = "npm1"
        npm1.Size = New Size(307, 23)
        npm1.TabIndex = 4
        ' 
        ' alamat1
        ' 
        alamat1.Location = New Point(284, 118)
        alamat1.Name = "alamat1"
        alamat1.Size = New Size(307, 23)
        alamat1.TabIndex = 5
        ' 
        ' nama1
        ' 
        nama1.Location = New Point(284, 71)
        nama1.Name = "nama1"
        nama1.Size = New Size(307, 23)
        nama1.TabIndex = 6
        ' 
        ' jenisKelamin1
        ' 
        jenisKelamin1.FormattingEnabled = True
        jenisKelamin1.Location = New Point(284, 169)
        jenisKelamin1.Name = "jenisKelamin1"
        jenisKelamin1.Size = New Size(307, 23)
        jenisKelamin1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(239, 227)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 29)
        Button1.TabIndex = 9
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Edit
        ' 
        Edit.Location = New Point(385, 227)
        Edit.Name = "Edit"
        Edit.Size = New Size(80, 29)
        Edit.TabIndex = 10
        Edit.Text = "Edit"
        Edit.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(531, 227)
        Button3.Name = "Button3"
        Button3.Size = New Size(80, 29)
        Button3.TabIndex = 11
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(144, 277)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(544, 161)
        DataGridView1.TabIndex = 12
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID Anggota"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "NPM"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Nama Anggota"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Jenis Kelamin"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Alamat"
        Column5.Name = "Column5"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(644, 102)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 13
        Button2.Text = "Test Koneksi"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(Edit)
        Controls.Add(Button1)
        Controls.Add(jenisKelamin1)
        Controls.Add(nama1)
        Controls.Add(alamat1)
        Controls.Add(npm1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = " "
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents npm1 As TextBox
    Friend WithEvents alamat1 As TextBox
    Friend WithEvents nama1 As TextBox
    Friend WithEvents jenisKelamin1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn

End Class
