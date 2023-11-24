using NUnit.Framework;

namespace TestingDataBase
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase ("wer","sdfyguiuoitdrstytre","245353")]
        [TestCase("qwertyuiopoiuytre123456", "strytuiutytsrtyrtuytrteyte","3456543")]
        public void Test1(string A, string C, string B) 
        {
            var sut = new RabotaSBDLib.Class1();
            var expect = "������ ���������";
            var actual = sut.Add(A,C,B);
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test2()
        {
            var sut = new RabotaSBDLib.Class1();
            var expect = "����������� - �������� ����";
            var actual = sut.GetByID("#2");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test3()
        {
            var sut = new RabotaSBDLib.Class1();
            var expect = "��������� � ��������� � ����� ��� 4 ����.������� ����, ����� �� ����� ����� ���� ����� � ������� ��� ����� ����� �� � �������� �����";
            var actual = sut.GetByID("#3");
            Assert.AreEqual(expect, actual);
        }
        [TestCase("#2", "sdfyguiuoitdrstytre")]
        [TestCase("#3", "strytuiutytsrtyrtuytrteyte")]
        public void Tes51(string A, string C)
        {
            var sut = new RabotaSBDLib.Class1();
            var expect = "������ ������ ��������";
            var actual = sut.Update(A, C);
            Assert.AreEqual(expect, actual);
        }
        [TestCase("#5432", "sdfyguiuoitdrstytre")]
        [TestCase("#5433", "strytuiutytsrtyrtuytrteyte")]
        public void Tes5(string A, string C)
        {
            var sut = new RabotaSBDLib.Class1();
            var expect = "������ ������ �� ��������";
            var actual = sut.Update(A, C);
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test6()
        {
            var sut = new RabotaSBDLib.Class1();
            var expect = "������ ������ �������";
            var actual = sut.GetByID("#3");
            Assert.AreEqual(expect, actual);
        }

    }
}