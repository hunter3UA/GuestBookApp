namespace Gb.Domain.DbEntities
{
    public class DbComment : BaseEntity
    {
        public required string Name { get; set; }

        public required string Text { get; set; }
    }
}