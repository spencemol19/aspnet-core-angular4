namespace aspcore_angular.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /* code-first migration with Entity Framework will automatically 
            associate foreign key with associative reference by convention Name --> NameId */
        public Make Make { get; set; }

        public int MakeId { get; set; }
    }
}