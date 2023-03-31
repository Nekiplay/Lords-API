# Lords Mobile API (Unofficial)
Lords Mobile Steam API Unofficial

# Allowed by IGG
![image](https://user-images.githubusercontent.com/35975332/228787364-b06466ee-34cf-4b5d-999b-b36e2020633d.png)

# Example
```csharp
Process game = Process.GetProcessesByName("Lords Mobile").First();
LordsAPI lordsAPI = new LordsAPI(game);
Console.WriteLine("==== Watchtower info ====");
Console.WriteLine("Attacked: " + lordsAPI.user.isAttacked);
Console.WriteLine("==== Colisium info ====");
Console.WriteLine("Power: " + lordsAPI.colisium.Power);
Console.WriteLine("==== User Info ====");
Console.WriteLine("Power: " + lordsAPI.user.Power);
Console.WriteLine("Stamina: " + lordsAPI.user.Stamina);
Console.WriteLine("Gems: " + lordsAPI.user.Gems);
Console.WriteLine("==== Barrack info ====");
Console.WriteLine("Army: " + lordsAPI.barrack.Army);
Console.WriteLine("==== Guild Info ====");
Console.WriteLine("Help's: " + lordsAPI.guild.Help);
Console.WriteLine("Gifts: " + lordsAPI.guild.Gifts);
Console.WriteLine("Money: " + lordsAPI.guild.Money);
```
