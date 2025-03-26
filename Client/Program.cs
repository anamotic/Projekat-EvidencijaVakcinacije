using Client.GUIController;

namespace Client
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LogInGUIController.Instance.ShowFrmLogin(); 
            Application.Run();

        }
    }
}