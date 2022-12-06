// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите целое число: ");
int inputNumber = int.Parse(Console.ReadLine());

void GetTheThirdNumber(int someNumber) {

    someNumber = Math.Abs(someNumber); // in case the number is negative

    if (someNumber < 100) {

            Console.Write("Третьей цифры нет!"); 

    } 
    
    else {

        while (someNumber > 1000) {
            someNumber = someNumber / 10;
        }

        someNumber = someNumber % 10;
        Console.Write(someNumber); 

    }

}

GetTheThirdNumber(inputNumber);
