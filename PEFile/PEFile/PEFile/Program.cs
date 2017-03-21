using System;
using System.IO;
using System.Collections.Generic;

namespace PEFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"d:\_statvw.dll";
            if (File.Exists(file))
            {
                PEFile peFile = new PEFile(file);
                for (int i = 0; i < peFile.Sections.Length; i++)
                {
                    if (peFile.Sections[i].SectionInstance != null && peFile.Sections[i].SectionInstance.GetType().Equals(typeof(Image_Resource_Directory)))
                    {
                        ((Image_Resource_Directory)peFile.Sections[i].SectionInstance).ExportResource("d:\\Format", 0, 0);
                    }
                }
            }
        }
    }
}
