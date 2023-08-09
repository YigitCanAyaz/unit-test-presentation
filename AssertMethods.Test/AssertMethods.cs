using Calculator.App;
using System;
using System.Collections.Generic;
using Xunit;

namespace AssertMethods.Test
{
    public class AssertMethods
    {
        // Assert.Equal: Beklenen değerle gerçek değerin eşit olup olmadığını kontrol eder.
        [Fact]
        public void TestEqual()
        {
            Assert.Equal(4, 2 + 2);
        }

        // Assert.NotEqual: İki değerin farklı olup olmadığını kontrol eder.
        [Fact]
        public void TestNotEqual()
        {
            Assert.NotEqual(5, 2 + 2);
        }

        // Assert.True: Bir ifadenin doğru olup olmadığını kontrol eder.
        [Fact]
        public void TestTrue()
        {
            Assert.True(2 + 2 == 4);
        }

        // Assert.False: Bir ifadenin yanlış olup olmadığını kontrol eder.
        [Fact]
        public void TestFalse()
        {
            Assert.False(2 + 2 == 5);
        }

        // Assert.NotNull: Değerin null olup olmadığını kontrol eder.
        [Fact]
        public void TestNotNull()
        {
            string result = "xUnit";
            Assert.NotNull(result);
        }

        // Assert.Null: Değerin null olup olmadığını kontrol eder.
        [Fact]
        public void TestNull()
        {
            string result = null;
            Assert.Null(result);
        }

        // Assert.Contains: Bir koleksiyonda belirli bir öğenin bulunup bulunmadığını kontrol eder.
        [Fact]
        public void TestContains()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            Assert.Contains(3, numbers);
        }

        // Assert.DoesNotContain: Bir koleksiyonda belirli bir öğenin bulunup bulunmadığını kontrol eder.
        [Fact]
        public void TestDoesNotContain()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            Assert.DoesNotContain(6, numbers);
        }

        // Assert.Throws: Belirli bir türde istisna atılmasını bekler.
        [Fact]
        public void TestThrows()
        {
            //Assert.Throws<DivideByZeroException>(() => { int result = 10 / 0; });
        }

        // Assert.Empty: Koleksiyonun boş olup olmadığını kontrol eder.
        [Fact]
        public void TestEmpty()
        {
            var numbers = new List<int>();
            Assert.Empty(numbers);
        }

        // Assert.Single: Koleksiyonun tek bir öğe içerip içermediğini kontrol eder.
        [Fact]
        public void TestSingle()
        {
            var numbers = new List<int> { 42 };
            Assert.Single(numbers);
        }

        // Assert.InRange: Değerin belirli bir aralıkta olup olmadığını kontrol eder.
        [Fact]
        public void TestInRange()
        {
            int value = 5;
            Assert.InRange(value, 1, 10);
        }

        // Assert.NotInRange: Değerin belirli bir aralıkta olmaması gerektiğini kontrol eder.
        [Fact]
        public void TestNotInRange()
        {
            int value = 15;
            Assert.NotInRange(value, 1, 10);
        }

        // Assert.All: Koleksiyon içindeki tüm öğelerin belirli bir koşulu sağlayıp sağlamadığını kontrol eder.
        [Fact]
        public void TestAll()
        {
            var numbers = new List<int> { 2, 4, 6, 8, 10 };
            Assert.All(numbers, number => Assert.True(number % 2 == 0));
        }

        // Assert.Collection: Koleksiyon içindeki öğelerin belirli bir durumu karşılayıp karşılamadığını kontrol etmek için bir dizi işlev kullanır.
        [Fact]
        public void TestCollection()
        {
            var numbers = new List<int> { 1, 2, 3 };
            Assert.Collection(numbers,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item));
        }

        // Assert.IsAssignableFrom: Bir tipin, diğer tipe referans verip veremeyeceğini tespit etmek için kullanılır.

        [Fact]
        public void TestIsAssignableFrom()
        {
            Assert.IsAssignableFrom<ICalculatorService>(new CalculatorService());
        }
    }
}
