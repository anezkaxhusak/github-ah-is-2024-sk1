﻿using System.ComponentModel.DataAnnotations;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using Microsoft.VisualBasic;


class Program

    // Shaker Sort Implementation
    {
    static void ShakerSort(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        int temp;

        while (left <= right)
        {
            // Move largest element to the right end
            for (int i = left; i < right; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }

            // Decrease the right boundary since the largest element is in place
            right--;

            // Move smallest element to the left end
            for (int i = right; i > left; i--)
            {
                if (arr[i] < arr[i - 1])
                {
                    temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                }
            }

            // Increase the left boundary since the smallest element is in place
            left++;
        }
    }

    static void Main()
    {

string again = "a";
        
        while(again == "a") {
         //   Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*************  *****************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }
        {
            
    
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("==========================================");
            Console.WriteLine();

            //deklarace pole    
            int[] myArray = new int[n];

            Random randomNumber = new Random();
         
        {
            Console.WriteLine("\n\nNáhodná čísla:");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]); 
            }

             int max = myArray[0];
             int min = myArray[0];
             int poziceMax = 0;
             int poziceMin = 0;
            for(int i = 1; i < n; i++ ) {
                if(myArray[i] > max) {
                    max = myArray[i];
                    poziceMax = i;
                }

                if(myArray[i] < min){
                    min = myArray[i];
                    poziceMin = i;
        
                }


            }
            
            

            Console.WriteLine("\n\nMaximum = {0}. Jeho pozice v poli = {1}", max, poziceMax );
            Console.WriteLine("Minimum = {0}. Jeho pozice v poli = {1}",min, poziceMin);



              ShakerSort(myArray);

            // Output the sorted array
            Console.WriteLine("\nSeřazená čísla:");
            foreach (var num in myArray)
            {
                Console.Write(num + "; ");
            }
            Console.WriteLine("\n\nLength: {0}", hm);

        // Output the results

            }


            Console.WriteLine();   
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            Console.ReadLine();
        }
                }
            }
        }



