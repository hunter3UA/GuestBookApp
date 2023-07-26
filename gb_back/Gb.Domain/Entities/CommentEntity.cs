namespace Gb.Domain.Entities
{
    public sealed class CommentEntity
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Text { get; set; }
    }
}
