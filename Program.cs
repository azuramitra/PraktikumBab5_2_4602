Console.Write("Masukkan tarif per Jam: ");
int tarifPerJam = int.Parse(Console.ReadLine());

Console.Write("Masukkan lama Penggunaan: ");
int lamaPenggunaan = int.Parse(Console.ReadLine());

int totalBiaya = tarifPerJam * lamaPenggunaan;

Console.WriteLine($"Lama penggunaan = {lamaPenggunaan} jam");
Console.WriteLine($"Tarif per jam = {tarifPerJam}");
Console.WriteLine($"Total biaya = {totalBiaya}");