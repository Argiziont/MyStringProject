using Xunit;

namespace MyStringProject.Tests
{
    public class UnitTest1
    {

        [Theory]//Testing AppendAtStart
        [InlineData(new char[] { 'z', 'q', 'n' }, new char[] { 'z', 'q' }, new char[] { 'z', 'q', 'z', 'q', 'n' })]
        [InlineData(new char[] { 'n', 'e', 'm' }, new char[] { 'z' }, new char[] { 'z', 'n', 'e', 'm' })]
        public void AppendStringMustBeEqual(char[] primaryString, char[] secondaryString, char[] expected)
        {
            MyString mstr = new MyString(primaryString);
            mstr.AppendAtStart(secondaryString);
            char[] output = mstr.CharArray;
            Assert.Equal(output, expected);
        }

        [Theory]//Testing AppendAtEnd
        [InlineData(new char[] { 'z', 'q', 'n' }, new char[] { 'z', 'q' }, new char[] { 'z', 'q', 'n', 'z', 'q' })]
        [InlineData(new char[] { 'n', 'e', 'm' }, new char[] { 'z' }, new char[] { 'n', 'e', 'm', 'z' })]
        public void AppendAtEndStringMustBeEqual(char[] primaryString, char[] secondaryString, char[] expected)
        {
            MyString mstr = new MyString(primaryString);
            mstr.AppendAtEnd(secondaryString);
            char[] output = mstr.CharArray;
            Assert.Equal(output, expected);
        }

        [Theory]//Testing SubString
        [InlineData(new char[] { 'z', 'q', 'n', 'n', 'g', 'u', 'M', 'i' }, 4,2, new char[] { 'g', 'u' })]
        [InlineData(new char[] { 'z', 'q', 'n', 'n', 'g', 'u', 'M', 'i' }, 2, 1, new char[] { 'n'})]
        public void SubStringMustBeEqual(char[] primaryString, int index,int count, char[] expected)
        {
            MyString mstr = new MyString(primaryString);
            Assert.Equal(mstr.SubString(index, count), expected);
        }
        [Theory]//Testing CountWords
        [InlineData("Hello my dear neighbor ", 4)]
        [InlineData("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod ", 11)]
        public void WordsCountMustBeEqual(string primaryString, int expected)
        {
            MyString mstr = new MyString(primaryString);
            Assert.Equal(mstr.CountWords(), expected);
        }

        [Theory]//Testing CountWords
        [InlineData("If you're visiting this page, you're likely here because you're searching for a random sentence." +
            " Sometimes a random word just isn't enough, and that is where the random sentence generator comes into play." +
            " By inputting the desired number, you can make a list of as many random sentences as you want or need." +
            " Producing random sentences can be helpful in a number of different ways.", 4)]

        [InlineData("For writers, a random sentence can help them get their creative juices flowing." +
            " Since the topic of the sentence is completely unknown, it forces the writer to be creative when the sentence appears." +
            " There are a number of different ways a writer can use the random sentence for creativity." +
            " The most common way to use the sentence is to begin a story." +
            " Another option is to include it somewhere in the story." +
            " A much more difficult challenge is to use it to end a story." +
            " In any of these cases, it forces the writer to think creatively since they have no idea what sentence will appear from the tool.", 7)]
        public void SentencesCountMustBeEqual(string primaryString, int expected)
        {
            MyString mstr = new MyString(primaryString);
            Assert.Equal(mstr.CountSentences(), expected);
        }

    }
}
