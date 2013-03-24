﻿using System;
using System.Collections.Generic;
using System.Linq;

public abstract class MultimediaDocument:BinaryDocument
{
    public long? Lenght { get; private set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "length")
        {
            this.Lenght = long.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("length", this.Lenght));
        base.SaveAllProperties(output);
    }
}
