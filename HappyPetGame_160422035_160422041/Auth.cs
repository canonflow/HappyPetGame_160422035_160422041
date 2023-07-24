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
    public static class Auth
    {
        #region FIELDS
        public static readonly string DB_FILE = "players_db.dat";
        private static Player currentPlayer = null;
        private static List<Player> listPlayers = LoadData();
        #endregion

        #region PROPERTIES
        #endregion

        #region METHODS
        // TODO: Buat ambil player yang berhasil login
        public static Player player()
        {
            if (currentPlayer == null) throw new ArgumentException("No player is currently logged in.");
            return currentPlayer;
        }

        // TODO: Buat Load Data players (Bisa diambil di Form jika dibutuhkan)
        public static List<Player> LoadData()
        {
            List<Player> listPlayers = new List<Player>();
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

                    return listPlayers;
                }

                //! Jika tidak ada, maka kita buat baru dan asumsikan bahwa blm ada player yang terdaftar
                FileStream fileStream = new FileStream(
                        DB_FILE,
                        FileMode.Create,
                        FileAccess.Write
                    );

                binaryFormatter.Serialize(fileStream, listPlayers);

                fileStream.Close();

                return listPlayers;
               
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        // TODO: Buat Nyimpen Data Player, digunakan pada saat SignUp dan UpdateCurrentPlayer
        public static void SaveData()
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

        // TODO: Update state, dipake di dalam method SaveData
        public static void UpdateCurrentPlayer(Player currPlayer)
        {
            for (int cnt = 0; cnt < listPlayers.Count; cnt++)
            {
                if (listPlayers[cnt].Username == currPlayer.Username)
                {
                    listPlayers[cnt] = currPlayer;
                }
            }
            currentPlayer = currPlayer;
            SaveData();
        }

        // TODO: Buat login, kalo berhasil fields currentPlayer diisi dengan player yang berhasil login
        public static bool Login(string username)
        {
            foreach (Player player in listPlayers)
            {
                if (player.Username == username)
                {
                    currentPlayer = player;
                    return true;
                }
            }

            throw new ArgumentException("Username not available!");
        }

        // TODO: Buat signup, bikin player baru denga username yang unique (YANG BELUM TERDAFTAR)
        public static bool SignUp(string username)
        {
            foreach (Player player in listPlayers)
            {
                if (player.Username == username)
                {
                    throw new ArgumentException($"Username: {username} is already taken!");
                }
            }

            //! Create new Player and add it to listOfPlayer in form signUp
            Player newPlayer = new Player(username);
            //form.listOfPlayers.Add(newPlayer);
            listPlayers.Add(newPlayer);

            //! Save File
            SaveData();

            return true;
        }

        //TODO: Buat Sign Out player, skalian update Player di list agar kesimpan
        public static bool SignOut()
        {
            if (currentPlayer != null)
            {
                UpdateCurrentPlayer(currentPlayer);
                currentPlayer = null;
                return true;
            }

            //! Ketika tidak ada player yang login tetapi maksa buat signout
            return false;
        }
        #endregion
    }
}
