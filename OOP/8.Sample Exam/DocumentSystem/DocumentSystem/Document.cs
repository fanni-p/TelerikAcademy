﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Document:IDocument
{
    public string Name { get; protected set; }
    public string Content { get; protected set; }

    public virtual void LoadProperty(string key, string value)
    {
        if (key == "name")
        {
            this.Name = value;
        }
        if (key == "content")
        {
            this.Content = value;
        }
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string,object>("name", this.Name));
        output.Add(new KeyValuePair<string,object>("content", this.Content));
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(this.GetType().Name);
        result.Append("[");
        IList<KeyValuePair<string, object>> attributes = new List<KeyValuePair<string, object>>();
        var sortedAttr = attributes.OrderBy(item => item.Key);
        SaveAllProperties(attributes);
        foreach (var attr in sortedAttr)
        {
            if (attr.Value != null)
            {
                result.Append(attr.Key);
                result.Append("=");
                result.Append(attr.Value);
                result.Append(";");
            }
        }
        result.Length--;
        result.Append("]");
        return result.ToString();
    }
}

