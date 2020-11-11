/////////////////////////// Joseph's math problem ////////////////////

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


                    //  example from the internet of how to 

                    //..=> var Freds = new[] { "Fred", "Freddy" };

                    ////..=> Freds = Freds.Concat(new[] { "Frederick" }).ToArray();
                    
                }

                // this variable was declared above and now we are giving it a new value 
                // that new value if the biggest number of the last array (newlist[])
                //in order to the the biggest number we need to use .Max() method

                max_number = newlist.Max();


            }
            
            int safe = (2*(number- max_number))+1;

            Console.WriteLine( "the safe place is : {0}", safe);
            Console.WriteLine("the max is :{0}",max_number);

            Console.ReadKey();


            //int num = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    num = i + 1;
            //}

            //Console.WriteLine(num);


            //2 * ( number - nb) + 1
            
           //nb is the neast base two of the given number 

            // 2*(7 - 4)+1 = 7
