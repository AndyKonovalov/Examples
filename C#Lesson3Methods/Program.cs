// void Method1()
// {
//     Console.WriteLine("Author: 'AndyKonovalov'");
// }
// Method1(); // Метод, который ничего не принимает и не возвращает, только выводит в консоль что-то, например авторство


// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Good news everyone"); // Метод, который принимает в себя аргумент (string msg) и ничего не возвращает, выводит только ту информацию, которую в него указали при вызове


// void Method2(string msg, int count) // Чтобы прервать зацикливание, используем Ctrl + C
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method2(msg:"Good news everyone", count:4); // Если метод принимает несколько аргументов, их можно проименовать. Этот метод выводит строку msg в консоль count-раз.


// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year); // Метод, который не принимает аргументов, но возвращает что-то, в этом случает текущий год. 
                         // Чтобы вернулся тип данных int нужно методу присвоить тип данных int

// string Method4 (int count, string c)
// {
//     int i = 0;
//     string result = string.Empty; // мы не можем переменной типа string присвоить значение "0", потому что это тип int, однако можно присвоить значение пустой строки string.Empty
//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4 (count: 10, c:"wow!"); // Метод, который принимает аргументы и возвращает результ действий, описанных в своем теле
// Console.WriteLine(res);


// string Method4 (int count, string c)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++) // цикл for это цикл while только записан компактнее
//     {
//         result = result + c;
//     }
//     return result;
// }
// string res = Method4(count: 10, c: "wow!");
// Console.WriteLine(res);


// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}"); // для i = 2, цикл j повторится 10 раз, потом сработает счетчик для i и i станет равным 3. И так, до тех пор пока i не станет равно 10
//     }
//     Console.WriteLine();
// }