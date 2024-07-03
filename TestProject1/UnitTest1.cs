using challenges_and_data_structures_code;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
       
        public void CommonElements_Case1_ReturnsCorrectResult()
        {
            // Arrange
            var arr1 = new[] { 1, 2, 3, 0 };
            var arr2 = new[] { 2, 3, 4, 9 };
            var expected = new[] { 2, 3 };
            //Act
            var actual =CommonElements.commonElements(arr1, arr2);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CommonElementsTests_ReturnCommonNumberCase2()
        {
            // Arrange
            var arr1 = new[] { 79, 8, 15 };
            var arr2 = new[] { 23, 79, 8 };
            var expected = new[] { 8,79 };
            //Act
            var actual = CommonElements.commonElements(arr1, arr2);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}