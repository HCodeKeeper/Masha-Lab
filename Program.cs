using Masha_Lab.Algorithm;
using Masha_Lab.UI;
class Program
{
    public static void Main(String[] args)
    {
        IValidator validator = new Validator();
        string[] input = new string[] {"MEOW,meow.meow,.!salfk???<>.!!sq", "ss.sss", "?aboba?", "...bubzik..."};
        string[] output = new string[5];
        for(int i = 0; i < input.Length; i++)
        {
            output[i] = validator.Validate(input[i]);
        }
        MainFrame MainFrame = new MainFrame(new ITask[]{new Masha_Lab.UI.Task("1st Task", "Задано непустий текст довжиною до 255 символів. Переконатися, що" +
            "кожне речення починається з великої латинської літери. Якщо це не так," +
            "виправити цю помилку. Ознакою кінця речення є крапка, три крапки, знак" +
            "оклику, знак запитання, їх комбінації.", input, output), new Masha_Lab.UI.Task("11st Task", "Задано непустий текст довжиною до 255 символів. Переконатися, що" +
            "кожне речення починається з великої латинської літери. Якщо це не так," +
            "виправити цю помилку. Ознакою кінця речення є крапка, три крапки, знак" +
            "оклику, знак запитання, їх комбінації.", input, output) });
    }
}