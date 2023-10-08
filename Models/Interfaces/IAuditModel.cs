namespace Project.Models.Interfaces
{
    public interface IAuditModel
    {
        public string? CreatedDate { get; set; }
        public string? LastModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
