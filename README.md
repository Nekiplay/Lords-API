# Lords Mobile API (Unofficial)
Lords Mobile Steam API Unofficial

# Allowed by IGG
![image](https://user-images.githubusercontent.com/35975332/228787364-b06466ee-34cf-4b5d-999b-b36e2020633d.png)

# Example
```csharp
Process game = Process.GetProcessesByName("Lords Mobile").First();
LordsAPI lordsAPI = new LordsAPI(game);
Console.WriteLine("==== User Info ====");
Console.WriteLine("Power: " + lordsAPI.user.Power);
Console.WriteLine("Stamina: " + lordsAPI.user.Stamina);
Console.WriteLine("Gems: " + lordsAPI.user.Gems);
Console.WriteLine("==== Clan Info ====");
Console.WriteLine("Gifts: " + lordsAPI.clan.Gifts);
```
