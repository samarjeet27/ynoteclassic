using System.Windows.Forms;

namespace SS.Ynote.Classic.Core.Project
{
    /// <summary>
    ///     ProjectNodeType
    /// </summary>
    public enum FolderNodeType
    {
        /// <summary>
        ///     The Node Type is a Folder
        /// </summary>
        Folder,

        /// <summary>
        ///     The Node Type is a File
        /// </summary>
        File
    }

    /// <summary>
    ///     Extended TreeNode for some properties
    /// </summary>
    public class ExTreeNode : TreeNode
    {
        /// <summary>
        ///     Default Constructor
        /// </summary>
        /// <param name="text"></param>
        /// <param name="name"></param>
        /// <param name="imageIndex"></param>
        /// <param name="selimageindex"></param>
        /// <param name="projectNodeType"></param>
        public ExTreeNode(string text, string name,
            int imageIndex, int selimageindex,
            FolderNodeType projectNodeType)
        {
            Text = text;
            Name = name;
            Type = projectNodeType;
            ImageIndex = imageIndex;
            SelectedImageIndex = selimageindex;
        }

        /// <summary>
        ///     Check Whether the Node contents been loaded
        /// </summary>
        public bool Loaded { get; set; }

        /// <summary>
        ///     The Node Type
        /// </summary>
        public FolderNodeType Type { get; private set; }
    }
}