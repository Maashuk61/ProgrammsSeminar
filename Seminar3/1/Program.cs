// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input quadrant number: ");
int number = Convert.ToInt32 (Console.ReadLine());
if (number == 1)
{
    Console.WriteLine ("X>0; y>0");
} 
if (number == 2)
{
    Console.WriteLine ("x>0; y<0");
}
if (number == 3)
{
    Console.WriteLine ("x<0; y<0");
}
if (number == 4)
{
    Console.WriteLine ("x<0; y>0");
}
if (number < 1 || number > 4)
{
    Console.WriteLine ("input interger from 1 to 4");
    return;
}