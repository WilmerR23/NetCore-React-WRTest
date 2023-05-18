namespace DGII.API.Helpers
{
    public class QueryParams
    {
        public QueryParams()
        {
            rowsPerPage = 10;
            pageNumber = 1;
        }
        public int rowsPerPage { get; set; }
        public int pageNumber { get; set; }
    }
}
