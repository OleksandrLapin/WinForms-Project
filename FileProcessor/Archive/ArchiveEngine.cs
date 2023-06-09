﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileProcessor.Archive;
using FileProcessor.Archive.Exceptions;


namespace FileCombineProject.Archive
{
    public class ArchiveEngine
    {
        private ICompressor Compressor { get; set; }

        private void SetCompressor(ArchiveEngineMode mode)
        {
            Compressor = mode switch
            {
                ArchiveEngineMode.Zip => new ZipCompressor(),

                _ => new ZipCompressor()
            };
        }

        public ArchiveEngine(ArchiveEngineMode mode = ArchiveEngineMode.Zip)
        {
            SetCompressor(mode);
        }
        public void SetMode(ArchiveEngineMode mode)
        {
            SetCompressor(mode);
        }
        public void CompressDirectory(string path, string destinationPath = "")
        {
            if (!Directory.Exists(path))
                throw new FileProcessor.Archive.Exceptions.DirectoryNotFoundException($"Directory {path} not found");

            if (destinationPath == string.Empty)
                destinationPath = path;

            Compressor.Compress(path, destinationPath);
        }
    }
}
