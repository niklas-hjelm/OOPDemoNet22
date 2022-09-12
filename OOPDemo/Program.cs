using OOPDemo;

Player niklas = new Player();

niklas.Alive = true;
niklas.Name = "Niklas";
niklas.Level = 1;

Console.WriteLine($"{niklas.Name} is level: {niklas.Level} and the player is alive: {niklas.Alive}");