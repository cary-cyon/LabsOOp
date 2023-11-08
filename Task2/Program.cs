// See https://aka.ms/new-console-template for more information
using Task2;

int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
List<IArrayChange> commands = new List<IArrayChange>();
commands.Add(new Mean());
commands.Add(new Increment());
commands.Add(new Min());

foreach (IArrayChange change in commands)
    change.ChangeArray(arr);

foreach (int i in arr)
    Console.WriteLine(i);