#define _CRT_SECURE_NO_DEPRECATE
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <time.h>
#include <string.h>
#include <conio.h>

#define numoftries 5	//constant

int tries = 5;	// global variable
char choice = ' ';	//global variables

char container[50] = {"Game Over \n"}; // array
char *p = container;	// pointer

char f1();	// function

extern int printRandoms(int lower, int upper, int count); //function2.c
extern char date();	//function2.c
