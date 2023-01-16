#include "mainheader.h"	// include headerfile


int main() // main function
{
	FILE *fp;
	 
	int lower, upper, count, a, i, b, magicNumber, hint;  //local variables
	

	lower = 1;			// random number parameters
	upper = 10;
	count = 1;
	srand(time(0)); 
	
	date();

	for (b = 0 ; b <= 2; b++)
	{
		printf("\n");
	}

    magicNumber = printRandoms(lower, upper, count); //magicnumber value
	hint = pow(magicNumber, 2);	// hint's value

		printf("Guess the magic number v1.0.0\t");
		printf("Description: Guess the number in %d tries\n", numoftries);
		printf("\n");

Loop:	for (i = 1; i <= 5; i++)
		{
			printf("Number of tries left: %d\n" , tries--);
			printf("Enter your number:");

			while(scanf("%d",&a) != 1)	
			    {
			        printf("Please enter an integer: ");
			        while(getchar() != '\n'); // checks if entered value is integer
			    }

			fp = fopen("file.txt", "a");	//opens file.txt
			fprintf(fp, "The entered number is : %d\n", a);
			fclose(fp);	//closes file.txt
			
			
			if (a == magicNumber)	//magicnumber found
			{
				printf("Congrats you found the number!\n");
				goto Loop3;
			}

		}
		

			printf("No tries left, would you like to continue? (y / n): \n"); // choice

Loop2:	f1(); //picking a choice
		
		if (choice == 'y')
		{
			tries = 5;
			printf("Hint: ! The squared value of the magic number is %d !\n", hint);
		    goto Loop;
		}

		else if (choice == 'n')
		{
		   goto Loop3;
		}
		else 
		{
		   goto Loop2;
		}

Loop3:	printf("%s" , p); //exit

		return 0; 
		
}


char f1() //entering a choice
{
		scanf("%c" , &choice);
		return 0;
}