public static string Indent(int count)
{
    return "".PadLeft(count);
}

Console.WriteLine(Indent(0) + "List");
Console.WriteLine(Indent(3) + "Item 1");
Console.WriteLine(Indent(6) + "Item 1.1");
Console.WriteLine(Indent(6) + "Item 1.2");
Console.WriteLine(Indent(3) + "Item 2");
Console.WriteLine(Indent(0) + "Item 2.1");v

// Output string:
//List
//   Item 1
//      Item 1.1
//      Item 1.2
//   Item 2
//Item 2.1