﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 12, 23, 34, 45, 56, 67, 78, 89, 90 };

int max = Max(Max(array[0], array[1], array[2]),
                Max(array[3], array[4], array[5]),
                Max(array[6], array[7], array[8]));

/*int a1 = 12;
int b1 = 43;
int c1 = 67;
int a2 = 21;
int b2 = 32;
int c2 = 78;
int a3 = 45;
int b3 = 91;
int c3 = 17;*/



/*int max1 = Max(a1,b1, c1);
int max2 = Max(a2,b2, c2);
int max3 = Max(a3,b3, c3);
int max = Max(max1, max2, max3);*/




/*if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;*/

Console.WriteLine(max);