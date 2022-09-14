using OOPDemo;

// instansiera ett objekt av typen Player
Player niklas = new Player();

niklas.Alive = true;
niklas.Name = "Niklas";
niklas.Level = 1;

//Console.WriteLine($"{niklas.Name} is level: {niklas.Level} and the player is alive: {niklas.Alive}");

//Console.WriteLine(niklas.ToString());

//niklas.PrintName("Niklas");

////instansiera en List innehållandes objekt av typen PLayer
//var players = new List<Player>();
////var tal = new List<int>();

////Lägger till en referens till objektet niklas som är av typen Player
//players.Add(niklas);

//for (int i = 100; i > 0; i--)
//{
//    var player = new Player();
//    player.Name = $"Person{i}";
//    player.Level = i;
//    player.Alive = true;
//    players.Add(player);
//    //tal.Add(i);
//}

////Använd Sort
////tal.Sort();

//// Använd reverse
//players.Reverse();

////foreach (var i in tal)
////{
////    Console.WriteLine(i);
////}

//// Count motsvarar Length på arrayer
//for (int i = 0; i < players.Count; i++)
//{
//    Console.WriteLine(players[i]);
//}

//instansiera en List innehållandes objekt av typen PLayer
var players = new Stack<Player>();
//var tal = new List<int>();

//Lägger till en referens till objektet niklas som är av typen Player
players.Push(niklas);

for (int i = 100; i > 0; i--)
{
    var player = new Player();
    player.Name = $"Person{i}";
    player.Level = i;
    player.Alive = true;
    players.Push(player);
    //tal.Add(i);
}

//Använd Sort
//tal.Sort();

//foreach (var i in tal)
//{
//    Console.WriteLine(i);
//}

// Count motsvarar Length på arrayer
//var length = players.Count;
//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine(players.Dequeue());
//}

while (players.Count > 0)
{
    Console.WriteLine(players.Pop());
}