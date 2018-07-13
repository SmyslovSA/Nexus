namespace Nexus.DataProvider.EntityModels
{
    public class DbGallery
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string ImageName { get; set; }

        public int DbSalerId { get; set; }

        public virtual DbSaler DbSaler { get; set; }
    }
}