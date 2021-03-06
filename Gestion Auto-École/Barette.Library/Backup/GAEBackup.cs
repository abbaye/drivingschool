﻿using System.IO;
using System.Threading;
using ICSharpCode.SharpZipLib.Zip;


namespace Barette.Library.Backup {
    public enum TauxCompression {
        Storage = 1,
        Bas = 3,
        Moyen = 4,
        Haute= 7,
        Maximum = 9
    }


    public class GAEBackup {

        /// <summary>
        /// Compresse un répertoire au format zip. Le taux de compression est par défaut au maximum
        /// </summary>
        /// <param name="InPath">Dossier d'entré</param>
        /// <param name="OutPath">Fichier zip de sorti</param>
        public static void CompressFolder(string InPath, string OutPath) {
            CompressFolder(InPath, OutPath, TauxCompression.Maximum, false);            
        }

        /// <summary>
        /// Compresse un répertoire au format zip
        /// </summary>
        /// <param name="InPath">Dossier d'entré</param>
        /// <param name="OutPath">Fichier zip de sorti</param>
        /// <param name="CompressionLevel">Taux de compression
        /// 0 -> Compression minimale 
        /// 9 -> Compression maximale  </param>
        public static void CompressFolder(string InPath, string OutPath, TauxCompression CompressionLevel) {
            CompressFolder(InPath, OutPath, CompressionLevel, false);
        }

        /// <summary>
        /// Compresse un répertoire au format zip
        /// Il est possible d'afficher une barre de progression
        /// </summary>
        /// <param name="InPath">Dossier d'entré</param>
        /// <param name="OutPath">Fichier zip de sorti</param>
        /// <param name="CompressionLevel">Taux de compression
        /// 0 -> Compression minimale 
        /// 9 -> Compression maximale  </param>
        /// <param name="ShowProgressWindows">Si true, une fenêtre de progression apparaitera</param>
        public static void CompressFolder(string InPath, string OutPath, TauxCompression CompressionLevel, bool ShowProgressWindows) {
            string[] files = Directory.GetFiles(InPath);
            string ZipName = OutPath;
            FormBackupProgress FormBackup = null;

            // Flux qui va créer l'archive 
            ZipOutputStream ZipStream = new ZipOutputStream(File.Create(ZipName));

            ZipStream.SetLevel((int)CompressionLevel);

            if (ShowProgressWindows) {
                FormBackup = new FormBackupProgress(0, files.Length);
                FormBackup.Show();
                FormBackup.SetActualValue = 0;
                Thread.Yield();
            }
                        
            // Pour chaque fichier
            int i = 0;
            foreach (string file in files) {                
                if (FormBackup != null) {
                    i++;
                    FormBackup.SetActualValue = i;
                    Thread.Yield();
                }

                // On récupère le chemin + nom du fichier 
                string file_tozip = file;

                // Stream qui va lire le fichier 
                FileStream fs = File.OpenRead(file_tozip);
                // Tableau de byte, de la taille du fichier à lire 
                byte[] buffer = new byte[fs.Length];
                // Lecture 
                fs.Read(buffer, 0, buffer.Length);
                // On    crée une nouvelle entrée dans l'archive 
                ZipEntry entry = new ZipEntry(Path.GetFileName(file_tozip));
                // On ajoute la nouvelle entrée 
                ZipStream.PutNextEntry(entry);
                ZipStream.Write(buffer, 0, buffer.Length);

                //On ferme le flux de lecture
                fs.Close();

            }
            // On ferme le flux 
            ZipStream.Finish();
            ZipStream.Close();

            if (FormBackup != null) FormBackup.Close();
        }
    }
}
