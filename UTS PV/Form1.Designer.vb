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
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        BuatKatalisBaruToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        TentangKataLeenToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        btnUbahKatalis1 = New Button()
        txtInspirasi = New TextBox()
        Label1 = New Label()
        btnRandom = New Button()
        GroupBox2 = New GroupBox()
        btnUbahKatalis2 = New Button()
        Button2 = New Button()
        txtLatarBelakang = New TextBox()
        GroupBox3 = New GroupBox()
        btnUbahKatalis3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        txtKelanjutan = New TextBox()
        btnSimpan = New Button()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(726, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BuatKatalisBaruToolStripMenuItem, KeluarToolStripMenuItem})
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(50, 20)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' BuatKatalisBaruToolStripMenuItem
        ' 
        BuatKatalisBaruToolStripMenuItem.Name = "BuatKatalisBaruToolStripMenuItem"
        BuatKatalisBaruToolStripMenuItem.Size = New Size(180, 22)
        BuatKatalisBaruToolStripMenuItem.Text = "Buat Katalis Baru"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(180, 22)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TentangKataLeenToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' TentangKataLeenToolStripMenuItem
        ' 
        TentangKataLeenToolStripMenuItem.Name = "TentangKataLeenToolStripMenuItem"
        TentangKataLeenToolStripMenuItem.Size = New Size(167, 22)
        TentangKataLeenToolStripMenuItem.Text = "Tentang KataLeen"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnUbahKatalis1)
        GroupBox1.Controls.Add(txtInspirasi)
        GroupBox1.Font = New Font("Segoe UI", 12.0F)
        GroupBox1.Location = New Point(26, 109)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(674, 204)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Inspirasi"
        ' 
        ' btnUbahKatalis1
        ' 
        btnUbahKatalis1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnUbahKatalis1.Font = New Font("Segoe UI", 9.0F)
        btnUbahKatalis1.Location = New Point(579, 165)
        btnUbahKatalis1.Name = "btnUbahKatalis1"
        btnUbahKatalis1.Size = New Size(85, 29)
        btnUbahKatalis1.TabIndex = 1
        btnUbahKatalis1.Text = "Ubah"
        btnUbahKatalis1.UseVisualStyleBackColor = True
        ' 
        ' txtInspirasi
        ' 
        txtInspirasi.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtInspirasi.Location = New Point(15, 28)
        txtInspirasi.Multiline = True
        txtInspirasi.Name = "txtInspirasi"
        txtInspirasi.ScrollBars = ScrollBars.Vertical
        txtInspirasi.Size = New Size(649, 131)
        txtInspirasi.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        Label1.Location = New Point(26, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 30)
        Label1.TabIndex = 4
        Label1.Text = "Katalis Hari Ini"
        ' 
        ' btnRandom
        ' 
        btnRandom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRandom.AutoSize = True
        btnRandom.Location = New Point(605, 52)
        btnRandom.Name = "btnRandom"
        btnRandom.Size = New Size(85, 29)
        btnRandom.TabIndex = 5
        btnRandom.Text = "Random"
        btnRandom.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnUbahKatalis2)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(txtLatarBelakang)
        GroupBox2.Font = New Font("Segoe UI", 12.0F)
        GroupBox2.Location = New Point(26, 319)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(674, 204)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "LatarBelakang"
        ' 
        ' btnUbahKatalis2
        ' 
        btnUbahKatalis2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnUbahKatalis2.Font = New Font("Segoe UI", 9.0F)
        btnUbahKatalis2.Location = New Point(579, 165)
        btnUbahKatalis2.Name = "btnUbahKatalis2"
        btnUbahKatalis2.Size = New Size(85, 29)
        btnUbahKatalis2.TabIndex = 2
        btnUbahKatalis2.Text = "Ubah"
        btnUbahKatalis2.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.Font = New Font("Segoe UI", 9.0F)
        Button2.Location = New Point(1053, 165)
        Button2.Name = "Button2"
        Button2.Size = New Size(85, 29)
        Button2.TabIndex = 1
        Button2.Text = "Ubah"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtLatarBelakang
        ' 
        txtLatarBelakang.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtLatarBelakang.Location = New Point(15, 28)
        txtLatarBelakang.Multiline = True
        txtLatarBelakang.Name = "txtLatarBelakang"
        txtLatarBelakang.ScrollBars = ScrollBars.Vertical
        txtLatarBelakang.Size = New Size(649, 131)
        txtLatarBelakang.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(btnUbahKatalis3)
        GroupBox3.Controls.Add(Button4)
        GroupBox3.Controls.Add(Button5)
        GroupBox3.Controls.Add(txtKelanjutan)
        GroupBox3.Font = New Font("Segoe UI", 12.0F)
        GroupBox3.Location = New Point(26, 529)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(674, 204)
        GroupBox3.TabIndex = 7
        GroupBox3.TabStop = False
        GroupBox3.Text = "Kelanjutan"
        ' 
        ' btnUbahKatalis3
        ' 
        btnUbahKatalis3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnUbahKatalis3.Font = New Font("Segoe UI", 9.0F)
        btnUbahKatalis3.Location = New Point(579, 165)
        btnUbahKatalis3.Name = "btnUbahKatalis3"
        btnUbahKatalis3.Size = New Size(85, 29)
        btnUbahKatalis3.TabIndex = 3
        btnUbahKatalis3.Text = "Ubah"
        btnUbahKatalis3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.Font = New Font("Segoe UI", 9.0F)
        Button4.Location = New Point(1053, 165)
        Button4.Name = "Button4"
        Button4.Size = New Size(85, 29)
        Button4.TabIndex = 2
        Button4.Text = "Ubah"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button5.Font = New Font("Segoe UI", 9.0F)
        Button5.Location = New Point(1527, 165)
        Button5.Name = "Button5"
        Button5.Size = New Size(85, 29)
        Button5.TabIndex = 1
        Button5.Text = "Ubah"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' txtKelanjutan
        ' 
        txtKelanjutan.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtKelanjutan.Location = New Point(15, 28)
        txtKelanjutan.Multiline = True
        txtKelanjutan.Name = "txtKelanjutan"
        txtKelanjutan.ScrollBars = ScrollBars.Vertical
        txtKelanjutan.Size = New Size(649, 131)
        txtKelanjutan.TabIndex = 0
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSimpan.AutoSize = True
        btnSimpan.Location = New Point(503, 52)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(85, 29)
        btnSimpan.TabIndex = 8
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(726, 759)
        Controls.Add(btnSimpan)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(btnRandom)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MinimumSize = New Size(400, 350)
        Name = "Form1"
        Text = "KataLeen"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtInspirasi As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuatKatalisBaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatSemuaKatalisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangKataLeenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnUbahKatalis1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRandom As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUbahKatalis2 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtLatarBelakang As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnUbahKatalis3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtKelanjutan As TextBox
    Friend WithEvents btnSimpan As Button

End Class
