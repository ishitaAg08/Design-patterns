using SingletonDemo;
Console.WriteLine("Let's learn singleton design patter - Thread unsafe");

Singleton fromE1 = Singleton.GetInstance;
fromE1.Print("Hello from E1");

Singleton fromE2 = Singleton.GetInstance;
fromE2.Print("Hello from E2");
