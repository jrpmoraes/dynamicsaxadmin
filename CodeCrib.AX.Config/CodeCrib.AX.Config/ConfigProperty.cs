﻿//This C# code file was released under the Ms-PL license
//http://www.opensource.org/licenses/ms-pl.html
//This script was originally intended for use with Microsoft Dynamics AX
//and maintained and distributed as a project on CodePlex
//http://dynamicsaxadmin.codeplex.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCrib.AX.Config
{
    [Serializable]
    public class ConfigProperty
    {
        public string Name
        {
            get;
            set;
        }
        public string DataType
        {
            get;
            set;
        }
        public string Value
        {
            get;
            set;
        }
    }
}
