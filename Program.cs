 string[] Mass;
 Console.WriteLine("VVedite massiv strok cheres probel");
 string stroka = Console.ReadLine();
            Mass = stroka.Split(' ');
            var result = new string[Mass .Length];
            var realSize = 0;
            foreach (var value in Mass )
            {
                if (value.Length <= 3)
                {
                    result[realSize] = value;
                    realSize++;
                }
            }
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);