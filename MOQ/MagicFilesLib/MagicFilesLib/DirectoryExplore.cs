﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;


namespace MagicFilesLib
{
   
        public class DirectoryExplorer : IDirectoryExplorer

        {

        public ICollection<string> GetFiles(string path)

        {

            string[] files = Directory.GetFiles(path);

            return files;

        }


        //IDirectoryExplorer IDirectoryExplorer;
        //public DirectoryExplorer(IDirectoryExplorer IDirectoryExplorer)
        //{
        //    this.IDirectoryExplorer = IDirectoryExplorer;
        //}
        //public ICollection<string> GetFiles(string path)
        //{
        //    return IDirectoryExplorer.GetFiles(path);
        //}

    }
   
}
