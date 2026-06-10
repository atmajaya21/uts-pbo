using System;
public class RiwayatPesanan
{
    private string kategoriPaket;
    private int jumlahPorsi;
    private string tanggalPesan;
    private PesananMakanan dataPesanan; 

    
    public void TambahPesanan(string kategoriPaket, int jumlahPorsi, string tanggalPesan, PesananMakanan dataPesanan)
    {
        this.kategoriPaket = kategoriPaket;
        this.tanggalPesan = tanggalPesan;
        this.dataPesanan = dataPesanan;
        this.jumlahPorsi = jumlahPorsi;
    }

    
    public void CetakRiwayat()
    {
        dataPesanan.TampilInfo();
        Console.WriteLine($"Total Bill: Rp {dataPesanan.HitungTotalBill(jumlahPorsi)}");
        Console.WriteLine($"1.{kategoriPaket} |  {jumlahPorsi} porsi | {tanggalPesan}");
        Console.WriteLine();        
    }
}