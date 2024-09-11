
// Ask the user the length
Console.WriteLine("Length?");

// Program will gather the number from Length
String? Length = Console.ReadLine();
int LengthInt = Convert.ToInt32(Length);

// Ask the user the Wide
Console.WriteLine("Wide");

// Program will gather the number for Wide
String? Wide = Console.ReadLine();
int WideInt = Convert.ToInt32(Wide);

// The program will write out the total area, it will take Length time two and Wide time two
Console.WriteLine(LengthInt + LengthInt + WideInt + WideInt);
Console.WriteLine("The area are " + LengthInt * WideInt);

