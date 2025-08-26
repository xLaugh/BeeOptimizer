using System.Diagnostics;
using System.Security.Principal;

namespace BeeOptimizer
{
    public partial class Form1 : Form
    {
        private bool languageMenuVisible = false;

        public Form1()
        {
            InitializeComponent();
            LanguageManager.DetectSystemLanguage();
            LoadLogos();
            LoadFlagImages();
            UpdateLanguage();
            CheckAdministratorRights();
        }

        private void LoadLogos()
        {
            try
            {
                if (File.Exists("2.gif"))
                {
                    // Charger pour la page d'accueil
                    logoBox.Image = Image.FromFile("2.gif");
                    logoBox.Visible = true;

                    // Charger pour la page À propos
                    aboutLogoBox.Image = Image.FromFile("2.gif");
                    aboutLogoBox.Visible = true;
                }
                else
                {
                    // Si le logo n'est pas trouvé, masquer les PictureBox
                    logoBox.Visible = false;
                    aboutLogoBox.Visible = false;
                }
            }
            catch
            {
                // En cas d'erreur, masquer les PictureBox
                logoBox.Visible = false;
                aboutLogoBox.Visible = false;
            }
        }

        private void LoadFlagImages()
        {
            try
            {
                // Charger les images des drapeaux
                picFrenchFlag.Image = FlagImages.CreateFrenchFlag();
                picEnglishFlag.Image = FlagImages.CreateBritishFlag();

                // S'assurer que les boutons de langues sont au-dessus des panneaux
                btnLanguageFlag.BringToFront();
                picFrenchFlag.BringToFront();
                picEnglishFlag.BringToFront();

                // Le drapeau principal sera mis à jour dans UpdateLanguage()
            }
            catch
            {
                // En cas d'erreur, ne rien faire - les PictureBox resteront vides
            }
        }

