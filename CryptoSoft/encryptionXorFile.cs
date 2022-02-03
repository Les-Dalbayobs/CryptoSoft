using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoSoft
{
    class encryptionXorFile
    {
        #region attributes
        string fileSource;
        string fileDestination;
        int cle;

        #endregion

        #region parameter
        public string FileSource { get => fileSource; set => fileSource = value; }
        public string FileDestination { get => fileDestination; set => fileDestination = value; }
        public int Cle { get => cle; set => cle = value; }
        #endregion

        #region constructor
        public encryptionXorFile(string source, string destination)
        {
            this.fileSource = source;
            this.fileDestination = destination;
            this.cle = 64;
        }
        #endregion

        #region methods
        public int encryption()
        {
            int valid = 0;

            

            return valid;
        }
        #endregion

    }
}
