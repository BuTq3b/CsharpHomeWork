﻿/*
Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины

Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

bool Triangle(int a, int b, int c)
{
    if (a + b > c && b + c > a && a + c > b)
    return true;
    else
    return false;
}

System.Console.WriteLine(Triangle(4,5,7));