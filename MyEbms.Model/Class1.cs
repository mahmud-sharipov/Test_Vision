namespace Model
{
    public class Category
    {
        public string Name { get; set; }
        public Category Parent { get; set; }

        public List<Category> ChildItems { get; set; }

    }
}