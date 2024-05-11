namespace AplicatieChestionareAuto
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string nextPage = "";

            ApplicationConfiguration.Initialize();
            MainForm dashBoardForm = new MainForm();
            Application.Run(dashBoardForm);
            nextPage = dashBoardForm.GetNextPage();

            while(true)
            {
                if(nextPage == "MainForm")
                {
                    MainForm mainForm = new MainForm();
                    Application.Run(mainForm);
                    nextPage = mainForm.GetNextPage();
                }
                else if(nextPage == "TipuriChestionareForm")
                {
                    TipuriChestionareForm tipuriChestionareForm = new TipuriChestionareForm();
                    Application.Run(tipuriChestionareForm);
                    nextPage = tipuriChestionareForm.GetNextPage();
                }
                else if (nextPage =="ChestionarForm")
                {
                    ChestionarForm chestionarForm = new ChestionarForm();
                    Application.Run(chestionarForm);
                    nextPage = chestionarForm.GetNextPage();
                }
                else
                {
                    break;
                }
            }
        }
    }
}