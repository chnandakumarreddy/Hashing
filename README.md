# Solutions to various HashTable questions in C-Sharp

In this repository I will try to solve various Hashtable questions using C#

In most of my solutions I would be using Dictionary class in .NET framework, it is important to note the usage of Dictionary vs Hashtable.

1. Dictionary is a special type of hastable where in it supports generics and it is type safe as well.
2. Dictionary uses chaining as collision resolution strategy where as hashtable uses re-hashing.


First Question:
Given an array of strings (all lowercase letters), the task is to group them in such a way that all strings in a group are shifted versions of each other.

Two string S and T are called shifted if,
S.length = T.length 
and
S[i] = T[i] + K for all 1 <= i <= S.length  for a constant integer K

Input  : str[] = {"acd", "dfg", "wyz", "yab", "mop",
                 "bdfh", "a", "x", "moqs"};

Output : a x
         acd dfg wyz yab mop
         bdfh moqs

