using System;
using System.Collections.Generic;
using System.Text;

namespace Shadow_Android
    //This is a terrible programming practice for an OO programming language, but I'm too fucking lazy to use proper classes so fuk u. NEVER USE GLOBAL VARS I'M JUST A LAZY FUCK
{

    /// <summary>
    /// Contains global variables for project.
    /// </summary>
    public static class Stats
    {
        /// <summary>
        /// Global variable that is constant.
        /// </summary>
        public const string GlobalString = "Important Text";

        /// <summary>
        /// Static value protected by access routine.
        /// </summary>
        static int _globalValue;
        static int _embarrasLevel;

        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static int AnnoyLevel
        {
            get
            {
                return _globalValue;
            }
            set
            {
                _globalValue = value;
            }
        }
        public static int embarrasLevel
        {
            get
            {
                return _embarrasLevel;
            }
            set
            {
                _embarrasLevel = value;
            }
        }

        /// <summary>
        /// Global static field.
        /// </summary>
        public static bool GlobalBoolean;
    }
}