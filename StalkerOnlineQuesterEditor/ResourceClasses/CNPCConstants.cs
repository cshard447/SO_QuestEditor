﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StalkerOnlineQuesterEditor
{
    //! @todo: выкуривать, менять с NpcData
    public class CNPCConstants
    {
        public Dictionary<string, CNPCDescription> NPCs;

        public CNPCConstants()
        {
            NPCs = new Dictionary<string, CNPCDescription>();
        }
        public Dictionary<string, CNPCDescription> getAllNPCsDescription()
        {
            return NPCs;
        }

        public CNPCDescription getDescriptionOnKey(string key)
        {
                return NPCs[key.Trim()];
        }

        public string getKeyOnDescription(string description)
        {
            if (NPCs.Keys.Contains(description))
            {
                foreach (string key in NPCs.Keys)
                    if (this.NPCs[key].getName().Equals(description))
                        return key;
            }
            return "";
        }
    }

    public class CNPCDescription
    {
        string name;
        public CNPCDescription(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
