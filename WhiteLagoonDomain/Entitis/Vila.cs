namespace WhiteLagoon.Domain.Entitis
{
    public class Vila
    { //prop + tab:
        public int Id { get; set; } //Camel case
        public required string Name { get; set; }

        public string? Description { get; set; } //? nao obrigatorio, opcional
        public double Price { get; set; }

        public int Sqft { get; set; }

        public int Occupancy { get; set; }

        public string? ImageUrl { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
