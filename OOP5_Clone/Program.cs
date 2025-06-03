using OOP5_Clone;

Customer c1=new Customer();
c1.Id = 1;
c1.Name = "Obama";

Customer c2 = c1;
//Lúc này c1 và c2 cùng trỏ tới 1 ô nhớ
//1 ô nhớ có từ 2 đối tượng trở lên trỏ vào ==>alias
//c1 đổi làm c2 đổi và ngược lại

Customer c3 = c1.copy();
//lúc này sao chép toàn bộ dữ liệu tại ô nhớ c1 đang quản lý
//sang 1 ô nhớ mới hoàn toàn và giao cho c3 quản lý
//lúc này c3 đổi ko liên quan c1 và ngược lại

Product p1 = new Product() { Id = 1, Name = "Coca", Quantity = "10", Price = 100};
Product p2 = new Product() { Id = 2, Name = "Pepsi", Quantity = "20", Price = 80};

p1 = p2;
p2.Name = "Sting";
p2.Price = 123;

//thì p1 cũng bị đổi dữ liệu, vì p1 và p2 cùng quản lý 1 ô nhớ
//mà p2 đổi thì hiển nhiên p1 cũng bị đổi theo
Console.WriteLine("Thông tin của p1: ");
Console.WriteLine(p1);

Product p3 = new Product() { Id = 3, Name = "Number One", Quantity = "30", Price = 50 };
Product p4 = new Product() { Id = 4, Name = "Red Bull", Quantity = "40", Price = 60 };
Product p5 = new Product() { Id = 5, Name = "Vfresh", Quantity = "50", Price = 70 };

p5 = p3;
p3 = p4;

//Hỏi: ô nhớ cấp phát cho p3 có bị tự động thu hồi không vì sao?

Product p6 = new Product() { Id = 6, Name = "Number One", Quantity = "30", Price = 50 };
Product p7 = p6.clone();
//lúc này HDH sẽ cấp phát 1 ô nhớ mới cho p7 quản lý
// và ô nhớ này có giá trị y chang giá trị của ô nhớ mà p6 đang quản lý
//Tức là p6 và p7 quản lý 2 ô nhớ khác nhau hoàn toàn
//p6 đổi ko liên can gì p7 và ngược lại
//===> ko phải ALIAS
Console.WriteLine("Thông tin của p6: ");
Console.WriteLine(p6);
Console.WriteLine("Thông tin của p7: ");
Console.WriteLine(p7);
p7.Name = "Thuốc trị hôi nách";
Console.WriteLine("Thông tin của p6 lần 2: ");
Console.WriteLine(p6);