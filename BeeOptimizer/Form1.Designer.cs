namespace BeeOptimizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            homePagePanel = new Panel();
            logoBox = new PictureBox();
            titleLabel = new Label();
            subtitleLabel = new Label();
            homeVersionLabel = new Label();
            tempFilesPanel = new Panel();
            tempFilesIcon = new Label();
            tempFilesTitle = new Label();
            tempFilesDesc = new Label();
            btnCleanTemp = new Button();
            minecraftPanel = new Panel();
            minecraftIcon = new Label();
            minecraftTitle = new Label();
            minecraftDesc = new Label();
            btnBoostMinecraft = new Button();
            statusLabel = new Label();
            btnAboutSmall = new Button();
            btnLanguageFlag = new PictureBox();
            picFrenchFlag = new PictureBox();
            picEnglishFlag = new PictureBox();
            aboutPagePanel = new Panel();
            aboutLogoBox = new PictureBox();
            aboutTitleLabel = new Label();
            aboutVersionLabel = new Label();
            aboutDescLabel = new Label();
            aboutFeaturesLabel = new Label();
            aboutDevLabel = new Label();
            btnBackHome = new Button();
            homePagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            tempFilesPanel.SuspendLayout();
            minecraftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLanguageFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFrenchFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEnglishFlag).BeginInit();
            aboutPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)aboutLogoBox).BeginInit();
            SuspendLayout();
            // 
            // homePagePanel
            // 
            homePagePanel.BackColor = Color.FromArgb(255, 248, 220);
            homePagePanel.Controls.Add(logoBox);
            homePagePanel.Controls.Add(titleLabel);
            homePagePanel.Controls.Add(subtitleLabel);
            homePagePanel.Controls.Add(homeVersionLabel);
            homePagePanel.Controls.Add(tempFilesPanel);
            homePagePanel.Controls.Add(minecraftPanel);
            homePagePanel.Controls.Add(statusLabel);
            homePagePanel.Controls.Add(btnAboutSmall);
            homePagePanel.Dock = DockStyle.Fill;
            homePagePanel.Location = new Point(0, 0);
            homePagePanel.Name = "homePagePanel";
            homePagePanel.Size = new Size(800, 320);
            homePagePanel.TabIndex = 0;
            // 
            // logoBox
            // 
            logoBox.Location = new Point(50, 25);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(80, 80);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 8;
            logoBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(51, 51, 51);
            titleLabel.Location = new Point(150, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(267, 51);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "BeeOptimizer";
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 12F);
            subtitleLabel.ForeColor = Color.FromArgb(102, 102, 102);
            subtitleLabel.Location = new Point(150, 76);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(268, 21);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Optimisez votre expérience Minecraft";
            // 
            // homeVersionLabel
            // 
            homeVersionLabel.AutoSize = true;
            homeVersionLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            homeVersionLabel.ForeColor = Color.FromArgb(255, 193, 7);
            homeVersionLabel.Location = new Point(450, 50);
            homeVersionLabel.Name = "homeVersionLabel";
            homeVersionLabel.Size = new Size(100, 20);
            homeVersionLabel.TabIndex = 2;
            homeVersionLabel.Text = "Version 0.0.1";
            // 
            // tempFilesPanel
            // 
            tempFilesPanel.BackColor = Color.FromArgb(255, 252, 230);
            tempFilesPanel.BorderStyle = BorderStyle.FixedSingle;
            tempFilesPanel.Controls.Add(tempFilesIcon);
            tempFilesPanel.Controls.Add(tempFilesTitle);
            tempFilesPanel.Controls.Add(tempFilesDesc);
            tempFilesPanel.Controls.Add(btnCleanTemp);
            tempFilesPanel.Location = new Point(80, 120);
            tempFilesPanel.Name = "tempFilesPanel";
            tempFilesPanel.Size = new Size(280, 150);
            tempFilesPanel.TabIndex = 2;
            // 
            // tempFilesIcon
            // 
            tempFilesIcon.AutoSize = true;
            tempFilesIcon.Font = new Font("Segoe UI", 20F);
            tempFilesIcon.ForeColor = Color.FromArgb(255, 152, 0);
            tempFilesIcon.Location = new Point(15, 15);
            tempFilesIcon.Name = "tempFilesIcon";
            tempFilesIcon.Size = new Size(54, 37);
            tempFilesIcon.TabIndex = 0;
            tempFilesIcon.Text = "🗑️";
            // 
            // tempFilesTitle
            // 
            tempFilesTitle.AutoSize = true;
            tempFilesTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tempFilesTitle.ForeColor = Color.FromArgb(64, 64, 64);
            tempFilesTitle.Location = new Point(72, 20);
            tempFilesTitle.Name = "tempFilesTitle";
            tempFilesTitle.Size = new Size(163, 21);
            tempFilesTitle.TabIndex = 1;
            tempFilesTitle.Text = "Nettoyer les fichiers";
            // 
            // tempFilesDesc
            // 
            tempFilesDesc.Font = new Font("Segoe UI", 9F);
            tempFilesDesc.ForeColor = Color.FromArgb(128, 128, 128);
            tempFilesDesc.Location = new Point(15, 55);
            tempFilesDesc.Name = "tempFilesDesc";
            tempFilesDesc.Size = new Size(250, 40);
            tempFilesDesc.TabIndex = 2;
            tempFilesDesc.Text = "Supprime les fichiers temporaires système pour libérer de l'espace disque.";
            // 
            // btnCleanTemp
            // 
            btnCleanTemp.BackColor = Color.FromArgb(255, 193, 7);
            btnCleanTemp.FlatAppearance.BorderSize = 0;
            btnCleanTemp.FlatStyle = FlatStyle.Flat;
            btnCleanTemp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCleanTemp.ForeColor = Color.FromArgb(51, 51, 51);
            btnCleanTemp.Location = new Point(15, 105);
            btnCleanTemp.Name = "btnCleanTemp";
            btnCleanTemp.Size = new Size(250, 35);
            btnCleanTemp.TabIndex = 3;
            btnCleanTemp.Text = "Supprimer fichiers temporaires";
            btnCleanTemp.UseVisualStyleBackColor = false;
            btnCleanTemp.Click += btnCleanTemp_Click;
            // 
            // minecraftPanel
            // 
            minecraftPanel.BackColor = Color.FromArgb(255, 252, 230);
            minecraftPanel.BorderStyle = BorderStyle.FixedSingle;
            minecraftPanel.Controls.Add(minecraftIcon);
            minecraftPanel.Controls.Add(minecraftTitle);
            minecraftPanel.Controls.Add(minecraftDesc);
            minecraftPanel.Controls.Add(btnBoostMinecraft);
            minecraftPanel.Location = new Point(380, 120);
            minecraftPanel.Name = "minecraftPanel";
            minecraftPanel.Size = new Size(280, 150);
            minecraftPanel.TabIndex = 3;
            // 
            // minecraftIcon
            // 
            minecraftIcon.AutoSize = true;
            minecraftIcon.Font = new Font("Segoe UI", 20F);
            minecraftIcon.ForeColor = Color.FromArgb(76, 175, 80);
            minecraftIcon.Location = new Point(15, 15);
            minecraftIcon.Name = "minecraftIcon";
            minecraftIcon.Size = new Size(54, 37);
            minecraftIcon.TabIndex = 0;
            minecraftIcon.Text = "⚡";
            // 
            // minecraftTitle
            // 
            minecraftTitle.AutoSize = true;
            minecraftTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            minecraftTitle.ForeColor = Color.FromArgb(64, 64, 64);
            minecraftTitle.Location = new Point(69, 20);
            minecraftTitle.Name = "minecraftTitle";
            minecraftTitle.Size = new Size(146, 21);
            minecraftTitle.TabIndex = 1;
            minecraftTitle.Text = "Booster Minecraft";
            minecraftTitle.Click += minecraftTitle_Click;
            // 
            // minecraftDesc
            // 
            minecraftDesc.Font = new Font("Segoe UI", 9F);
            minecraftDesc.ForeColor = Color.FromArgb(128, 128, 128);
            minecraftDesc.Location = new Point(15, 55);
            minecraftDesc.Name = "minecraftDesc";
            minecraftDesc.Size = new Size(250, 40);
            minecraftDesc.TabIndex = 2;
            minecraftDesc.Text = "Augmente la priorité de Minecraft pour améliorer les performances et réduire les lags.";
            // 
            // btnBoostMinecraft
            // 
            btnBoostMinecraft.BackColor = Color.FromArgb(255, 193, 7);
            btnBoostMinecraft.FlatAppearance.BorderSize = 0;
            btnBoostMinecraft.FlatStyle = FlatStyle.Flat;
            btnBoostMinecraft.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBoostMinecraft.ForeColor = Color.FromArgb(51, 51, 51);
            btnBoostMinecraft.Location = new Point(15, 105);
            btnBoostMinecraft.Name = "btnBoostMinecraft";
            btnBoostMinecraft.Size = new Size(250, 35);
            btnBoostMinecraft.TabIndex = 3;
            btnBoostMinecraft.Text = "Augmenter priorité Minecraft";
            btnBoostMinecraft.UseVisualStyleBackColor = false;
            btnBoostMinecraft.Click += btnBoostMinecraft_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 9F);
            statusLabel.ForeColor = Color.FromArgb(128, 128, 128);
            statusLabel.Location = new Point(50, 285);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(132, 15);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Prêt pour l'optimisation";
            statusLabel.Click += statusLabel_Click;
            // 
            // btnAboutSmall
            // 
            btnAboutSmall.BackColor = Color.FromArgb(255, 193, 7);
            btnAboutSmall.FlatAppearance.BorderSize = 0;
            btnAboutSmall.FlatStyle = FlatStyle.Flat;
            btnAboutSmall.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAboutSmall.ForeColor = Color.FromArgb(51, 51, 51);
            btnAboutSmall.Location = new Point(720, 10);
            btnAboutSmall.Name = "btnAboutSmall";
            btnAboutSmall.Size = new Size(70, 25);
            btnAboutSmall.TabIndex = 6;
            btnAboutSmall.Text = "À propos";
            btnAboutSmall.UseVisualStyleBackColor = false;
            btnAboutSmall.Click += btnAboutSmall_Click;
            // 
            // btnLanguageFlag
            // 
            btnLanguageFlag.BackColor = Color.Transparent;
            btnLanguageFlag.Cursor = Cursors.Hand;
            btnLanguageFlag.Location = new Point(765, 290);
            btnLanguageFlag.Name = "btnLanguageFlag";
            btnLanguageFlag.Size = new Size(30, 20);
            btnLanguageFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLanguageFlag.TabIndex = 14;
            btnLanguageFlag.TabStop = false;
            btnLanguageFlag.Click += btnLanguageFlag_Click;
            // 
            // picFrenchFlag
            // 
            picFrenchFlag.BackColor = Color.Transparent;
            picFrenchFlag.Cursor = Cursors.Hand;
            picFrenchFlag.Location = new Point(765, 260);
            picFrenchFlag.Name = "picFrenchFlag";
            picFrenchFlag.Size = new Size(30, 20);
            picFrenchFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            picFrenchFlag.TabIndex = 15;
            picFrenchFlag.TabStop = false;
            picFrenchFlag.Visible = false;
            picFrenchFlag.Click += btnFrenchFlag_Click;
            // 
            // picEnglishFlag
            // 
            picEnglishFlag.BackColor = Color.Transparent;
            picEnglishFlag.Cursor = Cursors.Hand;
            picEnglishFlag.Location = new Point(765, 230);
            picEnglishFlag.Name = "picEnglishFlag";
            picEnglishFlag.Size = new Size(30, 20);
            picEnglishFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            picEnglishFlag.TabIndex = 16;
            picEnglishFlag.TabStop = false;
            picEnglishFlag.Visible = false;
            picEnglishFlag.Click += btnEnglishFlag_Click;
            // 
            // aboutPagePanel
            // 
            aboutPagePanel.BackColor = Color.FromArgb(255, 248, 220);
            aboutPagePanel.Controls.Add(aboutLogoBox);
            aboutPagePanel.Controls.Add(aboutTitleLabel);
            aboutPagePanel.Controls.Add(aboutVersionLabel);
            aboutPagePanel.Controls.Add(aboutDescLabel);
            aboutPagePanel.Controls.Add(aboutFeaturesLabel);
            aboutPagePanel.Controls.Add(aboutDevLabel);
            aboutPagePanel.Controls.Add(btnBackHome);
            aboutPagePanel.Dock = DockStyle.Fill;
            aboutPagePanel.Location = new Point(0, 0);
            aboutPagePanel.Name = "aboutPagePanel";
            aboutPagePanel.Size = new Size(800, 320);
            aboutPagePanel.TabIndex = 1;
            aboutPagePanel.Visible = false;
            // 
            // aboutLogoBox
            // 
            aboutLogoBox.Location = new Point(50, 25);
            aboutLogoBox.Name = "aboutLogoBox";
            aboutLogoBox.Size = new Size(80, 80);
            aboutLogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            aboutLogoBox.TabIndex = 8;
            aboutLogoBox.TabStop = false;
            // 
            // aboutTitleLabel
            // 
            aboutTitleLabel.AutoSize = true;
            aboutTitleLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            aboutTitleLabel.ForeColor = Color.FromArgb(51, 51, 51);
            aboutTitleLabel.Location = new Point(150, 25);
            aboutTitleLabel.Name = "aboutTitleLabel";
            aboutTitleLabel.Size = new Size(267, 51);
            aboutTitleLabel.TabIndex = 9;
            aboutTitleLabel.Text = "BeeOptimizer";
            // 
            // aboutVersionLabel
            // 
            aboutVersionLabel.AutoSize = true;
            aboutVersionLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            aboutVersionLabel.ForeColor = Color.FromArgb(255, 193, 7);
            aboutVersionLabel.Location = new Point(430, 50);
            aboutVersionLabel.Name = "aboutVersionLabel";
            aboutVersionLabel.Size = new Size(100, 20);
            aboutVersionLabel.TabIndex = 10;
            aboutVersionLabel.Text = "Version 0.0.1";
            // 
            // aboutDescLabel
            // 
            aboutDescLabel.Font = new Font("Segoe UI", 10F);
            aboutDescLabel.ForeColor = Color.FromArgb(102, 102, 102);
            aboutDescLabel.Location = new Point(50, 110);
            aboutDescLabel.Name = "aboutDescLabel";
            aboutDescLabel.Size = new Size(700, 25);
            aboutDescLabel.TabIndex = 11;
            aboutDescLabel.Text = "Optimiseur de performance spécialement conçu pour améliorer votre expérience Minecraft.";
            // 
            // aboutFeaturesLabel
            // 
            aboutFeaturesLabel.Font = new Font("Segoe UI", 9F);
            aboutFeaturesLabel.ForeColor = Color.FromArgb(64, 64, 64);
            aboutFeaturesLabel.Location = new Point(50, 150);
            aboutFeaturesLabel.Name = "aboutFeaturesLabel";
            aboutFeaturesLabel.Size = new Size(350, 100);
            aboutFeaturesLabel.TabIndex = 12;
            aboutFeaturesLabel.Text = "🛠️ Fonctionnalités :\n• Nettoyage des fichiers temporaires\n• Optimisation des processus Minecraft\n• Interface moderne et intuitive\n• Droits administrateur requis";
            // 
            // aboutDevLabel
            // 
            aboutDevLabel.Font = new Font("Segoe UI", 9F);
            aboutDevLabel.ForeColor = Color.FromArgb(64, 64, 64);
            aboutDevLabel.Location = new Point(420, 150);
            aboutDevLabel.Name = "aboutDevLabel";
            aboutDevLabel.Size = new Size(300, 100);
            aboutDevLabel.TabIndex = 13;
            aboutDevLabel.Text = "Dev par Laugh";
            // 
            // btnBackHome
            // 
            btnBackHome.BackColor = Color.FromArgb(255, 193, 7);
            btnBackHome.FlatAppearance.BorderSize = 0;
            btnBackHome.FlatStyle = FlatStyle.Flat;
            btnBackHome.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnBackHome.ForeColor = Color.FromArgb(51, 51, 51);
            btnBackHome.Location = new Point(720, 10);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(70, 25);
            btnBackHome.TabIndex = 7;
            btnBackHome.Text = "🏠 Accueil";
            btnBackHome.UseVisualStyleBackColor = false;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 220);
            ClientSize = new Size(800, 320);
            Controls.Add(homePagePanel);
            Controls.Add(aboutPagePanel);
            Controls.Add(btnLanguageFlag);
            Controls.Add(picFrenchFlag);
            Controls.Add(picEnglishFlag);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BeeOptimizer - Optimiseur Minecraft";
            homePagePanel.ResumeLayout(false);
            homePagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            tempFilesPanel.ResumeLayout(false);
            tempFilesPanel.PerformLayout();
            minecraftPanel.ResumeLayout(false);
            minecraftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnLanguageFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFrenchFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEnglishFlag).EndInit();
            aboutPagePanel.ResumeLayout(false);
            aboutPagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)aboutLogoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel homePagePanel;
        private System.Windows.Forms.Panel aboutPagePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Panel tempFilesPanel;
        private System.Windows.Forms.Label tempFilesIcon;
        private System.Windows.Forms.Label tempFilesTitle;
        private System.Windows.Forms.Label tempFilesDesc;
        private System.Windows.Forms.Button btnCleanTemp;
        private System.Windows.Forms.Panel minecraftPanel;
        private System.Windows.Forms.Label minecraftIcon;
        private System.Windows.Forms.Label minecraftTitle;
        private System.Windows.Forms.Label minecraftDesc;
        private System.Windows.Forms.Button btnBoostMinecraft;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button btnAboutSmall;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Label aboutTitleLabel;
        private System.Windows.Forms.Label aboutVersionLabel;
        private System.Windows.Forms.Label aboutDescLabel;
        private System.Windows.Forms.Label aboutFeaturesLabel;
        private System.Windows.Forms.Label aboutDevLabel;
        private System.Windows.Forms.PictureBox aboutLogoBox;
        private System.Windows.Forms.PictureBox btnLanguageFlag;
        private System.Windows.Forms.PictureBox picFrenchFlag;
        private System.Windows.Forms.PictureBox picEnglishFlag;
        private System.Windows.Forms.Label homeVersionLabel;
    }
}