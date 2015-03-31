using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace units
{
    /// <summary>
    /// Offensive or defensive role
    /// </summary>
    enum position
    {
        offensive,
        defensive
    }
    /// <summary>
    /// Difficulty of AI, or scripted
    /// </summary>
    enum difficulty
    {
        scripted,
        coward,
        stable,
        aggressive,
        rambo
    }

    public partial class fighter
    {
        public position role;
        public difficulty diff;

        public bool canMove;

        public Point Pos;
        public Rectangle bounds;

        /// <summary>
        /// Superconstructor for Fighter class (Defensive)
        /// </summary>
        /// <param name="r">Off/Def role of unit</param>
        /// <param name="d">Difficulty of unit</param>
        /// <param name="startPos">Starting coordinates of unit</param>
        /// <param name="bnd">Bounds that the unit may not leave</param>
        public void superInit(position r, difficulty d, Point startPos, Rectangle bnd)
        {
            role = r;
            diff = d;

            Pos = startPos;
            bounds = bnd;
        }
        /// <summary>
        /// Superconstructor for Fighter class (Offensive)
        /// </summary>
        /// <param name="r">Off/Def role of unit</param>
        /// <param name="d">Difficulty of unit</param>
        /// <param name="startPos">Starting coordinates of unit</param>
        public void superInit(position r, difficulty d, Point startPos)
        {
            role = r;
            diff = d;

            Pos = startPos;
        }
        /// <summary>
        /// Moves unit in current direction
        /// </summary>
        /// <param name="pixels">Pixels to move the unit</param>
        public void move(int pixels)
        {
            if (canMove)
            {
                if (role == position.defensive)
                {
                    if (math.isInArea(this))
                    {
                        // TODO: move unit
                    }
                    else
                    {
                        // TODO: move unit back to defensive post
                    }
                }
                else
                {
                    // TODO: move unit
                }
            }
            else
            {
                // Can't move, not allowed by user
            }
        }
    }
    public class fighterHeavy : fighter
    {
        public fighterHeavy(position pos)
        {
            superInit(pos);
        }
    }
    public class fighterAssault : fighter
    {
        public fighterAssault(position pos)
        {
            superInit(pos);
        }
    }
    public class fighterSniper : fighter
    {
        public fighterSniper(position pos)
        {
            superInit(pos);
        }
    }
    public class fighterLight : fighter
    {
        public fighterLight(position pos)
        {
            superInit(pos);
        }
    }
    public class math
    {
        /// <summary>
        /// Finds out if the unit is within bounds
        /// </summary>
        /// <param name="f">Fighter object</param>
        /// <returns></returns>
        public static bool isInArea(fighter f)
        {
            if(f.bounds.Contains(f.Pos))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Finds out if the unit is within bounds
        /// </summary>
        /// <param name="f">Fighter object</param>
        /// <param name="p">Point to test</param>
        /// <returns></returns>
        public static bool isInArea(fighter f, Point p)
        {
            if (f.bounds.Contains(p))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
