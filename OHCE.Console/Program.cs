﻿using OHCE.Domaine;
using OHCE.Domaine.Langue;

var langue = new LangueFrançaise();
var palindrome = new Palindrome(langue, MomentDeLaJournée.Soir);

Console.WriteLine(palindrome.Interpréter(Console.ReadLine() ?? string.Empty));