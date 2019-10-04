namespace VSFolderCleanup.Models
{
    internal class FolderItem
    {
        public string FullPath { get; set; }
        public string DisplayPath { get; set; }

        public override string ToString()
        {
            return DisplayPath;
        }
    }
}
