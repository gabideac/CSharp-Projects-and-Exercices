using System;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug();
            /*  String se = Console.ReadLine(); 
              double  X = Convert.ToDouble(se);

             String sc = Console.ReadLine();
             double Y = Convert.ToDouble(sc);

             String st = Console.ReadLine();
             double T = Convert.ToDouble(st);

             String sc2 = Console.ReadLine();
             double Z = Convert.ToDouble(sc2);

             String st2 = Console.ReadLine();
             double Q = Convert.ToDouble(st2);

             double y2 = Y /  T;
             double t2 = T / T;
             double z2 = Z / Q;
             double q2 = Q / Q;

             double theMightyAnswerPupalTata = X * z2 / y2;


             Console.WriteLine(theMightyAnswerPupalTata); */

            /* String distantaString = Console.ReadLine();
              decimal z = Convert.ToDecimal(distantaString);

              String vitTren = Console.ReadLine();
              decimal x = Convert.ToDecimal(vitTren); */

            /*    double birdSpeed = 2 * x;
                double meetingPoint = z / 2;
                double firstRunTrain = meetingPoint / 3;
                double firstRun = meetingPoint - firstRunTrain;
                double secondRunTrain = firstRunTrain / 3;
                double secondRun = firstRunTrain - secondRunTrain;
                double trdRunTrain = secondRunTrain / 3;
                double trdRun = secondRunTrain - trdRunTrain;
                double distance = firstRun + secondRun + trdRun;
                int aproxDistance = Convert.ToInt32(distance);


                */
            /* decimal dist = ((decimal)1 / 4 * z) + ((decimal)1 / 4 * z);
             decimal time = (decimal)(dist / (x + x)) * 2 * x;
             Console.WriteLine((double)time);
          */

            /* int n = Convert.ToInt32(Console.ReadLine());
             int m = Convert.ToInt32(Console.ReadLine());
             int a = Convert.ToInt32(Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());


             decimal result = ((decimal)(n * m) / (a * b));
             int loss = (int)Math.Ceiling(result * 15 / 100);

             Console.WriteLine((int)(loss + result));
            */

            /*  double a = Convert.ToDouble(Console.ReadLine());
              double b = Convert.ToDouble(Console.ReadLine());

              if (a > b)
              {
                  Console.WriteLine(b);
              }
              else
              {
                  Console.WriteLine(a);
              }
              ;
  */



            /*int z = Convert.ToInt32(Console.ReadLine());
            double t = Convert.ToDouble(Console.ReadLine());

            if (z == 1)
            {
                Console.WriteLine(t * 5);
            }
            else
            {
                Console.WriteLine(t * 3);
            }
            ;
            */

            /*  double n = Convert.ToDouble(Console.ReadLine());
              if (n % 3 == 0 && n % 5 == 0)
              {
                  Console.WriteLine("FizzBuzz");
              }
              else if (n % 5 == 0)
              {
                  Console.WriteLine("Buzz");
              }
              else if (n % 3 == 0 )
              {
                  Console.WriteLine("Fizz");
              }
              else
              { Console.WriteLine(n); };
              ;
            */

            /* double money = Convert.ToDouble(Console.ReadLine());


             double eggs = 0.5;
             int apples = 3;
             int nrOfBread = 2;

             if (money >= 10)
             {
                 money = money - 10;
                 Console.WriteLine(nrOfBread);

             } else if (money >= 5) {
                 money = money - 5;
                 Console.WriteLine(nrOfBread - 1);
             }
             else  Console.WriteLine(0);

             double nrOfEggs = money / eggs ;

             if (nrOfEggs >= 10)
             {
                 Console.WriteLine(10);
                 money = money - 5;
             }
             else if(nrOfEggs < 10)
             {
                 money = money - (nrOfEggs * eggs) ;
                 Console.WriteLine((int)nrOfEggs);
             }
             else Console.WriteLine(0);

             double nrOfApples = money / apples;
             int y = 10;
             if (money >= 9)
             {
                 Console.WriteLine(3);
                 money = money - 9;
                 y = 10 - 2;
             }
             else if (money >= 6)
             {
                 Console.WriteLine(2);
                 money = money - 6;
             }
             else if (money >= 3)
             {
                 Console.WriteLine(1);
                 money = money - 3;

             }
             else Console.WriteLine(0);

             if (y == 8)
             {
                 Console.WriteLine("DA");
             }
             else Console.WriteLine("NU");
            */


            /*  int number = Convert.ToInt32(Console.ReadLine());
              double firstDecimal =  number / 1000;
              double secondDecimal = Math.Floor((number - (firstDecimal * 1000)) / 100);
              double thirdDecimal = Math.Floor((number - (firstDecimal * 1000) - (secondDecimal * 100)) / 10);
              double forthDecimal = (number - (firstDecimal * 1000) - (secondDecimal * 100) - (thirdDecimal * 10));

              if (firstDecimal % 2 == 0)
              {
                  Console.WriteLine("PAR");
              } else
              {
                  Console.WriteLine("IMPAR");
              }

              if (secondDecimal % 2 == 0)
              {
                  Console.WriteLine("PAR");
              }
              else
              {
                  Console.WriteLine("IMPAR");
              }

              if (thirdDecimal % 2 == 0)
              {
                  Console.WriteLine("PAR");
              }
              else
              {
                  Console.WriteLine("IMPAR");
              }

              if (forthDecimal % 2 == 0)
              {
                  Console.WriteLine("PAR");
              }
              else
              {
                  Console.WriteLine("IMPAR");
              }
              */

            /*            string zodie = Console.ReadLine();

                        switch (zodie)
                        {
                            case "Berbec":
                                Console.WriteLine("martie");
                                Console.WriteLine("aprilie");
                                break;
                            case "Taur":
                                Console.WriteLine("aprilie");
                                Console.WriteLine("mai");
                                break;
                            case "Gemeni":
                                Console.WriteLine("mai");
                                Console.WriteLine("iunie");
                                break;
                            case "Rac":
                                Console.WriteLine("iunie");
                                Console.WriteLine("iulie");
                                break;
                            case "Leu":
                                Console.WriteLine("iulie");
                                Console.WriteLine("august");
                                break;
                            case "Fecioara":
                                Console.WriteLine("august");
                                Console.WriteLine("septembrie");
                                break;
                            case "Balanta":
                                Console.WriteLine("septembrie");
                                Console.WriteLine("octombrie");
                                break;
                            case "Scorpion":
                                Console.WriteLine("octombrie");
                                Console.WriteLine("noiembrie");
                                break;
                            case "Sagetator":
                                Console.WriteLine("noiembrie");
                                Console.WriteLine("decembrie");
                                break;
                            case "Capricorn":
                                Console.WriteLine("decembrie");
                                Console.WriteLine("ianuarie");
                                break;
                            case "Varsator":
                                Console.WriteLine("ianuarie");
                                Console.WriteLine("februarie");
                                break;
                            case "Pesti":
                                Console.WriteLine("februarie");
                                Console.WriteLine("martie");
                                break;
                            default:
                                Console.WriteLine("zodie invalida");
                                break;
                        }

                        */
            /*  int x = 0;
              while (true)
              {
                  string stringNr = Console.ReadLine();
                  if (stringNr == "x")
                  {
                      break;
                  }
                  int intNr = Convert.ToInt32(stringNr);
                  x = x + intNr;

              }
              Console.WriteLine(x );
              */

            /*            int x  = 0 ;
                        while (true)
                        {
                            int  theNr =  Convert.ToInt32(Console.ReadLine());
                            if (theNr  == 0)
                            {
                                break;
                            }
                           else if (theNr > 0)
                            {
                                if (x < theNr )
                                {
                                    x = theNr;
                                }


                            }
                        }
                        Console.Write(x);

                        */
            /*
                        int x; 
                        int  rez = 1;
                        int num = Convert.ToInt32(Console.ReadLine());


                        for (x = 1; x <= num; x++)
                        {
                            rez = rez * x;
                        }


                        Console.Write(rez);
            */

            /*
                        int count = 0;

                        while (true)
                        {
                            string stringNr = Console.ReadLine();
                            if (stringNr == "x")
                            {
                                break;
                            }
                            else { int nums = Convert.ToInt32(stringNr);
                              if (nums > 0 )
                                {
                                    count = count + 1;
                                }
                            }
                        }
                        Console.WriteLine(count);
            */


        }
        private static void Debug()
        {
            /*   int[] numbers = { 2, 3, 5, 7, 25, 15, 9, 30 };
               string[] result = new string[8];

               for (int i = 0; i < numbers.Length; i++)
               {
                   result[i] = "";

                   if (numbers[i] % 3 == 0)
                       result[i] += "Fizz";

                   if (numbers[i] % 5 == 0)
                       result[i] += "Buzz";

                   if (result[i] == "")
                       result[i] += numbers[i].ToString();
               }

               for (int i = 0; i < result.Length; i++)
                   Console.WriteLine(result[i]);


           */
            /*int votesResult = 0;
            int votesCount = 0;
            string vote;
            while (true)
            {
                vote = Console.ReadLine();

                if (vote != "stop")
                {
                    votesCount++;

                    if (vote == "up")
                    {
                        votesResult++;
                    }
                    else if (vote == "down")
                    {
                        votesResult--;
                    }
                }
                else
                {
                    break;
                }
                
            }
            Console.WriteLine(votesResult + " " + votesCount);


            */

            /*   int sumLimit = Convert.ToInt32(Console.ReadLine());
               int sum = 0;
               int count = 0;
               int lastNr = 0;
               while (sum < sumLimit)
               {
                  int number = Convert.ToInt32(Console.ReadLine());
                   sum += number;
                   count++;
                   lastNr = number;
               }

               Console.WriteLine((sum - lastNr) + " " + (count - 1));
            */
            /* string input = Console.ReadLine();
             while (input != "stop" && input != "")
             {
                 string inputType = "";
                 bool onlyDigits = true;

                 for (int i = 0; i < input.Length; i++)
                 {
                     if (input[i] < '0' || input[i] > '9')
                         onlyDigits = false;
                 }

                 if (onlyDigits)
                 {
                     inputType = "numar";
                 }

                 if (input == "true" || input == "false")
                 {
                     inputType = "valoare booleana";
                 }

                 if (inputType == "")
                 {
                     inputType = "text";
                 }

                 Console.WriteLine(inputType);
                 input = Console.ReadLine();

             */

            /*  string input = Console.ReadLine();
              string digit = Console.ReadLine();

              if (input.Contains(digit))
              {
                  Console.WriteLine("True");
              }
              else
              {
                  Console.WriteLine("False");
              }

              */

            /*   string input = Console.ReadLine();
               char digit = Convert.ToChar(Console.ReadLine());
               int count = 0;
               int letter;
               int x;
               int counted = 0;
               for (letter = 0; letter < input.Length; letter++)
               {
                   x = letter;
                   if ( input[x] == digit  )
                   {

                       count++;
                       counted = count;
                   }
                   else
                   {
                       count = count + 0;
                   }

               }
               Console.WriteLine(counted);

               */



            /* string phrase = Console.ReadLine();
             string[] words = phrase.Split(' ');

             foreach (var word in words)
             {
                 Console.WriteLine(word);
             }
            */


            /*   string str;
               int wrd, l;

               str = Console.ReadLine();
               int returnWord = Convert.ToInt32(Console.ReadLine());

               l = 0;
               wrd = 1;

               while (l <= str.Length - 1)
               {

                   if (str[l] == ' ')
                   {
                       wrd++;
                   }

                   l++;
                   if (returnWord == wrd)
                   {

                   }

               }
               Console.WriteLine(wrd);


               */






            /*
            string fraze = Console.ReadLine();
            int countedWord = Convert.ToInt32(Console.ReadLine());
            string[] splitEm = fraze.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (countedWord <= splitEm.Length)
            {
                Console.WriteLine(splitEm[countedWord - 1]);
            }
            else
            {
                Console.WriteLine("N/A");
            }
        */

            /*  string encodedMessage = Console.ReadLine();
              string message = "";
              for (int i = 0; i < encodedMessage.Length; i++)
              {
                  if (encodedMessage[i] == ' ')
                  {
                      message += ' ';
                      continue;
                  }

                  if (i % 2 == 0)
                  {
                      message += (char)(encodedMessage[i] + 1);
                  }
                  else
                  {
                      message += (char)(encodedMessage[i] - 1);
                  }
              }
              Console.WriteLine(message);
            */




            /*
                         string encodedMessage = Console.ReadLine();
                         string message = "";
                        foreach (char ch in encodedMessage)
                        {

                            if (ch == ' ')
                            {
                                message += ' ';
                                continue;
                            }
                          if (ch % 2 == 0)
                            {
                                message +=  (ch + 1).ToString();
                            }
                            else
                            {
                                message += (ch - 1).ToString() ;
                            }

                           /* message = message  + ch.ToString(); 
        }

        Console.WriteLine(message);
            */

            /*    string text = Console.ReadLine();
                string textToFind = Console.ReadLine();

                int count = 0;

                for (int i = 0; i <= text.Length - textToFind.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < textToFind.Length; j++)
                    {
                        if (text[i + j] != textToFind[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match == true)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            */




            /* string count = "";

             while (true)
             {
                 string stringNr = Console.ReadLine();
                 if (stringNr == "x")
                 {
                     break;
                 } 
                     int nums = Convert.ToInt32(stringNr);
                     if (nums % 2 == 0)
                     {
                         count += nums + "\n";
                     }
        }
                     if (count == "" )
                     {
                 count = "N/A";
                                      }

             Console.WriteLine(count);
            */



            /*
            string list = Console.ReadLine();
            string[] ArrList = list.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var count = ArrList.Length;
            string reversedList =  "" ;
            int index = count - 1;

            int i;
             
            for (i = 0; i < count; i++)
            {
                reversedList += ArrList[index] + " " ;
                if (index != 0)
                {
                    index = index - 1;
                }
 }
            Console.WriteLine(reversedList);
            */


            /*   string candidate = Console.ReadLine();
               int nrPassed = Convert.ToInt32(Console.ReadLine());
               string passed = "";
               string  passedList = "";
               int i;

               for (i = 0; i < nrPassed; i++)
               {
                   passed = Console.ReadLine() + " ";
                   passedList += passed;
               }

               if (passedList.Contains(candidate + " "))
               {
                   Console.WriteLine("True");
               }
               else
               {
                   Console.WriteLine("False");
               }
            */

            /*
                        int nrOfLivezi = Convert.ToInt32(Console.ReadLine());
                        int i;
                        int[][] livezi = new int[nrOfLivezi][];
                        int meri = 0;
                        int peri = 0;
                        int cireesi = 0;
                        int m  = 0;
                        string n = "";
                        for (i = 0; i < nrOfLivezi; i++)
                        {
                            string livada = Console.ReadLine();
                            string[] LivadaList = livada.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                            int[] livadaListInt = Array.ConvertAll(LivadaList, int.Parse);  
                            livezi[i] = livadaListInt ;
                            for (int j = 0; j <= livezi.Length; j++)
                            {
                                foreach (var x in livezi)
                                {
                                    m = livezi[i][0] + livezi[i][1] + livezi[i][2];

                                }
                            }
                            n += "Livada " + (i+ 1) + ": " +  m.ToString() + "\n"; 

                            meri +=  livezi[i][0] ;
                            peri += livezi[i][1];
                            cireesi += livezi[i][2];
                        }
                            Console.WriteLine(n);
                            Console.WriteLine("Meri: "+ meri);
                        Console.WriteLine("Peri: " + peri);
                        Console.WriteLine("Ciresi: " + cireesi);
            */

            /*   int input = Convert.ToInt32(Console.ReadLine());
               int i;
               int count = 0;

               for (i = 1; i <= input + 1; i++)
               {
                   count += i;
               }

               Console.WriteLine(count);
            */

            /* string input1 = Console.ReadLine();
             string input2 = Console.ReadLine();
             string output = "";

             char[] ch1 = new char[input1.Length];
             for (int i = 0; i < input1.Length; i++)
             {
                 ch1[i] = input1[i];
             }

             char[] ch2 = new char[input2.Length];
             for (int j = 0; j < input2.Length; j++)
             {
                 ch2[j] = input2[j];
             }
             if (input1.Length < input2.Length)
             {
                 for (int q = 0; q < input1.Length; q++)
                 {
                     if (ch1[q] == ch2[q])
                     {
                         output += ch1[q];
                     }
                     else
                     {
                         break;
                     }
                 }
             }
             else
             {
                 for (int q = 0; q < input2.Length; q++)
                 {
                     if (ch1[q] == ch2[q])
                     {
                         output += ch1[q];
                     }
                     else
                     {
                         break;
                     }
                 }
             }
             Console.WriteLine(output);
            */


            /*   int x = Convert.ToInt32(Console.ReadLine());
               int y = Convert.ToInt32(Console.ReadLine());
               int sumx = 0;
               int divideY ;
               int i;
               for (i = 0; i < 100 ; i++)
               {
                   sumx += x;
                    divideY = sumx % y;

                   if (divideY == 0)
                   {
                       Console.WriteLine(sumx);
                       break;

                   }
               }

               */

            {
                /*  int[] valuesList = ReadValuesList();

                  string line = Console.ReadLine();

                  while (line != "x")
                  {
                      string[] lineItems = line.Split(' ');
                      int index = Convert.ToInt32(lineItems[0]);
                      int value = Convert.ToInt32(lineItems[1]);
                      UpdateValue(valuesList, index, value);
                      line = Console.ReadLine();
                  }

                  PrintValuesList(valuesList);
                  Console.Read();
              }

              static void UpdateValue(int[] valuesList, int index, int value)
              {
                  // to do: remove line below and implement this function
                  throw new NotImplementedException();
              }

              static void PrintValuesList(int[] valuesList)
              {
                  for (int i = 0; i < valuesList.Length; i++)
                      Console.Write(valuesList[i] + " ");
              }

              static int[] ReadValuesList()
              {
                  string[] inputValues = Console.ReadLine().Split(' ');
                  int[] values = new int[inputValues.Length];

                  for (int i = 0; i < values.Length; i++)
                      values[i] = Convert.ToInt32(inputValues[i]);

                  return values;
              }


                  */
                Console.WriteLine(00011101 | 00111000);
                Console.Read();

            }
        }
    }
}









        
            
        

        
    




