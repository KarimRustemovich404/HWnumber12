namespace HWnumber12.Classes
{
    public class Solving
    {
        #region Methods

        /// <summary>
        /// Метод, который, по идее, должен находить факториал числа 
        /// </summary>
        public int solveFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Метод для возведения чиса в квадрат
        /// </summary>
        public int Squaring(int number)
        {
            return number * number;
        }
        #endregion
    }
}
