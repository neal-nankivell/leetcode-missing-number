using Answer;
using NUnit.Framework;

namespace Tests
{
    public class SolutionTests
    {
        [TestCase(3, 0, 1, ExpectedResult = 2)]
        [TestCase(9, 6, 4, 2, 3, 5, 7, 0, 1, ExpectedResult = 8)]
        public int MissingNumber(params int[] nums)
        {
            var sut = new Solution();

            return sut.MissingNumber(nums);
        }
    }
}