string? name;
while (true)
{
    Console.Write("Как вас зовут? ");
    name = Console.ReadLine();

    if (name is null)
    {
        Console.WriteLine("Ввод завершён.");
        return;
    }

    name = name.Trim();
    if (!string.IsNullOrWhiteSpace(name))
    {
        break;
    }

    Console.WriteLine("Имя не должно быть пустым. Попробуйте ещё раз.");
}

Console.WriteLine($"Привет, {name}! Это мой новый проект.");
Console.WriteLine("Я изучаю VS Code, AI и GitHub.");
Console.WriteLine("Моя первая программа успешно работает!");
// Изменение в ветке feature-update
