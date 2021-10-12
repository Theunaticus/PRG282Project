using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PRG282Project.ApplicationLayer;
using PRG282Project.PresentationLayer;

namespace PRG282Project.DataAccessLayer
{
    class FileHandler
    {
        public static FileHandler current;
        string UsersFile = @"\Users.dat";

        public FileHandler()
        {
            current = this;
        }

        public bool SaveToFile(string Text)
        {
            try
            {
                //FileMode Mode = FileMode.Open;
                //if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + UsersFile))
                //{
                //    Mode = FileMode.OpenOrCreate;
                //}
                //FileStream FS = new FileStream(AppDomain.CurrentDomain.BaseDirectory + UsersFile, Mode);
                StreamWriter SW = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + UsersFile, append: true);
                SW.WriteLine(EncoderDecoder.Encode(Text));
                SW.Close();
                //FS.Close();
                return true;
            }
            catch (Exception e)
            {
                PL.current.DisplayError(e.Message);
                return false;
            }
        }

        public string[] ReadAllFormFile  ()
        {
            try
            {
                List<string> Result = new List<string>();
                StreamReader SR = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + UsersFile);
                string Line;
                while ((Line = SR.ReadLine())!=null)
                {
                    Result.Add(EncoderDecoder.Decode(Line));
                }
                SR.Close();
                return Result.ToArray();
            }
            catch (Exception e)
            {
                PL.current.DisplayError(e.Message);
                return null;
            }
        }
    }
}
