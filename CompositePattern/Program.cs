using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CompositePattern.Component;
using CompositePattern.Composite;
using CompositePattern.Leaf;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainFolder = CreateDataFromDisk();
            mainFolder.DisplayAll();
            Console.ReadKey();

        }
        
        public static Folder CreateDataFromDisk()
        {
            string[] directories = System.IO.Directory.GetDirectories(GetPath(1));

            Folder rootFolder = new Folder() { Name = "RootFolder" };
            foreach (string directory in directories)
            {
                Folder folder = new Folder() { Name = new System.IO.FileInfo(directory).Name };
                DirSearch(directory, folder);
                rootFolder.AddElement(folder);
            }
            return rootFolder;
        }


        static void DirSearch(string sDir, Folder parentFolder)
        {
            try
            {
                foreach (string d in System.IO.Directory.GetDirectories(sDir))
                {
                    Folder subFolder = new Folder() { Name = new System.IO.FileInfo(d).Name };
                    foreach (string f in System.IO.Directory.GetFiles(d))
                    {
                        subFolder.Elements.Add(new File() { Name = new System.IO.FileInfo(f).Name });
                    }
                    DirSearch(d, subFolder);
                    parentFolder.Elements.Add(subFolder);
                }
                foreach (string f in System.IO.Directory.GetFiles(sDir))
                {
                    parentFolder.Elements.Add(new File() { Name = new System.IO.FileInfo(f).Name });
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
        public static string GetPath(int levels)
        {
            string path = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString();
            for (int i = 0; i < levels; i++)
            {
                path = System.IO.Directory.GetParent(path).ToString();
            }
            return path;
        }

    }
}
