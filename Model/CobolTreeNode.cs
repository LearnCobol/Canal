﻿using System.Windows.Forms;

namespace Model
{
    public abstract class CobolTreeNode : TreeNode
    {
        protected CobolTreeNode()
        {
        }

        protected CobolTreeNode(string nodeText, int indexDataDivision)
            : base(nodeText)
        {
            IndexInSource = indexDataDivision;
        }

        public int IndexInSource { get; private set; }
    }
}