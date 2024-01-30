using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    static class CompareFiles
    {

        public static bool EqualsFiles(DataFile f1, DataFile f2)
        {
            return (f1.getData() == f2.getData() && f1.getFileName() == f2.getFileName());

        }
        public static int CompareSizeFiles(DataFile f1, DataFile f2)
        {

            if (f1.GetSize() > f2.GetSize() )
            {
                return 1;
            }
            if (f2.GetSize() > f1.GetSize())
            {
                return -1;
            }
            return 0;
        }
        
    }


}
