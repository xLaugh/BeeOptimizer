# 🐝 BeeOptimizer

**Optimiseur Minecraft pour améliorer vos performances de jeu**

![Version](https://img.shields.io/badge/version-0.0.1-yellow.svg)
![Platform](https://img.shields.io/badge/platform-Windows-blue.svg)
![.NET](https://img.shields.io/badge/.NET-8.0-purple.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

## ✨ Fonctionnalités

- 🗑️ **Nettoyage automatique des fichiers temporaires**
  - Supprime les fichiers temporaires de `%TEMP%` et `C:\Windows\Temp`
  - Affichage de l'espace libéré en temps réel
  
- ⚡ **Optimisation de Minecraft**
  - Détection automatique des processus Minecraft
  - Augmentation de la priorité à "Temps réel" pour de meilleures performances
  
- 🌍 **Support multilingue**
  - Interface en Français et Anglais
  - Détection automatique de la langue système

## 🚀 Installation

### Prérequis
- Windows 10/11
- .NET 8.0 Runtime
- Droits administrateur

### Téléchargement
1. Allez dans la section [Releases](https://github.com/xLaugh/BeeOptimizer/releases)
2. Téléchargez la dernière version `BeeOptimizer.exe`
3. **Clic droit** → **Exécuter en tant qu'administrateur**

### Compilation depuis les sources
```bash
git clone https://github.com/xLaugh/BeeOptimizer.git
cd BeeOptimizer
dotnet restore
dotnet build --configuration Release
```

## 📖 Utilisation

1. **Lancez l'application en tant qu'administrateur**
2. **Nettoyage des fichiers temporaires** :
   - Cliquez sur "Supprimer les fichiers temporaires"
   - L'application supprime automatiquement les fichiers inutiles
   - Visualisez l'espace libéré
   
3. **Optimisation Minecraft** :
   - Lancez Minecraft
   - Cliquez sur "Augmenter l'utilisation Minecraft"
   - Les processus Minecraft passent en priorité temps réel
   
4. **Changement de langue** :
   - Cliquez sur le drapeau en bas à droite
   - Sélectionnez votre langue préférée

### Comment contribuer :
1. Fork le projet
2. Créez une branche pour votre fonctionnalité (`git checkout -b feature/NouvelleFonctionnalite`)
3. Committez vos changements (`git commit -m 'Ajouter NouvelleFonctionnalite'`)
4. Push vers la branche (`git push origin feature/NouvelleFonctionnalite`)
5. Ouvrez une Pull Request

## 📄 Licence

Ce projet est sous licence MIT. Voir le fichier [LICENSE](LICENSE) pour plus de détails.

## ⚠️ Avertissement

BeeOptimizer nécessite les droits administrateur pour modifier les priorités des processus et accéder aux dossiers système. Utilisez uniquement sur des systèmes de confiance.

