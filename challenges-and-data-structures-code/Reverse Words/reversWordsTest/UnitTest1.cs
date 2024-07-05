namespace reversWordsTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestCase1()
        {
            string input = "csharp is programming language";
            string expected = "language programming is csharp";

            string actual = Program.ReverseWords(input);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestCase2()
        {
            string input = "Reverse the words in this sentence";
            string expected = "sentence this in words the Reverse";

            string actual = Program.ReverseWords(input);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestCase3()
        {
            string input = "challenges and data structures";
            string expected = "structures data and challenges";

            string actual = Program.ReverseWords(input);

            Assert.Equal(expected, actual);
        }
    }
}