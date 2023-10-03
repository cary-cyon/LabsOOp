// See https://aka.ms/new-console-template for more information
using Lab1;

EuroDateTime euroDataTime = new EuroDateTime();
euroDataTime.PrintDateTime();
UsDateTime usDateTime = new UsDateTime();
usDateTime.PrintDateTime();

IDateTime dateTime = new DateTimeDecorator(euroDataTime, 'A', 4, 'b', 5);
IDateTime dateDataTime = new DateTimeDecorator(dateTime, 'b', 4, 'A', 5);
dateTime.PrintDateTime();
dateDataTime.PrintDateTime();