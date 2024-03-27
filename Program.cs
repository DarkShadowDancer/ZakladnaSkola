namespace ZakladnaSkola
{
    internal class Program
    {
        static void Main()
        {
            //Zapne menu
            SkolaUI schoolUI = new SkolaUI();
            MenuSkola menuSkola = new MenuSkola(schoolUI);
            menuSkola.Run();
        }
    }
}