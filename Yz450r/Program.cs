class Program
{
    static void Main(string[] args)
    {
        // 1. Simulasi Pesanan Paket Hemat
        PaketPrasmanan pesananrini = new PaketPrasmanan("yono", "M05", "Ayam bakar", 30000, 10000);
        RiwayatPesanan riwayat = new RiwayatPesanan();
        riwayat.TambahPesanan("Prasmanan", 4, "13-10-2025", pesananrini);
        riwayat.CetakRiwayat();

        // Menahan console agar tidak langsung menutup
        Console.ReadLine();
    }
}
