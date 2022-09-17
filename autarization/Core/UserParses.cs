﻿using Autorization.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autarization.Core
{

    public static class UserParser
    {
        public static IEnumerable<User> ParseFile (string path)
        {
            foreach (string line in File.ReadAllLines("users2.txt").Skip(1))
            {
                string[] props = line.Split(';');

                yield return new User(props[0], props[1], props[2], Convert.ToInt32(props[3]), Convert.ToDecimal(props[4]));
            }
        }

    }
    
}
