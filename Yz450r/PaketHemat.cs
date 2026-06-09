using System;
public class PaketHemat : PesananMakanan
{
    private double hargaPerPorsi;
    public PaketHemat(string namaPemesan, string nomorMeja, string menuUtama, double hargaPerPorsi)
        : base(namaPemesan, nomorMeja, menuUtama)
    {
        this.hargaPerPorsi = hargaPerPorsi;
    }

    // polymorphism override rumus hitung total bill
    public override double HitungTotalBill(int jumlahPorsi)
    {
        return jumlahPorsi * hargaPerPorsi;
    }
}
