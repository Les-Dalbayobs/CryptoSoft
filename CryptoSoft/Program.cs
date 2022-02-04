using System;

namespace CryptoSoft
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                if (args[0] != string.Empty || args[0] != null || args[1] != string.Empty || args[1] != null)
                {
                    encryptionXorFile encryptFile = new encryptionXorFile(args[0], args[1]);

                    double time = encryptFile.encryption();
                    int timeInt;

                    timeInt = ((int)time);

                    return timeInt;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
        }      
    }
}
