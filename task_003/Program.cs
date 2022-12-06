// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру, обозначающую день недели (1-7): ");
int inputDay = int.Parse(Console.ReadLine());
string weekDay = "не выходной день";
string weekEnd = "выходной день!";
string dash = " – ";

string[] days = {"не является днем недели",
                        "понедельник",
                        "вторник", 
                        "среда", 
                        "четверг", 
                        "пятница", 
                        "суббота", 
                        "воскресенье"};

string OutputDay(int day) {

    switch(day) {

        case 1:
            return days[day] + dash + weekDay;
            break;
        case 2:
            return days[day] + dash + weekDay;
            break;
        case 3:
            return days[day] + dash + weekDay;
            break;
        case 4:
            return days[day] + dash + weekDay;
            break;
        case 5:
            return days[day] + dash + weekDay;
            break;
        case 6:
            return days[day] + dash + weekEnd; // weekend
            break;
        case 7:
            return days[day] + dash + weekEnd; // weekend
            break;
        default:
            return day + dash + days[0]; // exception
            break;
        
    }
    
}

string result = OutputDay(inputDay);
Console.WriteLine(result);
