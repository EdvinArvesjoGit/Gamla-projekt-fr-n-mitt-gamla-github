Enemy e = new Enemy() {name = "a"};
Enemy e2 = new Enemy() {name = "a2"};
Hero h = new Hero() {name = "12123"};

// e.name = "a";
// e2.name = "a2";
// h.name = "12123";
e.Attack();


h.hp -= e.Attack();
Console.WriteLine(h.hp);

Console.ReadLine();


