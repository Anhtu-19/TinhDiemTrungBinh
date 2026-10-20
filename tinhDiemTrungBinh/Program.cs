Console.WriteLine("Lap 1");
Console.Write("Nhap ho ten: ");
string hoTen = Console.ReadLine();

Console.Write("Nhap diem mon C#: ");
double diemC = double.Parse(Console.ReadLine());

Console.Write("Nhap diem mon TKWEB: ");
double diemWeb = double.Parse(Console.ReadLine());

Console.Write("Nhập điểm môn CSDL: ");
double diemCSDL = double.Parse(Console.ReadLine());

double diemTB = (diemC + diemWeb + diemCSDL) / 3;
Console.WriteLine("Điểm Trung Bình: " + diemTB);

if (diemTB > 5)
{
    Console.WriteLine("Kết Quả Đạt");
}
else
{
    Console.WriteLine("Kết Quả Chưa Đạt");
}