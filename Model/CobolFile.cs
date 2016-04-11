﻿using Model.References;
using System.Collections.Generic;

namespace Model
{
    public class CobolFile
    {
        public string Name { get; set; }

        public string Text { get; set; }

        public FileReference FileReference { get; set; }

        public Dictionary<string, string> Infos { get; set; }

        public List<Variable> Variables { get { return CobolTree == null ? new List<Variable>() : CobolTree.Variables; } }

        public List<FileReference> CallReferences { get { return CobolTree == null ? new List<FileReference>() : CobolTree.CallReferences; } }

        public CobolTree CobolTree { get; set; }

        public CobolFile(string text, string name)
        {
            Name = name;
            Text = text;
        }
    }
}