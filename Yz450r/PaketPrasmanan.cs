using System;
public class PaketPrasmanan : PesananMakanan
{
    private double hargaPerPorsi;
    private double biayaService;

    public PaketPrasmanan(string namaPemesan, string nomorMeja, string menuUtama, double hargaPerPorsi, double biayaService)
        : base(namaPemesan, nomorMeja, menuUtama)
    {
        this.hargaPerPorsi = hargaPerPorsi;
        this.biayaService = biayaService;
    }

   
    public override double HitungTotalBill(int jumlahPorsi)
    {
        return (jumlahPorsi * hargaPerPorsi) + biayaService;
    }
}