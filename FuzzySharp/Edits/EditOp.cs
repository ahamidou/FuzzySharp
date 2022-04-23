namespace FuzzySharp.Edits
{
    public enum EditType
    {
        DELETE = 0,
        EQUAL = 1,
        INSERT = 2,
        REPLACE = 3,
        KEEP = 4,
    }

    public readonly struct EditOp
    {
        public EditOp(int source, int dest, EditType type)
        {
            SourcePos = source;
            DestPos = dest;
            EditType = type;
        }
        public readonly EditType EditType;
        public readonly int SourcePos;
        public readonly int DestPos;
    }
}
