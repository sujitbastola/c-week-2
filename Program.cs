namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: variables and interpolated strings ----

            // TODO 1: declare a variable called userName that holds your name.
            //         Text needs the type string.
            string username = "Sujit BAstola";

            // TODO 2: declare a variable called luckyNumber holding your
            //         favourite single-digit number. A whole number is int.
            int luckyNumber = 7;

            // TODO 3: print ONE line that reads exactly:
            //         Hello, <your name>! Your lucky number is <the number>.
            //         Use string interpolation, not the + operator.
            Console.WriteLine($"Hello, {username}! Your lucky number is {luckyNumber}.");

            // ---- Task 2: constants and methods ----
            // TODO 2: create a Circle object and print Circle.PI. 
            Circle circle = new Circle();
            Console.WriteLine(Circle.PI);


            // ---- Task 3: data types and type conversion ----

            byte tiny = 200;
            short small = 30000;

            // TODO 4: declare one variable for each of these types and give
            //         it a sensible value:
            //             int, long, float, double, decimal, char, bool
            int myInt = 100;
            long myLong = 10000000000;
            float myFloat = 3.14f;
            double myDouble = 3.14159;
            decimal myDecimal = 3.141592653589793238462643383279502m;
            char myChar = 'A';
            bool myBool = true;

            // TODO 5: convert the number 42 into a string, storing the
            //         result in a new variable.
            string myString = 42.ToString();

            // TODO 6: convert the string "3.14" into a double, storing the
            //         result in a new variable.
            double myDoubleFromString = double.Parse("3.14");

            // These two lines are done for you as a model.
            Console.WriteLine($"byte   = {tiny}      (type: byte)");
            Console.WriteLine($"short  = {small}     (type: short)");

            // TODO 7: print one labelled line for each of the remaining
            //         variables, including the two you converted.
            //         Keep the spacing so the columns line up.
            Console.WriteLine($"int    = {myInt}      (type: int)");
            Console.WriteLine($"long   = {myLong}      (type: long)");
            Console.WriteLine($"float  = {myFloat}      (type: float)");
            Console.WriteLine($"double = {myDouble}      (type: double)");
            Console.WriteLine($"decimal = {myDecimal}      (type: decimal)");
            Console.WriteLine($"char   = {myChar}      (type: char)");
            Console.WriteLine($"bool   = {myBool}      (type: bool)");
            Console.WriteLine($"string = {myString}      (type: string)");
            Console.WriteLine($"double from string = {myDoubleFromString}      (type: double)");

            // ---- Task 4: arrays and Array methods ----
            int[] numbers = { 42, 7, 19, 3, 88 };

            // TODO 8: print the numbers in their original order on one
            //         line, separated by commas.
            Console.WriteLine(string.Join(", ", numbers));

            // TODO 9: sort them ascending with Array.Sort, then print the
            //         line again.
            Array.Sort(numbers);
            Console.WriteLine(string.Join(", ", numbers));

            // TODO 10: reverse them with Array.Reverse, then print again.
            Array.Reverse(numbers);
            Console.WriteLine(string.Join(", ", numbers));

            // TODO 11: print each element on its own line using a for loop,
            //          showing the index as well as the value.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }

            // TODO 12: use Array.IndexOf to find the position of 19 and
            //          print it. Then look up 100 and print that too.
            int positionOf19 = Array.IndexOf(numbers, 19);
            Console.WriteLine($"Position of 19: {positionOf19}");

            int positionOf100 = Array.IndexOf(numbers, 100);
            Console.WriteLine($"Position of 100: {positionOf100}");



            // ---- Task 5: DateTime and TimeSpan ----
            DateTime birthDate = new DateTime(2001, 08, 20);

            // TODO 13: declare a DateTime holding the current date and time,
            //          called today.
            DateTime today = DateTime.Now;

            // TODO 14: subtract birthDate from today. The result is a
            //          TimeSpan — name it ageSpan.
            //          Subtracting two DateTimes gives you a TimeSpan, so
            //          there is nothing to convert explicitly.

            TimeSpan ageSpan = today - birthDate;

            // TODO 15: work out the age in whole years from the TimeSpan and
            //          store it in an int called years.
            //          ageSpan.TotalDays / 365.25 gives a decimal number of
            //          years — cast it to int to drop the fraction.
            int years = (int)(ageSpan.TotalDays / 365.25);

            // TODO 16: print your birth date, today's date, your age in
            //          years, and your birth date plus 10 days.
            Console.WriteLine($"Birth Date: {birthDate}");
            Console.WriteLine($"Today: {today}");
            Console.WriteLine($"Age in Years: {years}");
            Console.WriteLine($"Birth Date + 10 Days: {birthDate.AddDays(10)}");


        }
    }
}
