//Console.WriteLine("Interitance!");
using Inheritance_YetGenAkbank.Entities;

Console.WriteLine("Calender App");

Meeting meeting1 = new()
{
    Title = "YetGen Jump & Akbank Backend Planlama Toplantısı",
    Details = new List<string>()
    {
        "Katılımcıların alım süreci konuşulması",
        "Akbanktan gelen mailin konuşması."
    },
    StartTime = new DateTime(2023, 09, 18, 19, 00, 00),
    EndTime = new DateTime(2023, 09, 18, 20, 00, 00),
    Guests = new() { "hakan@deneme.com", "ali@deneme.com" },
};

Todo todo1 = new()
{
    Title = "Katılımcılara geri bildirim teslimi",
    Details = new List<string>()
    {
        "Değerlendirme tablo analizi."
    },
    StartTime = new DateTime(2023, 09, 20, 21, 00, 00),
    FinishTime = new DateTime(2023, 09, 20, 22, 00, 00),
    Importance = "High Priority"
};

meeting1.GetNotification();
todo1.GetNotification();
//BaseClass baseClass = new();
//baseClass.Text = "Test";
//baseClass.Print();

//DerivedClas derivedClass = new();
//derivedClass.Text = "Test 2";
//derivedClass.Print();

//class BaseClass //Parent - Kalıtım veren
//{
//    public string Text { get; set; }

//    public void Print()
//    {
//        Console.WriteLine("Print method"); 
//    }

//}
//class DerivedClas : BaseClass //Child - Kalıtım Alan - DericedClass Baseclassdan kalıtım aldı.
//{
//    public int Number { get; set; } 
//}
