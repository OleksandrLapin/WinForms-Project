﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor
{
    public class Finder
    {
        private RegexFileAnalyzer regexFileAnalyzer;

        public string[] DirMasks { get; set; } = { };
        public string[] FileMasks { get; set; } = { };
        public ObjectContainer Container { get; set; } = new ObjectContainer();

        public Finder()
        {
            regexFileAnalyzer = new RegexFileAnalyzer();
        }

        public void FindDirectories(string rootPath)
        {
            DirectoryInfo dir = new DirectoryInfo(rootPath);

            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo d in dirs)
            {
                if (DirMasks.Contains(d.Name))
                    Container.Dirs.Add(d);
                else
                    FindDirectories(d.FullName);
            }
        }

        public void FindFilesRecursive(string rootPath)
        {
            DirectoryInfo dir = new DirectoryInfo(rootPath);

            DirectoryInfo[] NestedDirs = dir.GetDirectories();
            FileInfo[] NestedFiles = dir.GetFiles();

            Container.Files.AddRange(regexFileAnalyzer.AnalyzeFiles(NestedFiles, FileMasks));

            foreach (DirectoryInfo d in NestedDirs)
                FindFilesRecursive(d.FullName);
        }

        public void FindFiles(string rootPath)
        {
            DirectoryInfo dir = new DirectoryInfo(rootPath);

            FileInfo[] NestedFiles = dir.GetFiles();

            Container.Files.AddRange(regexFileAnalyzer.AnalyzeFiles(NestedFiles, FileMasks));
        }

        public void FindAll(string rootPath)
        {
            DirectoryInfo dir = new DirectoryInfo(rootPath);

            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();

            Container.Files.AddRange(regexFileAnalyzer.AnalyzeFiles(files, FileMasks));

            foreach (DirectoryInfo d in dirs)
            {
                if (DirMasks.Contains(d.Name))
                {
                    Container.Dirs.Add(d);
                    FindFiles(d.FullName);
                }
                else
                    FindAll(d.FullName);
            }            
        }
    }
}
