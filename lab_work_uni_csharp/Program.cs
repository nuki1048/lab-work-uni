namespace lab_work_uni_csharp;

static class Program
{
  
    [STAThread]
    static void Main()
    {
        
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmDetailed());
    }
}