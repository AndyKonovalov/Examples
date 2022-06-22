double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2; // Собака бежит ко второму другу
int meetDistance = 10;
int count = 0; // Количество раз, которое собака пробежит от одного друга к другому
double time = 0;

while (distance > meetDistance)
{
    if (friend == 1)
{
    Console.Write ("friend = ");
    Console.WriteLine (friend); 
    time = distance / (firstFriendSpeed + dogSpeed); // Время, за которое собака добежит до первого друга
    friend = 2;
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
}
   
    if (friend == 2)
    {
    Console.Write ("friend = ");
    Console.WriteLine (friend);
    time = distance / (secondFriendSpeed + dogSpeed); // Время, за которое собака добежит до второго друга
    friend = 1;
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    }

    count++;
}
Console.Write ("count = ");
Console.WriteLine (count);