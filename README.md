# Solutions to various HashTable questions in C-Sharp

In this repository I will try to solve various Hashtable questions using C#

In most of my solutions I would be using Dictionary class in .NET framework, it is important to note the usage of Dictionary vs Hashtable.

1. Dictionary is a special type of hastable where in it supports generics and it is type safe as well.
2. Dictionary uses chaining as collision resolution strategy where as hashtable uses re-hashing.


#1 First Question: (GroupShifter.cs)
-------------------------------------------------------------------------------------------------------------------
  Given an array of strings, the task is to group them in such a way that all strings in a group are shifted versions of each other.

  Two string S and T are called shifted if,
  S.length = T.length 
  and
  S[i] = T[i] + K for all 1 <= i <= S.length  for a constant integer K

    Input  : str[] = {"acd", "dfg", "wyz", "yab", "mop",
                     "bdfh", "a", "x", "moqs"};

    Output : {a x}, 
             {acd dfg wyz yab mop},
             {bdfh moqs}

#2 Second Question: (SubArrayWithZeroSum.cs)
---------------------------------------------------------------------------------------------------------------------

Given an input array of number, find the list of all sub arrays whose sum in zero. 
SubArray meaning it should consider only contigious elements

Input:  [6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7]

Output:  
[2, 4],

[2, 6],

[5, 6],

[6, 9],

[0, 10]

#3 Third Question: (SubArrayWithSum.cs)
------------------------------------------------------------------------------------------------------------------------

Given an input array of numbers and a sum, find the first occurence of sub array within the input array whose sume matches the given input sum.

Input:  {1, 4, 20, 3, 10, 5}, sum = 33

Ouptut: [2, 4]

