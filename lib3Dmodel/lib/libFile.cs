using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib3Dmodel.lib
{
    public class libFile
    {
        public static bool isValid(string file) => File.Exists(file) || Directory.Exists(file);
        
    }
}
