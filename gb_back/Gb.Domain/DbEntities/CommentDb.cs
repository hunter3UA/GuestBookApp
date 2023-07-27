namespace Gb.Domain.DbEntities
{
    public sealed class CommentDb : BaseEntity
    {
        public required string Name { get; set; }

        public required string Text { get; set; }
    }
}