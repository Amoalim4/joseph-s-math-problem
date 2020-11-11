/////////////////////////// Joseph's math problem ////////////////////

 // formula
            //2 * ( x - n) + 1
            
           // n is the neast base 2 <<< e.g[2,4,8,16,32,61,128] ....

           //{ 2 (2) , 4 =( 2* 2), 8 = (2 * 2 * 2) >>>> 

           // so n is the nearest base two number of X while X is the given number

///////////////////////////////////----- the code ---//////////////////////////////////////

            // |==>
            // here i created an Array that holds the base 2 number
            // in this case we only have first 7 

            int[] sq = { 2, 4, 8, 16, 32, 64, 128 ,256,512,};

                       

            // <==|
            // creating another Array, this array will be empty and we will add values later

            int[] newlist = { };

            //.. ==> declaring  variable
            // now these two variable are empty but we will use one the to get the user's input
            // and the other for calculating the maxmum number in the (newlist[]) array 
            int max_number = 0;
            int number = 0;

            //..=> asking the user's input 

           
            // this is the variable we said will will use it to get the user's input
            // since it is an Integer we need to covert it to string 
            //because C# gets and prints every thing as string 

             Console.WriteLine("Enter the number");

             number = int.Parse(Console.ReadLine());





            // -->

            for (int i = 0; i < (sq.Length); i++)
            {
                // the if is checking if the user's input is greater then the value of the existing array (sq[])           

                if (sq[i] <= number)
                {
                    // if so that value will be added in the new array (newlist[])

                    newlist = newlist.Concat( new[] {sq[i]}).ToArray();
                    
                }

                // this variable was declared above and now we are giving it a new value 
                // that new value if the biggest number of the last array (newlist[])
                //in order to the the biggest number we need to use .Max() method

                max_number = newlist.Max();


            }
            
            int safe = (2*(number- max_number))+1;

            Console.WriteLine( "the safe place is : {0}", safe);
           

            Console.ReadKey();

           // ///////////////////////// test ///////////// 
           // X = 41
           // so the N (nearest ) = 32 

            // 2*(41 - 32)+1 = 19

           // so 19 is the safest place to sit if there are 41 people in there.
