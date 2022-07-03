double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2; // Собака бежит ко второму другу
int meetDistance = 10;
int count = 0; // Количество раз, которое собака пробежит от одного друга к другому
double time = 0;

double DistFriend1()
{
    time = distance / (firstFriendSpeed + dogSpeed); // Время, за которое собака добежит до первого друга
    friend = 2;
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    return distance; 
}

double DistFriend2()
{
    time = distance / (secondFriendSpeed + dogSpeed); // Время, за которое собака добежит до второго друга
    friend = 1;
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    return distance;
}

while (distance > meetDistance)
{
    if (friend == 1)
{
    // time = distance / (firstFriendSpeed + dogSpeed); // Время, за которое собака добежит до первого друга
    // friend = 2;
    // distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    Console.WriteLine ($"Текущее расстояние между друзьями {Math.Round(DistFriend1(), 2)}");
}
   
    else 
    
    {
    
    // time = distance / (secondFriendSpeed + dogSpeed); // Время, за которое собака добежит до второго друга
    // friend = 1;
    // distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    Console.WriteLine ($"Текущее расстояние между друзьями {Math.Round(DistFriend2(), 2)}");
    }

    count++;
}
Console.Write ($"Собака пробежит между друзьями {count} раз(а)");