namespace СТРОКИ
{
    internal class Program
    {
        /*1) Описать метод  string CreatePhoneNumber(int[] numbers), который принимает массив чисел и составляет из них номер телефона. 
             * Не забудьте проверять длину массива (в российском номере должно быть 10 цифр) */
        public static string CreatePhoneNumber(int[] numbers)
        {
            if (numbers.Length != 10)
            {
                return "Массив должен содержать 10 цифр";
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 10)
                {
                    return "В массиве не должнл быть чисел больше 9";
                }
            }
            
            string phone = "";

            phone += numbers[0].ToString() + numbers[1].ToString() + numbers[2].ToString();

            phone += " ";
            phone += numbers[3].ToString() + numbers[4].ToString() + numbers[5].ToString();
            phone += "-";
            phone += numbers[6].ToString() + numbers[7].ToString();
            phone += "-";
            phone += numbers[8].ToString() + numbers[9].ToString();

            return phone;
        }


        //2) Описать метод string TrimString(string phrase, int len), который будет обрезать строку(первый аргумент),
        //если она длиннее запрошенной максимальной длины строки(второй аргумент). Результат должен заканчиваться на "..."
        //Эти точки в конце также входят в длину строки.
        //Например, TrimString("Writing code is fun", 14) => "Writing cod..."
        //Если строка меньше или равна максимальной длине строки, то просто верните строку без обрезки или точек.
        //Если запрошенная длина строки меньше или равна 3 символам, то длина точек не прибавляется к длине строки.
        //например.должен возвращаться , потому что 1 <= 3trim("He", 1)"H..."
        public static string TrimString(string phrase, int len)
        {
            if (phrase.Length <= len)
            {
                return phrase;
            }
            if (len <= 3)
            {
                return phrase.Substring(0, len) + "...";
            }
            return phrase.Substring(0, len - 3) + "...";
        }


        //3) Описать метод long SquareDigits(long n), который возведет в квадрат каждую цифру в числе. Например, SquareDigits(5678) => 25364964
        public static long SquareDigits(long n)
        {
            string s = n.ToString();
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                int digit = s[i] - '0';
                int digit2 = digit * digit;
                result += digit2;
            }
            return long.Parse(result);
        }


        /*4) Вы наверняка знакомы с системой «лайков» из Facebook и других сайтов. Люди могут ставить «лайки» сообщениям в блогах, фотографиям или другим элементам. 
         * Допустим, мы хотим создать текст, который должен отображаться рядом с таким элементом. 
         * Описать метод string Likes(string[] names), который принимает массив, содержащий имена людей,
         * которым понравился товар. Он должен возвращать отображаемый текст, как показано в примерах:
        [] --> "no one likes this"
        ["Peter"] --> "Peter likes this"
        ["Jacob", "Alex"] --> "Jacob and Alex like this"
        ["Max", "John", "Mark"] --> "Max, John and Mark like this"
        ["Alex", "Jacob", "Mark", "Max"] --> "Alex, Jacob and 2 others like this"*/
        public static string Likes(string[] names)
        {
            if (names == null)
            {
                return "no one likes this";
            }
            else if (names.Length == 1)
            {
                return names[0] + " likes this";
            }
            else if (names.Length == 2)
            {
                return names[0] + " and " + names[1] + " like this";
            }
            else if (names.Length == 3)
            {
                return names[0] + ", " + names[1] + " and " + names[2] + " like this";
            }
            else
            {
                return names[0] + ", " + names[1] + " and " + (names.Length - 2) + " others like this";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив чисел для номера телефона");
            string input = Console.ReadLine();
            string[] numbersSt = input.Split(' ');
            int[] numbers = new int[numbersSt.Length];
            for (int i = 0; i < numbersSt.Length; i++)
            {
                numbers[i] = int.Parse(numbersSt[i]);
            }
            Console.WriteLine(CreatePhoneNumber(numbers));


            Console.WriteLine("Введите строку и максимальную длину");
            string input2 = Console.ReadLine();
            string[] St = input2.Split(' ');
            Console.WriteLine(TrimString(St[0], int.Parse(St[1])));


            Console.WriteLine("Введите число");
            string input3 = Console.ReadLine();
            Console.WriteLine(SquareDigits(int.Parse(input3)));


            Console.WriteLine("Введите имена");
            string input4 = Console.ReadLine();
            string[] Names = input4.Split(' ');
            Console.WriteLine(Likes(Names));
        }
    }
}