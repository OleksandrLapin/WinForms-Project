﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCombineProject.File_cleaner
{
    public static class Cleaner
    {
        public static void Clean(FileSystemInfo? obj, bool toRecycleBin)
        {
            if (obj != null && obj.Exists)
            {
                if (toRecycleBin)
                {
                    if (obj.GetType() == typeof(DirectoryInfo))
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(obj.FullName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    else if (obj.GetType() == typeof(FileInfo))
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(obj.FullName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
                else
                    obj.Delete();
            }
        }

    }
}
