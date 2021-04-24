using System.Collections.Generic;
using System.Runtime.Serialization;

namespace mnd.Common
{


    [DataContract]
    public class QueryPage
    {

        [DataMember(Name = "initialPage")]
        public int initialPage { get; set; }

        [DataMember(Name = "pageSize")]
        public int pageSize { get; set; }
    }

    [DataContract]
    public class SortField
    {

        [DataMember(Name = "propertyName")]
        public string propertyName { get; set; }

        [DataMember(Name = "ascending")]
        public bool ascending { get; set; }
    }

    [DataContract]
    public class SortInfo
    {

        [DataMember(Name = "sortFields")]
        public IList<SortField> sortFields { get; set; }
    }

    [DataContract]
    public class QueryParameterDTO
    {

        [DataMember(Name = "queryParameterType")]
        public string queryParameterType { get; set; }

        [DataMember(Name = "propertyName")]
        public string propertyName { get; set; }

        [DataMember(Name = "similarityStrategy")]
        public string similarityStrategy { get; set; }

        [DataMember(Name = "value")]
        public string value { get; set; }
    }

    [DataContract]
    public class SearchParam
    {

        [DataMember(Name = "queryPage")]
        public QueryPage queryPage { get; set; }

        [DataMember(Name = "sortInfo")]
        public SortInfo sortInfo { get; set; }

        [DataMember(Name = "queryParameterDTOs")]
        public IList<QueryParameterDTO> queryParameterDTOs { get; set; }

        [DataMember(Name = "queryTotal")]
        public bool queryTotal { get; set; }
    }
}
