namespace ExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DivisionNoHandling();
            DivisionWithExceptionHandling();
            DivisionWithExceptionHandlingMoreInfo();
            DivisionWithExceptionHandlingThrow();
            GeneratingException();
            HandlingRandomException();
        }
        static int Division(int top, int bottom) => top / bottom;
        static void DivisionNoHandling()
        {
            Division(1, 0);
        }
        static void DivisionWithExceptionHandling()
        {
            try
            {
                Division(1, 0);
            }
            catch (Exception error)
            {

            }
        }
        static void DivisionWithExceptionHandlingMoreInfo()
        {
            try
            {
                Division(1, 0);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        static void DivisionWithExceptionHandlingThrow()
        {
            try
            {
                Division(1, 0);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                throw new Exception();
            }
        }
        static void GeneratingException()
        {
            throw new Exception();
        }
        static void HandlingRandomException()
        {
            try
            {
                GeneratingRandomException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The designated index is out of range.");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("The member being accessed is null.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("The operation being conducted is invalid.");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("The Arithmetic operation being done is invalid.");
            }
            catch (FormatException)
            {
                Console.WriteLine("The format conversion is invalid.");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("The attempted casting is unsupported.");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("The runtime cannot allocate enough memory to perform this operation.");
            }

        }
        static void GeneratingRandomException()
        {
            int exceptionType = new Random().Next() % 7;
            switch (exceptionType)
            {
                case 0:
                    throw new IndexOutOfRangeException();
                case 1:
                    throw new NullReferenceException();
                case 2:
                    throw new InvalidOperationException();
                case 3:
                    throw new ArithmeticException();
                case 4:
                    throw new FormatException();
                case 5:
                    throw new InvalidCastException();
                case 6:
                    throw new OutOfMemoryException();
            }
        }



    }
}
