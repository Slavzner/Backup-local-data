using System;
using System.IO;
using System.Threading;

namespace ClassLibrary_BackupMechanism
{
    /// <summary>
    /// Mechanism for Backup data
    /// </summary>
    public class BackupMechanism
    {
        private string SYMBOL = "";
        public bool flagSuccess = false;

        public int fileCount { get; set; }

        //public bool flagSuccess { get; set; }
        public string source { get; set; }

        public string target { get; set; }

        public BackupMechanism(string source, string target)
        {
            this.source = source;
            this.target = target;
            fileCount = 0;
        }

        /// <summary>
        /// Copy all data from source to target
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public void copyData()
        {
            copyData(source, target);
        }

        private void copyData(string source, string target)
        {
            if (Directory.Exists(source))
            {
                // Debug.Assert(source == SYMBOL && target == SYMBOL, "Invalid Paths!");
                if (source != SYMBOL && target != SYMBOL)
                {
                    try
                    {
                        // If directory from target exist in source don`t copy(BUG)

                        // Create all of the directories
                        foreach (string dirPath in Directory.EnumerateDirectories(source, "*",
                            SearchOption.AllDirectories))
                        {
                            if (!dirPath.Equals(target))
                            {
                                Directory.CreateDirectory(dirPath.Replace(source, target));
                            }
                        }
                    }
                    catch
                    {
                        flagSuccess = false;
                    }
                    try
                    {
                        // Copy all the files & Replaces any files with the same name
                        foreach (string newPath in Directory.EnumerateFiles(source, "*.*",
                        SearchOption.AllDirectories))
                        {
                            File.Copy(newPath, newPath.Replace(source, target), true);
                            fileCount++;
                            Thread.Sleep(500);
                        }
                    }
                    catch
                    {
                        flagSuccess = false;
                    }
                    flagSuccess = true; ;
                }
                else
                {
                    flagSuccess = false;
                }
            }
            else
            {
                flagSuccess = false;
            }
        }
    }
}

    
