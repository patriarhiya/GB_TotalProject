using System;
using static System.Console;
using static System.Array;

string [] array = {"привет", "22", "опа", "хорошо", "-2"};
int count = 0;
string [] newArray = array;

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length < 4){
        newArray[count] = array[i];
        count++;
    }
}

Resize(ref newArray, count);
foreach (var item in newArray) Write($"{item} ");