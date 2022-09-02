// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.



Console.WriteLine("n:");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("m:");
        int m = Convert.ToInt32(Console.ReadLine());
        int [,]arr=new int [n, m];
        Random ran = new Random();
        int sum = 0;
        float middle = 0;

        for (int i=0; i < n; i++)
        {
            for(int j=0; j<m; j++)
            {
                arr[i, j] = ran.Next(0, 100);


                    sum += arr[i, j];

                 middle = sum /( m*n);

                Console.Write(arr[i, j] + "\t");


            }
            Console.WriteLine();

        }
        Console.WriteLine("middle=" + middle);

        Console.ReadLine();