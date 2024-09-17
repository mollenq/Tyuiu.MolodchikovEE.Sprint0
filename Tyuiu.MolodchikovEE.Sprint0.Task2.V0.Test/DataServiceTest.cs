using Tyuiu.MolodchikovEE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MolodchikovEE.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Егор";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.Equal("Привет..., Егор", res);
        }
    }
}