using Tyuiu.MolodchikovEE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MolodchikovEE.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetMessageValid()
        {
            // ������� �������� ������� ������������, ������� �� ����������
            var name = "����";
            var res = DataService.GetMessage(name);

            //�������� ����� Assert � ����� AreEqual
            Assert.Equal("������..., ����", res);
        }
    }
}