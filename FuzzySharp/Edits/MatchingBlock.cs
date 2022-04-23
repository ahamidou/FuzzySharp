namespace FuzzySharp.Edits
{
    public readonly struct MatchingBlock
    {
        public MatchingBlock(int sourcePos, int destPos, int length)
        {
            SourcePos = sourcePos;
            DestPos = destPos;
            Length = length;
        }

        public readonly int SourcePos;
        public readonly int DestPos;
        public readonly int Length;
    }
}
