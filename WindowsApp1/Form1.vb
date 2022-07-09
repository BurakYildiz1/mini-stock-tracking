Public Class Form1
    Private Sub Form1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Structure Urun
        Public Ismi As String
        Public Fiyat As Double
        Public Sub New(ByVal UrunIsim As String, ByVal UrunFiyat As Double)
            Ismi = UrunIsim
            Fiyat = UrunFiyat
        End Sub
        Public Overrides Function ToString() As String
            Return String.Format("{0} - {1:C}", Ismi, Fiyat)
        End Function
    End Structure
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbTedarikci.SelectionMode = SelectionMode.MultiExtended
        lbStok.SelectionMode = SelectionMode.MultiExtended
        lbIade.SelectionMode = SelectionMode.MultiExtended
        UrunEkle()
    End Sub

    Sub UrunEkle()
        Dim u As Urun
        u = New Urun("Kalem", 1.49)
        lbTedarikci.Items.Add(u)
        u = New Urun("Silgi", 0.39)
        lbTedarikci.Items.Add(u)
        u = New Urun("Defter", 4.99)
        lbTedarikci.Items.Add(u)
        u = New Urun("Cetvel", 1.99)
        lbTedarikci.Items.Add(u)
        u = New Urun("Pergel", 2.99)
        lbTedarikci.Items.Add(u)
        u = New Urun("Not Defteri", 3.79)
        lbTedarikci.Items.Add(u)
    End Sub

    Private Sub btnEkle_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnEkle.Click
        ' Tedarikçiden alınan ürünler stok listesine eklenir
        For Each item As Object In lbTedarikci.SelectedItems
            lbStok.Items.Add(item)
        Next
        ' Stok listesine eklenen tüm ürünler
        ' tedarikçi listesinden çıkartılır
        For Each item As Object In lbStok.Items

        Next
        btnCikar.Enabled = True
        btnHesapla.Enabled = True
    End Sub

    Private Sub btnCikar_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnCikar.Click
        ' Tedarikçiden alınan ürünler stok listesine eklenir
        For Each item As Object In lbStok.SelectedItems
            lbIade.Items.Add(item)
        Next
        ' Stok listesine eklenen tüm ürünler
        ' tedarikçi listesinden çıkartılır
        For Each item As Object In lbTedarikci.Items
            lbStok.Items.Remove(item)
        Next
        If lbStok.Items.Count = 0 Then
            btnCikar.Enabled = False
            btnHesapla.Enabled = False
        End If
    End Sub

    Private Sub btnHesapla_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnHesapla.Click
        Dim toplam As Double
        For i As Integer = 0 To lbStok.Items.Count - 1
            Dim urun As Urun = lbStok.Items(i)
            toplam += urun.Fiyat
        Next
        lblToplam.Text = toplam
    End Sub

    Private Sub lbStok_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbStok.SelectedIndexChanged

        Dim secilen As Urun
        secilen = lbStok.SelectedItem
        lblUrunFiyat.Text = String.Format("{0:C}",
secilen.Fiyat)
    End Sub


End Class
