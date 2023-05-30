using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class QueryParams : IDto
    {
        public string? QueryString { get; set; }
        public Boolean SortType { get; set; }   // true ? sort by asc id : sort by desc id
        public int Count { get; set; }
        public int TotalCount { get; set; }
    }
}
