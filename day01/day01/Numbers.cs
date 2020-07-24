namespace day01
{
    public class Numbers
    {
        private string numberString { get; set; }

        public Numbers(string inputString)
        {
            numberString = inputString;
        }

        public int SumNumbers()
        {
            return SumNumbersWithJump(1);
        }

        // Now, instead of considering the next digit, it wants you to consider the digit halfway around the circular list.
        // That is, if your list contains 10 items, only include a digit in your sum if the digit 10/2 = 5 steps forward matches it.
        // Fortunately, your list has an even number of elements.
        public int SumNumbersWithJump(int jumpAheadBy = 0)
        {
            var runningTotal = 0;

            if (jumpAheadBy == 0)
                jumpAheadBy = numberString.Length / 2;

            for (var pos = 0; pos < numberString.Length; pos++)
            {
                var jumpAheadPos = (pos + jumpAheadBy) % numberString.Length;
                if (numberString[pos] == numberString[jumpAheadPos])
                    runningTotal += (int)numberString[pos] - '0';
            }

            return runningTotal;
        }
    }
}
