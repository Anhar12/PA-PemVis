<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customerpage
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customerpage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.panelHistory = New System.Windows.Forms.Panel()
        Me.btnBatalkan = New System.Windows.Forms.Button()
        Me.cbFilter = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearchHistory = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_game = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_topup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_topup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waktu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelOrder = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_game = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPesan = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cbGame = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbJumlah = New System.Windows.Forms.ComboBox()
        Me.txtNickname = New System.Windows.Forms.TextBox()
        Me.asd = New System.Windows.Forms.Label()
        Me.panelHome = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblOops = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.panelHistory.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOrder.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelHome.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.MainPanel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1099, 618)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Controls.Add(Me.btnHistory)
        Me.Panel3.Controls.Add(Me.btnOrder)
        Me.Panel3.Controls.Add(Me.btnHome)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(78, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 493)
        Me.Panel3.TabIndex = 33
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Maroon
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(14, 438)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 41)
        Me.btnLogout.TabIndex = 31
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnHistory.FlatAppearance.BorderSize = 2
        Me.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHistory.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.White
        Me.btnHistory.Location = New System.Drawing.Point(14, 287)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(100, 41)
        Me.btnHistory.TabIndex = 23
        Me.btnHistory.Text = "HISTORY"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnOrder.FlatAppearance.BorderSize = 2
        Me.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrder.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.White
        Me.btnOrder.Location = New System.Drawing.Point(14, 219)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(100, 41)
        Me.btnOrder.TabIndex = 22
        Me.btnOrder.Text = "ORDER"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnHome.FlatAppearance.BorderSize = 2
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(14, 150)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(100, 41)
        Me.btnHome.TabIndex = 20
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.PA.My.Resources.Resources.logo_baru
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(14, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.panelHistory)
        Me.MainPanel.Controls.Add(Me.panelOrder)
        Me.MainPanel.Controls.Add(Me.panelHome)
        Me.MainPanel.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainPanel.Location = New System.Drawing.Point(213, 62)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(810, 493)
        Me.MainPanel.TabIndex = 49
        '
        'panelHistory
        '
        Me.panelHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelHistory.Controls.Add(Me.btnBatalkan)
        Me.panelHistory.Controls.Add(Me.cbFilter)
        Me.panelHistory.Controls.Add(Me.Button1)
        Me.panelHistory.Controls.Add(Me.txtSearchHistory)
        Me.panelHistory.Controls.Add(Me.Label9)
        Me.panelHistory.Controls.Add(Me.DataGridView4)
        Me.panelHistory.Font = New System.Drawing.Font("Futura Md BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelHistory.Location = New System.Drawing.Point(-1, -1)
        Me.panelHistory.Name = "panelHistory"
        Me.panelHistory.Size = New System.Drawing.Size(810, 493)
        Me.panelHistory.TabIndex = 52
        '
        'btnBatalkan
        '
        Me.btnBatalkan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnBatalkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBatalkan.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatalkan.Location = New System.Drawing.Point(3, 84)
        Me.btnBatalkan.Name = "btnBatalkan"
        Me.btnBatalkan.Size = New System.Drawing.Size(145, 35)
        Me.btnBatalkan.TabIndex = 52
        Me.btnBatalkan.Text = "Batalkan Pesanan"
        Me.btnBatalkan.UseVisualStyleBackColor = False
        '
        'cbFilter
        '
        Me.cbFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFilter.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilter.FormattingEnabled = True
        Me.cbFilter.Items.AddRange(New Object() {"Semua", "Menunggu", "Berhasil", "Gagal"})
        Me.cbFilter.Location = New System.Drawing.Point(419, 85)
        Me.cbFilter.Name = "cbFilter"
        Me.cbFilter.Size = New System.Drawing.Size(121, 27)
        Me.cbFilter.TabIndex = 51
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Button1.BackgroundImage = Global.PA.My.Resources.Resources.icon_search_removebg_preview
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(776, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 27)
        Me.Button1.TabIndex = 47
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtSearchHistory
        '
        Me.txtSearchHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtSearchHistory.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchHistory.Location = New System.Drawing.Point(546, 84)
        Me.txtSearchHistory.Name = "txtSearchHistory"
        Me.txtSearchHistory.Size = New System.Drawing.Size(224, 27)
        Me.txtSearchHistory.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Futura Md BT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(261, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(279, 26)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Data Riwayat Transaksi"
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToResizeColumns = False
        Me.DataGridView4.AllowUserToResizeRows = False
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView4.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Futura Md BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView4.ColumnHeadersHeight = 34
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.nama_game, Me.ID_user, Me.nickname, Me.jumlah_topup, Me.harga_topup, Me.waktu, Me.Status})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Futura Md BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView4.GridColor = System.Drawing.Color.Black
        Me.DataGridView4.Location = New System.Drawing.Point(3, 122)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.RowHeadersWidth = 62
        Me.DataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(801, 357)
        Me.DataGridView4.TabIndex = 36
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "id"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.FillWeight = 41.98922!
        Me.DataGridViewTextBoxColumn5.HeaderText = "No."
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'nama_game
        '
        Me.nama_game.FillWeight = 95.84388!
        Me.nama_game.HeaderText = "Game"
        Me.nama_game.MinimumWidth = 8
        Me.nama_game.Name = "nama_game"
        Me.nama_game.ReadOnly = True
        '
        'ID_user
        '
        Me.ID_user.FillWeight = 97.11629!
        Me.ID_user.HeaderText = "ID Akun"
        Me.ID_user.MinimumWidth = 8
        Me.ID_user.Name = "ID_user"
        Me.ID_user.ReadOnly = True
        '
        'nickname
        '
        Me.nickname.FillWeight = 96.37785!
        Me.nickname.HeaderText = "Nickname"
        Me.nickname.MinimumWidth = 8
        Me.nickname.Name = "nickname"
        Me.nickname.ReadOnly = True
        '
        'jumlah_topup
        '
        Me.jumlah_topup.FillWeight = 95.84388!
        Me.jumlah_topup.HeaderText = "Jumlah"
        Me.jumlah_topup.MinimumWidth = 8
        Me.jumlah_topup.Name = "jumlah_topup"
        Me.jumlah_topup.ReadOnly = True
        '
        'harga_topup
        '
        Me.harga_topup.FillWeight = 95.84388!
        Me.harga_topup.HeaderText = "Harga"
        Me.harga_topup.MinimumWidth = 8
        Me.harga_topup.Name = "harga_topup"
        Me.harga_topup.ReadOnly = True
        '
        'waktu
        '
        Me.waktu.FillWeight = 149.6001!
        Me.waktu.HeaderText = "Waktu"
        Me.waktu.MinimumWidth = 8
        Me.waktu.Name = "waktu"
        Me.waktu.ReadOnly = True
        '
        'Status
        '
        Me.Status.FillWeight = 72.0536!
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 8
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'panelOrder
        '
        Me.panelOrder.BackColor = System.Drawing.Color.Transparent
        Me.panelOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelOrder.Controls.Add(Me.Label1)
        Me.panelOrder.Controls.Add(Me.DataGridView1)
        Me.panelOrder.Controls.Add(Me.btnClear)
        Me.panelOrder.Controls.Add(Me.btnPesan)
        Me.panelOrder.Controls.Add(Me.txtTotal)
        Me.panelOrder.Controls.Add(Me.cbGame)
        Me.panelOrder.Controls.Add(Me.Label2)
        Me.panelOrder.Controls.Add(Me.Label4)
        Me.panelOrder.Controls.Add(Me.Label6)
        Me.panelOrder.Controls.Add(Me.Label3)
        Me.panelOrder.Controls.Add(Me.txtId)
        Me.panelOrder.Controls.Add(Me.Label5)
        Me.panelOrder.Controls.Add(Me.cbJumlah)
        Me.panelOrder.Controls.Add(Me.txtNickname)
        Me.panelOrder.Controls.Add(Me.asd)
        Me.panelOrder.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelOrder.Location = New System.Drawing.Point(-1, -1)
        Me.panelOrder.Name = "panelOrder"
        Me.panelOrder.Size = New System.Drawing.Size(810, 493)
        Me.panelOrder.TabIndex = 51
        Me.panelOrder.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Futura Md BT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(329, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 26)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Order Page"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeight = 34
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Jumlah, Me.Harga, Me.id_game})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(448, 124)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(336, 304)
        Me.DataGridView1.TabIndex = 25
        '
        'No
        '
        Me.No.FillWeight = 38.07107!
        Me.No.HeaderText = "No."
        Me.No.MinimumWidth = 8
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        '
        'Jumlah
        '
        Me.Jumlah.FillWeight = 130.9645!
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.MinimumWidth = 8
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        '
        'Harga
        '
        Me.Harga.FillWeight = 130.9645!
        Me.Harga.HeaderText = "Harga"
        Me.Harga.MinimumWidth = 8
        Me.Harga.Name = "Harga"
        Me.Harga.ReadOnly = True
        '
        'id_game
        '
        Me.id_game.HeaderText = "id_game"
        Me.id_game.MinimumWidth = 8
        Me.id_game.Name = "id_game"
        Me.id_game.ReadOnly = True
        Me.id_game.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(340, 393)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 35)
        Me.btnClear.TabIndex = 28
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnPesan
        '
        Me.btnPesan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPesan.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesan.Location = New System.Drawing.Point(21, 393)
        Me.btnPesan.Name = "btnPesan"
        Me.btnPesan.Size = New System.Drawing.Size(83, 35)
        Me.btnPesan.TabIndex = 27
        Me.btnPesan.Text = "Top Up"
        Me.btnPesan.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(83, 301)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(340, 27)
        Me.txtTotal.TabIndex = 31
        '
        'cbGame
        '
        Me.cbGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbGame.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGame.FormattingEnabled = True
        Me.cbGame.Location = New System.Drawing.Point(21, 124)
        Me.cbGame.Name = "cbGame"
        Me.cbGame.Size = New System.Drawing.Size(192, 27)
        Me.cbGame.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Futura Md BT", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(509, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 22)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Daftar Harga Top Up"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(17, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Game"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "ID Akun"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(21, 219)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(192, 27)
        Me.txtId.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(227, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Jumlah Top Up"
        '
        'cbJumlah
        '
        Me.cbJumlah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJumlah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbJumlah.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJumlah.FormattingEnabled = True
        Me.cbJumlah.Items.AddRange(New Object() {"5", "12", "50", "70", "140", "355", "720", "1450", "2180", "3640"})
        Me.cbJumlah.Location = New System.Drawing.Point(231, 124)
        Me.cbJumlah.Name = "cbJumlah"
        Me.cbJumlah.Size = New System.Drawing.Size(192, 27)
        Me.cbJumlah.TabIndex = 22
        '
        'txtNickname
        '
        Me.txtNickname.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNickname.Location = New System.Drawing.Point(231, 219)
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(192, 27)
        Me.txtNickname.TabIndex = 20
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.BackColor = System.Drawing.Color.Transparent
        Me.asd.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.ForeColor = System.Drawing.Color.White
        Me.asd.Location = New System.Drawing.Point(227, 197)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(91, 19)
        Me.asd.TabIndex = 17
        Me.asd.Text = "Nickname"
        '
        'panelHome
        '
        Me.panelHome.BackColor = System.Drawing.Color.Transparent
        Me.panelHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelHome.Controls.Add(Me.Label8)
        Me.panelHome.Controls.Add(Me.DataGridView3)
        Me.panelHome.Controls.Add(Me.btnSearch)
        Me.panelHome.Controls.Add(Me.txtSearch)
        Me.panelHome.Controls.Add(Me.lblOops)
        Me.panelHome.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelHome.Location = New System.Drawing.Point(-1, -1)
        Me.panelHome.Name = "panelHome"
        Me.panelHome.Size = New System.Drawing.Size(810, 493)
        Me.panelHome.TabIndex = 50
        Me.panelHome.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Futura Md BT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(274, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(254, 26)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Home Page Customer"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToResizeColumns = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView3.ColumnHeadersHeight = 34
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView3.GridColor = System.Drawing.Color.Black
        Me.DataGridView3.Location = New System.Drawing.Point(44, 137)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidth = 62
        Me.DataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView3.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(717, 351)
        Me.DataGridView3.TabIndex = 33
        Me.DataGridView3.Visible = False
        '
        'Column1
        '
        Me.Column1.FillWeight = 30.45686!
        Me.Column1.HeaderText = "No."
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 175.2838!
        Me.Column2.HeaderText = "Nama Game"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 107.1607!
        Me.Column3.HeaderText = "Jumlah"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 87.09876!
        Me.Column4.HeaderText = "Harga"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSearch.BackgroundImage = Global.PA.My.Resources.Resources.icon_search_removebg_preview
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(733, 98)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(28, 27)
        Me.btnSearch.TabIndex = 32
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(44, 98)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(683, 27)
        Me.txtSearch.TabIndex = 0
        '
        'lblOops
        '
        Me.lblOops.AutoSize = True
        Me.lblOops.Font = New System.Drawing.Font("Futura Md BT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOops.ForeColor = System.Drawing.Color.White
        Me.lblOops.Location = New System.Drawing.Point(184, 189)
        Me.lblOops.Name = "lblOops"
        Me.lblOops.Size = New System.Drawing.Size(333, 26)
        Me.lblOops.TabIndex = 45
        Me.lblOops.Text = "Oops Data Tidak Ditemukan"
        Me.lblOops.Visible = False
        '
        'Customerpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BackgroundImage = Global.PA.My.Resources.Resources.BG_fix1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1099, 618)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Customerpage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factory Store"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.panelHistory.ResumeLayout(False)
        Me.panelHistory.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOrder.ResumeLayout(False)
        Me.panelOrder.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelHome.ResumeLayout(False)
        Me.panelHome.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MainPanel As Panel
    Friend WithEvents panelHistory As Panel
    Friend WithEvents cbFilter As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearchHistory As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents nama_game As DataGridViewTextBoxColumn
    Friend WithEvents ID_user As DataGridViewTextBoxColumn
    Friend WithEvents nickname As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_topup As DataGridViewTextBoxColumn
    Friend WithEvents harga_topup As DataGridViewTextBoxColumn
    Friend WithEvents waktu As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents panelOrder As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents id_game As DataGridViewTextBoxColumn
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPesan As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents cbGame As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbJumlah As ComboBox
    Friend WithEvents txtNickname As TextBox
    Friend WithEvents asd As Label
    Friend WithEvents panelHome As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblOops As Label
    Friend WithEvents btnBatalkan As Button
End Class
