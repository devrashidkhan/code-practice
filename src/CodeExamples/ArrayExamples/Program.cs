
//Single Dimensional Array

int[] age = new int[31];
age[0] = 13;
age[1] = 21;
age[2] = 22;
age[3] = 23;

string[] name = new string[10];
name[0] = "Rashid";
name[1] = "Bogura";
name[2] = "C#";

//Multidimensional Array

int[,] block = new int[10, 10];
block[0, 0] = 10;
block[1, 0] = 20;
block[2, 0] = 30;

block[0, 1] = 31;
block[1, 2] = 32;
block[2, 3] = 33;

string[] citis = new string[] { "Bogura", "Dhaka", "Khulna" };

int[,,,] somethings = new int[2, 4, 6, 8];
somethings[0, 0, 0, 0] = 1;
somethings[0, 0, 0, 1] = 2;


//Jagged Array

int[][] grades = new int[10][];
grades[0] = new int[10];
grades[1] = new int[12];
grades[2] = new int[17];

grades[0][0] = 40;
grades[0][1] = 50;

