// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using Microsoft.Win32.SafeHandles;

Console.WriteLine("Hello, World!");

Registry reg = new();
Member member = new("Hampus", "Hampus@hej");
Member member2 = new("Hampus2", "Hampus@hej");
Member member3 = new("Hampus3", "Hampus@hejhej");

reg.Register(member);
reg.Register(member2);
reg.Register(member3);

reg.PrintAllMembers();
