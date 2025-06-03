// See https://aka.ms/new-console-template for more information
using OOP;
using System.Text;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước mắm";
Console.OutputEncoding = Encoding.UTF8;
c1.PrintInfo();

Employee emp1 = new Employee();
/*
            emp1 _id = 1;
            emp1 _name = "Nguyễn Văn A";*/
//để thay đổi giá trị của thuộc tính:

emp1.Id = 1; //tự gọi set cho property ID;
emp1.Name = "Nguyễn Văn A"; //tự gọi set cho property Name;
emp1.Email = "A@gmail.com";
emp1.Phone = "0123456789";
//để lấy giá trị thuộc tính
//tự gọi get cho property Id
Console.WriteLine($"Employee ID ={emp1.Id}");
//tự gọi get cho property Name
Console.WriteLine($"Employee Name ={emp1.Name}");
emp1.PrintInfo();
//Ngoài ra mọi lớp đối tượng có hàm toString giống java
//để từ động triệu gọi hàm này khi đối tượng được xuất ra màn hình
Console.WriteLine("----------------------------");
Console.WriteLine(emp1);

//vừa tạo đối tượng vừa tạo giá trị cho thuộc tính:
Employee emp2 = new Employee(2,"Tý Đại Bàng","ty@yahoo.com","091231234");
//xuất thong tin của emp2
Console.WriteLine(emp2);

Employee emp3 = new Employee()
{
    Id = 1,
    Name = "Tún",
    Email = "Tun@gmail.com",
    Phone = "0123456789"
};
//xuất thông tin emp3;
Console.WriteLine(emp3);