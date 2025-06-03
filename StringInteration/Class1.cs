using System;
using System.Text;

string ho = "Nguyen";
string tendem = "Tien";
string ten = "Anh";
StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(' ');
sb.Append(tendem);
sb.Append(' ');
sb.Append(ten);
string name2 = sb.ToString();
Console.WriteLine(name2);
Console.ReadLine();