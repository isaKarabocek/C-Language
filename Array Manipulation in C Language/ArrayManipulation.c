#include<stdio.h>
#include<math.h>
#include<time.h>
#include<stdlib.h>


void print(int a[]);
void bubble(int a[]);
void random(int a[]);
void multip(int a[], int b[]);

int main()
{

	int data[5] = { 3, 8, 1, 25, 16 };

	print(data);

	return 0;
}
void print(int a[])
{
	printf("The original version of the array\n\n");
	printf("Element       Data\n");
	int i;
	for (i = 0; i < 5; i++)
	{
		printf("     %d         %d \n", i, a[i]);
	}

	bubble(a);
	random(a);

}
void bubble(int a[])
{
	int i, j;
	//repeating loop 5 (number of elements in the array) times
	for (j = 0; j<5; j++)
	{
		//initially swapped is false
		int swapped = 0;
		i = 0;
		while (i<5 - 1)
		{
			//comparing the adjacent elements
			if (a[i] > a[i + 1])
			{
				//swapping
				int temp = a[i];
				a[i] = a[i + 1];
				a[i + 1] = temp;
				//Changing the value of swapped
				swapped = 1;
			}
			i++;
		}
		//if swapped is false then the array is sorted
		//we can stop the loop
		if (!swapped)
			break;
	}
	printf("\n\nPutting numbers in order\n\n");
	printf("Element       Data\n");
	for (i = 0; i < 5; i++)
	{
		printf("     %d         %d\n", i, a[i]);
	}

}
void random(int a[])
{
	int i;
	int rnd[5];

	srand(time(NULL));

	for (i = 0; i < 5; i++)
	{
		rnd[i] = (rand() % 99);
	}

	printf("\n\nRandom Numbers\n\n");
	printf("Element       Data\n");
	for (i = 0; i < 5; i++)
	{
		printf("     %d         %d \n", i, rnd[i]);
	}
	multip(a, rnd);

}
void multip(int a[], int b[])
{
	int m[5];
	int i;
	for (i = 0; i < 5; i++)
	{
		m[i] = a[i] * b[i];
	}
	printf("\n\nElements multiplied by random numbers\n\n");
	printf("Element       Data\n");
	for (i = 0; i < 5; i++)
	{
		printf("     %d         %d \n", i, m[i]);
	}
}