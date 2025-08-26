using System.Security.Principal;

namespace BeeOptimizer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Vérifier les droits administrateur
            if (!IsRunningAsAdministrator())
            {
                MessageBox.Show("🔒 BeeOptimizer nécessite les droits administrateur !\n\n" +
                              "Veuillez relancer l'application en tant qu'administrateur :\n" +
                              "• Clic droit sur BeeOptimizer.exe\n" +
                              "• Sélectionnez 'Exécuter en tant qu'administrateur'\n\n" +
                              "L'application va maintenant se fermer.",
                              "🐝 BeeOptimizer - Droits administrateur requis",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Application.Run(new Form1());
        }

        private static bool IsRunningAsAdministrator()
        {
            try
            {
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch
            {
                return false;
            }
        }
    }
}