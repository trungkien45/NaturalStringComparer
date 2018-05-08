# NaturalStringComparer
String Compare Natural

by normal, strings

string 1
string 2
...
string 10
string 11
when sort by Array.Sort() =>
string 1
string 10
string 11
string 2
...

this class help sort by order 1

Use:

            var folders = Directory.GetDirectories(path);
            Array.Sort(folders, new NaturalStringComparer());
