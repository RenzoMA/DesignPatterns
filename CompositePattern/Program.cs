using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CompositePattern.Component;
using CompositePattern.Composite;
using CompositePattern.Leaf;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileOne = new File { Name = "Doc1.docx" };
            var fileTwo = new File { Name = "mypdf.pdf" };
            var fileThree = new File { Name = "picture.jpg" };
            var fileFour = new File { Name = "Renzo.gif" };
            var fileFive = new File { Name = "Doc1.docx" };
            var fileFolder = new Folder { Name = "MyFiles", Elements = { fileOne, fileTwo, fileThree, fileFive } };
            var fileFolder2 = new Folder { Name = "MyFiles", Elements = { fileOne, fileTwo, fileThree, fileFive } };
            var fileFolder3 = new Folder { Name = "MyFiles", Elements = { fileOne, fileTwo, fileThree, fileFive } };
            var mainFolder = new Folder {Name = "MyFolder" , Elements = {fileFolder , fileFour, fileFolder2, fileFolder3 } };
            //var mainFolder = CreateData();
            mainFolder.DisplayAll();
            Console.ReadKey();

        }

        public static Folder CreateData()
        {
            var fileElements = new List<SystemElement>();
            var folderElements = new List<SystemElement>();

            for (var i = 0; i < 20; i++)
            {
                if (i % 5 != 0)
                {
                    var file = new File { Name = $"Doc{i}.txt" };
                    fileElements.Add(file);
                }
                else
                {
                    var folder = new Folder { Name = $"Folder{i}", Elements = fileElements };
                    fileElements = new List<SystemElement>();
                    if (folderElements.Count > 0)
                    {
                        Folder lastFolder = folderElements.Last() as Folder;
                        lastFolder?.Elements.Add(folder);
                    }
                    folderElements.Add(folder);
                }
            }
            
            
            var mainFolder = new Folder { Name = "RootFolder", Elements = folderElements };
            return mainFolder;
        }
    }
}
