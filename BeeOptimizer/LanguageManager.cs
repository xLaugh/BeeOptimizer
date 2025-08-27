using System.Globalization;

namespace BeeOptimizer
{
    public static class LanguageManager
    {
        public static bool IsEnglish { get; private set; } = false;

        public static void DetectSystemLanguage()
        {
            string culture = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToLower();
            IsEnglish = culture == "en";
        }

        public static void SetLanguage(bool english)
        {
            IsEnglish = english;
        }

        // Textes pour la page d'accueil
        public static string Title => IsEnglish ? "BeeOptimizer" : "BeeOptimizer";
        public static string Subtitle => IsEnglish ? "Optimize your Minecraft experience" : "Optimisez votre expérience Minecraft";
        public static string CleanFilesTitle => IsEnglish ? "Clean Files" : "Nettoyer les fichiers";
        public static string CleanFilesDesc => IsEnglish ? "Remove system temporary files to free disk space." : "Supprime les fichiers temporaires système pour libérer de l'espace disque.";
        public static string CleanFilesButton => IsEnglish ? "Delete temporary files" : "Supprimer fichiers temporaires";
        public static string BoostMinecraftTitle => IsEnglish ? "Boost Minecraft" : "Booster Minecraft";
        public static string BoostMinecraftDesc => IsEnglish ? "Increase Minecraft priority to improve performance and reduce lag." : "Augmente la priorité de Minecraft pour améliorer les performances et réduire les lags.";
        public static string BoostMinecraftButton => IsEnglish ? "Increase Minecraft priority" : "Augmenter priorité Minecraft";
        public static string AboutButton => IsEnglish ? "About" : "À propos";
        // Statut supprimé - pas de texte par défaut

        // Textes pour la page À propos
        public static string AboutTitle => IsEnglish ? "BeeOptimizer" : "BeeOptimizer";
        public static string AboutVersion => IsEnglish ? "Version 0.0.1" : "Version 0.0.1";
        public static string AboutDesc => IsEnglish ? "Performance optimizer specially designed to improve your Minecraft experience." : "Optimiseur de performance spécialement conçu pour améliorer votre expérience Minecraft.";
        public static string AboutFeatures => IsEnglish ? 
            "🛠️ Features:\n• Temporary files cleanup\n• Minecraft process optimization\n• Modern and intuitive interface\n• Administrator rights required" :
            "🛠️ Fonctionnalités :\n• Nettoyage des fichiers temporaires\n• Optimisation des processus Minecraft\n• Interface moderne et intuitive\n• Droits administrateur requis";
        public static string AboutDev => IsEnglish ? "Dev by Laugh" : "Dev par Laugh";
        public static string HomeButton => IsEnglish ? "🏠 Home" : "🏠 Accueil";

        // Messages d'état
        public static string CleaningInProgress => IsEnglish ? "Cleaning in progress..." : "Nettoyage en cours...";
        public static string FilesDeleted(int count, string size) => IsEnglish ? 
            $"✅ {count} files deleted ({size} freed)" : 
            $"✅ {count} fichiers supprimés ({size} libérés)";
        public static string CleaningError => IsEnglish ? "❌ Error during cleaning" : "❌ Erreur lors du nettoyage";
        public static string SearchingMinecraft => IsEnglish ? "Searching for Minecraft..." : "Recherche de Minecraft...";
        public static string MinecraftNotFound => IsEnglish ? "❌ Minecraft not found" : "❌ Minecraft non trouvé";
        public static string MinecraftOptimized(int count) => IsEnglish ? 
            $"⚡ {count} Minecraft processes optimized" : 
            $"⚡ {count} processus Minecraft optimisés";
        public static string CannotOptimizeMinecraft => IsEnglish ? "❌ Cannot optimize Minecraft" : "❌ Impossible d'optimiser Minecraft";
        
        // Messages pour les boîtes de dialogue
        public static string CleanupCompleteTitle => IsEnglish ? "BeeOptimizer" : "BeeOptimizer";
        public static string CleanupCompleteMessage(int files, string size) => IsEnglish ?
            $"Cleanup completed successfully!\n\nFiles deleted: {files}\nSpace freed: {size}" :
            $"Nettoyage terminé avec succès !\n\nFichiers supprimés : {files}\nEspace libéré : {size}";
        public static string ErrorTitle => IsEnglish ? "Error" : "Erreur";
        public static string ErrorMessage(string error) => IsEnglish ?
            $"An error occurred:\n{error}" :
            $"Une erreur s'est produite :\n{error}";
        public static string MinecraftNotFoundMessage => IsEnglish ?
            "No Minecraft process detected.\n\nMake sure Minecraft is running." :
            "Aucun processus Minecraft détecté.\n\nAssurez-vous que Minecraft est en cours d'exécution.";
        public static string MinecraftOptimizedMessage(int count) => IsEnglish ?
            $"Priority increased successfully!\n\nOptimized processes: {count}\n\nMinecraft should now run more smoothly." :
            $"Priorité augmentée avec succès !\n\nProcessus optimisés : {count}\n\nMinecraft devrait maintenant fonctionner plus fluidement.";
        public static string CannotOptimizeMessage => IsEnglish ?
            "Unable to modify priority.\n\nTry running BeeOptimizer as administrator." :
            "Impossible de modifier la priorité.\n\nEssayez de lancer BeeOptimizer en tant qu'administrateur.";
        public static string AdminRequiredError => IsEnglish ?
            "⚠️ Error: Administrator rights required!" :
            "⚠️ Erreur : Droits administrateur requis !";
        public static string CheckRightsError => IsEnglish ?
            "❌ Error checking rights" :
            "❌ Erreur lors de la vérification des droits";

        // Textes pour la désactivation des services
        public static string DisableServicesTitle => IsEnglish ? "Disable Services" : "Désactiver les services";
        public static string DisableServicesDesc => IsEnglish ? "Disable unnecessary Windows services to improve performance." : "Désactive les services Windows inutiles pour améliorer les performances.";
        public static string DisableServicesButton => IsEnglish ? "Disable unnecessary services" : "Désactiver services inutiles";
        public static string DisablingServices => IsEnglish ? "Disabling services..." : "Désactivation des services...";
        public static string ServicesDisabled(int count) => IsEnglish ? 
            $"✅ {count} services disabled" : 
            $"✅ {count} services désactivés";
        public static string NoServicesDisabled => IsEnglish ? "❌ No services disabled" : "❌ Aucun service désactivé";
        public static string ServicesError => IsEnglish ? "❌ Error disabling services" : "❌ Erreur lors de la désactivation des services";
        
        public static string ServicesDisabledTitle => IsEnglish ? "Services Disabled" : "Services Désactivés";
        public static string ServicesDisabledMessage(int count, string servicesList) => IsEnglish ?
            $"Services disabled successfully!\n\nDisabled services ({count}):\n• {servicesList}" :
            $"Services désactivés avec succès !\n\nServices désactivés ({count}) :\n• {servicesList}";
        public static string NoServicesDisabledMessage => IsEnglish ?
            "No services were disabled.\n\nThis may be because:\n• Services are already disabled\n• Services don't exist on this system\n• Insufficient permissions" :
            "Aucun service n'a été désactivé.\n\nCela peut être dû à :\n• Les services sont déjà désactivés\n• Les services n'existent pas sur ce système\n• Permissions insuffisantes";
    }
}
