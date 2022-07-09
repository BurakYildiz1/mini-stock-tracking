<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblUrunFiyat = New System.Windows.Forms.Label()
        Me.lblToplam = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnHesapla = New System.Windows.Forms.Button()
        Me.btnCikar = New System.Windows.Forms.Button()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.lbStok = New System.Windows.Forms.ListBox()
        Me.lbTedarikci = New System.Windows.Forms.ListBox()
        Me.lbIade = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUrunFiyat
        '
        Me.lblUrunFiyat.AutoSize = True
        Me.lblUrunFiyat.Location = New System.Drawing.Point(666, 338)
        Me.lblUrunFiyat.Name = "lblUrunFiyat"
        Me.lblUrunFiyat.Size = New System.Drawing.Size(0, 13)
        Me.lblUrunFiyat.TabIndex = 21
        '
        'lblToplam
        '
        Me.lblToplam.AutoSize = True
        Me.lblToplam.Location = New System.Drawing.Point(666, 386)
        Me.lblToplam.Name = "lblToplam"
        Me.lblToplam.Size = New System.Drawing.Size(0, 13)
        Me.lblToplam.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(436, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "toplam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(433, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "secilen urun"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(552, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "stok"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(95, 51)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(39, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "tedarik"
        '
        'btnHesapla
        '
        Me.btnHesapla.Location = New System.Drawing.Point(364, 218)
        Me.btnHesapla.Name = "btnHesapla"
        Me.btnHesapla.Size = New System.Drawing.Size(75, 23)
        Me.btnHesapla.TabIndex = 15
        Me.btnHesapla.Text = "Hesapla"
        Me.btnHesapla.UseVisualStyleBackColor = True
        '
        'btnCikar
        '
        Me.btnCikar.Location = New System.Drawing.Point(364, 160)
        Me.btnCikar.Name = "btnCikar"
        Me.btnCikar.Size = New System.Drawing.Size(75, 23)
        Me.btnCikar.TabIndex = 14
        Me.btnCikar.Text = "çıkar"
        Me.btnCikar.UseVisualStyleBackColor = True
        '
        'btnEkle
        '
        Me.btnEkle.Location = New System.Drawing.Point(364, 103)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(75, 23)
        Me.btnEkle.TabIndex = 13
        Me.btnEkle.Text = "ekle"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'lbStok
        '
        Me.lbStok.FormattingEnabled = True
        Me.lbStok.Location = New System.Drawing.Point(555, 83)
        Me.lbStok.Name = "lbStok"
        Me.lbStok.Size = New System.Drawing.Size(151, 186)
        Me.lbStok.TabIndex = 12
        '
        'lbTedarikci
        '
        Me.lbTedarikci.FormattingEnabled = True
        Me.lbTedarikci.Location = New System.Drawing.Point(98, 83)
        Me.lbTedarikci.Name = "lbTedarikci"
        Me.lbTedarikci.Size = New System.Drawing.Size(151, 186)
        Me.lbTedarikci.TabIndex = 11
        '
        'lbIade
        '
        Me.lbIade.FormattingEnabled = True
        Me.lbIade.Location = New System.Drawing.Point(889, 83)
        Me.lbIade.Name = "lbIade"
        Me.lbIade.Size = New System.Drawing.Size(150, 186)
        Me.lbIade.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(889, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "iade"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbIade)
        Me.Controls.Add(Me.lblUrunFiyat)
        Me.Controls.Add(Me.lblToplam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnHesapla)
        Me.Controls.Add(Me.btnCikar)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.lbStok)
        Me.Controls.Add(Me.lbTedarikci)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUrunFiyat As Label
    Friend WithEvents lblToplam As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents btnHesapla As Button
    Friend WithEvents btnCikar As Button
    Friend WithEvents btnEkle As Button
    Friend WithEvents lbStok As ListBox
    Friend WithEvents lbTedarikci As ListBox
    Friend WithEvents lbIade As ListBox
    Friend WithEvents Label5 As Label
End Class