        private void CheckAdministratorRights()
        {
            try
            {
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                bool isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);

                if (isAdmin)
                {
                    // Pas de texte de statut pour le mode administrateur
                    statusLabel.Text = "";
                    this.Text = LanguageManager.IsEnglish ? "BeeOptimizer - Minecraft Optimizer" : "BeeOptimizer - Optimiseur Minecraft";
                }
                else
                {
                    statusLabel.Text = LanguageManager.AdminRequiredError;
                    statusLabel.ForeColor = Color.FromArgb(244, 67, 54);

                    MessageBox.Show("🔒 ERREUR : Droits administrateur requis !\n\n" +
                                  "BeeOptimizer nécessite les droits administrateur pour fonctionner correctement.\n\n" +
                                  "Pour résoudre ce problème :\n" +
                                  "1. Fermez cette application\n" +
                                  "2. Clic droit sur BeeOptimizer.exe\n" +
                                  "3. Sélectionnez 'Exécuter en tant qu'administrateur'\n\n" +
                                  "L'application va maintenant se fermer.",
                                  "BeeOptimizer - Erreur de permissions",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = LanguageManager.CheckRightsError;
                statusLabel.ForeColor = Color.FromArgb(244, 67, 54);
                MessageBox.Show(LanguageManager.ErrorMessage("Vérification des droits administrateur : " + ex.Message),
                    LanguageManager.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCleanTemp_Click(object sender, EventArgs e)
        {
            try
            {
                statusLabel.Text = LanguageManager.CleaningInProgress;
                statusLabel.ForeColor = Color.FromArgb(255, 152, 0);
                Application.DoEvents();

                long totalDeleted = 0;
                int filesDeleted = 0;

                // Nettoyer le dossier temp de l'utilisateur
                string userTempPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp");
                var userResult = CleanTempDirectory(userTempPath);
                totalDeleted += userResult.size;
                filesDeleted += userResult.files;

                // Nettoyer le dossier temp système
                string systemTempPath = @"C:\Windows\Temp";
                var systemResult = CleanTempDirectory(systemTempPath);
                totalDeleted += systemResult.size;
                filesDeleted += systemResult.files;

                // Afficher le résultat
                string sizeText = FormatBytes(totalDeleted);
                statusLabel.Text = LanguageManager.FilesDeleted(filesDeleted, sizeText);
                statusLabel.ForeColor = Color.FromArgb(76, 175, 80);

                MessageBox.Show(LanguageManager.CleanupCompleteMessage(filesDeleted, sizeText),
                    LanguageManager.CleanupCompleteTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                statusLabel.Text = LanguageManager.CleaningError;
                statusLabel.ForeColor = Color.FromArgb(244, 67, 54);
                MessageBox.Show(LanguageManager.ErrorMessage(ex.Message), LanguageManager.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private (long size, int files) CleanTempDirectory(string path)
        {
            long totalSize = 0;
            int fileCount = 0;

            try
            {
                if (Directory.Exists(path))
                {
                    foreach (string file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
                    {
                        try
                        {
                            FileInfo fileInfo = new FileInfo(file);
                            totalSize += fileInfo.Length;
                            File.Delete(file);
                            fileCount++;
                        }
                        catch
                        {
                            // Ignorer les fichiers en cours d'utilisation
                        }
                    }

                    // Supprimer les dossiers vides
                    foreach (string dir in Directory.GetDirectories(path, "*", SearchOption.AllDirectories))
                    {
                        try
                        {
                            if (Directory.GetFiles(dir, "*", SearchOption.AllDirectories).Length == 0)
                            {
                                Directory.Delete(dir, true);
                            }
                        }
                        catch
                        {
                            // Ignorer les erreurs
                        }
                    }
                }
            }
            catch
            {
                // Continuer même en cas d'erreur d'accès
            }

            return (totalSize, fileCount);
        }

        private void btnBoostMinecraft_Click(object sender, EventArgs e)
        {
            try
            {
                statusLabel.Text = LanguageManager.SearchingMinecraft;
                statusLabel.ForeColor = Color.FromArgb(255, 152, 0);
                Application.DoEvents();

                // Rechercher les processus Minecraft
                Process[] minecraftProcesses = Process.GetProcessesByName("javaw")
                    .Concat(Process.GetProcessesByName("java"))
                    .Where(p => p.MainWindowTitle.Contains("Minecraft") ||
                               p.ProcessName.Contains("minecraft") ||
                               IsMinecraftProcess(p))
                    .ToArray();

                if (minecraftProcesses.Length == 0)
                {
                    statusLabel.Text = LanguageManager.MinecraftNotFound;
                    statusLabel.ForeColor = Color.FromArgb(244, 67, 54);
                    MessageBox.Show(LanguageManager.MinecraftNotFoundMessage,
                        LanguageManager.CleanupCompleteTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int boostedProcesses = 0;
                foreach (Process process in minecraftProcesses)
                {
                    try
                    {
                        process.PriorityClass = ProcessPriorityClass.RealTime;
                        boostedProcesses++;
                    }
                    catch
                    {
                        // Essayer avec High priority si RealTime échoue
                        try
                        {
                            process.PriorityClass = ProcessPriorityClass.High;
                            boostedProcesses++;
                        }
                        catch
                        {
                            // Ignorer si l'accès est refusé
                        }
                    }
                }

                if (boostedProcesses > 0)
                {
                    statusLabel.Text = LanguageManager.MinecraftOptimized(boostedProcesses);
                    statusLabel.ForeColor = Color.FromArgb(76, 175, 80);
                    MessageBox.Show(LanguageManager.MinecraftOptimizedMessage(boostedProcesses),
                        LanguageManager.CleanupCompleteTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    statusLabel.Text = LanguageManager.CannotOptimizeMinecraft;
                    statusLabel.ForeColor = Color.FromArgb(244, 67, 54);
                    MessageBox.Show(LanguageManager.CannotOptimizeMessage,
                        LanguageManager.CleanupCompleteTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = LanguageManager.CleaningError;
                statusLabel.ForeColor = Color.FromArgb(244, 67, 54);
                MessageBox.Show(LanguageManager.ErrorMessage(ex.Message), LanguageManager.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsMinecraftProcess(Process process)
        {
            try
            {
                string commandLine = GetCommandLine(process);
                return commandLine.Contains("minecraft") ||
                       commandLine.Contains("net.minecraft") ||
                       commandLine.Contains("MinecraftLauncher");
            }
            catch
            {
                return false;
            }
        }

        private string GetCommandLine(Process process)
        {
            try
            {
                using (var searcher = new System.Management.ManagementObjectSearcher(
                    $"SELECT CommandLine FROM Win32_Process WHERE ProcessId = {process.Id}"))
                {
                    foreach (System.Management.ManagementObject obj in searcher.Get())
                    {
                        return obj["CommandLine"]?.ToString() ?? "";
                    }
                }
            }
            catch
            {
                return "";
            }
            return "";
        }

        private string FormatBytes(long bytes)
        {
            if (bytes >= 1073741824) // GB
                return $"{bytes / 1073741824.0:F1} GB";
            else if (bytes >= 1048576) // MB
                return $"{bytes / 1048576.0:F1} MB";
            else if (bytes >= 1024) // KB
                return $"{bytes / 1024.0:F1} KB";
            else
                return $"{bytes} bytes";
        }

        private void minecraftTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAboutSmall_Click(object sender, EventArgs e)
        {
            ShowAboutPage();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void ShowHomePage()
        {
            HideLanguageMenu();
            homePagePanel.Visible = true;
            aboutPagePanel.Visible = false;
            homePagePanel.BringToFront();
            
            // S'assurer que les boutons de langue restent visibles
            btnLanguageFlag.BringToFront();
            picFrenchFlag.BringToFront();
            picEnglishFlag.BringToFront();
        }

        private void ShowAboutPage()
        {
            HideLanguageMenu();
            aboutPagePanel.Visible = true;
            homePagePanel.Visible = false;
            aboutPagePanel.BringToFront();
            
            // S'assurer que les boutons de langue restent visibles
            btnLanguageFlag.BringToFront();
            picFrenchFlag.BringToFront();
            picEnglishFlag.BringToFront();
        }

        private void btnLanguageFlag_Click(object sender, EventArgs e)
        {
            ToggleLanguageMenu();
        }

        private void btnFrenchFlag_Click(object sender, EventArgs e)
        {
            LanguageManager.SetLanguage(false); // French
            UpdateLanguage();
            HideLanguageMenu();
        }

        private void btnEnglishFlag_Click(object sender, EventArgs e)
        {
            LanguageManager.SetLanguage(true); // English
            UpdateLanguage();
            HideLanguageMenu();
        }

        private void ToggleLanguageMenu()
        {
            if (languageMenuVisible)
            {
                HideLanguageMenu();
            }
            else
            {
                ShowLanguageMenu();
            }
        }

        private void ShowLanguageMenu()
        {
            picFrenchFlag.Visible = true;
            picEnglishFlag.Visible = true;
            btnLanguageFlag.BringToFront();
            picFrenchFlag.BringToFront();
            picEnglishFlag.BringToFront();
            languageMenuVisible = true;
        }

        private void HideLanguageMenu()
        {
            picFrenchFlag.Visible = false;
            picEnglishFlag.Visible = false;
            languageMenuVisible = false;
        }

        private void UpdateLanguage()
        {
            // Mettre à jour le bouton de langue principal avec la bonne image
            btnLanguageFlag.Image = LanguageManager.IsEnglish ?
                FlagImages.CreateBritishFlag() :
                FlagImages.CreateFrenchFlag();

            // Page d'accueil
            titleLabel.Text = LanguageManager.Title;
            subtitleLabel.Text = LanguageManager.Subtitle;
            homeVersionLabel.Text = LanguageManager.AboutVersion;
            tempFilesTitle.Text = LanguageManager.CleanFilesTitle;
            tempFilesDesc.Text = LanguageManager.CleanFilesDesc;
            btnCleanTemp.Text = LanguageManager.CleanFilesButton;
            minecraftTitle.Text = LanguageManager.BoostMinecraftTitle;
            minecraftDesc.Text = LanguageManager.BoostMinecraftDesc;
            btnBoostMinecraft.Text = LanguageManager.BoostMinecraftButton;
            btnAboutSmall.Text = LanguageManager.AboutButton;
            // Garder la barre de statut vide par défaut (sauf si une action est en cours)
            if (statusLabel.Text == "Prêt pour l'optimisation" || statusLabel.Text == "Ready for optimization" || statusLabel.Text.Contains("Mode Administrateur") || statusLabel.Text.Contains("Administrator mode"))
            {
                statusLabel.Text = "";
            }

            // Page À propos
            aboutTitleLabel.Text = LanguageManager.AboutTitle;
            aboutVersionLabel.Text = LanguageManager.AboutVersion;
            aboutDescLabel.Text = LanguageManager.AboutDesc;
            aboutFeaturesLabel.Text = LanguageManager.AboutFeatures;
            aboutDevLabel.Text = LanguageManager.AboutDev;
            btnBackHome.Text = LanguageManager.HomeButton;

            // Mettre à jour le titre de la fenêtre
            this.Text = LanguageManager.IsEnglish ? "BeeOptimizer - Minecraft Optimizer" : "BeeOptimizer - Optimiseur Minecraft";
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
