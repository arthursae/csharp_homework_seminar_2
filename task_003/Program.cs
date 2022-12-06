// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру, обозначающую день недели (1-7): ");
int inputDay = int.Parse(Console.ReadLine());

string OutputDay(int day) {

    string weekDay = "не выходной день"; // predefined message for weekdays
    string weekEnd = "выходной день!"; // predefined message for weekends
    string dash = " – "; //  delimiting character

    string[] days = {"не является днем недели",
                        "понедельник",
                        "вторник", 
                        "среда", 
                        "четверг", 
                        "пятница", 
                        "суббота", 
                        "воскресенье"};

    switch(day) {

        case > 0 and <= 5:
            return days[day] + dash + weekDay; // weekdays
            break;

        case > 5 and <= 7:
            return days[day] + dash + weekEnd; // weekends
            break;

        default:
            return day + dash + days[0]; // exception
            break;
        
    }
    
}

string result = OutputDay(inputDay);
Console.WriteLine(result);
