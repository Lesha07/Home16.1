class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введіть шлях до вихідного файлу: ");
            
            string sourcePath = Console.ReadLine();

            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Помилка: Вихідний файл не знайдено.");
                return;
            }
            
            Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: ");
            string destinationPath = Console.ReadLine();
         
            File.Copy(sourcePath, destinationPath, overwrite: true);

            Console.WriteLine("Файл успішно скопійовано!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка: {ex.Message}");
        }
    }
}
