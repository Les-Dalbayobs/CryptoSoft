using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;


namespace CryptoSoft
{
    class encryptionXorFile
    {
        #region attributes
        string fileSource;
        string fileDestination;
        long key;
        #endregion

        #region parameter
        public string FileSource { get => fileSource; set => fileSource = value; }
        public string FileDestination { get => fileDestination; set => fileDestination = value; }
        public long Key { get => key; set => key = value; }
        #endregion

        #region constructor
        public encryptionXorFile(string source, string destination)
        {
            this.fileSource = source;
            this.fileDestination = destination;
            this.key = 9954897459662147;
        }
        #endregion

        #region methods
        public double encryption()
        {
            try
            {
                if (File.Exists(this.fileDestination))
                {
                    if(File.GetLastWriteTime(FileSource) <= File.GetLastWriteTime(FileDestination))
                    {
                        return 0;
                    }
                }

                DateTime encryptDelay = DateTime.Now;

                byte[] content = File.ReadAllBytes(this.fileSource);
                byte[] result = new byte[content.Length];

                for (int i = 0; i < content.Length; i++)
                {
                    result[i] = (byte)(content[i] ^ this.key);
                }

                using (FileStream fs = File.Create(fileDestination))
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        fs.WriteByte(result[i]);
                    }
                }

                TimeSpan timeSpan = DateTime.Now - encryptDelay;

                double timeEncrypt = timeSpan.TotalMilliseconds; 

                return timeEncrypt;
            }
            catch 
            {
                return -1;
            }
        }
        #endregion

    }
}
