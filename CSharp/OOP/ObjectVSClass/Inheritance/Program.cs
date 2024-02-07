// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");


Knife knife = new Knife();
Baretta baretta = new Baretta();
SG1 sniper = new SG1();

Player player = new Player();
player.Weapon = sniper;
player.Weapon.Attack();
player.Weapon.ChangePosition();
player.Weapon = knife;
player.Weapon.Attack();
player.Weapon.ChangePosition();

player.Weapon = baretta;
player.Weapon.Attack();
player.Weapon.ChangePosition();

baretta.ChangePosition();