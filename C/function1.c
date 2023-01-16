int printRandoms(int lower, int upper, int count)	// random number calculation
{ 
    int i; 
    for (i = 0; i < count; i++) { // count = 1 for goes 1 time
        int num = (rand() % (upper - lower + 1)) + lower; // random number generator
		return num;
    } 
}