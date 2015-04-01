using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#IF DEBUG
using System.Diagnostics;
#ENDIF

namespace arms
{
    public partial class weapon
    {
        public readonly int damage;
        public readonly int clipSize;
        public readonly double rateOfFire;

        public readonly string GUIname;

        public int clipFill;

        /// <summary>
        /// Parent constructor for all weapons
        /// </summary>
        /// <param name="dmg">Damage dealt by weapon</param>
        /// <param name="cSize">Size of clip in weapon</param>
        /// <param name="ROF">Rate of fire (per second)</param>
        /// <param name="gName">Name as it appears in the GUI</param>
        public weapon(int dmg, int cSize, double ROF, string gName)
        {
            damage = dmg;
            clipSize = cSize;
            clipFill = cSize;
            rateOfFire = ROF;
        }
        /// <summary>
        /// Returns weapon definition
        /// </summary>
        /// <returns>Struct with weapon stats</returns>
        public static virtual weaponStats wInfo()
        {
            #IF DEBUG
            Debug.Write("Warning: Weapon wInfo() is not defined");
            #ENDIF
            weaponStats ws;
            ws.wsName = "Empty weapon definition";
            ws.wsDamage = 0;
            ws.wsClipSize = 0;
            ws.wsRateOfFire = 0;
            return ws;
        }
        /// <summary>
        /// Fires weapon and modifies properties
        /// </summary>
        public void fire()
        {
            //TODO: Insert check for (decimal)ROF
            if(clipFill > 0)
            {
                // Go ahead and fire, we have enough rounds
                clipFill--;
            }
            else
            {
                // Do nothing, no rounds are in clip
            }
        }
        /// <summary>
        /// Reloads weapon
        /// </summary>
        public void reload()
        {
            clipFill = clipSize;
        }
        /// <summary>
        /// Checks to see if the clip is empty
        /// </summary>
        /// <returns>If the clip is empty</returns>
        public bool clipIsEmpty()
        {
            if(clipFill < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    /// <summary>
    /// Creates a weapon->AssaultRifle
    /// </summary>
    public class weaponAssaultRifle : weapon
    {
        public weaponAssaultRifle() : base(weaponAssaultRifle.wInfo().wsDamage, weaponAssaultRifle.wInfo().wsClipSize, weaponAssaultRifle.wInfo().wsRateOfFire, weaponAssaultRifle.wInfo().wsName)
        {

        }
        /// <summary>
        /// Returns weapon definition
        /// </summary>
        /// <returns>Struct with weapon stats</returns>
        public static override weaponStats wInfo(weapon w)
        {
            weaponStats ws;
            ws.wsName = "Assault Rifle";
            ws.wsDamage = 50;
            ws.wsClipSize = 25;
            ws.wsRateOfFire = 4;
            return ws;
        }
    }
    /// <summary>
    /// Creates weapon->Pistol
    /// </summary>
    public class weaponPistol : weapon
    {
        public weaponPistol() : base(weaponPistol.wInfo().wsDamage, weaponPistol.wInfo().wsClipSize, weaponPistol.wInfo().wsRateOfFire, weaponPistol.wInfo().wsName)
        {

        }
        /// <summary>
        /// Returns weapon definition
        /// </summary>
        /// <returns>Struct with weapon stats</returns>
        public static override weaponStats wInfo(weapon w)
        {
            weaponStats ws;
            ws.wsName = "Pistol";
            ws.wsDamage = 25;
            ws.wsClipSize = 5;
            ws.wsRateOfFire = 1;
            return ws;
        }
    }
    /// <summary>
    /// Creates weapon->RocketLauncher
    /// </summary>
    public class weaponRocketLauncher : weapon
    {
        public weaponRocketLauncher()
            : base(weaponRocketLauncher.wInfo().wsDamage, weaponRocketLauncher.wInfo().wsClipSize, weaponRocketLauncher.wInfo().wsRateOfFire, weaponRocketLauncher.wInfo().wsName)
        {

        }
        /// <summary>
        /// Returns weapon definition 
        /// </summary>
        /// <returns>Struct with weapon stats</returns>
        public static override weaponStats wInfo(weapon w)
        {
            weaponStats ws;
            ws.wsName = "RocketLauncher";
            ws.wsDamage = 100;
            ws.wsClipSize = 1;
            ws.wsRateOfFire = 0.25;
            return ws;
        }
    }
    /// <summary>
    /// Creates a custom type of weapon
    /// </summary>
    public class weaponCustom : weapon
    {
        public weaponStats WeaponStats;
        /// <summary>
        /// Constructor for a custom weapon type
        /// </summary>
        /// <param name="wDamage">Damage dealt by weapon</param>
        /// <param name="wClipSize">Size of clip</param>
        /// <param name="wRateOfFire">Rate of fire (per second)</param>
        /// <param name="wName">Name as it appears in the GUI</param>
        public weaponCustom(int wDamage, int wClipSize, double wRateOfFire, string wName) : base(wDamage, wClipSize, wRateOfFire, wName)
        {
            WeaponStats.wsDamage = wDamage;
            WeaponStats.wsClipSize = wClipSize;
            WeaponStats.wsRateOfFire = wRateOfFire;
            WeaponStats.wsName = wName;
        }
        public static override weaponStats wInfo(weaponCustom w)
        {
            return w.WeaponStats;
        }
    }
    public struct weaponStats
    {
        public int wsDamage;
        public int wsClipSize;
        public double wsRateOfFire;
        public string wsName;
    }
}
