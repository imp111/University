typedef struct Dates { //structure and type definition
   char date[20];
   char time[20];
} Date;

char date() //function
{
   int i;

   Date date;
 
   strcpy( date.date, __DATE__);	// saves current time to char date with type date
   strcpy( date.time, __TIME__);    // saves current date to char time with type date
 
   for (i = 0 ; i < 20; i++)
   {
	   printf("#");
   }
	
   printf("\n");
   printf( "Month: %s \n", date.date); //displays current date
   printf( "Time: %s \n", date.time);  //displays current time

   for (i = 0 ; i < 20; i++)
   {
	   printf("#");
   }

   return 0;
}