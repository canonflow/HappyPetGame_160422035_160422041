using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace HappyPetGame_160422035_160422041
{
    public static class GameUtils
    {
        #region FIELDS
        /*
        public static readonly int COLLISION_ID = 2194;
        public static readonly int HAPPY_PET_DOOR_ID = 594;
        public static readonly int BATTLE_ARENA_ID = 2706;
        */
        private enum ValueId
        {
            COLLISION_ID = 2195,
            HAPPY_PET_DOOR_ID = 595,
            BATTLE_ARENA_ID = 2707,
            MAP_2_ID = 2903,
            MAP_1_ID = 855,
            MAP_3_ID = 1879

        }
        public static readonly Dictionary<int, string> TypeID = new Dictionary<int, string>
        {
            { 0, "Fire" },
            { 1, "Ice" },
            { 2, "Metal" },
            { 3, "Wind" },
            { 4, "Earth" },
            { 5, "Lightning" },
            { 6, "Water" },
        };
        public static readonly int PLAYER_MOVEMENT = 3;
        public static readonly int MARGIN_ERROR = 3;
        public static readonly Point START_BACKGROUND_LOCATION = new Point(-80, -300);
        public static readonly Point USER_STARTING_POINT_BEGIN = new Point(200, 200);
        private static Dictionary<char, Dictionary<string, bool>> keys = new Dictionary<char, Dictionary<string, bool>>
        {
            { 'W', new Dictionary<string, bool> { { "pressed", false } }  },
            { 'A', new Dictionary<string, bool> { { "pressed", false } }  },
            { 'S', new Dictionary<string, bool> { { "pressed", false } }  },
            { 'D', new Dictionary<string, bool> { { "pressed", false } }  },
            { 'F', new Dictionary<string, bool> { { "pressed", false } }  }
        };
        public static readonly int SIZE_BOUNDARY = 16;
        public static readonly List<Skill> LIST_OF_SKILLS = new List<Skill>
        {
            new Skill("Frostbite", 1, 50),
            new Skill("Flamestrike", 0, 65),
            new Skill("Tempest", 3, 55),
            new Skill("Quake", 4, 60),
            new Skill("Thunderbold", 5, 70),
            new Skill("Aqua Burst", 6, 45),
            new Skill("Molten Barrage", 0, 70),
            new Skill("Blizzard", 1, 75),
            new Skill("Metal Slash", 2, 80),
            new Skill("Galeforce", 3, 65),
            new Skill("Terraquake", 4, 75),
            new Skill("Shockwave", 5, 80),
            new Skill("Hydro Canon", 6, 75),
            new Skill("Emberstorm", 0, 60),
            new Skill("Flamestrike", 0, 65),
            new Skill("Icicle Spear", 1, 55),
            new Skill("Steel Cyclone", 2, 70),
            new Skill("Wind Dance", 3, 50),
            new Skill("Stone Crush", 4, 65),
            new Skill("Lightning Serpent", 5, 75),
            new Skill("Tsunami", 6, 80)
        };
        public static readonly int SKILL_DAMAGE_FOR_UPGRADE = 5;
        public static readonly int ULTIMATE_FOR_UPGRADE = 10;
        public static readonly int HP_UPGRADE = 50;
        public static readonly int ENEMY_HP_UPGRADE = 100;
        public static readonly int ENEMY_DAMAGE_UPGRADE = 10;
        public static readonly int ENEMY_ULTI_UPGRADE = 10;
        public static readonly int BASE_ASIMOLE_HP = 600;
        public static readonly int BASE_ASIMOLE_DAMAGE = 50;
        public static readonly int BASE_ASIMOLE_ULTI = 100;
        public static readonly int BASE_BARREL_HP = 400;
        public static readonly int BASE_BARREL_DAMAGE = 90;
        public static readonly int BASE_BARREL_ULTI = 165;
        public static readonly int BASE_DEMON_POT_HP = 510;
        public static readonly int BASE_DEMON_POT_DAMAGE = 70;
        public static readonly int BASE_DEMON_POT_ULTI = 130;
        /// <summary>
        /// Dari -> Kemana
        /// </summary>
        private static Dictionary<string, Dictionary<string, Point>> UserTransitionLocation = new Dictionary<string, Dictionary<string, Point>>
        {
            { "1", new Dictionary<string, Point>
                {
                    { "2", new Point(110, 220) }
                }
            },
            { "2", new Dictionary<string, Point>
                {
                    { "1", new Point(830, 220) },
                    { "3", new Point(370, 90) }
                }
            },
            { "3", new Dictionary<string, Point>
                {
                    { "2", new Point(370, 480) }
                }
            }
        };
        #endregion

        #region METHODS
        //! Cari lokasi selanjutnya bersadarkan map terkini
        public static Point UserNextLocation(int from, int to)
        {
            return UserTransitionLocation[from.ToString()][to.ToString()];
        }
        //! setTimeout kayak di JS
        public static async Task SetTimeout(Action callback, int interval = 1000)
        {
            /*
            Timer timer = new Timer();
            timer.Interval = interval;
            timer.Tick += delegate (object sender, EventArgs args)
            {
                callback();
                timer.Stop();
                timer.Dispose();
            };

            timer.Start();
            */
            await Task.Delay(interval);
            callback();
        }

        public static async Task AnimateWithMovement(Action callback, int duration = 100, int interval = 1, bool timerStop = true)
        {
            Timer timer = new Timer();
            timer.Interval = interval;
            
            timer.Tick += delegate (object sender, EventArgs args)
            {
                callback();
            };

            /*
             * Implementasi kalo gk pake delegate
            timer.Tick += new EventHandler((object sender, EventArgs args) =>
            {
                callback();
            });
            */
            
            /*
             * Kalo pake callback bertipe EventHandler
            timer.Tick += callback;
            */

            //! Start animasinya
            timer.Start();

            //! Tunggu delay
            await Task.Delay(duration);

            if (timerStop)
            {
                //! stop sama hapus timer
                timer.Stop();
                timer.Dispose();
            }
        }

        //! Prefer kalo buat trigger ke button
        public static async Task SetDuration(Action callback, int duration)
        {
            callback();
            await Task.Delay(duration);
        }

        public static async Task Render(Action callback)
        {
            await Task.Run(() => callback());
        }

        //! Ambil Keys
        public static Dictionary<char, Dictionary<string, bool>> ImportKeys()
        {
            return keys;
        }

        //! Method buat check collision antara user dengan boundary
        public static bool ImportCollisionCheck(User user, Boundary boundary, char dir, int range)
        {
            PictureBox playerPic = user.Picture;
            PictureBox boundPic = boundary.Picture;
            // !Top / Left ditambah atau dikurangi untuk memprediksi apakah ada BOUNDARY tergantung arah yang ditentukan oleh 'dir'
            // !Nilai yang akan digunakan adalah 'range'
            switch (dir)
            {
                case 'W':
                    return (
                        playerPic.Left + playerPic.Width >= boundPic.Left &&
                        playerPic.Left <= boundPic.Left + boundPic.Width &&
                        playerPic.Top <= boundPic.Top + range + boundPic.Height &&
                        playerPic.Top + playerPic.Height >= boundPic.Top + range
                    );
                case 'A':
                    return (
                        playerPic.Left + playerPic.Width >= boundPic.Left + range &&
                        playerPic.Left <= boundPic.Left + range + boundPic.Width &&
                        playerPic.Top <= boundPic.Top + boundPic.Height &&
                        playerPic.Top + playerPic.Height >= boundPic.Top
                    );
                case 'S':
                    return (
                        playerPic.Left + playerPic.Width >= boundPic.Left &&
                        playerPic.Left <= boundPic.Left + boundPic.Width &&
                        playerPic.Top <= boundPic.Top - range + boundPic.Height &&
                        playerPic.Top + playerPic.Height >= boundPic.Top - range
                    );
                case 'D':
                    return (
                        playerPic.Left + playerPic.Width >= boundPic.Left - range &&
                        playerPic.Left <= boundPic.Left - range + boundPic.Width &&
                        playerPic.Top <= boundPic.Top + boundPic.Height &&
                        playerPic.Top + playerPic.Height >= boundPic.Top
                    );
                default:
                    return false;
            }
        }

        //! Check id 
        public static bool IsBoundary(long value)
        {
            return value == (long)ValueId.COLLISION_ID;
        }

        public static bool IsMap2Point(long value)
        {
            return value == (long)ValueId.MAP_2_ID;
        }

        public static bool IsMap1Point(long value)
        {
            return value == (long)ValueId.MAP_1_ID;
        }

        public static bool IsMap3Point(long value)
        {
            return value == (long)ValueId.MAP_3_ID;
        }

        public static bool IsHappyPetId(long value)
        {
            return value == (long)ValueId.HAPPY_PET_DOOR_ID;
        }

        public static bool IsBattleArenaId(long value)
        {
            return value == (long)ValueId.BATTLE_ARENA_ID;
        }
        #endregion
    }
}
