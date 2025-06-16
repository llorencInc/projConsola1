// File: FunctionsLibrary.cs
public class FunctionsLibrary
{
    public static void PrintRectangle(int width, int height)
    {
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine(new string('*', width));
        }
    }
}