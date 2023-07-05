using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public static class GameUtils
    {
        #region FIELDS
        public static readonly string DB_FILE = "players_db.dat";
        #endregion

        #region METHODS
        public static bool LoadData(out List<Player> listPlayers)
        {
            listPlayers = new List<Player>();
            // TODO: Cek dan load file
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                //! Jika ada
                if (File.Exists(DB_FILE))
                {
                    FileStream fileStream1 = new FileStream(
                            DB_FILE, 
                            FileMode.Open, 
                            FileAccess.Read
                        );


                    listPlayers = binaryFormatter.Deserialize(fileStream1) as List<Player>;

                    fileStream1.Close();

                    return true;
                }

                //! Jika tidak ada, maka kita buat baru dan asumsikan bahwa blm ada player yang terdaftar
                FileStream fileStream = new FileStream(
                        DB_FILE,
                        FileMode.Create,
                        FileAccess.Write
                    );

                binaryFormatter.Serialize(fileStream, listPlayers);

                fileStream.Close();

                return false;
               
            }
            catch (Exception x)
            {
                throw new ArgumentException(x.Message);
            }
        }

        public static void SaveData(List<Player> listPlayers)
        {
            try
            {
                FileStream fileStream = new FileStream(
                        DB_FILE,
                        FileMode.Create,
                        FileAccess.Write
                    );

                BinaryFormatter binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(fileStream, listPlayers);

                fileStream.Close();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public static bool Login(string username, FormLogin form)
        {
            foreach (Player player in form.listOfPlayers)
            {
                if (player.Username == username)
                {
                    return true;
                }
            }

            throw new ArgumentException("Username not available!");
        }

        public static bool SignUp(string username, FormSignUp form)
        {
            foreach (Player player in form.listOfPlayers)
            {
                if (player.Username == username)
                {
                    throw new ArgumentException($"Username: {username} is already taken!");
                }
            }

            //! Create new Player and add it to listOfPlayer in form signUp
            Player newPlayer = new Player(username);
            form.listOfPlayers.Add(newPlayer);

            //! Save File
            SaveData(form.listOfPlayers);

            return true;
        }
        #endregion
    }
}
