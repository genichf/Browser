using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    // Model for response in JSON to client after his request to ~/api/browse (or ~/api/browse?path=...)
    public class DirectoryBrowseModel
    {
        /*public DirectoryBrowseModel()
        {
            Less10Mb = 0;
            More10less50Mb = 0;
            More100Mb = 0;
        }*/
        public MyDirectory ParentDirectory { get; set; }
        public MyDirectory CurrentDirectory { get; set; }
        public MyDrive CurrentDrive { get; set; }

        public List<MyDirectory> Directories { get; set; }
        public List<MyFile> Files { get; set; }
        public List<MyFileSize> AllFilesSizes { get; set; }
        public List<MyDrive> Drives { get; set; }

        /*public int Less10Mb { get; set; }
        public int More10less50Mb { get; set; }
        public int More100Mb { get; set; }*/
    }
}