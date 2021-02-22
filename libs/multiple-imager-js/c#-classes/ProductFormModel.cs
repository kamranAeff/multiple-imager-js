 public class ProductFormModel
    {
        public int Id { get; set; }

        [NotMapped]
        public ImageItem[] Files { get; set; }
    }