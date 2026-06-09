using System;
using System.Collections.Generic;
using System.Text;

public abstract class PesananMakanan
{
    private string namaPemesan;
    private string nomorMeja;
    private string menuUtama;
    
    public string NamaPemesan
    {
        get { return namaPemesan; }
        set { namaPemesan = value; }
    }

    public string NomorMeja
    {
        get { return nomorMeja; }
        set { nomorMeja = value; }

    }

    public string MenuUtama
    {
        get { return menuUtama; }
        set { menuUtama = value; }
    }
 
    public PesananMakanan(string namaPemesan, string nomorMeja, string menuUtama)
    {
        this.NamaPemesan = namaPemesan;
        this.NomorMeja = nomorMeja;
        this.MenuUtama = menuUtama;
    }
    public void TampilInfo()
    {
        Console.WriteLine($"Pemesan :{NamaPemesan} | Meja: {NomorMeja} | Menu: {MenuUtama}");
    }

    public abstract double HitungTotalBill(int jumlahPorsi);

}
