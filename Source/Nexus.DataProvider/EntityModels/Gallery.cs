namespace Nexus.DataProvider.EntityModels
{
    public class Gallery
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string ImageName { get; set; }

        public int DbSalerId { get; set; }

        public virtual Saler DbSaler { get; set; }
    }
}