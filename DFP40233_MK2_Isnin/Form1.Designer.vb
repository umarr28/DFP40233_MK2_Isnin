<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblMaklumatPelanggan = New Label()
        lblNama = New Label()
        txtNama = New TextBox()
        lblNotel = New Label()
        txtNotel = New TextBox()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        cbxNegeri = New ComboBox()
        lblNegeri = New Label()
        lblJantina = New Label()
        gbxJantina = New GroupBox()
        rbtPerempuan = New RadioButton()
        rbtLelaki = New RadioButton()
        lblKaedahBayaran = New Label()
        gbxKaedahBayaran = New GroupBox()
        rbtCashless = New RadioButton()
        rbtCash = New RadioButton()
        lblPerisa = New Label()
        GroupBox1 = New GroupBox()
        cbxPisang = New CheckBox()
        cbxStrawberi = New CheckBox()
        cbxCoklat = New CheckBox()
        cbxKopi = New CheckBox()
        cbxMilo = New CheckBox()
        lblTarikh = New Label()
        dtpTarikh = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        btnCreate = New Button()
        btnRead = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        gbxJantina.SuspendLayout()
        gbxKaedahBayaran.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMaklumatPelanggan
        ' 
        lblMaklumatPelanggan.AutoSize = True
        lblMaklumatPelanggan.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMaklumatPelanggan.Location = New Point(259, 23)
        lblMaklumatPelanggan.Name = "lblMaklumatPelanggan"
        lblMaklumatPelanggan.Size = New Size(271, 29)
        lblMaklumatPelanggan.TabIndex = 0
        lblMaklumatPelanggan.Text = "MAKLUMAT PELANGGAN"
        lblMaklumatPelanggan.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(80, 105)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(142, 98)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(255, 27)
        txtNama.TabIndex = 2
        ' 
        ' lblNotel
        ' 
        lblNotel.AutoSize = True
        lblNotel.Location = New Point(74, 143)
        lblNotel.Name = "lblNotel"
        lblNotel.Size = New Size(62, 20)
        lblNotel.TabIndex = 3
        lblNotel.Text = "No. Tel :"
        ' 
        ' txtNotel
        ' 
        txtNotel.Location = New Point(142, 140)
        txtNotel.Name = "txtNotel"
        txtNotel.Size = New Size(255, 27)
        txtNotel.TabIndex = 4
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(72, 181)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(64, 20)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Alamat :"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(142, 181)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(255, 117)
        txtAlamat.TabIndex = 6
        ' 
        ' cbxNegeri
        ' 
        cbxNegeri.AutoCompleteCustomSource.AddRange(New String() {"Perlis", "Kedah", "P. Pinang", "Perak", "Selangor", "N. Sembilan", "Melaka", "Johor", "Terengganu", "Pahang", "Kelantan", "Sabah", "Sarawak", "WP. Kuala Lumpur"})
        cbxNegeri.FormattingEnabled = True
        cbxNegeri.Location = New Point(142, 318)
        cbxNegeri.Name = "cbxNegeri"
        cbxNegeri.Size = New Size(151, 28)
        cbxNegeri.TabIndex = 7
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(75, 326)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(61, 20)
        lblNegeri.TabIndex = 8
        lblNegeri.Text = "Negeri :"
        ' 
        ' lblJantina
        ' 
        lblJantina.AutoSize = True
        lblJantina.Location = New Point(74, 378)
        lblJantina.Name = "lblJantina"
        lblJantina.Size = New Size(62, 20)
        lblJantina.TabIndex = 9
        lblJantina.Text = "Jantina :"
        ' 
        ' gbxJantina
        ' 
        gbxJantina.Controls.Add(rbtPerempuan)
        gbxJantina.Controls.Add(rbtLelaki)
        gbxJantina.Location = New Point(142, 366)
        gbxJantina.Name = "gbxJantina"
        gbxJantina.Size = New Size(118, 106)
        gbxJantina.TabIndex = 10
        gbxJantina.TabStop = False
        ' 
        ' rbtPerempuan
        ' 
        rbtPerempuan.AutoSize = True
        rbtPerempuan.Location = New Point(7, 60)
        rbtPerempuan.Name = "rbtPerempuan"
        rbtPerempuan.Size = New Size(104, 24)
        rbtPerempuan.TabIndex = 1
        rbtPerempuan.TabStop = True
        rbtPerempuan.Text = "Perempuan"
        rbtPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbtLelaki
        ' 
        rbtLelaki.AutoSize = True
        rbtLelaki.Location = New Point(6, 26)
        rbtLelaki.Name = "rbtLelaki"
        rbtLelaki.Size = New Size(68, 24)
        rbtLelaki.TabIndex = 0
        rbtLelaki.TabStop = True
        rbtLelaki.Text = "Lelaki"
        rbtLelaki.UseVisualStyleBackColor = True
        ' 
        ' lblKaedahBayaran
        ' 
        lblKaedahBayaran.AutoSize = True
        lblKaedahBayaran.Location = New Point(13, 489)
        lblKaedahBayaran.Name = "lblKaedahBayaran"
        lblKaedahBayaran.Size = New Size(123, 20)
        lblKaedahBayaran.TabIndex = 11
        lblKaedahBayaran.Text = "Kaedah bayaran :"
        ' 
        ' gbxKaedahBayaran
        ' 
        gbxKaedahBayaran.Controls.Add(rbtCashless)
        gbxKaedahBayaran.Controls.Add(rbtCash)
        gbxKaedahBayaran.Location = New Point(142, 489)
        gbxKaedahBayaran.Name = "gbxKaedahBayaran"
        gbxKaedahBayaran.Size = New Size(180, 87)
        gbxKaedahBayaran.TabIndex = 12
        gbxKaedahBayaran.TabStop = False
        ' 
        ' rbtCashless
        ' 
        rbtCashless.AutoSize = True
        rbtCashless.Location = New Point(6, 46)
        rbtCashless.Name = "rbtCashless"
        rbtCashless.Size = New Size(83, 24)
        rbtCashless.TabIndex = 1
        rbtCashless.TabStop = True
        rbtCashless.Text = "cashless"
        rbtCashless.UseVisualStyleBackColor = True
        ' 
        ' rbtCash
        ' 
        rbtCash.AutoSize = True
        rbtCash.Location = New Point(6, 16)
        rbtCash.Name = "rbtCash"
        rbtCash.Size = New Size(59, 24)
        rbtCash.TabIndex = 0
        rbtCash.TabStop = True
        rbtCash.Text = "cash"
        rbtCash.UseVisualStyleBackColor = True
        ' 
        ' lblPerisa
        ' 
        lblPerisa.AutoSize = True
        lblPerisa.Location = New Point(476, 101)
        lblPerisa.Name = "lblPerisa"
        lblPerisa.Size = New Size(54, 20)
        lblPerisa.TabIndex = 13
        lblPerisa.Text = "Perisa :"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbxPisang)
        GroupBox1.Controls.Add(cbxStrawberi)
        GroupBox1.Controls.Add(cbxCoklat)
        GroupBox1.Controls.Add(cbxKopi)
        GroupBox1.Controls.Add(cbxMilo)
        GroupBox1.Location = New Point(536, 98)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(255, 116)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        ' 
        ' cbxPisang
        ' 
        cbxPisang.AutoSize = True
        cbxPisang.Location = New Point(140, 67)
        cbxPisang.Name = "cbxPisang"
        cbxPisang.Size = New Size(74, 24)
        cbxPisang.TabIndex = 4
        cbxPisang.Text = "Pisang"
        cbxPisang.UseVisualStyleBackColor = True
        ' 
        ' cbxStrawberi
        ' 
        cbxStrawberi.AutoSize = True
        cbxStrawberi.Location = New Point(140, 37)
        cbxStrawberi.Name = "cbxStrawberi"
        cbxStrawberi.Size = New Size(94, 24)
        cbxStrawberi.TabIndex = 3
        cbxStrawberi.Text = "Strawberi"
        cbxStrawberi.UseVisualStyleBackColor = True
        ' 
        ' cbxCoklat
        ' 
        cbxCoklat.AutoSize = True
        cbxCoklat.Location = New Point(17, 83)
        cbxCoklat.Name = "cbxCoklat"
        cbxCoklat.Size = New Size(73, 24)
        cbxCoklat.TabIndex = 2
        cbxCoklat.Text = "Coklat"
        cbxCoklat.UseVisualStyleBackColor = True
        ' 
        ' cbxKopi
        ' 
        cbxKopi.AutoSize = True
        cbxKopi.Location = New Point(17, 53)
        cbxKopi.Name = "cbxKopi"
        cbxKopi.Size = New Size(62, 24)
        cbxKopi.TabIndex = 1
        cbxKopi.Text = "Kopi"
        cbxKopi.UseVisualStyleBackColor = True
        ' 
        ' cbxMilo
        ' 
        cbxMilo.AutoSize = True
        cbxMilo.Location = New Point(17, 23)
        cbxMilo.Name = "cbxMilo"
        cbxMilo.Size = New Size(61, 24)
        cbxMilo.TabIndex = 0
        cbxMilo.Text = "Milo"
        cbxMilo.UseVisualStyleBackColor = True
        ' 
        ' lblTarikh
        ' 
        lblTarikh.AutoSize = True
        lblTarikh.Location = New Point(476, 247)
        lblTarikh.Name = "lblTarikh"
        lblTarikh.Size = New Size(54, 20)
        lblTarikh.TabIndex = 15
        lblTarikh.Text = "Tarikh :"
        ' 
        ' dtpTarikh
        ' 
        dtpTarikh.Location = New Point(536, 247)
        dtpTarikh.Name = "dtpTarikh"
        dtpTarikh.Size = New Size(250, 27)
        dtpTarikh.TabIndex = 16
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(381, 343)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(429, 82)
        DataGridView1.TabIndex = 17
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Bil"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "No. tel"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(381, 467)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(94, 29)
        btnCreate.TabIndex = 18
        btnCreate.Text = "CREATE"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' btnRead
        ' 
        btnRead.Location = New Point(500, 467)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(94, 29)
        btnRead.TabIndex = 19
        btnRead.Text = "READ"
        btnRead.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(614, 467)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 20
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(726, 467)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 21
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(851, 588)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnRead)
        Controls.Add(btnCreate)
        Controls.Add(DataGridView1)
        Controls.Add(dtpTarikh)
        Controls.Add(lblTarikh)
        Controls.Add(GroupBox1)
        Controls.Add(lblPerisa)
        Controls.Add(gbxKaedahBayaran)
        Controls.Add(lblKaedahBayaran)
        Controls.Add(gbxJantina)
        Controls.Add(lblJantina)
        Controls.Add(lblNegeri)
        Controls.Add(cbxNegeri)
        Controls.Add(txtAlamat)
        Controls.Add(lblAlamat)
        Controls.Add(txtNotel)
        Controls.Add(lblNotel)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(lblMaklumatPelanggan)
        Name = "Form1"
        Text = "Form1"
        gbxJantina.ResumeLayout(False)
        gbxJantina.PerformLayout()
        gbxKaedahBayaran.ResumeLayout(False)
        gbxKaedahBayaran.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMaklumatPelanggan As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNotel As Label
    Friend WithEvents txtNotel As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cbxNegeri As ComboBox
    Friend WithEvents lblNegeri As Label
    Friend WithEvents lblJantina As Label
    Friend WithEvents gbxJantina As GroupBox
    Friend WithEvents rbtPerempuan As RadioButton
    Friend WithEvents rbtLelaki As RadioButton
    Friend WithEvents lblKaedahBayaran As Label
    Friend WithEvents gbxKaedahBayaran As GroupBox
    Friend WithEvents rbtCash As RadioButton
    Friend WithEvents rbtCashless As RadioButton
    Friend WithEvents lblPerisa As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxPisang As CheckBox
    Friend WithEvents cbxStrawberi As CheckBox
    Friend WithEvents cbxCoklat As CheckBox
    Friend WithEvents cbxKopi As CheckBox
    Friend WithEvents cbxMilo As CheckBox
    Friend WithEvents lblTarikh As Label
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button

End Class
