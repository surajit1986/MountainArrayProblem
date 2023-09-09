// See https://aka.ms/new-console-template for more information

using MountainSequence;

Console.WriteLine("check mountain sequence for given array : {0,2,3,4,5,2,1}");
var arr = new int[] { 0, 2, 3, 4, 5, 2, 1 };
MountainSeq obj = new MountainSeq();
Console.WriteLine(obj.IfMountainSeq(arr));
Console.ReadKey();
